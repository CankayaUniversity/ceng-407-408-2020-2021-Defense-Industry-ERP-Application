using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ERP_APP.Models.DB
{
    public partial class ERPDBContext : DbContext
    {
        public ERPDBContext()
        {
        }

        public ERPDBContext(DbContextOptions<ERPDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblAcc> TblAccs { get; set; }
        public virtual DbSet<TblAccounting> TblAccountings { get; set; }
        public virtual DbSet<TblFirstQuality> TblFirstQualities { get; set; }
        public virtual DbSet<TblHumanR> TblHumanRs { get; set; }
        public virtual DbSet<TblProduction> TblProductions { get; set; }
        public virtual DbSet<TblRecordProduct> TblRecordProducts { get; set; }
        public virtual DbSet<TblShipment> TblShipments { get; set; }
        public virtual DbSet<TblWarehouse> TblWarehouses { get; set; }
     //   public object TblFirstQuality { get; internal set; }

        /*
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
if (!optionsBuilder.IsConfigured)
{
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
optionsBuilder.UseSqlServer("Server=DESKTOP-NNCQ7L4\\SQLEXPRESS;Database=ERPDB;Trusted_Connection=True;");
}
}
*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<TblAcc>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("Tbl_Acc");

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.AccName)
                    .HasMaxLength(50)
                    .HasColumnName("accName");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .HasColumnName("userName");

                entity.Property(e => e.UserPass)
                    .HasMaxLength(50)
                    .HasColumnName("userPass");

                entity.Property(e => e.UserRole)
                    .HasMaxLength(50)
                    .HasColumnName("userRole");
            });

            modelBuilder.Entity<TblAccounting>(entity =>
            {
                entity.HasKey(e => e.AccId);

                entity.ToTable("Tbl_Accounting");

                entity.Property(e => e.AccId).HasColumnName("accID");

                entity.Property(e => e.HResourceId).HasColumnName("hResourceID");

                entity.Property(e => e.vergidurumu).HasColumnName("vergidurumu");

                entity.Property(e => e.aylar)
                    .HasMaxLength(50)
                    .HasColumnName("aylar");

                entity.Property(e => e.Remarks).HasColumnName("remarks");

                entity.Property(e => e.Salary).HasColumnName("salary");
                entity.Property(e => e.digergider).HasColumnName("digergider");
                entity.Property(e => e.gelir).HasColumnName("gelir");
                entity.Property(e => e.sigortalar).HasColumnName("sigortalar");

                entity.HasOne(d => d.HResource)
                    .WithMany(p => p.TblAccountings)
                    .HasForeignKey(d => d.HResourceId)
                    .HasConstraintName("FK_Tbl_Accounting_Tbl_HumanR");
            });

            modelBuilder.Entity<TblFirstQuality>(entity =>
            {
                entity.HasKey(e => e.PartId);

                entity.ToTable("Tbl_FirstQuality");

                entity.Property(e => e.PartId).HasColumnName("partID");

                entity.Property(e => e.LotBatchNo).HasMaxLength(50);

                entity.Property(e => e.Nsn)
                    .HasMaxLength(50)
                    .HasColumnName("NSN");

                entity.Property(e => e.PartNo)
                    .HasMaxLength(50)
                    .HasColumnName("partNo");

                entity.Property(e => e.PartPiece).HasColumnName("partPiece");

                entity.Property(e => e.PartPieceType)
                    .HasMaxLength(50)
                    .HasColumnName("partPieceType");

                entity.Property(e => e.PartRemainPiece).HasColumnName("partRemainPiece");

                entity.Property(e => e.ProductId).HasColumnName("productID");

                entity.Property(e => e.Remark).HasColumnName("remark");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblFirstQualities)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Tbl_FirstQuality_Tbl_RecordProduct");
            });

            modelBuilder.Entity<TblHumanR>(entity =>
            {
                entity.HasKey(e => e.HResourceId);

                entity.ToTable("Tbl_HumanR");

                entity.Property(e => e.HResourceId).HasColumnName("hResourceID");

                entity.Property(e => e.Remarks).HasColumnName("remarks");

                entity.Property(e => e.WorkPerformance).HasColumnName("workPerformance");

                entity.Property(e => e.WorkerId).HasColumnName("workerID");

                entity.Property(e => e.WorkerName)
                    .HasMaxLength(50)
                    .HasColumnName("workerName");

                entity.Property(e => e.WorkerSertificate).HasColumnName("workerSertificate");

                entity.Property(e => e.WorkerSurname)
                    .HasMaxLength(50)
                    .HasColumnName("workerSurname");
            });

            modelBuilder.Entity<TblProduction>(entity =>
            {
                entity.HasKey(e => e.ProductionId);

                entity.ToTable("Tbl_Production");

                entity.Property(e => e.ProductionId).HasColumnName("productionID");

                entity.Property(e => e.HarnessType)
                    .HasMaxLength(50)
                    .HasColumnName("harnessType");

                entity.Property(e => e.IsFinal)
                    .HasMaxLength(50)
                    .HasColumnName("isFinal");

                entity.Property(e => e.IsOuality)
                    .HasMaxLength(50)
                    .HasColumnName("isOuality");

                entity.Property(e => e.IsTest)
                    .HasMaxLength(50)
                    .HasColumnName("isTest");

                entity.Property(e => e.Notification).HasColumnName("notification");

                entity.Property(e => e.Place)
                    .HasMaxLength(50)
                    .HasColumnName("place");

                entity.Property(e => e.ProductId).HasColumnName("productID");

                entity.Property(e => e.ProductionType)
                    .HasMaxLength(50)
                    .HasColumnName("productionType");

                entity.Property(e => e.Remarks).HasColumnName("remarks");

                entity.Property(e => e.SerialNum)
                    .HasMaxLength(50)
                    .HasColumnName("serialNum");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("date")
                    .HasColumnName("updateDate");

                entity.Property(e => e.WarehouseId).HasColumnName("warehouseID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblProductions)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Tbl_Production_Tbl_RecordProduct");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.TblProductions)
                    .HasForeignKey(d => d.WarehouseId)
                    .HasConstraintName("FK_Tbl_Production_Tbl_Warehouse");
            });

            modelBuilder.Entity<TblRecordProduct>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.ToTable("Tbl_RecordProduct");

                entity.Property(e => e.ProductId).HasColumnName("productID");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .HasColumnName("companyName");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(50)
                    .HasColumnName("orderNo");

                entity.Property(e => e.Piece).HasColumnName("piece");

                entity.Property(e => e.PieceType)
                    .HasMaxLength(50)
                    .HasColumnName("pieceType");

                entity.Property(e => e.RemainPiece).HasColumnName("remainPiece");

                entity.Property(e => e.Remarks).HasColumnName("remarks");

                entity.Property(e => e.tanim).HasColumnName("tanim");

                entity.Property(e => e.StokNo)
                    .HasMaxLength(50)
                    .HasColumnName("stokNo");

                entity.Property(e => e.WorkOrderNo)
                    .HasMaxLength(50)
                    .HasColumnName("workOrderNo");
            });

            modelBuilder.Entity<TblShipment>(entity =>
            {
                entity.HasKey(e => e.ShipmentId);

                entity.ToTable("Tbl_Shipment");

                entity.Property(e => e.ShipmentId).HasColumnName("shipmentID");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                
                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .HasColumnName("invoiceNo");
                entity.Property(e => e.seriNo)
                    .HasMaxLength(50)
                    .HasColumnName("seriNo");
                entity.Property(e => e.dokRev)
                    .HasMaxLength(50)
                    .HasColumnName("dokRev");
                entity.Property(e => e.eyes)
                    .HasMaxLength(50)
                    .HasColumnName("eyes");
                entity.Property(e => e.elektrik)
                    .HasMaxLength(50)
                    .HasColumnName("elektrik");
                entity.Property(e => e.paket)
                    .HasMaxLength(50)
                    .HasColumnName("paket");
                entity.Property(e => e.Piece).HasColumnName("piece");

                entity.Property(e => e.ProductId).HasColumnName("productID");

                entity.Property(e => e.Remarks).HasColumnName("remarks");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblShipments)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Tbl_Shipment_Tbl_RecordProduct");
            });

            modelBuilder.Entity<TblWarehouse>(entity =>
            {
                entity.HasKey(e => e.WarehouseId);

                entity.ToTable("Tbl_Warehouse");

                entity.Property(e => e.WarehouseId).HasColumnName("warehouseID");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.GivenDate)
                    .HasColumnType("date")
                    .HasColumnName("givenDate");

                entity.Property(e => e.Place)
                    .HasMaxLength(50)
                    .HasColumnName("place");

                entity.Property(e => e.ProductId).HasColumnName("productID");

                entity.Property(e => e.ReceiverName)
                    .HasMaxLength(50)
                    .HasColumnName("receiverName");

                entity.Property(e => e.Remarks).HasColumnName("remarks");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblWarehouses)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Tbl_Warehouse_Tbl_RecordProduct");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
