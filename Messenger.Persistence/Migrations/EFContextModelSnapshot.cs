﻿// <auto-generated />
using System;
using MessengerX.Persistence.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Messenger.Persistence.Migrations
{
    [DbContext(typeof(EFContext))]
    partial class EFContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AccountChannel", b =>
                {
                    b.Property<int>("AccountsId")
                        .HasColumnType("int");

                    b.Property<int>("ChannelsId")
                        .HasColumnType("int");

                    b.HasKey("AccountsId", "ChannelsId");

                    b.HasIndex("ChannelsId");

                    b.ToTable("AccountChannel");
                });

            modelBuilder.Entity("AccountMessage", b =>
                {
                    b.Property<int>("ReadAccountsId")
                        .HasColumnType("int");

                    b.Property<int>("ReadMessagesId")
                        .HasColumnType("int");

                    b.HasKey("ReadAccountsId", "ReadMessagesId");

                    b.HasIndex("ReadMessagesId");

                    b.ToTable("AccountMessage");
                });

            modelBuilder.Entity("MessengerX.Domain.Entities.Accounts.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ActivityStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastOnlineAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Role");

                    b.ToTable("Accounts");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Account");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("MessengerX.Domain.Entities.Channels.Channel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastActivity")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Channels");
                });

            modelBuilder.Entity("MessengerX.Domain.Entities.Messages.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("ChannelId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRead")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TargetMessageId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("ChannelId");

                    b.HasIndex("TargetMessageId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("MessengerX.Domain.Entities.RefreshTokens.RefreshToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpiryTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("RefreshTokens");
                });

            modelBuilder.Entity("MessengerX.Domain.Entities.Admins.Admin", b =>
                {
                    b.HasBaseType("MessengerX.Domain.Entities.Accounts.Account");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.ToTable("Accounts");

                    b.HasDiscriminator().HasValue("Admin");
                });

            modelBuilder.Entity("MessengerX.Domain.Entities.Users.User", b =>
                {
                    b.HasBaseType("MessengerX.Domain.Entities.Accounts.Account");

                    b.Property<DateOnly?>("Birthday")
                        .HasColumnType("date");

                    b.Property<bool>("IsBanned")
                        .HasColumnType("bit");

                    b.ToTable("Accounts");

                    b.HasDiscriminator().HasValue("User");
                });

            modelBuilder.Entity("AccountChannel", b =>
                {
                    b.HasOne("MessengerX.Domain.Entities.Accounts.Account", null)
                        .WithMany()
                        .HasForeignKey("AccountsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MessengerX.Domain.Entities.Channels.Channel", null)
                        .WithMany()
                        .HasForeignKey("ChannelsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AccountMessage", b =>
                {
                    b.HasOne("MessengerX.Domain.Entities.Accounts.Account", null)
                        .WithMany()
                        .HasForeignKey("ReadAccountsId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MessengerX.Domain.Entities.Messages.Message", null)
                        .WithMany()
                        .HasForeignKey("ReadMessagesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MessengerX.Domain.Entities.Messages.Message", b =>
                {
                    b.HasOne("MessengerX.Domain.Entities.Accounts.Account", "Author")
                        .WithMany("Messages")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MessengerX.Domain.Entities.Channels.Channel", "Channel")
                        .WithMany("Messages")
                        .HasForeignKey("ChannelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MessengerX.Domain.Entities.Messages.Message", "TargetMessage")
                        .WithMany("ChildMessages")
                        .HasForeignKey("TargetMessageId");

                    b.Navigation("Author");

                    b.Navigation("Channel");

                    b.Navigation("TargetMessage");
                });

            modelBuilder.Entity("MessengerX.Domain.Entities.RefreshTokens.RefreshToken", b =>
                {
                    b.HasOne("MessengerX.Domain.Entities.Accounts.Account", "Account")
                        .WithMany("RefreshTokens")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("MessengerX.Domain.Entities.Accounts.Account", b =>
                {
                    b.Navigation("Messages");

                    b.Navigation("RefreshTokens");
                });

            modelBuilder.Entity("MessengerX.Domain.Entities.Channels.Channel", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("MessengerX.Domain.Entities.Messages.Message", b =>
                {
                    b.Navigation("ChildMessages");
                });
#pragma warning restore 612, 618
        }
    }
}
