// <auto-generated />
using BotUnunin.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BotUnunin.Data.Migrations
{
    [DbContext(typeof(UnuninContext))]
    [Migration("20220909133814_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BotUnunin.Models.ImageOfUs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LoveId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LoveId");

                    b.ToTable("ImageOfUss");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Có người định trốn cơ đấy :)))))",
                            LoveId = 1,
                            Url = "1.jpeg"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Tỏ tình lại còn bày đặt suy nghĩiiii :3",
                            LoveId = 2,
                            Url = "2.png"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Anh thi mà khum giúp chỉ chụp ảnh",
                            LoveId = 3,
                            Url = "3.png"
                        },
                        new
                        {
                            Id = 4,
                            Description = "",
                            LoveId = 3,
                            Url = "4.png"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Đi làm với đi học nà",
                            LoveId = 3,
                            Url = "51.jpg"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Dù lạnh vẫn đưa áo cho bé mặc :3",
                            LoveId = 3,
                            Url = "97.jpeg"
                        },
                        new
                        {
                            Id = 7,
                            Description = "",
                            LoveId = 3,
                            Url = "78.jpg"
                        },
                        new
                        {
                            Id = 8,
                            Description = "",
                            LoveId = 3,
                            Url = "80.jpg"
                        },
                        new
                        {
                            Id = 9,
                            Description = "Đi về quê ăn tết có người khum muốn gặpp nà",
                            LoveId = 3,
                            Url = "82.jpeg"
                        },
                        new
                        {
                            Id = 10,
                            Description = "",
                            LoveId = 3,
                            Url = "81.jpg"
                        },
                        new
                        {
                            Id = 11,
                            Description = "",
                            LoveId = 3,
                            Url = "6.png"
                        },
                        new
                        {
                            Id = 12,
                            Description = "Gặp nhao sau tếtt",
                            LoveId = 3,
                            Url = "94.jpeg"
                        },
                        new
                        {
                            Id = 13,
                            Description = "",
                            LoveId = 3,
                            Url = "96.jpeg"
                        },
                        new
                        {
                            Id = 14,
                            Description = "Lần đầu về nhà anhh",
                            LoveId = 3,
                            Url = "10.png"
                        },
                        new
                        {
                            Id = 15,
                            Description = "",
                            LoveId = 3,
                            Url = "8.png"
                        },
                        new
                        {
                            Id = 16,
                            Description = "",
                            LoveId = 3,
                            Url = "7.png"
                        },
                        new
                        {
                            Id = 17,
                            Description = "",
                            LoveId = 3,
                            Url = "9.png"
                        },
                        new
                        {
                            Id = 18,
                            Description = "Lần đầu đi xem phimm nà",
                            LoveId = 3,
                            Url = "11.png"
                        },
                        new
                        {
                            Id = 19,
                            Description = "Valentine đầu tiênnn :3",
                            LoveId = 3,
                            Url = "12.png"
                        },
                        new
                        {
                            Id = 25,
                            Description = "",
                            LoveId = 3,
                            Url = "83.jpg"
                        },
                        new
                        {
                            Id = 26,
                            Description = "",
                            LoveId = 3,
                            Url = "84.jpg"
                        },
                        new
                        {
                            Id = 20,
                            Description = "Kỉ niệm tháng đầu tiênnnn",
                            LoveId = 4,
                            Url = "13.png"
                        },
                        new
                        {
                            Id = 21,
                            Description = "",
                            LoveId = 4,
                            Url = "14.png"
                        },
                        new
                        {
                            Id = 27,
                            Description = "Đưa bé đi tiêmm",
                            LoveId = 4,
                            Url = "98.jpg"
                        },
                        new
                        {
                            Id = 28,
                            Description = "",
                            LoveId = 4,
                            Url = "99.jpg"
                        },
                        new
                        {
                            Id = 22,
                            Description = "",
                            LoveId = 5,
                            Url = "15.png"
                        },
                        new
                        {
                            Id = 24,
                            Description = "",
                            LoveId = 5,
                            Url = "14.png"
                        },
                        new
                        {
                            Id = 29,
                            Description = "Anh bị covidd :(",
                            LoveId = 5,
                            Url = "57.png"
                        },
                        new
                        {
                            Id = 30,
                            Description = "",
                            LoveId = 6,
                            Url = "53.jpg"
                        },
                        new
                        {
                            Id = 31,
                            Description = "",
                            LoveId = 6,
                            Url = "58.jpeg"
                        },
                        new
                        {
                            Id = 32,
                            Description = "Đi đạp xe đạppp",
                            LoveId = 6,
                            Url = "56.JPEG"
                        },
                        new
                        {
                            Id = 33,
                            Description = "",
                            LoveId = 6,
                            Url = "22.png"
                        },
                        new
                        {
                            Id = 34,
                            Description = "",
                            LoveId = 6,
                            Url = "23.png"
                        },
                        new
                        {
                            Id = 35,
                            Description = "",
                            LoveId = 6,
                            Url = "65.jpg"
                        },
                        new
                        {
                            Id = 36,
                            Description = "",
                            LoveId = 6,
                            Url = "66.jpg"
                        },
                        new
                        {
                            Id = 37,
                            Description = "",
                            LoveId = 6,
                            Url = "68.jpg"
                        },
                        new
                        {
                            Id = 38,
                            Description = "",
                            LoveId = 6,
                            Url = "69.jpeg"
                        },
                        new
                        {
                            Id = 39,
                            Description = "Đạp vịt nàaa",
                            LoveId = 6,
                            Url = "70.jpeg"
                        },
                        new
                        {
                            Id = 40,
                            Description = "",
                            LoveId = 6,
                            Url = "71.jpg"
                        },
                        new
                        {
                            Id = 41,
                            Description = "Đi Sóc Sơnnnnnnn",
                            LoveId = 6,
                            Url = "72.jpg"
                        },
                        new
                        {
                            Id = 42,
                            Description = "",
                            LoveId = 6,
                            Url = "73.jpg"
                        },
                        new
                        {
                            Id = 43,
                            Description = "",
                            LoveId = 6,
                            Url = "75.jpg"
                        },
                        new
                        {
                            Id = 44,
                            Description = "",
                            LoveId = 6,
                            Url = "79.jpg"
                        },
                        new
                        {
                            Id = 57,
                            Description = "Anh bảo mệt là bé đến bênnn",
                            LoveId = 6,
                            Url = "24.png"
                        },
                        new
                        {
                            Id = 56,
                            Description = "",
                            LoveId = 6,
                            Url = "34.jpg"
                        },
                        new
                        {
                            Id = 45,
                            Description = "Đi tô tượnggg",
                            LoveId = 7,
                            Url = "60.jpeg"
                        },
                        new
                        {
                            Id = 46,
                            Description = "Đi Thiên Đường Bảo Sơn nàaaa",
                            LoveId = 7,
                            Url = "86.jpeg"
                        },
                        new
                        {
                            Id = 47,
                            Description = "",
                            LoveId = 7,
                            Url = "87.jpeg"
                        },
                        new
                        {
                            Id = 48,
                            Description = "",
                            LoveId = 7,
                            Url = "88.jpeg"
                        },
                        new
                        {
                            Id = 49,
                            Description = "",
                            LoveId = 7,
                            Url = "89.jpeg"
                        },
                        new
                        {
                            Id = 50,
                            Description = "",
                            LoveId = 7,
                            Url = "90.jpg"
                        },
                        new
                        {
                            Id = 51,
                            Description = "",
                            LoveId = 7,
                            Url = "62.jpeg"
                        },
                        new
                        {
                            Id = 58,
                            Description = "",
                            LoveId = 7,
                            Url = "30.png"
                        },
                        new
                        {
                            Id = 59,
                            Description = "",
                            LoveId = 7,
                            Url = "32.png"
                        },
                        new
                        {
                            Id = 60,
                            Description = "",
                            LoveId = 7,
                            Url = "29.png"
                        },
                        new
                        {
                            Id = 61,
                            Description = "",
                            LoveId = 7,
                            Url = "30.png"
                        },
                        new
                        {
                            Id = 65,
                            Description = "",
                            LoveId = 7,
                            Url = "27.png"
                        },
                        new
                        {
                            Id = 62,
                            Description = "",
                            LoveId = 8,
                            Url = "33.png"
                        },
                        new
                        {
                            Id = 63,
                            Description = "Đi Hải Phònggggg",
                            LoveId = 8,
                            Url = "35.png"
                        },
                        new
                        {
                            Id = 64,
                            Description = "",
                            LoveId = 8,
                            Url = "36.png"
                        },
                        new
                        {
                            Id = 66,
                            Description = "",
                            LoveId = 8,
                            Url = "64.jpeg"
                        },
                        new
                        {
                            Id = 67,
                            Description = "",
                            LoveId = 8,
                            Url = "67.jpg"
                        },
                        new
                        {
                            Id = 68,
                            Description = "",
                            LoveId = 8,
                            Url = "91.jpg"
                        },
                        new
                        {
                            Id = 69,
                            Description = "",
                            LoveId = 8,
                            Url = "37.png"
                        },
                        new
                        {
                            Id = 70,
                            Description = "",
                            LoveId = 8,
                            Url = "38.png"
                        },
                        new
                        {
                            Id = 71,
                            Description = "",
                            LoveId = 9,
                            Url = "39.png"
                        },
                        new
                        {
                            Id = 72,
                            Description = "",
                            LoveId = 9,
                            Url = "40.png"
                        },
                        new
                        {
                            Id = 73,
                            Description = "",
                            LoveId = 9,
                            Url = "40.png"
                        },
                        new
                        {
                            Id = 74,
                            Description = "",
                            LoveId = 9,
                            Url = "41.png"
                        },
                        new
                        {
                            Id = 75,
                            Description = "",
                            LoveId = 9,
                            Url = "42.png"
                        },
                        new
                        {
                            Id = 76,
                            Description = "Đi Hạ Long nàaaa",
                            LoveId = 9,
                            Url = "43.png"
                        },
                        new
                        {
                            Id = 77,
                            Description = "",
                            LoveId = 9,
                            Url = "44.png"
                        },
                        new
                        {
                            Id = 78,
                            Description = "",
                            LoveId = 9,
                            Url = "45.png"
                        },
                        new
                        {
                            Id = 79,
                            Description = "",
                            LoveId = 9,
                            Url = "92.jpeg"
                        },
                        new
                        {
                            Id = 80,
                            Description = "",
                            LoveId = 9,
                            Url = "74.jpeg"
                        },
                        new
                        {
                            Id = 81,
                            Description = "",
                            LoveId = 9,
                            Url = "76.jpg"
                        },
                        new
                        {
                            Id = 82,
                            Description = "",
                            LoveId = 9,
                            Url = "77.jpeg"
                        },
                        new
                        {
                            Id = 83,
                            Description = "",
                            LoveId = 9,
                            Url = "93.jpg"
                        },
                        new
                        {
                            Id = 23,
                            Description = "",
                            LoveId = 5,
                            Url = "16.png"
                        },
                        new
                        {
                            Id = 84,
                            Description = "",
                            LoveId = 10,
                            Url = "100.jpg"
                        },
                        new
                        {
                            Id = 85,
                            Description = "",
                            LoveId = 10,
                            Url = "47.png"
                        },
                        new
                        {
                            Id = 86,
                            Description = "",
                            LoveId = 10,
                            Url = "48.png"
                        },
                        new
                        {
                            Id = 87,
                            Description = "",
                            LoveId = 10,
                            Url = "59.jpeg"
                        },
                        new
                        {
                            Id = 88,
                            Description = "",
                            LoveId = 10,
                            Url = "47.png"
                        },
                        new
                        {
                            Id = 89,
                            Description = "",
                            LoveId = 10,
                            Url = "49.png"
                        },
                        new
                        {
                            Id = 90,
                            Description = "",
                            LoveId = 10,
                            Url = "50.png"
                        },
                        new
                        {
                            Id = 91,
                            Description = "",
                            LoveId = 10,
                            Url = "61.png"
                        },
                        new
                        {
                            Id = 52,
                            Description = "Lần đầu đến trườngggg nà",
                            LoveId = 8,
                            Url = "31.png"
                        },
                        new
                        {
                            Id = 53,
                            Description = "Đi xem Vũ hátt",
                            LoveId = 8,
                            Url = "63.jpeg"
                        },
                        new
                        {
                            Id = 54,
                            Description = "",
                            LoveId = 8,
                            Url = "55.jpg"
                        },
                        new
                        {
                            Id = 55,
                            Description = "1/6 Bên bé nàaa",
                            LoveId = 8,
                            Url = "90.jpg"
                        });
                });

            modelBuilder.Entity("BotUnunin.Models.Love", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Loves");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Title = "Lần đầu gặp nàaaaaaa"
                        },
                        new
                        {
                            Id = 2,
                            Title = "Lần thứ 2 nà tỏ tìnhh :3"
                        },
                        new
                        {
                            Id = 3,
                            Title = "Đi chơi tháng đầu tiênnn"
                        },
                        new
                        {
                            Id = 4,
                            Title = "Kỉ niệm tháng đầu tiênn"
                        },
                        new
                        {
                            Id = 5,
                            Title = "Đi chơi tháng thứ haiiii"
                        },
                        new
                        {
                            Id = 6,
                            Title = "Đi chơi tháng thứ baaa"
                        },
                        new
                        {
                            Id = 7,
                            Title = "Đi chơi tháng thứ tư"
                        },
                        new
                        {
                            Id = 8,
                            Title = "Đi chơi tháng thứ nămmm"
                        },
                        new
                        {
                            Id = 9,
                            Title = "Đi chơi tháng thứ sáuuuuu"
                        },
                        new
                        {
                            Id = 10,
                            Title = "Từ ngày xa bé đến giờ"
                        });
                });

            modelBuilder.Entity("BotUnunin.Models.ImageOfUs", b =>
                {
                    b.HasOne("BotUnunin.Models.Love", "Love")
                        .WithMany("ImageOfUss")
                        .HasForeignKey("LoveId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Love");
                });

            modelBuilder.Entity("BotUnunin.Models.Love", b =>
                {
                    b.Navigation("ImageOfUss");
                });
#pragma warning restore 612, 618
        }
    }
}
