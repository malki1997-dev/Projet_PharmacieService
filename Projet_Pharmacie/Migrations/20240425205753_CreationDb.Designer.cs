﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projet_Pharmacie.Models;

#nullable disable

namespace Projet_Pharmacie.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20240425205753_CreationDb")]
    partial class CreationDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Projet_PharmaService.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdresseEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateNaissance")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("Projet_PharmaService.Models.ArchivePanier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("PanierId")
                        .HasColumnType("int");

                    b.Property<string>("livraison")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("modePaiment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("motif")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("prixTotal")
                        .HasColumnType("float");

                    b.Property<string>("statuts")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("time")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PanierId");

                    b.ToTable("ArchivePaniers");
                });

            modelBuilder.Entity("Projet_PharmaService.Models.Catalog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Catalogs");
                });

            modelBuilder.Entity("Projet_PharmaService.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdresseEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateNaissance")
                        .HasColumnType("datetime2");

                    b.Property<string>("Etat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mutuelle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Projet_PharmaService.Models.Commande", b =>
                {
                    b.Property<int>("CommandeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommandeId"), 1L, 1);

                    b.Property<string>("AdresseLivraison")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCommande")
                        .HasColumnType("datetime2");

                    b.Property<int>("LivreurId")
                        .HasColumnType("int");

                    b.Property<string>("QR")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SuiviLivraison")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CommandeId");

                    b.HasIndex("LivreurId");

                    b.ToTable("Commandes");
                });

            modelBuilder.Entity("Projet_PharmaService.Models.Facture", b =>
                {
                    b.Property<int>("FactureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FactureId"), 1L, 1);

                    b.Property<int>("CommandeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateFacture")
                        .HasColumnType("datetime2");

                    b.Property<int>("PaiementId")
                        .HasColumnType("int");

                    b.Property<double>("PrixTotalFacture")
                        .HasColumnType("float");

                    b.Property<double>("TvaFacture")
                        .HasColumnType("float");

                    b.HasKey("FactureId");

                    b.HasIndex("CommandeId");

                    b.HasIndex("PaiementId");

                    b.ToTable("Factures");
                });

            modelBuilder.Entity("Projet_PharmaService.Models.Livraison", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("dateLivraison")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Livraisons");
                });

            modelBuilder.Entity("Projet_PharmaService.Models.Livreur", b =>
                {
                    b.Property<int>("LivreurId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LivreurId"), 1L, 1);

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdresseEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateNaissance")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoteSatisfais")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Permis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VehiculeUtilise")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZoneLivraison")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LivreurId");

                    b.ToTable("Livreurs");
                });

            modelBuilder.Entity("Projet_PharmaService.Models.Medicament", b =>
                {
                    b.Property<int>("MedicamentId")
                        .HasColumnType("int");

                    b.Property<int>("CatalogId")
                        .HasColumnType("int");

                    b.Property<int>("CommandeId")
                        .HasColumnType("int");

                    b.Property<int?>("PanierId")
                        .HasColumnType("int");

                    b.Property<string>("designation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("form")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("info")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MedicamentId");

                    b.HasIndex("CatalogId");

                    b.HasIndex("CommandeId");

                    b.HasIndex("PanierId");

                    b.ToTable("Medicaments");
                });

            modelBuilder.Entity("Projet_PharmaService.Models.Notification", b =>
                {
                    b.Property<int>("NotificationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NotificationId"), 1L, 1);

                    b.Property<int?>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Destinataire")
                        .HasColumnType("int");

                    b.Property<int>("LivreurId")
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PharmacieId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NotificationId");

                    b.HasIndex("ClientId");

                    b.HasIndex("LivreurId");

                    b.HasIndex("PharmacieId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("Projet_PharmaService.Models.Paiement", b =>
                {
                    b.Property<int>("PaiementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaiementId"), 1L, 1);

                    b.Property<string>("PaiementMode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PaiementId");

                    b.ToTable("Paiements");
                });

            modelBuilder.Entity("Projet_PharmaService.Models.Panier", b =>
                {
                    b.Property<int>("PanierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PanierId"), 1L, 1);

                    b.Property<int>("PharmacyId")
                        .HasColumnType("int");

                    b.Property<int>("clientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("dateCreation")
                        .HasColumnType("datetime2");

                    b.Property<double>("prixTotal")
                        .HasColumnType("float");

                    b.Property<string>("satuts")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PanierId");

                    b.HasIndex("PharmacyId");

                    b.HasIndex("clientId");

                    b.ToTable("Paniers");
                });

            modelBuilder.Entity("Projet_PharmaService.Models.Pharmacie", b =>
                {
                    b.Property<int>("PharmacieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PharmacieId"), 1L, 1);

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CodePostal")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Enseigne")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ville")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PharmacieId");

                    b.ToTable("Pharmacies");
                });

            modelBuilder.Entity("Projet_PharmaService.Models.Statistique", b =>
                {
                    b.Property<int>("StatistiqueID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StatistiqueID"), 1L, 1);

                    b.Property<int>("StockId")
                        .HasColumnType("int");

                    b.Property<double>("chifreDaffaire")
                        .HasColumnType("float");

                    b.Property<double>("margeBeneficiaire")
                        .HasColumnType("float");

                    b.Property<int>("nombreVentes")
                        .HasColumnType("int");

                    b.Property<string>("period")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StatistiqueID");

                    b.HasIndex("StockId");

                    b.ToTable("Statistiques");
                });

            modelBuilder.Entity("Projet_PharmaService.Models.Stock", b =>
                {
                    b.Property<int>("StockId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StockId"), 1L, 1);

                    b.Property<int>("MedicamentId")
                        .HasColumnType("int");

                    b.Property<int>("PharmacieId")
                        .HasColumnType("int");

                    b.Property<DateTime>("datePeremption")
                        .HasColumnType("datetime2");

                    b.Property<int>("quantite")
                        .HasColumnType("int");

                    b.Property<double>("seuilReaprovisionnement")
                        .HasColumnType("float");

                    b.HasKey("StockId");

                    b.HasIndex("MedicamentId");

                    b.HasIndex("PharmacieId")
                        .IsUnique();

                    b.ToTable("Stocks");
                });

            modelBuilder.Entity("Projet_PharmaService.Models.ArchivePanier", b =>
                {
                    b.HasOne("Projet_PharmaService.Models.Panier", "panier")
                        .WithMany()
                        .HasForeignKey("PanierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("panier");
                });

            modelBuilder.Entity("Projet_PharmaService.Models.Commande", b =>
                {
                    b.HasOne("Projet_PharmaService.Models.Livreur", "Livreur")
                        .WithMany("Commandes")
                        .HasForeignKey("LivreurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Livreur");
                });

            modelBuilder.Entity("Projet_PharmaService.Models.Facture", b =>
                {
                    b.HasOne("Projet_PharmaService.Models.Commande", "Commande")
                        .WithMany()
                        .HasForeignKey("CommandeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Projet_PharmaService.Models.Paiement", "Paiement")
                        .WithMany("Factures")
                        .HasForeignKey("PaiementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Commande");

                    b.Navigation("Paiement");
                });

            modelBuilder.Entity("Projet_PharmaService.Models.Medicament", b =>
                {
                    b.HasOne("Projet_PharmaService.Models.Catalog", "catalog")
                        .WithMany("medicaments")
                        .HasForeignKey("CatalogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Projet_PharmaService.Models.Commande", "Commande")
                        .WithMany("Medicament")
                        .HasForeignKey("CommandeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Projet_PharmaService.Models.Panier", null)
                        .WithMany("Medicaments")
                        .HasForeignKey("PanierId");

                    b.Navigation("Commande");

                    b.Navigation("catalog");
                });

            modelBuilder.Entity("Projet_PharmaService.Models.Notification", b =>
                {
                    b.HasOne("Projet_PharmaService.Models.Client", null)
                        .WithMany("Notifications")
                        .HasForeignKey("ClientId");

                    b.HasOne("Projet_PharmaService.Models.Livreur", "Livreur")
                        .WithMany()
                        .HasForeignKey("LivreurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Projet_PharmaService.Models.Pharmacie", "Pharmacie")
                        .WithMany("Notifications")
                        .HasForeignKey("PharmacieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Livreur");

                    b.Navigation("Pharmacie");
                });

            modelBuilder.Entity("Projet_PharmaService.Models.Panier", b =>
                {
                    b.HasOne("Projet_PharmaService.Models.Pharmacie", "Pharmacy")
                        .WithMany("Paniers")
                        .HasForeignKey("PharmacyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Projet_PharmaService.Models.Client", "client")
                        .WithMany("Paniers")
                        .HasForeignKey("clientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pharmacy");

                    b.Navigation("client");
                });

            modelBuilder.Entity("Projet_PharmaService.Models.Statistique", b =>
                {
                    b.HasOne("Projet_PharmaService.Models.Stock", "Stock")
                        .WithMany("statistiques")
                        .HasForeignKey("StockId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Stock");
                });

            modelBuilder.Entity("Projet_PharmaService.Models.Stock", b =>
                {
                    b.HasOne("Projet_PharmaService.Models.Medicament", "Medicament")
                        .WithMany()
                        .HasForeignKey("MedicamentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Projet_PharmaService.Models.Pharmacie", "Pharmacie")
                        .WithOne("Stock")
                        .HasForeignKey("Projet_PharmaService.Models.Stock", "PharmacieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medicament");

                    b.Navigation("Pharmacie");
                });

            modelBuilder.Entity("Projet_PharmaService.Models.Catalog", b =>
                {
                    b.Navigation("medicaments");
                });

            modelBuilder.Entity("Projet_PharmaService.Models.Client", b =>
                {
                    b.Navigation("Notifications");

                    b.Navigation("Paniers");
                });

            modelBuilder.Entity("Projet_PharmaService.Models.Commande", b =>
                {
                    b.Navigation("Medicament");
                });

            modelBuilder.Entity("Projet_PharmaService.Models.Livreur", b =>
                {
                    b.Navigation("Commandes");
                });

            modelBuilder.Entity("Projet_PharmaService.Models.Paiement", b =>
                {
                    b.Navigation("Factures");
                });

            modelBuilder.Entity("Projet_PharmaService.Models.Panier", b =>
                {
                    b.Navigation("Medicaments");
                });

            modelBuilder.Entity("Projet_PharmaService.Models.Pharmacie", b =>
                {
                    b.Navigation("Notifications");

                    b.Navigation("Paniers");

                    b.Navigation("Stock");
                });

            modelBuilder.Entity("Projet_PharmaService.Models.Stock", b =>
                {
                    b.Navigation("statistiques");
                });
#pragma warning restore 612, 618
        }
    }
}
