using Calendar;
using Calendar.Database;

namespace CalendarTests
{
    public class Tests
    {
        //dodaæ testy na wszystkie metody z calendarLogic
        [Test]
        public void TestGetNumberOfStartingDayOfTheWeek_Jan23_returns0()
        {
            var calendarLogic = new CalendarLogic();
            calendarLogic.year = 2023;
            calendarLogic.month = 1;
            var dayNumber = calendarLogic.GetNumberOfStartingDayOfTheWeek();
            var expectedResult = 0;

            Assert.AreEqual(expectedResult, dayNumber);
        }
        [Test]
        public void TestNextMonthChange_1_return2() 
        {
            var calendarLogic = new CalendarLogic();

            calendarLogic.month = 1;
            calendarLogic.NextMonthChange();
            var monthNuber = calendarLogic.month;
            var expectedResult = 2;

            Assert.AreEqual(expectedResult, monthNuber);
        }
        [Test]
        public void TestNextMonthChange_12_return1()
        {
            var calendarLogic = new CalendarLogic();

            calendarLogic.month = 12;
            calendarLogic.NextMonthChange();
            var monthNuber = calendarLogic.month;
            var expectedResult = 1;

            Assert.AreEqual(expectedResult, monthNuber);
        }
        
        [Test]
        public void TestPrevMonthChange_1_return12()
        {
            var calendarLogic = new CalendarLogic();

            calendarLogic.month = 1;
            calendarLogic.PrevMonthChange();
            var monthNuber = calendarLogic.month;
            var expectedResult = 12;

            Assert.AreEqual(expectedResult, monthNuber);
        }
        [Test]
        public void TestPrevMonthChange_2_return1()
        {
            var calendarLogic = new CalendarLogic();

            calendarLogic.month = 2;
            calendarLogic.PrevMonthChange();
            var monthNuber = calendarLogic.month;
            var expectedResult = 1;

            Assert.AreEqual(expectedResult, monthNuber);
        }
        [Test]
        public void TestAddTask_numberOfTasks_OneMore()
        {
            var calendarLogic = new CalendarLogic();

            var numberOfTasksBefore = calendarLogic.currentCalendar.TaskList.Count();
            calendarLogic.AddTask("1", "");
            var numberOfTasksAfter = calendarLogic.currentCalendar.TaskList.Count();

            Assert.IsTrue(numberOfTasksAfter == numberOfTasksBefore + 1);
        }
    }
}