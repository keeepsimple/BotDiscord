using BotUnunin.Models;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace BotUnunin.Data
{
    public class UnuninContext : DbContext
    {
        public UnuninContext(DbContextOptions opt) : base(opt)
        {

        }

        public DbSet<Love> Loves { get; set; }

        public DbSet<ImageOfUs> ImageOfUss { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var image1 = new ImageOfUs
            {
                Id = 1,
                Description = "Có người định trốn cơ đấy :)))))",
                Url = "1.jpeg",
                LoveId = 1
            };
            var image2 = new ImageOfUs
            {
                Id = 2,
                Description = "Tỏ tình lại còn bày đặt suy nghĩiiii :3",
                Url = "2.png",
                LoveId = 2
            };
            var image3 = new ImageOfUs
            {
                Id = 3,
                Description = "Anh thi mà khum giúp chỉ chụp ảnh",
                Url = "3.png",
                LoveId = 3
            };
            var image4 = new ImageOfUs
            {
                Id = 4,
                Description = "",
                Url = "4.png",
                LoveId = 3
            };
            var image5 = new ImageOfUs
            {
                Id = 5,
                Description = "Đi làm với đi học nà",
                Url = "51.jpg",
                LoveId = 3
            };
            var image6 = new ImageOfUs
            {
                Id = 6,
                Description = "Dù lạnh vẫn đưa áo cho bé mặc :3",
                Url = "97.jpeg",
                LoveId = 3
            };
            var image9 = new ImageOfUs
            {
                Id = 9,
                Description = "Đi về quê ăn tết có người khum muốn gặpp nà",
                Url = "82.jpeg",
                LoveId = 3
            };
            var image7 = new ImageOfUs
            {
                Id = 7,
                Description = "",
                Url = "78.jpg",
                LoveId = 3
            };
            var image8 = new ImageOfUs
            {
                Id = 8,
                Description = "",
                Url = "80.jpg",
                LoveId = 3
            };
            var image10 = new ImageOfUs
            {
                Id = 10,
                Description = "",
                Url = "81.jpg",
                LoveId = 3
            };
            var image11 = new ImageOfUs
            {
                Id = 11,
                Description = "",
                Url = "6.png",
                LoveId = 3
            };
            var image12 = new ImageOfUs
            {
                Id = 12,
                Description = "Gặp nhao sau tếtt",
                Url = "94.jpeg",
                LoveId = 3
            };
            var image13 = new ImageOfUs
            {
                Id = 13,
                Description = "",
                Url = "96.jpeg",
                LoveId = 3
            };
            var image14 = new ImageOfUs
            {
                Id = 14,
                Description = "Lần đầu về nhà anhh",
                Url = "10.png",
                LoveId = 3
            };
            var image15 = new ImageOfUs
            {
                Id = 15,
                Description = "",
                Url = "8.png",
                LoveId = 3
            };
            var image16 = new ImageOfUs
            {
                Id = 16,
                Description = "",
                Url = "7.png",
                LoveId = 3
            };
            var image17 = new ImageOfUs
            {
                Id = 17,
                Description = "",
                Url = "9.png",
                LoveId = 3
            };
            var image18 = new ImageOfUs
            {
                Id = 18,
                Description = "Lần đầu đi xem phimm nà",
                Url = "11.png",
                LoveId = 3
            };
            var image19 = new ImageOfUs
            {
                Id = 19,
                Description = "Valentine đầu tiênnn :3",
                Url = "12.png",
                LoveId = 3
            };
            var image20 = new ImageOfUs
            {
                Id = 20,
                Description = "Kỉ niệm tháng đầu tiênnnn",
                Url = "13.png",
                LoveId = 4
            };
            var image21 = new ImageOfUs
            {
                Id = 21,
                Description = "",
                Url = "14.png",
                LoveId = 4
            };
            var image22 = new ImageOfUs
            {
                Id = 22,
                Description = "",
                Url = "15.png",
                LoveId = 5
            };
            var image23 = new ImageOfUs
            {
                Id = 23,
                Description = "",
                Url = "16.png",
                LoveId = 5
            };
            var image24 = new ImageOfUs
            {
                Id = 24,
                Description = "",
                Url = "14.png",
                LoveId = 5
            };
            var image25 = new ImageOfUs
            {
                Id = 25,
                Description = "",
                Url = "83.jpg",
                LoveId = 3
            };
            var image26 = new ImageOfUs
            {
                Id = 26,
                Description = "",
                Url = "84.jpg",
                LoveId = 3
            };
            var image27 = new ImageOfUs
            {
                Id = 27,
                Description = "Đưa bé đi tiêmm",
                Url = "98.jpg",
                LoveId = 4
            };
            var image28 = new ImageOfUs
            {
                Id = 28,
                Description = "",
                Url = "99.jpg",
                LoveId = 4
            };
            var image29 = new ImageOfUs
            {
                Id = 29,
                Description = "Anh bị covidd :(",
                Url = "57.png",
                LoveId = 5
            };
            var image30 = new ImageOfUs
            {
                Id = 30,
                Description = "",
                Url = "53.jpg",
                LoveId = 6
            };
            var image31 = new ImageOfUs
            {
                Id = 31,
                Description = "",
                Url = "58.jpeg",
                LoveId = 6
            };
            var image32 = new ImageOfUs
            {
                Id = 32,
                Description = "Đi đạp xe đạppp",
                Url = "56.JPEG",
                LoveId = 6
            };
            var image33 = new ImageOfUs
            {
                Id = 33,
                Description = "",
                Url = "22.png",
                LoveId = 6
            };
            var image34 = new ImageOfUs
            {
                Id = 34,
                Description = "",
                Url = "23.png",
                LoveId = 6
            };
            var image35 = new ImageOfUs
            {
                Id = 35,
                Description = "",
                Url = "65.jpg",
                LoveId = 6
            };
            var image36 = new ImageOfUs
            {
                Id = 36,
                Description = "",
                Url = "66.jpg",
                LoveId = 6
            };
            var image37 = new ImageOfUs
            {
                Id = 37,
                Description = "",
                Url = "68.jpg",
                LoveId = 6
            };
            var image38 = new ImageOfUs
            {
                Id = 38,
                Description = "",
                Url = "69.jpeg",
                LoveId = 6
            };
            var image39 = new ImageOfUs
            {
                Id = 39,
                Description = "Đạp vịt nàaa",
                Url = "70.jpeg",
                LoveId = 6
            };
            var image40 = new ImageOfUs
            {
                Id = 40,
                Description = "",
                Url = "71.jpg",
                LoveId = 6
            };
            var image41 = new ImageOfUs
            {
                Id = 41,
                Description = "Đi Sóc Sơnnnnnnn",
                Url = "72.jpg",
                LoveId = 6
            };
            var image42 = new ImageOfUs
            {
                Id = 42,
                Description = "",
                Url = "73.jpg",
                LoveId = 6
            };
            var image43 = new ImageOfUs
            {
                Id = 43,
                Description = "",
                Url = "75.jpg",
                LoveId = 6
            };
            var image44 = new ImageOfUs
            {
                Id = 44,
                Description = "",
                Url = "79.jpg",
                LoveId = 6
            };
            var image45 = new ImageOfUs
            {
                Id = 45,
                Description = "Đi tô tượnggg",
                Url = "60.jpeg",
                LoveId = 7
            };
            var image46 = new ImageOfUs
            {
                Id = 46,
                Description = "Đi Thiên Đường Bảo Sơn nàaaa",
                Url = "86.jpeg",
                LoveId = 7
            };
            var image47 = new ImageOfUs
            {
                Id = 47,
                Description = "",
                Url = "87.jpeg",
                LoveId = 7
            };
            var image48 = new ImageOfUs
            {
                Id = 48,
                Description = "",
                Url = "88.jpeg",
                LoveId = 7
            };
            var image49 = new ImageOfUs
            {
                Id = 49,
                Description = "",
                Url = "89.jpeg",
                LoveId = 7
            };
            var image50 = new ImageOfUs
            {
                Id = 50,
                Description = "",
                Url = "90.jpg",
                LoveId = 7
            };
            var image51 = new ImageOfUs
            {
                Id = 51,
                Description = "",
                Url = "62.jpeg",
                LoveId = 7
            };
            var image52 = new ImageOfUs
            {
                Id = 52,
                Description = "Lần đầu đến trườngggg nà",
                Url = "31.png",
                LoveId = 8
            };
            var image53 = new ImageOfUs
            {
                Id = 53,
                Description = "Đi xem Vũ hátt",
                Url = "63.jpeg",
                LoveId = 8
            };
            var image54 = new ImageOfUs
            {
                Id = 54,
                Description = "",
                Url = "55.jpg",
                LoveId = 8
            };
            var image55 = new ImageOfUs
            {
                Id = 55,
                Description = "1/6 Bên bé nàaa",
                Url = "90.jpg",
                LoveId = 8
            };
            var image56 = new ImageOfUs
            {
                Id = 56,
                Description = "",
                Url = "34.jpg",
                LoveId = 6
            };
            var image57 = new ImageOfUs
            {
                Id = 57,
                Description = "Anh bảo mệt là bé đến bênnn",
                Url = "24.png",
                LoveId = 6
            };
            var image58 = new ImageOfUs
            {
                Id = 58,
                Description = "",
                Url = "30.png",
                LoveId = 7
            };
            var image59 = new ImageOfUs
            {
                Id = 59,
                Description = "",
                Url = "32.png",
                LoveId = 7
            };
            var image60 = new ImageOfUs
            {
                Id = 60,
                Description = "",
                Url = "29.png",
                LoveId = 7
            };
            var image61 = new ImageOfUs
            {
                Id = 61,
                Description = "",
                Url = "30.png",
                LoveId = 7
            };

            var image62 = new ImageOfUs
            {
                Id = 62,
                Description = "",
                Url = "33.png",
                LoveId = 8
            };

            var image63 = new ImageOfUs
            {
                Id = 63,
                Description = "Đi Hải Phònggggg",
                Url = "35.png",
                LoveId = 8
            };

            var image64 = new ImageOfUs
            {
                Id = 64,
                Description = "",
                Url = "36.png",
                LoveId = 8
            };
            var image65 = new ImageOfUs
            {
                Id = 65,
                Description = "",
                Url = "27.png",
                LoveId = 7
            };
            var image66 = new ImageOfUs
            {
                Id = 66,
                Description = "",
                Url = "64.jpeg",
                LoveId = 8
            };
            var image67 = new ImageOfUs
            {
                Id = 67,
                Description = "",
                Url = "67.jpg",
                LoveId = 8
            };
            var image68 = new ImageOfUs
            {
                Id = 68,
                Description = "",
                Url = "91.jpg",
                LoveId = 8
            };
            var image69 = new ImageOfUs
            {
                Id = 69,
                Description = "",
                Url = "37.png",
                LoveId = 8
            };
            var image70 = new ImageOfUs
            {
                Id = 70,
                Description = "",
                Url = "38.png",
                LoveId = 8
            };
            var image71 = new ImageOfUs
            {
                Id = 71,
                Description = "",
                Url = "39.png",
                LoveId = 9
            };
            var image72 = new ImageOfUs
            {
                Id = 72,
                Description = "",
                Url = "40.png",
                LoveId = 9
            };
            var image73 = new ImageOfUs
            {
                Id = 73,
                Description = "",
                Url = "40.png",
                LoveId = 9
            };
            var image74 = new ImageOfUs
            {
                Id = 74,
                Description = "",
                Url = "41.png",
                LoveId = 9
            };
            var image75 = new ImageOfUs
            {
                Id = 75,
                Description = "",
                Url = "42.png",
                LoveId = 9
            };
            var image76 = new ImageOfUs
            {
                Id = 76,
                Description = "Đi Hạ Long nàaaa",
                Url = "43.png",
                LoveId = 9
            };
            var image77 = new ImageOfUs
            {
                Id = 77,
                Description = "",
                Url = "44.png",
                LoveId = 9
            };
            var image78 = new ImageOfUs
            {
                Id = 78,
                Description = "",
                Url = "45.png",
                LoveId = 9
            };
            var image79 = new ImageOfUs
            {
                Id = 79,
                Description = "",
                Url = "92.jpeg",
                LoveId = 9
            };
            var image80 = new ImageOfUs
            {
                Id = 80,
                Description = "",
                Url = "74.jpeg",
                LoveId = 9
            };
            var image81 = new ImageOfUs
            {
                Id = 81,
                Description = "",
                Url = "76.jpg",
                LoveId = 9
            };
            var image82 = new ImageOfUs
            {
                Id = 82,
                Description = "",
                Url = "77.jpeg",
                LoveId = 9
            };
            var image83 = new ImageOfUs
            {
                Id = 83,
                Description = "",
                Url = "93.jpg",
                LoveId = 9
            };
            var image84 = new ImageOfUs
            {
                Id = 84,
                Description = "",
                Url = "100.jpg",
                LoveId = 10
            };
            var image85 = new ImageOfUs
            {
                Id = 85,
                Description = "",
                Url = "47.png",
                LoveId = 10
            };
            var image86 = new ImageOfUs
            {
                Id = 86,
                Description = "",
                Url = "48.png",
                LoveId = 10
            };
            var image87 = new ImageOfUs
            {
                Id = 87,
                Description = "",
                Url = "59.jpeg",
                LoveId = 10
            };
            var image88 = new ImageOfUs
            {
                Id = 88,
                Description = "",
                Url = "47.png",
                LoveId = 10
            };
            var image89 = new ImageOfUs
            {
                Id = 89,
                Description = "",
                Url = "49.png",
                LoveId = 10
            };
            var image90 = new ImageOfUs
            {
                Id = 90,
                Description = "",
                Url = "50.png",
                LoveId = 10
            };
            var image91 = new ImageOfUs
            {
                Id = 91,
                Description = "",
                Url = "61.png",
                LoveId = 10
            };
            var firstDate = new Love
            {
                Id = 1,
                Title = "Lần đầu gặp nàaaaaaa"
            };
            var loveStart = new Love
            {
                Id = 2,
                Title = "Lần thứ 2 nà tỏ tìnhh :3"
            };
            var oneMonth = new Love
            {
                Id = 3,
                Title = "Đi chơi tháng đầu tiênnn"
            };
            var firstAnni = new Love
            {
                Id = 4,
                Title = "Kỉ niệm tháng đầu tiênn"
            };
            var twoMonth = new Love
            {
                Id = 5,
                Title = "Đi chơi tháng thứ haiiii"
            };
            var threeMonth = new Love
            {
                Id = 6,
                Title = "Đi chơi tháng thứ baaa"
            };
            var fourMonth = new Love
            {
                Id = 7,
                Title = "Đi chơi tháng thứ tư"
            };
            var fiveMonth = new Love
            {
                Id = 8,
                Title = "Đi chơi tháng thứ nămmm"
            };
            var sixMonth = new Love
            {
                Id = 9,
                Title = "Đi chơi tháng thứ sáuuuuu"
            };
            var sevenToNow = new Love
            {
                Id = 10,
                Title = "Từ ngày xa bé đến giờ"
            };

            modelBuilder.Entity<Love>().HasData(
                firstDate, loveStart, oneMonth, firstAnni, twoMonth, threeMonth, fourMonth, fiveMonth, sixMonth, sevenToNow
                );
            modelBuilder.Entity<ImageOfUs>().HasData(image1, image2, image3, image4, image5, image6, image7,
                    image8, image9, image10, image11, image12, image13, image14, image15, image16, image17, image18, image19,
                    image25, image26, image20, image21, image27, image28, image22, image24, image29, image30, image31, image32, image33, image34, image35,
                    image36, image37, image38, image39, image40, image41, image42, image43, image44, image57, image56,
                    image45, image46, image47, image48, image49, image50, image51,
                    image58, image59, image60, image61, image65, image62, image63, image64, image66, image67, image68, image69, image70,
                    image71, image72, image73, image74,
                    image75, image76, image77, image78, image79, image80, image81, image82, image83, image23,
                    image84, image85, image86, image87, image88, image89, image90, image91, image52, image53, image54, image55);

            modelBuilder.Entity<ImageOfUs>(x =>
            {
                x.HasKey(e => e.Id);
                x.HasOne(l => l.Love).WithMany(p => p.ImageOfUss).HasForeignKey(f => f.LoveId);
            });
        }
    }
}