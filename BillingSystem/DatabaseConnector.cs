using Microsoft.EntityFrameworkCore;

namespace BillingSystem;

public class DatabaseConnector : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<Receipt> Receipts { get; set; }
    public DbSet<ItemReceipt> ItemReceipts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Define the database to be SQL Server and provide the connection string
        string connectionString = "Server=PUNISHER41\\SQLEXPRESS;Database=coffee-shop;Integrated Security=True;";

        optionsBuilder.UseSqlServer(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure the entities
        modelBuilder.Entity<User>()
            .HasKey(u => u.Id);

        modelBuilder.Entity<Item>()
            .HasKey(i => i.Id);

        modelBuilder.Entity<Receipt>()
            .HasKey(r => r.Id);

        modelBuilder.Entity<ItemReceipt>()
            .HasKey(ir => new { ir.ItemId, ir.ReceiptId });

        // Define foreign key relationships
        modelBuilder.Entity<Receipt>()
            .HasOne(r => r.User)
            .WithMany(u => u.Receipts)
            .HasForeignKey(r => r.UserId);

        modelBuilder.Entity<ItemReceipt>()
            .HasOne(ir => ir.Item)
            .WithMany()
            .HasForeignKey(ir => ir.ItemId);

        modelBuilder.Entity<ItemReceipt>()
            .HasOne(ir => ir.Receipt)
            .WithMany(r => r.ItemReceipts)
            .HasForeignKey(ir => ir.ReceiptId);
    }

    // Create the database if it doesn't exist
    public void CreateDatabase()
    {
        // Since we are using SQL Server, we don't need to check for file existence
        using (var context = new DatabaseConnector())
        {
            context.Database.EnsureCreated();
        }
    }

    public List<User> User_List()
    {
        return Users.ToList();
    }

    public User? User_Authenticate(string username, string password)
    {
        // Check if the user exists in the database
        return Users.FirstOrDefault(u => u.Username == username && u.Password == password);
    }

    public bool User_Exists(string username)
    {
        if (Users.Any(u => u.Username == username))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool User_Create(string username, string password)
    {
        // Check if the username already exists
        if (!User_Exists(username))
        {
            // Add new user to the database
            var newUser = new User { Username = username, Password = password };
            Users.Add(newUser);
            SaveChanges();
            return true;
        }
        else
        {
            return false;
        }
    }

    public List<Item> Item_List()
    {
        return Items.ToList();
    }

    public Receipt Receipt_Create(User user)
    {
        var newReceipt = new Receipt { UserId = user.Id };
        Receipts.Add(newReceipt);
        SaveChanges();
        return newReceipt;
    }

    public void Receipts_Delete()
    {
        // Fetch all receipts from the database
        var allReceipts = Receipts.ToList();

        // Remove all fetched receipts
        Receipts.RemoveRange(allReceipts);

        // Save changes to the database
        SaveChanges();
    }

    public void ItemReceipts_Create(ItemReceipt[] items)
    {
        ItemReceipts.AddRange(items);
        SaveChanges();
    }

    public List<Receipt> Receipt_List()
    {
        return Receipts
            .Include(r => r.User)
            .Include(r => r.ItemReceipts)
            .ThenInclude(ir => ir.Item)
            .ToList();
    }
}

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public ICollection<Receipt> Receipts { get; set; } // Navigation property
}

public class Item
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Image { get; set; }
    public decimal Price { get; set; }
}

public class Receipt
{
    public int Id { get; set; }
    public int UserId { get; set; } // Foreign key to User
    public User User { get; set; } // Navigation property
    public ICollection<ItemReceipt> ItemReceipts { get; set; } // Navigation property
}

public class ItemReceipt
{
    public int ItemId { get; set; } // Composite key part
    public int ReceiptId { get; set; } // Composite key part
    public Item Item { get; set; } // Navigation property
    public Receipt Receipt { get; set; } // Navigation property
    public int Quantity { get; set; } // Number of items with ItemId in receipt with ReceiptId
}

public static class AdminCredentials
{
    public const string Username = "admin";
    public const string Password = "admin";
}