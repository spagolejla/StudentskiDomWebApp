﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using StudentskiDom.Data.EF;
using System;

namespace StudentskiDom.Data.Migrations
{
    [DbContext(typeof(MojContext))]
    [Migration("20180405115957_inic")]
    partial class inic
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StudentskiDom.Data.Models.AkademskaGodina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naziv");

                    b.HasKey("Id");

                    b.ToTable("AkademskeGodine");
                });

            modelBuilder.Entity("StudentskiDom.Data.Models.Drzava", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naziv");

                    b.HasKey("Id");

                    b.ToTable("Drzave");
                });

            modelBuilder.Entity("StudentskiDom.Data.Models.Fakultet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adresa");

                    b.Property<string>("Mail");

                    b.Property<string>("Naziv");

                    b.HasKey("Id");

                    b.ToTable("Fakulteti");
                });

            modelBuilder.Entity("StudentskiDom.Data.Models.Grad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naziv");

                    b.Property<int>("_RegijaId");

                    b.HasKey("Id");

                    b.HasIndex("_RegijaId");

                    b.ToTable("Gradovi");
                });

            modelBuilder.Entity("StudentskiDom.Data.Models.KorisnickiNalog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("KorisnickoIme");

                    b.Property<string>("Lozinka");

                    b.HasKey("Id");

                    b.ToTable("KorisnickiNalozi");
                });

            modelBuilder.Entity("StudentskiDom.Data.Models.Posjetilac", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Ime");

                    b.Property<string>("JMBG");

                    b.Property<string>("Mail");

                    b.Property<string>("Prezime");

                    b.Property<string>("Telefon");

                    b.HasKey("Id");

                    b.ToTable("Pojsjetioci");
                });

            modelBuilder.Entity("StudentskiDom.Data.Models.Regija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naziv");

                    b.Property<int>("_DrzavaId");

                    b.HasKey("Id");

                    b.HasIndex("_DrzavaId");

                    b.ToTable("Regije");
                });

            modelBuilder.Entity("StudentskiDom.Data.Models.RezervacijaSale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BrojSati");

                    b.Property<DateTime>("Datum");

                    b.Property<double>("UkupnaCijena");

                    b.Property<int>("_PosjetilacId");

                    b.Property<int>("_SalaId");

                    b.Property<int>("_ZaposlenikId");

                    b.HasKey("Id");

                    b.HasIndex("_PosjetilacId");

                    b.HasIndex("_SalaId");

                    b.HasIndex("_ZaposlenikId");

                    b.ToTable("RezervacijeSale");
                });

            modelBuilder.Entity("StudentskiDom.Data.Models.Sala", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("CijenaPoSatu");

                    b.Property<int>("Kapacitet");

                    b.Property<string>("Naziv");

                    b.HasKey("Id");

                    b.ToTable("Sale");
                });

            modelBuilder.Entity("StudentskiDom.Data.Models.Soba", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BrojKreveta");

                    b.Property<string>("Naziv");

                    b.Property<int>("Sprat");

                    b.Property<int?>("_TipSobeId");

                    b.HasKey("Id");

                    b.HasIndex("_TipSobeId");

                    b.ToTable("Sobe");
                });

            modelBuilder.Entity("StudentskiDom.Data.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adresa");

                    b.Property<DateTime>("DatumRodjenja");

                    b.Property<string>("Ime");

                    b.Property<string>("JMBG");

                    b.Property<int?>("KorisnickiNalogId");

                    b.Property<string>("Mail");

                    b.Property<string>("Prezime");

                    b.Property<string>("Spol");

                    b.Property<string>("Telefon");

                    b.Property<int?>("_FakultetId");

                    b.Property<int?>("_GradId");

                    b.HasKey("Id");

                    b.HasIndex("KorisnickiNalogId");

                    b.HasIndex("_FakultetId");

                    b.HasIndex("_GradId");

                    b.ToTable("Studenti");
                });

            modelBuilder.Entity("StudentskiDom.Data.Models.StudentSoba", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumDodjele");

                    b.Property<string>("Napomena");

                    b.Property<int>("_AkademskaGodinaId");

                    b.Property<int>("_SobaId");

                    b.Property<int>("_StudentId");

                    b.Property<int>("_ZaposlenikId");

                    b.HasKey("Id");

                    b.HasIndex("_AkademskaGodinaId");

                    b.HasIndex("_SobaId");

                    b.HasIndex("_StudentId");

                    b.HasIndex("_ZaposlenikId");

                    b.ToTable("StudentiSobe");
                });

            modelBuilder.Entity("StudentskiDom.Data.Models.TerminVeseraja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumKoristenja");

                    b.Property<int>("VrijemeKoristenja");

                    b.Property<int>("_StudentSobaId");

                    b.Property<int>("_VesMasinaId");

                    b.HasKey("Id");

                    b.HasIndex("_StudentSobaId");

                    b.HasIndex("_VesMasinaId");

                    b.ToTable("TerminiVeseraja");
                });

            modelBuilder.Entity("StudentskiDom.Data.Models.TipSobe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naziv");

                    b.HasKey("Id");

                    b.ToTable("TipoviSoba");
                });

            modelBuilder.Entity("StudentskiDom.Data.Models.TipUplate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naziv");

                    b.HasKey("Id");

                    b.ToTable("TipoviUplata");
                });

            modelBuilder.Entity("StudentskiDom.Data.Models.Uplata", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Datum");

                    b.Property<double>("Iznos");

                    b.Property<int>("_StudentSobaId");

                    b.Property<int>("_TipUplateId");

                    b.Property<int>("_ZaposlenikId");

                    b.HasKey("Id");

                    b.HasIndex("_StudentSobaId");

                    b.HasIndex("_TipUplateId");

                    b.HasIndex("_ZaposlenikId");

                    b.ToTable("Uplate");
                });

            modelBuilder.Entity("StudentskiDom.Data.Models.VesMasina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Kapacitet");

                    b.Property<string>("Naziv");

                    b.Property<bool>("Susilica");

                    b.HasKey("Id");

                    b.ToTable("VesMasine");
                });

            modelBuilder.Entity("StudentskiDom.Data.Models.VrstaZaposlenika", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IznosSatnice");

                    b.Property<string>("Naziv");

                    b.HasKey("Id");

                    b.ToTable("VrsteZaposlenika");
                });

            modelBuilder.Entity("StudentskiDom.Data.Models.Zaposlenik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Ime");

                    b.Property<string>("JMBG");

                    b.Property<int?>("KorisnickiNalogId");

                    b.Property<string>("Mail");

                    b.Property<string>("Prezime");

                    b.Property<string>("Telefon");

                    b.Property<int?>("_GradId");

                    b.Property<int?>("_VrstaZaposlenikaId");

                    b.HasKey("Id");

                    b.HasIndex("KorisnickiNalogId");

                    b.HasIndex("_GradId");

                    b.HasIndex("_VrstaZaposlenikaId");

                    b.ToTable("Zaposlenici");
                });

            modelBuilder.Entity("StudentskiDom.Data.Models.Grad", b =>
                {
                    b.HasOne("StudentskiDom.Data.Models.Regija", "_Regija")
                        .WithMany()
                        .HasForeignKey("_RegijaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StudentskiDom.Data.Models.Regija", b =>
                {
                    b.HasOne("StudentskiDom.Data.Models.Drzava", "_Drzava")
                        .WithMany()
                        .HasForeignKey("_DrzavaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StudentskiDom.Data.Models.RezervacijaSale", b =>
                {
                    b.HasOne("StudentskiDom.Data.Models.Posjetilac", "_Posjetilac")
                        .WithMany()
                        .HasForeignKey("_PosjetilacId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("StudentskiDom.Data.Models.Sala", "_Sala")
                        .WithMany()
                        .HasForeignKey("_SalaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("StudentskiDom.Data.Models.Zaposlenik", "_Zaposlenik")
                        .WithMany()
                        .HasForeignKey("_ZaposlenikId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StudentskiDom.Data.Models.Soba", b =>
                {
                    b.HasOne("StudentskiDom.Data.Models.TipSobe", "_TipSobe")
                        .WithMany()
                        .HasForeignKey("_TipSobeId");
                });

            modelBuilder.Entity("StudentskiDom.Data.Models.Student", b =>
                {
                    b.HasOne("StudentskiDom.Data.Models.KorisnickiNalog", "KorisnickiNalog")
                        .WithMany()
                        .HasForeignKey("KorisnickiNalogId");

                    b.HasOne("StudentskiDom.Data.Models.Fakultet", "_Fakultet")
                        .WithMany()
                        .HasForeignKey("_FakultetId");

                    b.HasOne("StudentskiDom.Data.Models.Grad", "_Grad")
                        .WithMany()
                        .HasForeignKey("_GradId");
                });

            modelBuilder.Entity("StudentskiDom.Data.Models.StudentSoba", b =>
                {
                    b.HasOne("StudentskiDom.Data.Models.AkademskaGodina", "_AkademskaGodina")
                        .WithMany()
                        .HasForeignKey("_AkademskaGodinaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("StudentskiDom.Data.Models.Soba", "_Soba")
                        .WithMany()
                        .HasForeignKey("_SobaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("StudentskiDom.Data.Models.Student", "_Student")
                        .WithMany()
                        .HasForeignKey("_StudentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("StudentskiDom.Data.Models.Zaposlenik", "_Zaposlenik")
                        .WithMany()
                        .HasForeignKey("_ZaposlenikId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("StudentskiDom.Data.Models.TerminVeseraja", b =>
                {
                    b.HasOne("StudentskiDom.Data.Models.StudentSoba", "_StudentSoba")
                        .WithMany()
                        .HasForeignKey("_StudentSobaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("StudentskiDom.Data.Models.VesMasina", "_VesMasina")
                        .WithMany()
                        .HasForeignKey("_VesMasinaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StudentskiDom.Data.Models.Uplata", b =>
                {
                    b.HasOne("StudentskiDom.Data.Models.StudentSoba", "_StudentSoba")
                        .WithMany()
                        .HasForeignKey("_StudentSobaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("StudentskiDom.Data.Models.TipUplate", "_TipUplate")
                        .WithMany()
                        .HasForeignKey("_TipUplateId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("StudentskiDom.Data.Models.Zaposlenik", "_Zaposlenik")
                        .WithMany()
                        .HasForeignKey("_ZaposlenikId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StudentskiDom.Data.Models.Zaposlenik", b =>
                {
                    b.HasOne("StudentskiDom.Data.Models.KorisnickiNalog", "KorisnickiNalog")
                        .WithMany()
                        .HasForeignKey("KorisnickiNalogId");

                    b.HasOne("StudentskiDom.Data.Models.Grad", "_Grad")
                        .WithMany()
                        .HasForeignKey("_GradId");

                    b.HasOne("StudentskiDom.Data.Models.VrstaZaposlenika", "_VrstaZaposlenika")
                        .WithMany()
                        .HasForeignKey("_VrstaZaposlenikaId");
                });
#pragma warning restore 612, 618
        }
    }
}
