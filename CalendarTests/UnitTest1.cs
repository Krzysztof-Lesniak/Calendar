using Calendar;
using Calendar.Database;
using Calendar.Models;

namespace CalendarTests
{
    public class Tests
    {
        //doda� testy na wszystkie metody z CalendarLogic
        [Test]
        public void TestGetNumberOfStartingDayOfTheWeek_Jan23_returns0()
        {
            CalendarLogic.year = 2023;
            CalendarLogic.month = 1;
            var dayNumber = CalendarLogic.GetNumberOfStartingDayOfTheWeek();
            var expectedResult = 0;

            Assert.AreEqual(expectedResult, dayNumber);
        }
        [Test]
        public void TestNextMonthChange_1_return2()
        {
            CalendarLogic.month = 1;
            CalendarLogic.NextMonthChange();
            var monthNuber = CalendarLogic.month;
            var expectedResult = 2;

            Assert.AreEqual(expectedResult, monthNuber);
        }
        [Test]
        public void TestNextMonthChange_12_return1()
        {
            CalendarLogic.month = 12;
            CalendarLogic.NextMonthChange();
            var monthNuber = CalendarLogic.month;
            var expectedResult = 1;

            Assert.AreEqual(expectedResult, monthNuber);
        }

        [Test]
        public void TestPrevMonthChange_1_return12()
        {
            CalendarLogic.month = 1;
            CalendarLogic.PrevMonthChange();
            var monthNuber = CalendarLogic.month;
            var expectedResult = 12;

            Assert.AreEqual(expectedResult, monthNuber);
        }
        [Test]
        public void TestPrevMonthChange_2_return1()
        {
            CalendarLogic.month = 2;
            CalendarLogic.PrevMonthChange();
            var monthNuber = CalendarLogic.month;
            var expectedResult = 1;

            Assert.AreEqual(expectedResult, monthNuber);
        }
        [Test]
        public void TestAddTask_numberOfTasks_OneMore()
        {
            var testCalendarDb = new TestCalendarDb();
            var numberOfTasksBefore = CalendarLogic.currentCalendar.TaskList.Count();
            CalendarLogic.AddTask("1", "", testCalendarDb);
            var numberOfTasksAfter = CalendarLogic.currentCalendar.TaskList.Count();

            Assert.IsTrue(numberOfTasksAfter == numberOfTasksBefore + 1);
        }

        private class TestCalendarDb : ICalendarDb
        {
            public void AddTask(CalendarTask calendarTask)
            {
            }
        }
    }
}