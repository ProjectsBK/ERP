using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ERP.Models
{
    public partial class ERPContext : DbContext
    {
        public ERPContext()
        {
        }

        public ERPContext(DbContextOptions<ERPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ContractReview> ContractReview { get; set; }
        public virtual DbSet<CustomerMaster> CustomerMaster { get; set; }
        public virtual DbSet<GaugeMaster> GaugeMaster { get; set; }
        public virtual DbSet<GradeMaster> GradeMaster { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<ItemMaster> ItemMaster { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<MachineMaster> MachineMaster { get; set; }
        public virtual DbSet<Marketing> Marketing { get; set; }
        public virtual DbSet<PoEntry> PoEntry { get; set; }
        public virtual DbSet<PriceMaster> PriceMaster { get; set; }
        public virtual DbSet<ProcessMaster> ProcessMaster { get; set; }
        public virtual DbSet<Purchase> Purchase { get; set; }
        public virtual DbSet<Stores> Stores { get; set; }
        public virtual DbSet<SupplierMaster> SupplierMaster { get; set; }
        public virtual DbSet<WeightMaster> WeightMaster { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ERP;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContractReview>(entity =>
            {
                entity.HasKey(e => e.ContractReviewCode)
                    .HasName("PK__Contract__DF11B724DFBFA773");

                entity.ToTable("Contract_Review");

                entity.Property(e => e.ContractReviewCode)
                    .HasColumnName("Contract_review_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PackingDate)
                    .HasColumnName("Packing_Date")
                    .HasColumnType("date");

                entity.Property(e => e.PromiseDate)
                    .HasColumnName("Promise_Date")
                    .HasColumnType("date");

                entity.Property(e => e.RevisedDeliveryDate)
                    .HasColumnName("Revised_Delivery_Date")
                    .HasColumnType("date");

                entity.Property(e => e.SaleOrderNo)
                    .HasColumnName("Sale_Order_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SaleOrderNoNavigation)
                    .WithMany(p => p.ContractReview)
                    .HasForeignKey(d => d.SaleOrderNo)
                    .HasConstraintName("FK__Contract___Sale___46E78A0C");
            });

            modelBuilder.Entity<CustomerMaster>(entity =>
            {
                entity.HasKey(e => e.CustomerCode)
                    .HasName("PK__customer__4CDE64D7230DB131");

                entity.ToTable("customer_Master");

                entity.Property(e => e.CustomerCode)
                    .HasColumnName("Customer_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedBy)
                    .HasColumnName("Approved_By")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedDate)
                    .HasColumnName("Approved_Date")
                    .HasColumnType("date");

                entity.Property(e => e.CustomerAddedBy)
                    .HasColumnName("Customer_Added_By")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerAddedDate)
                    .HasColumnName("Customer_Added_Date")
                    .HasColumnType("date");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasColumnName("Customer_Name")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("Modified_Date")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<GaugeMaster>(entity =>
            {
                entity.HasKey(e => e.GaugeCode)
                    .HasName("PK__Gauge_Ma__00D3ADC05AAE61A9");

                entity.ToTable("Gauge_Master");

                entity.Property(e => e.GaugeCode)
                    .HasColumnName("Gauge_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedBy)
                    .HasColumnName("Approved_By")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedDate)
                    .HasColumnName("Approved_Date")
                    .HasColumnType("date");

                entity.Property(e => e.CalibrationDate)
                    .HasColumnName("Calibration_Date")
                    .HasColumnType("date");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DueDate)
                    .HasColumnName("Due_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("Modified_Date")
                    .HasColumnType("date");

                entity.Property(e => e.Size)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GradeMaster>(entity =>
            {
                entity.HasKey(e => e.GradeId)
                    .HasName("PK__grade_Ma__D4437153B43DE7AD");

                entity.ToTable("grade_Master");

                entity.Property(e => e.GradeId)
                    .HasColumnName("Grade_ID")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedBy)
                    .HasColumnName("Approved_By")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedDate)
                    .HasColumnName("Approved_Date")
                    .HasColumnType("date");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created_By")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("date");

                entity.Property(e => e.GradeName)
                    .HasColumnName("Grade_Name")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("Modified_Date")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.HasKey(e => e.InNo)
                    .HasName("PK__Invoice__9A0FD17E04417DEA");

                entity.Property(e => e.InNo).HasColumnName("In_NO");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("Invoice_Date")
                    .HasColumnType("date");

                entity.Property(e => e.InvoiceNo)
                    .HasColumnName("Invoice_No")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceQty).HasColumnName("Invoice_Qty");

                entity.Property(e => e.SaleOrderNo)
                    .HasColumnName("Sale_Order_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SaleOrderNoNavigation)
                    .WithMany(p => p.Invoice)
                    .HasForeignKey(d => d.SaleOrderNo)
                    .HasConstraintName("FK__Invoice__Sale_Or__4316F928");
            });

            modelBuilder.Entity<ItemMaster>(entity =>
            {
                entity.HasKey(e => e.ProductNo)
                    .HasName("PK__Item_Mas__B40D3A36AC2D8CAD");

                entity.ToTable("Item_Master");

                entity.Property(e => e.ProductNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedBy)
                    .HasColumnName("Approved_By")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedDate)
                    .HasColumnName("Approved_Date")
                    .HasColumnType("date");

                entity.Property(e => e.Condition)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created_By")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModelNo)
                    .HasColumnName("Model_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("Modified_Date")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("login");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MachineMaster>(entity =>
            {
                entity.HasKey(e => e.MachineCode)
                    .HasName("PK__Machine___23EFAFE9BF3C064E");

                entity.ToTable("Machine_Master");

                entity.Property(e => e.MachineCode)
                    .HasColumnName("Machine_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedBy)
                    .HasColumnName("Approved_By")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedDate)
                    .HasColumnName("Approved_Date")
                    .HasColumnType("date");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("date");

                entity.Property(e => e.DateOfPurchased)
                    .HasColumnName("Date_Of_Purchased")
                    .HasColumnType("date");

                entity.Property(e => e.MachineHourRate).HasColumnName("Machine_hour_Rate");

                entity.Property(e => e.MachineMake)
                    .HasColumnName("Machine_Make")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MachineName)
                    .HasColumnName("Machine_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("Modified_Date")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<Marketing>(entity =>
            {
                entity.HasKey(e => e.EnquiryNo)
                    .HasName("PK__Marketin__0ABFF61E010486BE");

                entity.Property(e => e.EnquiryNo)
                    .HasColumnName("Enquiry_No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedBy)
                    .HasColumnName("Approved_By")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedDate)
                    .HasColumnName("Approved_Date")
                    .HasColumnType("date");

                entity.Property(e => e.CustomerDetails)
                    .HasColumnName("Customer_Details")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("Customer_Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EnquiryDetailsEnteredBy)
                    .HasColumnName("Enquiry_Details_EnteredBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EquiryDetailsEnteredDate)
                    .HasColumnName("Equiry_Details_EnteredDate")
                    .HasColumnType("date");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("Modified_Date")
                    .HasColumnType("date");

                entity.Property(e => e.QuoteCreatedBy)
                    .HasColumnName("Quote_Created_By")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QuoteCreatedDate)
                    .HasColumnName("Quote_Created_Date")
                    .HasColumnType("date");

                entity.Property(e => e.QuoteNo)
                    .HasColumnName("Quote_No")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PoEntry>(entity =>
            {
                entity.HasKey(e => e.SaleOrderNo)
                    .HasName("PK__PO_Entry__7333C03A8230ADB8");

                entity.ToTable("PO_Entry");

                entity.Property(e => e.SaleOrderNo)
                    .HasColumnName("Sale_Order_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedBy)
                    .HasColumnName("Approved_By")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedDate)
                    .HasColumnName("Approved_Date")
                    .HasColumnType("date");

                entity.Property(e => e.CastingDrawingNo)
                    .HasColumnName("Casting_Drawing_No")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Category)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ConditionOfSupply)
                    .HasColumnName("Condition_Of_Supply")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("date");

                entity.Property(e => e.CustomerCode)
                    .HasColumnName("Customer_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerRequiredDate)
                    .HasColumnName("Customer_Required_Date")
                    .HasColumnType("date");

                entity.Property(e => e.GradeId)
                    .HasColumnName("Grade_ID")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MachiningDrawingNumber)
                    .HasColumnName("Machining_Drawing_Number")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ModeOfShipment)
                    .HasColumnName("Mode_Of_Shipment")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("Modified_Date")
                    .HasColumnType("date");

                entity.Property(e => e.OrderEntryDate)
                    .HasColumnName("Order_Entry_Date")
                    .HasColumnType("date");

                entity.Property(e => e.PoDate)
                    .HasColumnName("PO_Date")
                    .HasColumnType("date");

                entity.Property(e => e.PoNo)
                    .HasColumnName("PO_No")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PoReceivedDate)
                    .HasColumnName("PO_Received_Date")
                    .HasColumnType("date");

                entity.Property(e => e.PosNo)
                    .HasColumnName("Pos_No")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PriceMasterCode)
                    .HasColumnName("Price_Master_Code")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ProductNo)
                    .HasColumnName("Product_No")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.CustomerCodeNavigation)
                    .WithMany(p => p.PoEntry)
                    .HasForeignKey(d => d.CustomerCode)
                    .HasConstraintName("FK__PO_Entry__Custom__37A5467C");

                entity.HasOne(d => d.Grade)
                    .WithMany(p => p.PoEntry)
                    .HasForeignKey(d => d.GradeId)
                    .HasConstraintName("FK__PO_Entry__Grade___398D8EEE");

                entity.HasOne(d => d.PriceMasterCodeNavigation)
                    .WithMany(p => p.PoEntry)
                    .HasForeignKey(d => d.PriceMasterCode)
                    .HasConstraintName("FK__PO_Entry__Price___3A81B327");

                entity.HasOne(d => d.ProductNoNavigation)
                    .WithMany(p => p.PoEntry)
                    .HasForeignKey(d => d.ProductNo)
                    .HasConstraintName("FK__PO_Entry__Produc__38996AB5");
            });

            modelBuilder.Entity<PriceMaster>(entity =>
            {
                entity.HasKey(e => e.PriceMasterCode)
                    .HasName("PK__Price_Ma__BAC1DD879BCBBE79");

                entity.ToTable("Price_Master");

                entity.Property(e => e.PriceMasterCode)
                    .HasColumnName("Price_Master_Code")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedBy)
                    .HasColumnName("Approved_By")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedDate)
                    .HasColumnName("Approved_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ConversitionRate).HasColumnName("Conversition_Rate");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created_By")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("date");

                entity.Property(e => e.CurrencyType)
                    .HasColumnName("Currency_Type")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("Modified_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ProductNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnName("unit_Price");

                entity.HasOne(d => d.ProductNoNavigation)
                    .WithMany(p => p.PriceMaster)
                    .HasForeignKey(d => d.ProductNo)
                    .HasConstraintName("FK__Price_Mas__Produ__32E0915F");
            });

            modelBuilder.Entity<ProcessMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Process_Master");

                entity.Property(e => e.OperationCode).HasColumnName("Operation_Code");

                entity.Property(e => e.OperationName)
                    .HasColumnName("Operation_Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductNo)
                    .HasColumnName("Product_No")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.ProductNoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.ProductNo)
                    .HasConstraintName("FK__Process_M__Produ__267ABA7A");
            });

            modelBuilder.Entity<Purchase>(entity =>
            {
                entity.HasKey(e => e.PurchaseRequestNo)
                    .HasName("PK__Purchase__425DF7CA6B4086B1");

                entity.Property(e => e.PurchaseRequestNo)
                    .HasColumnName("Purchase_Request_No")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedBy)
                    .HasColumnName("Approved_By")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedDate)
                    .HasColumnName("Approved_Date")
                    .HasColumnType("date");

                entity.Property(e => e.DeliveryDate)
                    .HasColumnName("Delivery_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("Modified_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ParNo)
                    .HasColumnName("Par_No")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PoNumberToSupplier)
                    .HasColumnName("PO_Number_to_Supplier")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PoQtyToSupplier).HasColumnName("PO_Qty_to_Supplier");

                entity.Property(e => e.PoRelesedBy)
                    .HasColumnName("PO_Relesed_By")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PoRelesedDate)
                    .HasColumnName("PO_Relesed_Date")
                    .HasColumnType("date");

                entity.Property(e => e.PurchaseOrderStatus)
                    .HasColumnName("Purchase_Order_Status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RequestQty).HasColumnName("Request_Qty");

                entity.Property(e => e.RequestedBy)
                    .HasColumnName("Requested_By")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierName)
                    .HasColumnName("Supplier_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Stores>(entity =>
            {
                entity.HasKey(e => e.IndentNumber)
                    .HasName("PK__stores__4F7F424EE6733088");

                entity.ToTable("stores");

                entity.Property(e => e.IndentNumber)
                    .HasColumnName("Indent_Number")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IndenetRaisedDate)
                    .HasColumnName("Indenet_Raised_Date")
                    .HasColumnType("date");

                entity.Property(e => e.IndentRaisedBy)
                    .HasColumnName("Indent_Raised_By")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.IndentRaisedQty).HasColumnName("Indent_Raised_Qty");

                entity.Property(e => e.IssuedBy)
                    .HasColumnName("Issued_By")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IssuedDate)
                    .HasColumnName("Issued_Date")
                    .HasColumnType("date");

                entity.Property(e => e.IssuedQtyAgainstIndent)
                    .HasColumnName("Issued_Qty_Against_Indent")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SaleOrderNo)
                    .HasColumnName("Sale_Order_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SaleOrderNoNavigation)
                    .WithMany(p => p.Stores)
                    .HasForeignKey(d => d.SaleOrderNo)
                    .HasConstraintName("FK__stores__Sale_Ord__3F466844");
            });

            modelBuilder.Entity<SupplierMaster>(entity =>
            {
                entity.HasKey(e => e.SupplierCode)
                    .HasName("PK__Supplier__1D8777D1CC68DFAA");

                entity.ToTable("Supplier_Master");

                entity.Property(e => e.SupplierCode)
                    .HasColumnName("Supplier_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedBy)
                    .HasColumnName("Approved_By")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedDate)
                    .HasColumnName("Approved_Date")
                    .HasColumnType("date");

                entity.Property(e => e.Location)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("Modified_Date")
                    .HasColumnType("date");

                entity.Property(e => e.SupplierAddedBy)
                    .HasColumnName("Supplier_Added_By")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierAddedDate)
                    .HasColumnName("Supplier_Added_Date")
                    .HasColumnType("date");

                entity.Property(e => e.SupplierName)
                    .IsRequired()
                    .HasColumnName("Supplier_Name")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WeightMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Weight_Master");

                entity.Property(e => e.CastingWeight).HasColumnName("Casting_Weight");

                entity.Property(e => e.ProductNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WeightAfterFullMachining).HasColumnName("Weight_After_FullMachining");

                entity.Property(e => e.WeightMasterCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.ProductNoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.ProductNo)
                    .HasConstraintName("FK__Weight_Ma__Produ__24927208");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
