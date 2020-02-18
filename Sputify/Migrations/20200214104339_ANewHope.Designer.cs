﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sputify.Models;

namespace Sputify.Migrations
{
    [DbContext(typeof(SputifyContext))]
    [Migration("20200214104339_ANewHope")]
    partial class ANewHope
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sputify.Models.Album", b =>
                {
                    b.Property<int>("AlbumID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AlbumTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AlbumID");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("Sputify.Models.Collection", b =>
                {
                    b.Property<int>("CollectionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PlayOrder")
                        .HasColumnType("int");

                    b.Property<int?>("SongID")
                        .HasColumnType("int");

                    b.HasKey("CollectionID");

                    b.HasIndex("SongID");

                    b.ToTable("Collections");
                });

            modelBuilder.Entity("Sputify.Models.Playlist", b =>
                {
                    b.Property<int>("PlaylistID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CollectionID")
                        .HasColumnType("int");

                    b.Property<string>("PlaylistName")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("PlaylistID");

                    b.HasIndex("CollectionID");

                    b.ToTable("Playlists");
                });

            modelBuilder.Entity("Sputify.Models.Song", b =>
                {
                    b.Property<int>("SongID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AlbumID")
                        .HasColumnType("int");

                    b.Property<string>("SongName")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("SongPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrackNumber")
                        .HasColumnType("int");

                    b.HasKey("SongID");

                    b.HasIndex("AlbumID");

                    b.ToTable("Songs");
                });

            modelBuilder.Entity("Sputify.Models.Collection", b =>
                {
                    b.HasOne("Sputify.Models.Song", "Song")
                        .WithMany()
                        .HasForeignKey("SongID");
                });

            modelBuilder.Entity("Sputify.Models.Playlist", b =>
                {
                    b.HasOne("Sputify.Models.Collection", "Collection")
                        .WithMany()
                        .HasForeignKey("CollectionID");
                });

            modelBuilder.Entity("Sputify.Models.Song", b =>
                {
                    b.HasOne("Sputify.Models.Album", "Album")
                        .WithMany("Songs")
                        .HasForeignKey("AlbumID");
                });
#pragma warning restore 612, 618
        }
    }
}