﻿// <auto-generated />
using System;
using Merp.Accountancy.Drafts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Merp.Accountancy.Drafts.Migrations
{
    [DbContext(typeof(AccountancyDraftsDbContext))]
    partial class AccountancyDraftsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Merp.Accountancy.Drafts.Model.DraftLineItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code");

                    b.Property<string>("Description");

                    b.Property<Guid?>("InvoiceDraftId");

                    b.Property<int>("Quantity");

                    b.Property<decimal>("TotalPrice");

                    b.Property<decimal>("UnitPrice");

                    b.Property<decimal>("Vat");

                    b.Property<string>("VatDescription");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceDraftId");

                    b.ToTable("DraftLineItems");
                });

            modelBuilder.Entity("Merp.Accountancy.Drafts.Model.InvoiceDraft", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Currency");

                    b.Property<DateTime?>("Date");

                    b.Property<string>("Description");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("PaymentTerms");

                    b.Property<bool>("PricesAreVatIncluded");

                    b.Property<string>("PurchaseOrderNumber");

                    b.Property<decimal>("TaxableAmount");

                    b.Property<decimal>("Taxes");

                    b.Property<decimal>("TotalPrice");

                    b.Property<decimal>("TotalToPay");

                    b.HasKey("Id");

                    b.HasIndex("Date");

                    b.HasIndex("PurchaseOrderNumber");

                    b.ToTable("InvoiceDraft");

                    b.HasDiscriminator<string>("Discriminator").HasValue("InvoiceDraft");
                });

            modelBuilder.Entity("Merp.Accountancy.Drafts.Model.NonTaxableItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount");

                    b.Property<string>("Description");

                    b.Property<Guid?>("InvoiceDraftId");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceDraftId");

                    b.ToTable("DraftNonTaxableItems");
                });

            modelBuilder.Entity("Merp.Accountancy.Drafts.Model.PriceByVat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid?>("InvoiceDraftId");

                    b.Property<decimal?>("ProvidenceFundAmount");

                    b.Property<decimal>("TaxableAmount");

                    b.Property<decimal>("TotalPrice");

                    b.Property<decimal>("VatAmount");

                    b.Property<decimal>("VatRate");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceDraftId");

                    b.ToTable("DraftPricesByVat");
                });

            modelBuilder.Entity("Merp.Accountancy.Drafts.Model.OutgoingCreditNoteDraft", b =>
                {
                    b.HasBaseType("Merp.Accountancy.Drafts.Model.InvoiceDraft");


                    b.ToTable("OutgoingCreditNoteDraft");

                    b.HasDiscriminator().HasValue("OutgoingCreditNoteDraft");
                });

            modelBuilder.Entity("Merp.Accountancy.Drafts.Model.OutgoingInvoiceDraft", b =>
                {
                    b.HasBaseType("Merp.Accountancy.Drafts.Model.InvoiceDraft");


                    b.ToTable("OutgoingInvoiceDraft");

                    b.HasDiscriminator().HasValue("OutgoingInvoiceDraft");
                });

            modelBuilder.Entity("Merp.Accountancy.Drafts.Model.DraftLineItem", b =>
                {
                    b.HasOne("Merp.Accountancy.Drafts.Model.InvoiceDraft")
                        .WithMany("LineItems")
                        .HasForeignKey("InvoiceDraftId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Merp.Accountancy.Drafts.Model.InvoiceDraft", b =>
                {
                    b.OwnsOne("Merp.Accountancy.Drafts.Model.PartyInfo", "Customer", b1 =>
                        {
                            b1.Property<Guid?>("InvoiceDraftId");

                            b1.Property<string>("City");

                            b1.Property<string>("Country");

                            b1.Property<string>("Name")
                                .HasMaxLength(100);

                            b1.Property<string>("NationalIdentificationNumber");

                            b1.Property<Guid>("OriginalId");

                            b1.Property<string>("PostalCode");

                            b1.Property<string>("StreetName");

                            b1.Property<string>("VatIndex");

                            b1.HasIndex("Name");

                            b1.ToTable("InvoiceDraft");

                            b1.HasOne("Merp.Accountancy.Drafts.Model.InvoiceDraft")
                                .WithOne("Customer")
                                .HasForeignKey("Merp.Accountancy.Drafts.Model.PartyInfo", "InvoiceDraftId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });

                    b.OwnsOne("Merp.Accountancy.Drafts.Model.ProvidenceFund", "ProvidenceFund", b1 =>
                        {
                            b1.Property<Guid?>("InvoiceDraftId");

                            b1.Property<decimal?>("Amount");

                            b1.Property<string>("Description");

                            b1.Property<decimal?>("Rate");

                            b1.ToTable("InvoiceDraft");

                            b1.HasOne("Merp.Accountancy.Drafts.Model.InvoiceDraft")
                                .WithOne("ProvidenceFund")
                                .HasForeignKey("Merp.Accountancy.Drafts.Model.ProvidenceFund", "InvoiceDraftId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });

                    b.OwnsOne("Merp.Accountancy.Drafts.Model.WithholdingTax", "WithholdingTax", b1 =>
                        {
                            b1.Property<Guid?>("InvoiceDraftId");

                            b1.Property<decimal>("Amount");

                            b1.Property<string>("Description");

                            b1.Property<decimal>("Rate");

                            b1.Property<decimal>("TaxableAmountRate");

                            b1.ToTable("InvoiceDraft");

                            b1.HasOne("Merp.Accountancy.Drafts.Model.InvoiceDraft")
                                .WithOne("WithholdingTax")
                                .HasForeignKey("Merp.Accountancy.Drafts.Model.WithholdingTax", "InvoiceDraftId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });

            modelBuilder.Entity("Merp.Accountancy.Drafts.Model.NonTaxableItem", b =>
                {
                    b.HasOne("Merp.Accountancy.Drafts.Model.InvoiceDraft")
                        .WithMany("NonTaxableItems")
                        .HasForeignKey("InvoiceDraftId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Merp.Accountancy.Drafts.Model.PriceByVat", b =>
                {
                    b.HasOne("Merp.Accountancy.Drafts.Model.InvoiceDraft")
                        .WithMany("PricesByVat")
                        .HasForeignKey("InvoiceDraftId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
