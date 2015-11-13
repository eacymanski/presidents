using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MatchThePresidents
{
    class President
    {
        public string Name { get;set; }
        public string Dates { get; set; }
        public int Number { get; set; }
        public string Vice { get; set; }
        public Image Pic { get; set; }
        public President(string name, string dates, int number, string file, string vice="")
        {
            Name = name;
            Dates = dates;
            Number = number;
            Pic= Image.FromFile(file);
            Vice=vice;
        }

        public static List<President> getPresidents()
        {
            List<President> presidents = new List<President>();
            presidents.Add(new President("George Washington", "1789-1797", 1, "pictures\\Washington.jpg", "John Adams"));
            presidents.Add(new President("John Adams", "1797-1801", 2, "pictures\\Adams.jpg", "Thomas Jefferson"));
            presidents.Add(new President("Thomas Jefferson", "1801-1809", 3, "pictures\\Jefferson.jpg"));
            presidents.Add(new President("James Madison", "1809-1817", 4, "pictures\\Madison.jpg"));
            presidents.Add(new President("James Monroe", "1817-1825", 5, "pictures\\Monroe.jpg", "Daniel D. Tompkins"));
            presidents.Add(new President("John Quincy Adams", "1825-1829", 6, "pictures\\QAdams.jpg", "John C. Calhoun"));
            presidents.Add(new President("Andrew Jackson", "1829-1837", 7, "pictures\\Jackson.jpg", "Martin Van Buren"));
            presidents.Add(new President("Martin Van Buren", "1837-1841", 8, "pictures\\VanBuren.jpg", "Richard Mentor Johnson"));
            presidents.Add(new President("William Henry Harrison", "1841-1841", 9, "pictures\\WHHarrison.jpg", "John Tyler"));
            presidents.Add(new President("John Tyler", "1841-1845", 10, "pictures\\Tyler.jpg"));
            presidents.Add(new President("James K. Polk", "1845-1849", 11, "pictures\\Polk.jpg", "George M. Dallas"));
            presidents.Add(new President("Zachary Taylor", "1849-1850", 12, "pictures\\Taylor.jpg", "Millard Fillmore"));
            presidents.Add(new President("Millard Fillmore", "1850-1853", 13, "pictures\\Fillmore.jpg"));
            presidents.Add(new President("Franklin Pierce", "1853-1857", 14, "pictures\\Pierce.jpg", "William R. King"));
            presidents.Add(new President("James Buchanan", "1857-1861", 15, "pictures\\Buchanan.jpg", "John C. Breckinridge"));
            presidents.Add(new President("Abraham Lincoln", "1861-1865", 16, "pictures\\Lincoln.jpg"));
            presidents.Add(new President("Andrew Johnson", "1865-1869", 17, "pictures\\AJohnson.jpg"));
            presidents.Add(new President("Ulysses S. Grant", "1869-1877", 18, "pictures\\Grant.jpg"));
            presidents.Add(new President("Rutherford B. Hayes", "1877-1881", 19, "pictures\\Hayes.jpg", "William A. Wheeler"));
            presidents.Add(new President("James A. Garfield", "1881-1881", 20, "pictures\\Garfield.jpg", "Chester A. Arthur"));
            presidents.Add(new President("Chester Arthur", "1881-1885", 21, "pictures\\Arthur.jpg"));
            presidents.Add(new President("Grover Cleveland", "1885-1889", 22, "pictures\\Cleveland.jpg", "Thomas A. Hendricks"));
            presidents.Add(new President("Benjamin Harrison", "1889-1893", 23, "pictures\\BHarrison.jpg", "Levi P. Morton"));
            presidents.Add(new President("Grover Cleveland", "1893-1897", 24, "pictures\\Cleveland.jpg", "Adlai Stevenson"));
            presidents.Add(new President("William McKinley", "1897-1901", 25, "pictures\\McKinley.jpg", "Theodore Roosevelt"));
            presidents.Add(new President("Theodore Roosevelt", "1901-1909", 26, "pictures\\TRoosevelt.jpg", "Charles W. Fairbanks"));
            presidents.Add(new President("William Howard Taft", "1909-1913", 27, "pictures\\Taft.jpg", "James S. Sherman"));
            presidents.Add(new President("Woodrow Wilson", "1913-1921", 28, "pictures\\Wilson.jpg", "Thomas R. Marshall"));
            presidents.Add(new President("Warren G. Harding", "1921-1923", 29, "pictures\\Harding.jpg", "Calvin Coolidge"));
            presidents.Add(new President("Calvin Coolidge", "1923-1929", 30, "pictures\\Coolidge.jpg", "Charles G. Dawes"));
            presidents.Add(new President("Herbert Hoover", "1929-1933", 31, "pictures\\Hoover.jpg", "Charles Curtis"));
            presidents.Add(new President("Franklin D. Roosevelt", "1933-1945", 32, "pictures\\FRoosevelt.jpg"));
            presidents.Add(new President("Harry S. Truman", "1945-1953", 33, "pictures\\Truman.jpg", "Alben W. Barkley"));
            presidents.Add(new President("Dwight D. Eisenhower", "1953-1961", 34, "pictures\\Eisenhower.jpg", "Richard Nixon"));
            presidents.Add(new President("John F. Kennedy", "1961-1963", 35, "pictures\\Kennedy.jpg", "Lyndon B. Johnson"));
            presidents.Add(new President("Lyndon B. Johnson", "1963-1969", 36, "pictures\\LJohnson.jpg"));
            presidents.Add(new President("Richard Nixon", "1969-1974", 37, "pictures\\Nixon.jpg"));
            presidents.Add(new President("Gerald Ford", "1974-1977", 38, "pictures\\Ford.jpg"));
            presidents.Add(new President("Jimmy Carter", "1977-1981", 39, "pictures\\Carter.jpg"));
            presidents.Add(new President("Ronald Reagan", "1981-1989", 40, "pictures\\Reagan.jpg"));
            presidents.Add(new President("George H. W. Bush", "1989-1993", 41, "pictures\\HWBush.jpg"));
            presidents.Add(new President("Bill Clinton", "1993-2001", 42, "pictures\\Clinton.jpg"));
            presidents.Add(new President("George W. Bush", "2001-2009", 43, "pictures\\WBush.jpg"));
            presidents.Add(new President("Barack Obama", "2009-2017", 44, "pictures\\Obama.jpg"));

            return presidents;
        }    
    }

    
}
