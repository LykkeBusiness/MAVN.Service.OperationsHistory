// <auto-generated />
using System;
using MAVN.Service.OperationsHistory.MsSqlRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MAVN.Service.OperationsHistory.MsSqlRepositories.Migrations
{
    [DbContext(typeof(OperationsHistoryContext))]
    [Migration("20190927053822_MakeBonusCashInCampaignIdRequired")]
    partial class MakeBonusCashInCampaignIdRequired
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("operation_history")
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MAVN.Service.OperationsHistory.MsSqlRepositories.Entities.BonusCashInEntity", b =>
                {
                    b.Property<string>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("transaction_id");

                    b.Property<string>("Amount")
                        .IsRequired()
                        .HasColumnName("amount");

                    b.Property<string>("AssetSymbol")
                        .IsRequired()
                        .HasColumnName("asset");

                    b.Property<string>("BonusType")
                        .IsRequired()
                        .HasColumnName("bonus_type");

                    b.Property<string>("CampaignId")
                        .IsRequired()
                        .HasColumnName("campaign_id");

                    b.Property<string>("ConditionName")
                        .HasColumnName("condition_name");

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnName("customer_id");

                    b.Property<string>("ExternalOperationId")
                        .HasColumnName("external_operation_id");

                    b.Property<string>("PartnerId")
                        .HasColumnName("partner_id");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnName("timestamp");

                    b.HasKey("TransactionId");

                    b.HasIndex("CampaignId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("Timestamp");

                    b.ToTable("bonus_cash_in");
                });

            modelBuilder.Entity("MAVN.Service.OperationsHistory.MsSqlRepositories.Entities.BurnRuleEntity", b =>
                {
                    b.Property<string>("BurnRuleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("burn_rule_id");

                    b.Property<string>("BurnRuleName")
                        .IsRequired()
                        .HasColumnName("burn_rule_name");

                    b.HasKey("BurnRuleId");

                    b.ToTable("burn_rules");
                });

            modelBuilder.Entity("MAVN.Service.OperationsHistory.MsSqlRepositories.Entities.CampaignEntity", b =>
                {
                    b.Property<string>("CampaignId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CampaignName")
                        .IsRequired();

                    b.HasKey("CampaignId");

                    b.ToTable("campaigns");
                });

            modelBuilder.Entity("MAVN.Service.OperationsHistory.MsSqlRepositories.Entities.CustomerTierEntity", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnName("customer_id")
                        .HasColumnType("char(36)");

                    b.Property<string>("TierId")
                        .IsRequired()
                        .HasColumnName("tier_id")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnName("timestamp");

                    b.HasKey("Id");

                    b.ToTable("tiers_updates");
                });

            modelBuilder.Entity("MAVN.Service.OperationsHistory.MsSqlRepositories.Entities.PartnersPaymentEntity", b =>
                {
                    b.Property<string>("PaymentRequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("payment_request_id");

                    b.Property<string>("Amount")
                        .IsRequired()
                        .HasColumnName("amount");

                    b.Property<string>("AssetSymbol")
                        .IsRequired()
                        .HasColumnName("asset_symbol");

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnName("customer_id");

                    b.Property<string>("LocationId")
                        .HasColumnName("location_id");

                    b.Property<string>("PartnerId")
                        .IsRequired()
                        .HasColumnName("partner_id");

                    b.Property<string>("PartnerName")
                        .IsRequired()
                        .HasColumnName("partner_name");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnName("timestamp");

                    b.HasKey("PaymentRequestId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("Timestamp");

                    b.ToTable("partners_payments");
                });

            modelBuilder.Entity("MAVN.Service.OperationsHistory.MsSqlRepositories.Entities.PartnersPaymentRefundEntity", b =>
                {
                    b.Property<string>("PaymentRequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("payment_request_id");

                    b.Property<string>("Amount")
                        .IsRequired()
                        .HasColumnName("amount");

                    b.Property<string>("AssetSymbol")
                        .IsRequired()
                        .HasColumnName("asset_symbol");

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnName("customer_id");

                    b.Property<string>("LocationId")
                        .HasColumnName("location_id");

                    b.Property<string>("PartnerId")
                        .IsRequired()
                        .HasColumnName("partner_id");

                    b.Property<string>("PartnerName")
                        .IsRequired()
                        .HasColumnName("partner_name");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnName("timestamp");

                    b.HasKey("PaymentRequestId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("Timestamp");

                    b.ToTable("refunded_partners_payments");
                });

            modelBuilder.Entity("MAVN.Service.OperationsHistory.MsSqlRepositories.Entities.PaymentTransferEntity", b =>
                {
                    b.Property<string>("TransferId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("transfer_id");

                    b.Property<string>("Amount")
                        .IsRequired()
                        .HasColumnName("amount");

                    b.Property<string>("AssetSymbol")
                        .IsRequired()
                        .HasColumnName("asset_symbol");

                    b.Property<string>("BurnRuleId")
                        .IsRequired()
                        .HasColumnName("burn_rule_id");

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnName("customer_id");

                    b.Property<string>("InvoiceId")
                        .IsRequired()
                        .HasColumnName("invoice_id");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnName("timestamp");

                    b.HasKey("TransferId");

                    b.HasIndex("BurnRuleId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("Timestamp");

                    b.ToTable("payment_transfers");
                });

            modelBuilder.Entity("MAVN.Service.OperationsHistory.MsSqlRepositories.Entities.PaymentTransferRefundEntity", b =>
                {
                    b.Property<string>("TransferId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("transfer_id");

                    b.Property<string>("Amount")
                        .IsRequired()
                        .HasColumnName("amount");

                    b.Property<string>("AssetSymbol")
                        .IsRequired()
                        .HasColumnName("asset_symbol");

                    b.Property<string>("BurnRuleId")
                        .IsRequired()
                        .HasColumnName("burn_rule_id");

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnName("customer_id");

                    b.Property<string>("InvoiceId")
                        .IsRequired()
                        .HasColumnName("invoice_id");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnName("timestamp");

                    b.HasKey("TransferId");

                    b.HasIndex("BurnRuleId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("Timestamp");

                    b.ToTable("refunded_payment_transfers");
                });

            modelBuilder.Entity("MAVN.Service.OperationsHistory.MsSqlRepositories.Entities.TransactionHistoryEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AssetSymbol")
                        .IsRequired()
                        .HasColumnName("asset");

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnName("customer_id");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnName("timestamp");

                    b.Property<string>("TransactionId")
                        .IsRequired()
                        .HasColumnName("transaction_id");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnName("type");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("Timestamp");

                    b.HasIndex("TransactionId");

                    b.ToTable("transaction_history");
                });

            modelBuilder.Entity("MAVN.Service.OperationsHistory.MsSqlRepositories.Entities.TransferEntity", b =>
                {
                    b.Property<string>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("transaction_id");

                    b.Property<string>("Amount")
                        .IsRequired()
                        .HasColumnName("amount");

                    b.Property<string>("AssetSymbol")
                        .IsRequired()
                        .HasColumnName("asset");

                    b.Property<string>("ExternalOperationId")
                        .HasColumnName("external_operation_id");

                    b.Property<string>("ReceiverCustomerId")
                        .IsRequired()
                        .HasColumnName("receiver_id");

                    b.Property<string>("ReceiverWalletAddress")
                        .IsRequired()
                        .HasColumnName("receiver_wallet_address");

                    b.Property<string>("SenderCustomerId")
                        .IsRequired()
                        .HasColumnName("sender_id");

                    b.Property<string>("SenderWalletAddress")
                        .IsRequired()
                        .HasColumnName("sender_wallet_address");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnName("timestamp");

                    b.HasKey("TransactionId");

                    b.HasIndex("ReceiverCustomerId");

                    b.HasIndex("SenderCustomerId");

                    b.ToTable("transfer");
                });

            modelBuilder.Entity("MAVN.Service.OperationsHistory.MsSqlRepositories.Entities.BonusCashInEntity", b =>
                {
                    b.HasOne("MAVN.Service.OperationsHistory.MsSqlRepositories.Entities.CampaignEntity", "Campaign")
                        .WithMany()
                        .HasForeignKey("CampaignId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MAVN.Service.OperationsHistory.MsSqlRepositories.Entities.PaymentTransferEntity", b =>
                {
                    b.HasOne("MAVN.Service.OperationsHistory.MsSqlRepositories.Entities.BurnRuleEntity", "BurnRule")
                        .WithMany()
                        .HasForeignKey("BurnRuleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MAVN.Service.OperationsHistory.MsSqlRepositories.Entities.PaymentTransferRefundEntity", b =>
                {
                    b.HasOne("MAVN.Service.OperationsHistory.MsSqlRepositories.Entities.BurnRuleEntity", "BurnRule")
                        .WithMany()
                        .HasForeignKey("BurnRuleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
