using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xunit;

namespace DevelopStuff.Extensions.Tests
{
    public class ExtenwsionsTestFixture
    {
        [Fact]
        public void TestDaysAgo()
        {
            Assert.Equal<DateTime>(DateTime.Now.AddDays(-2).Date, 2.DaysAgo().Date);
        }

        [Fact]
        public void TestToSentence()
        {
            string[] things = new string[3] {"a","b","c"};

            Assert.Equal<string>("a, b, and c", things.ToSentence());

            int[] ints = new int[3] { 1, 2, 3 };

            Assert.Equal<string>("1, 2, and 3", ints.ToSentence());

            things = new string[0];
            Assert.Equal<string>("", things.ToSentence());

            things = new string[3];
            Assert.Equal<string>("", things.ToSentence());

            things = null;
            Assert.Throws<ArgumentNullException>(delegate { things.ToSentence(); });
        }

        [Fact]
        public void TestStringSubstrings()
        {
            string longString = "This is a long enough string to test.";
            string shortString = "abc";
            string emptyString = string.Empty;
            string nullString = null;

            // First
            Assert.Equal<string>("This",longString.First(4));
            Assert.Equal<string>("abc",shortString.First(4));
            Assert.Equal<string>("",emptyString.First(1));
            Assert.Throws<ArgumentNullException>(delegate { nullString.First(1); } );

            // Last
            Assert.Equal<string>("est.", longString.Last(4));
            Assert.Equal<string>("abc", shortString.Last(4));
            Assert.Equal<string>("", emptyString.Last(1));
            Assert.Throws<ArgumentNullException>(delegate { nullString.Last(1); } );

            // From
            Assert.Equal<string>(" is a long enough string to test.", longString.From(4));
            Assert.Equal<string>("",shortString.From(4));
            Assert.Equal<string>("",emptyString.From(1));
            Assert.Throws<ArgumentNullException>(delegate { nullString.From(1); } );
        }

        [Fact]
        public void TestToDateTime()
        {
            string nullString = null;
            Assert.Throws<ArgumentNullException>(delegate { nullString.ToInt(); });

            Assert.Equal<DateTime>(1.DaysAgo().Date, DateTime.Now.AddDays(-1).Date.ToString().ToDateTime());
            Assert.Equal<DateTime>(new DateTime(1981, 2, 18), "2/18/1981".ToDateTime());
            Assert.Equal<DateTime>(new DateTime(1981, 2, 18), "2/18/1981 00:00:00".ToDateTime());
            Assert.Equal<DateTime>(new DateTime(1981, 2, 18), "February 18, 1981".ToDateTime());

            Assert.Equal<DateTime>(DateTime.MinValue,"".ToDateTime());
            Assert.Equal<DateTime>(DateTime.MinValue, "The cow jumped over the moon.".ToDateTime());
        }

        [Fact]
        public void TestToInt()
        {
            string nullString = null;
            Assert.Throws<ArgumentNullException>(delegate { nullString.ToInt(); });
            Assert.Equal<int>(0, "".ToInt());
            Assert.Equal<int>(0, "0".ToInt());
            Assert.Equal<int>(5, "5".ToInt());
            Assert.Equal<int>(0, "The cow jumped over the moon.".ToInt());
        }

        [Fact]
        public void TestToDecimal()
        {
            string nullString = null;
            Assert.Throws<ArgumentNullException>(delegate { nullString.ToDecimal(); });
            Assert.Equal<decimal>(0, "".ToDecimal());
            Assert.Equal<decimal>(0, "0".ToDecimal());
            Assert.Equal<decimal>(5.5M, "5.5".ToDecimal());
            Assert.Equal<decimal>(0, "The cow jumped over the moon.".ToDecimal());
        }

        [Fact]
        public void TestIsNull()
        {
            object o = null;
            object p = new object();

            Assert.True(o.IsNull());
            Assert.False(p.IsNull());

            Assert.False(o.IsNotNull());
            Assert.True(p.IsNotNull());
        }

        [Fact]
        public void TestWithin()
        {
            Assert.True(0.Within(-1, 1));
            Assert.True(0.Within(-1, 1, true));
            Assert.True(0.Within(-1, 1, false));
            Assert.True(0.Within(0, 0, true));
            Assert.False(0.Within(0,0, false));
            Assert.False(0.Within(1, 2, false));
            Assert.False(0.Within(1, 2, false));
            Assert.Throws<ArgumentException>(delegate { Assert.False(0.Within(10, 0, false)); });

            decimal fifteen = 15.5M;
            Assert.True(fifteen.Within(15, 16));
            Assert.True(fifteen.Within(15, 16, true));
            Assert.True(fifteen.Within(15, 16, false));
            Assert.False(fifteen.Within(15, 15, true));
            Assert.False(fifteen.Within(15, 15, false));
            Assert.False(fifteen.Within(16, 17));
            Assert.False(fifteen.Within(16, 17, false));

            Assert.True(fifteen.Within(15.5M, 16M));
            Assert.True(fifteen.Within(15.5M, 15.5M));
            Assert.True(fifteen.Within(15.5M, 15.5M, true));
            Assert.False(fifteen.Within(15.5M, 15.5M, false));
            Assert.False(fifteen.Within(16.5M, 17.5M));
            Assert.False(fifteen.Within(16.5M, 17.5M, false));
        }

        [Fact]
        public void TestHumanReadableString()
        {
            DateTime future = DateTime.Now.AddDays(2);
            DateTime justNow = DateTime.Now;
            DateTime secondsAgo = 30.SecondsAgo();
            DateTime minuteAgo = 1.MinutesAgo();
            DateTime minutesAgo = 3.MinutesAgo();
            DateTime dayAgo = 1.DaysAgo();
            DateTime daysAgo = 10.DaysAgo();
            DateTime monthAgo = 1.MonthsAgo();
            DateTime monthsAgo = 10.MonthsAgo();
            DateTime yearAgo = 1.YearsAgo();
            DateTime yearsAgo = 2.YearsAgo();

            Assert.Equal("in the future", future.ToHumanReadableString());
            Assert.Equal("just now", justNow.ToHumanReadableString());
            Assert.Equal("30 seconds ago", secondsAgo.ToHumanReadableString());
            Assert.Equal("1 minute ago", minuteAgo.ToHumanReadableString());
            Assert.Equal("3 minutes ago", minutesAgo.ToHumanReadableString());
            Assert.Equal("1 day ago", dayAgo.ToHumanReadableString());
            Assert.Equal("10 days ago", daysAgo.ToHumanReadableString());
            Assert.Equal("1 month ago", monthAgo.ToHumanReadableString());
            Assert.Equal("10 months ago", monthsAgo.ToHumanReadableString());
            Assert.Equal("1 year ago", yearAgo.ToHumanReadableString());
            Assert.Equal("2 years ago", yearsAgo.ToHumanReadableString());
        }

    }
}
 