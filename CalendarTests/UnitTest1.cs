using Calendar;

namespace CalendarTests
{
    public class Tests
    {
        //dodaæ testy na wszystkie metody z CalendarLogic
        [Test]
        public void TestGetNumberOfStartingDayOfTheWeek_Jan23_returns0()
        {
            CalendarLogic.year = 2023;
            CalendarLogic.month = 1;
            var dayNumber = CalendarLogic.GetNumberOfStartingDayOfTheWeek();
            var expectedResult = 0;

            Assert.AreEqual(expectedResult, dayNumber);
        }
    }
}