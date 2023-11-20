﻿// <auto-generated />
using Biblioteka.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Biblioteka.Migrations
{
    [DbContext(typeof(LibraryDbContext))]
    partial class LibraryDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Library.Domain.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 2,
                            Name = "J.R.R.",
                            Surname = "Tolkien"
                        },
                        new
                        {
                            Id = 2,
                            CountryId = 3,
                            Name = "Stephen",
                            Surname = "King"
                        },
                        new
                        {
                            Id = 3,
                            CountryId = 1,
                            Name = "Andrzej",
                            Surname = "Sapkowski"
                        },
                        new
                        {
                            Id = 4,
                            CountryId = 3,
                            Name = "George R.R.",
                            Surname = "Martin"
                        },
                        new
                        {
                            Id = 5,
                            CountryId = 2,
                            Name = "J.K.",
                            Surname = "Rowling"
                        },
                        new
                        {
                            Id = 6,
                            CountryId = 3,
                            Name = "H.P.",
                            Surname = "Lovecraft"
                        },
                        new
                        {
                            Id = 7,
                            CountryId = 2,
                            Name = "William",
                            Surname = "Shakespeare"
                        },
                        new
                        {
                            Id = 8,
                            CountryId = 2,
                            Name = "Jane",
                            Surname = "Austen"
                        },
                        new
                        {
                            Id = 9,
                            CountryId = 2,
                            Name = "Emily",
                            Surname = "Bronte"
                        },
                        new
                        {
                            Id = 10,
                            CountryId = 2,
                            Name = "Charlotte",
                            Surname = "Bronte"
                        },
                        new
                        {
                            Id = 11,
                            CountryId = 2,
                            Name = "Anne",
                            Surname = "Bronte"
                        },
                        new
                        {
                            Id = 12,
                            CountryId = 2,
                            Name = "Arthur Conan",
                            Surname = "Doyle"
                        },
                        new
                        {
                            Id = 13,
                            CountryId = 2,
                            Name = "Agatha",
                            Surname = "Christie"
                        },
                        new
                        {
                            Id = 14,
                            CountryId = 4,
                            Name = "Jules",
                            Surname = "Verne"
                        },
                        new
                        {
                            Id = 15,
                            CountryId = 3,
                            Name = "Herman",
                            Surname = "Melville"
                        },
                        new
                        {
                            Id = 16,
                            CountryId = 3,
                            Name = "Mark",
                            Surname = "Twain"
                        },
                        new
                        {
                            Id = 17,
                            CountryId = 2,
                            Name = "Charles",
                            Surname = "Dickens"
                        },
                        new
                        {
                            Id = 18,
                            CountryId = 5,
                            Name = "Fyodor",
                            Surname = "Dostoevsky"
                        });
                });

            modelBuilder.Entity("Library.Domain.AuthorBook", b =>
                {
                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.HasKey("AuthorId", "BookId");

                    b.HasIndex("BookId");

                    b.ToTable("AuthorBooks");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            BookId = 5
                        },
                        new
                        {
                            AuthorId = 2,
                            BookId = 6
                        },
                        new
                        {
                            AuthorId = 5,
                            BookId = 1
                        },
                        new
                        {
                            AuthorId = 6,
                            BookId = 2
                        },
                        new
                        {
                            AuthorId = 10,
                            BookId = 3
                        },
                        new
                        {
                            AuthorId = 4,
                            BookId = 4
                        });
                });

            modelBuilder.Entity("Library.Domain.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfPages")
                        .HasColumnType("int");

                    b.Property<int>("PublisherId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearOfPublishing")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.HasIndex("LanguageId");

                    b.HasIndex("PublisherId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A novel by F. Scott Fitzgerald",
                            GenreId = 2,
                            ISBN = "978-3-16-148410-0",
                            Image = "great_gatsby.jpg",
                            LanguageId = 1,
                            NumberOfPages = 180,
                            PublisherId = 3,
                            Title = "The Great Gatsby",
                            YearOfPublishing = 1925
                        },
                        new
                        {
                            Id = 2,
                            Description = "A novel by Harper Lee",
                            GenreId = 4,
                            ISBN = "978-3-16-148410-1",
                            Image = "to_kill_a_mockingbird.jpg",
                            LanguageId = 1,
                            NumberOfPages = 281,
                            PublisherId = 3,
                            Title = "To Kill a Mockingbird",
                            YearOfPublishing = 1960
                        },
                        new
                        {
                            Id = 3,
                            Description = "A dystopian novel by George Orwell",
                            GenreId = 2,
                            ISBN = "978-3-16-148410-2",
                            Image = "1984.jpg",
                            LanguageId = 1,
                            NumberOfPages = 328,
                            PublisherId = 3,
                            Title = "1984",
                            YearOfPublishing = 1949
                        },
                        new
                        {
                            Id = 4,
                            Description = "A novel by J.D. Salinger",
                            GenreId = 4,
                            ISBN = "978-3-16-148410-3",
                            Image = "catcher_in_the_rye.jpg",
                            LanguageId = 1,
                            NumberOfPages = 277,
                            PublisherId = 3,
                            Title = "The Catcher in the Rye",
                            YearOfPublishing = 1951
                        },
                        new
                        {
                            Id = 5,
                            Description = "A novel by J.R.R. Tolkien",
                            GenreId = 1,
                            ISBN = "978-3-16-148410-4",
                            Image = "the_hobbit.jpg",
                            LanguageId = 1,
                            NumberOfPages = 310,
                            PublisherId = 1,
                            Title = "The Hobbit",
                            YearOfPublishing = 1937
                        },
                        new
                        {
                            Id = 6,
                            Description = "A novel by J.R.R. Tolkien",
                            GenreId = 1,
                            ISBN = "978-3-16-148410-5",
                            Image = "the_lord_of_the_rings.jpg",
                            LanguageId = 1,
                            NumberOfPages = 1178,
                            PublisherId = 1,
                            Title = "The Lord of the Rings",
                            YearOfPublishing = 1954
                        });
                });

            modelBuilder.Entity("Library.Domain.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Poland"
                        },
                        new
                        {
                            Id = 2,
                            Name = "United Kingdom"
                        },
                        new
                        {
                            Id = 3,
                            Name = "United States"
                        },
                        new
                        {
                            Id = 4,
                            Name = "France"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Germany"
                        });
                });

            modelBuilder.Entity("Library.Domain.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "ul. Kowalska 1, 00-000 Warszawa",
                            Email = "kowlski@jan.pl",
                            Name = "Jan",
                            PhoneNumber = "123456789",
                            Surname = "Kowalski"
                        },
                        new
                        {
                            Id = 2,
                            Address = "ul. Nowaka 1, 00-000 Warszawa",
                            Email = "adam@nowak.pl",
                            Name = "Adam",
                            PhoneNumber = "987654321",
                            Surname = "Nowak"
                        },
                        new
                        {
                            Id = 3,
                            Address = "ul. Nowacki 1, 00-000 Warszawa",
                            Email = "kamil@nowacki.pl",
                            Name = "Kamil",
                            PhoneNumber = "123123123",
                            Surname = "Nowacki"
                        });
                });

            modelBuilder.Entity("Library.Domain.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Fantasy"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Science Fiction"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Romance"
                        });
                });

            modelBuilder.Entity("Library.Domain.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("LanguageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LanguageName = "English"
                        },
                        new
                        {
                            Id = 2,
                            LanguageName = "Polish"
                        },
                        new
                        {
                            Id = 3,
                            LanguageName = "German"
                        },
                        new
                        {
                            Id = 4,
                            LanguageName = "French"
                        });
                });

            modelBuilder.Entity("Library.Domain.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("YearOfCreation")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Publishers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 1,
                            Name = "PWN",
                            YearOfCreation = 0
                        },
                        new
                        {
                            Id = 2,
                            CountryId = 1,
                            Name = "Wydawnictwo Literackie",
                            YearOfCreation = 0
                        },
                        new
                        {
                            Id = 3,
                            CountryId = 2,
                            Name = "Penguin Books",
                            YearOfCreation = 0
                        });
                });

            modelBuilder.Entity("Library.Domain.Rental", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("RentalDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReturnDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Rentals");
                });

            modelBuilder.Entity("Library.Domain.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Library.Domain.Worker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Workers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "test@wp.pl",
                            Name = "Wojtek",
                            Role = "Admin",
                            Surname = "Szoda"
                        },
                        new
                        {
                            Id = 2,
                            Email = "kowalski@test.pl",
                            Name = "Jan",
                            Role = "Worker",
                            Surname = "Kowalski"
                        },
                        new
                        {
                            Id = 3,
                            Email = "adam@nowak.pl",
                            Name = "Adam",
                            Role = "Worker",
                            Surname = "Nowak"
                        });
                });

            modelBuilder.Entity("Library.Domain.Author", b =>
                {
                    b.HasOne("Library.Domain.Country", "Country")
                        .WithMany("Authors")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Library.Domain.AuthorBook", b =>
                {
                    b.HasOne("Library.Domain.Author", "Author")
                        .WithMany("AuthorBooks")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Library.Domain.Book", "Book")
                        .WithMany("BookAuthors")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("Library.Domain.Book", b =>
                {
                    b.HasOne("Library.Domain.Genre", "Genre")
                        .WithMany("Books")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library.Domain.Language", "Language")
                        .WithMany("Books")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library.Domain.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("Language");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("Library.Domain.Publisher", b =>
                {
                    b.HasOne("Library.Domain.Country", "Country")
                        .WithMany("Publishers")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Library.Domain.Rental", b =>
                {
                    b.HasOne("Library.Domain.Book", "Book")
                        .WithMany("Rentals")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library.Domain.Customer", "Customer")
                        .WithMany("Rentals")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Library.Domain.Review", b =>
                {
                    b.HasOne("Library.Domain.Book", "Book")
                        .WithMany("Reviews")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library.Domain.Customer", "Customer")
                        .WithMany("Reviews")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Library.Domain.Author", b =>
                {
                    b.Navigation("AuthorBooks");
                });

            modelBuilder.Entity("Library.Domain.Book", b =>
                {
                    b.Navigation("BookAuthors");

                    b.Navigation("Rentals");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("Library.Domain.Country", b =>
                {
                    b.Navigation("Authors");

                    b.Navigation("Publishers");
                });

            modelBuilder.Entity("Library.Domain.Customer", b =>
                {
                    b.Navigation("Rentals");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("Library.Domain.Genre", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Library.Domain.Language", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Library.Domain.Publisher", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
