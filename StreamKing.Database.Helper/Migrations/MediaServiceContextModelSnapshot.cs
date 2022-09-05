﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using StreamKing.Database.Helper.Models;

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

            modelBuilder.Entity("StreamKing.Data.Accounts.Account", b =>
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

                    b.Property<string>("Region")
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

            modelBuilder.Entity("StreamKing.Data.Accounts.AccountLog", b =>
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

            modelBuilder.Entity("StreamKing.Data.Media.Episode", b =>
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

            modelBuilder.Entity("StreamKing.Data.Media.Genre", b =>
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

            modelBuilder.Entity("StreamKing.Data.Media.Media", b =>
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

            modelBuilder.Entity("StreamKing.Data.Media.Season", b =>
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

            modelBuilder.Entity("StreamKing.Data.Media.StreamingInfo", b =>
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

            modelBuilder.Entity("StreamKing.Data.Media.UserRating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("LastUpdated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<double>("Rating")
                        .HasColumnType("double precision");

                    b.Property<string>("Review")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("UserRating");
                });

            modelBuilder.Entity("StreamKing.Data.Media.WatchEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Tag")
                        .HasColumnType("text");

                    b.Property<int?>("UserRatingId")
                        .HasColumnType("integer");

                    b.Property<string>("watchEntry_type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserRatingId");

                    b.ToTable("WatchEntry");

                    b.HasDiscriminator<string>("watchEntry_type").HasValue("WatchEntry");
                });

            modelBuilder.Entity("StreamKing.Data.Media.Watchlist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<Guid?>("AccountId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("Watchlist");
                });

            modelBuilder.Entity("StreamKing.Data.Media.EpisodeEntry", b =>
                {
                    b.HasBaseType("StreamKing.Data.Media.WatchEntry");

                    b.Property<int>("EpisodeId")
                        .HasColumnType("integer");

                    b.Property<int?>("SeasonEntryId")
                        .HasColumnType("integer");

                    b.HasIndex("EpisodeId");

                    b.HasIndex("SeasonEntryId");

                    b.HasDiscriminator().HasValue("episode");
                });

            modelBuilder.Entity("StreamKing.Data.Media.Movie", b =>
                {
                    b.HasBaseType("StreamKing.Data.Media.Media");

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

            modelBuilder.Entity("StreamKing.Data.Media.MovieEntry", b =>
                {
                    b.HasBaseType("StreamKing.Data.Media.WatchEntry");

                    b.Property<int>("MovieTmdbId")
                        .HasColumnType("integer");

                    b.Property<int?>("WatchlistId")
                        .HasColumnType("integer")
                        .HasColumnName("MovieEntry_WatchlistId");

                    b.HasIndex("MovieTmdbId");

                    b.HasIndex("WatchlistId");

                    b.HasDiscriminator().HasValue("movie");
                });

            modelBuilder.Entity("StreamKing.Data.Media.SeasonEntry", b =>
                {
                    b.HasBaseType("StreamKing.Data.Media.WatchEntry");

                    b.Property<int>("SeasonId")
                        .HasColumnType("integer");

                    b.Property<int?>("SeriesEntryId")
                        .HasColumnType("integer");

                    b.HasIndex("SeasonId");

                    b.HasIndex("SeriesEntryId");

                    b.HasDiscriminator().HasValue("season");
                });

            modelBuilder.Entity("StreamKing.Data.Media.Series", b =>
                {
                    b.HasBaseType("StreamKing.Data.Media.Media");

                    b.Property<DateTime?>("LastAirDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasDiscriminator().HasValue("series");
                });

            modelBuilder.Entity("StreamKing.Data.Media.SeriesEntry", b =>
                {
                    b.HasBaseType("StreamKing.Data.Media.WatchEntry");

                    b.Property<int>("SeriesTmdbId")
                        .HasColumnType("integer");

                    b.Property<int?>("WatchlistId")
                        .HasColumnType("integer");

                    b.HasIndex("SeriesTmdbId");

                    b.HasIndex("WatchlistId");

                    b.HasDiscriminator().HasValue("series");
                });

            modelBuilder.Entity("StreamKing.Data.Accounts.AccountLog", b =>
                {
                    b.HasOne("StreamKing.Data.Accounts.Account", null)
                        .WithMany("Logs")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StreamKing.Data.Media.Episode", b =>
                {
                    b.HasOne("StreamKing.Data.Media.Season", null)
                        .WithMany("Episodes")
                        .HasForeignKey("SeasonId");
                });

            modelBuilder.Entity("StreamKing.Data.Media.Genre", b =>
                {
                    b.HasOne("StreamKing.Data.Media.Media", null)
                        .WithMany("Genres")
                        .HasForeignKey("MediaTmdbId");
                });

            modelBuilder.Entity("StreamKing.Data.Media.Season", b =>
                {
                    b.HasOne("StreamKing.Data.Media.Series", null)
                        .WithMany("Seasons")
                        .HasForeignKey("SeriesTmdbId");
                });

            modelBuilder.Entity("StreamKing.Data.Media.StreamingInfo", b =>
                {
                    b.HasOne("StreamKing.Data.Media.Media", null)
                        .WithMany("StreamingInfos")
                        .HasForeignKey("MediaTmdbId");
                });

            modelBuilder.Entity("StreamKing.Data.Media.WatchEntry", b =>
                {
                    b.HasOne("StreamKing.Data.Media.UserRating", "UserRating")
                        .WithMany()
                        .HasForeignKey("UserRatingId");

                    b.Navigation("UserRating");
                });

            modelBuilder.Entity("StreamKing.Data.Media.Watchlist", b =>
                {
                    b.HasOne("StreamKing.Data.Accounts.Account", null)
                        .WithMany("Watchlists")
                        .HasForeignKey("AccountId");
                });

            modelBuilder.Entity("StreamKing.Data.Media.EpisodeEntry", b =>
                {
                    b.HasOne("StreamKing.Data.Media.Episode", "Episode")
                        .WithMany()
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StreamKing.Data.Media.SeasonEntry", null)
                        .WithMany("Episodes")
                        .HasForeignKey("SeasonEntryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Episode");
                });

            modelBuilder.Entity("StreamKing.Data.Media.MovieEntry", b =>
                {
                    b.HasOne("StreamKing.Data.Media.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieTmdbId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StreamKing.Data.Media.Watchlist", null)
                        .WithMany("MovieList")
                        .HasForeignKey("WatchlistId");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("StreamKing.Data.Media.SeasonEntry", b =>
                {
                    b.HasOne("StreamKing.Data.Media.Season", "Season")
                        .WithMany()
                        .HasForeignKey("SeasonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StreamKing.Data.Media.SeriesEntry", null)
                        .WithMany("Seasons")
                        .HasForeignKey("SeriesEntryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Season");
                });

            modelBuilder.Entity("StreamKing.Data.Media.SeriesEntry", b =>
                {
                    b.HasOne("StreamKing.Data.Media.Series", "Series")
                        .WithMany()
                        .HasForeignKey("SeriesTmdbId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StreamKing.Data.Media.Watchlist", null)
                        .WithMany("SeriesList")
                        .HasForeignKey("WatchlistId");

                    b.Navigation("Series");
                });

            modelBuilder.Entity("StreamKing.Data.Accounts.Account", b =>
                {
                    b.Navigation("Logs");

                    b.Navigation("Watchlists");
                });

            modelBuilder.Entity("StreamKing.Data.Media.Media", b =>
                {
                    b.Navigation("Genres");

                    b.Navigation("StreamingInfos");
                });

            modelBuilder.Entity("StreamKing.Data.Media.Season", b =>
                {
                    b.Navigation("Episodes");
                });

            modelBuilder.Entity("StreamKing.Data.Media.Watchlist", b =>
                {
                    b.Navigation("MovieList");

                    b.Navigation("SeriesList");
                });

            modelBuilder.Entity("StreamKing.Data.Media.SeasonEntry", b =>
                {
                    b.Navigation("Episodes");
                });

            modelBuilder.Entity("StreamKing.Data.Media.Series", b =>
                {
                    b.Navigation("Seasons");
                });

            modelBuilder.Entity("StreamKing.Data.Media.SeriesEntry", b =>
                {
                    b.Navigation("Seasons");
                });
#pragma warning restore 612, 618
        }
    }
}
