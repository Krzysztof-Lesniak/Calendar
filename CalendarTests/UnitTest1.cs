using Calendar;

namespace CalendarTests
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            CalendarLogic.year = 2023;
            CalendarLogic.month = 1;
            var dayNumber = CalendarLogic.GetNumberOfStartingDayOfTheWeek();
            var expectedResult = 0;

            Assert.AreEqual(expectedResult, dayNumber);
        }
    }
}