﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using database.helper;

#nullable disable

namespace database.helper.Migrations
{
    [DbContext(typeof(MediaServiceContext))]
    partial class MediaServiceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AccountsDLL.Entities.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("FailedLogins")
                        .HasColumnType("integer");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("AccountsDLL.Entities.AccountLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<Guid?>("AccountId")
                        .HasColumnType("uuid");

                    b.Property<int>("Level")
                        .HasColumnType("integer");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("AccountLog");
                });

            modelBuilder.Entity("database.helper.Entitites.Episode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("AirDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("Number")
                        .HasColumnType("integer");

                    b.Property<double?>("Rating")
                        .HasColumnType("double precision");

                    b.Property<int?>("SeasonId")
                        .HasColumnType("integer");

                    b.Property<string>("StillPath")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<int?>("VoteCount")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("SeasonId");

                    b.ToTable("Episode");
                });

            modelBuilder.Entity("database.helper.Entitites.Genre", b =>
                {
                    b.Property<int>("InstanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("InstanceId"));

                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<int?>("MediaTmdbId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("InstanceId");

                    b.HasIndex("MediaTmdbId");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("database.helper.Entitites.Media", b =>
                {
                    b.Property<int>("TmdbId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TmdbId"));

                    b.Property<string>("BackdropURL")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Release")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Tagline")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("TmdbId");

                    b.ToTable("Media");

                    b.HasDiscriminator<string>("type").HasValue("Media");
                });

            modelBuilder.Entity("database.helper.Entitites.Season", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int?>("Number")
                        .HasColumnType("integer");

                    b.Property<int?>("SeriesTmdbId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("SeriesTmdbId");

                    b.ToTable("Season");
                });

            modelBuilder.Entity("database.helper.Entitites.StreamingInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<int?>("MediaTmdbId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("MediaTmdbId");

                    b.ToTable("StreamingInfo");
                });

            modelBuilder.Entity("database.helper.Entitites.Movie", b =>
                {
                    b.HasBaseType("database.helper.Entitites.Media");

                    b.Property<string>("ImdbId")
                        .HasColumnType("text");

                    b.Property<float?>("Rating")
                        .HasColumnType("real");

                    b.Property<int?>("Runtime")
                        .HasColumnType("integer");

                    b.Property<int?>("VoteCount")
                        .HasColumnType("integer");

                    b.HasDiscriminator().HasValue("movie");
                });

            modelBuilder.Entity("database.helper.Entitites.Series", b =>
                {
                    b.HasBaseType("database.helper.Entitites.Media");

                    b.Property<DateTime?>("LastAirDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasDiscriminator().HasValue("series");
                });

            modelBuilder.Entity("AccountsDLL.Entities.AccountLog", b =>
                {
                    b.HasOne("AccountsDLL.Entities.Account", null)
                        .WithMany("Logs")
                        .HasForeignKey("AccountId");
                });

            modelBuilder.Entity("database.helper.Entitites.Episode", b =>
                {
                    b.HasOne("database.helper.Entitites.Season", null)
                        .WithMany("Episodes")
                        .HasForeignKey("SeasonId");
                });

            modelBuilder.Entity("database.helper.Entitites.Genre", b =>
                {
                    b.HasOne("database.helper.Entitites.Media", null)
                        .WithMany("Genres")
                        .HasForeignKey("MediaTmdbId");
                });

            modelBuilder.Entity("database.helper.Entitites.Season", b =>
                {
                    b.HasOne("database.helper.Entitites.Series", null)
                        .WithMany("Seasons")
                        .HasForeignKey("SeriesTmdbId");
                });

            modelBuilder.Entity("database.helper.Entitites.StreamingInfo", b =>
                {
                    b.HasOne("database.helper.Entitites.Media", null)
                        .WithMany("StreamingInfos")
                        .HasForeignKey("MediaTmdbId");
                });

            modelBuilder.Entity("AccountsDLL.Entities.Account", b =>
                {
                    b.Navigation("Logs");
                });

            modelBuilder.Entity("database.helper.Entitites.Media", b =>
                {
                    b.Navigation("Genres");

                    b.Navigation("StreamingInfos");
                });

            modelBuilder.Entity("database.helper.Entitites.Season", b =>
                {
                    b.Navigation("Episodes");
                });

            modelBuilder.Entity("database.helper.Entitites.Series", b =>
                {
                    b.Navigation("Seasons");
                });
#pragma warning restore 612, 618
        }
    }
}
