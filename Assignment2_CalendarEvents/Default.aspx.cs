using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string[,] todo = new string[24, 4];

    protected void Page_Load(object sender, EventArgs e)
    {
        todo[0, 0] = "1/23/2017";
        todo[0, 2] = "Math 141 PreCalc";
        todo[0, 1] = "8:00 am - 8:50 am";
        todo[0, 3] = "RM 4183";
        todo[1, 0] = "1/23/2017";
        todo[1, 2] = "ICT 172 .Net Programming";
        todo[1, 1] = "10:00 am - 12:15 pm";
        todo[1, 3] = "RM 7931";
        todo[2, 0] = "1/23/2017";
        todo[2, 2] = "ABC Legal";
        todo[2, 1] = "12:45 pm - 5:00 pm";
        todo[2, 3] = "";
        todo[3, 0] = "1/24/2017";
        todo[3, 2] = "Math 141 PreCalc";
        todo[3, 1] = "8:00 am - 8:50 am";
        todo[3, 3] = "RM 4183";
        todo[4, 0] = "1/24/2017";
        todo[4, 2] = "ICT 222 SQL";
        todo[4, 1] = "10:00 am - 12:15 pm";
        todo[4, 3] = "RM 7931";
        todo[5, 0] = "1/24/2017";
        todo[5, 2] = "ABC Legal";
        todo[5, 1] = "12:45 pm - 5:00 pm";
        todo[5, 3] = "";
        todo[6, 0] = "1/25/2017";
        todo[6, 2] = "Math 141 PreCalc";
        todo[6, 1] = "8:00 am - 8:50 am";
        todo[6, 3] = "RM 4183";
        todo[7, 0] = "1/25/2017";
        todo[7, 2] = "ICT 172 .Net Programming";
        todo[7, 1] = "10:00 am - 12:15 pm";
        todo[7, 3] = "RM 7931";
        todo[8, 0] = "1/26/2017";
        todo[8, 2] = "Math 141 PreCalc";
        todo[8, 1] = "8:00 am - 8:50 am";
        todo[8, 3] = "RM 4183";
        todo[9, 0] = "1/26/2017";
        todo[9, 2] = "ICT 222 SQL";
        todo[9, 1] = "10:00 am - 12:15 pm";
        todo[9, 3] = "RM 7931";
        todo[10, 0] = "1/27/2017";
        todo[10, 2] = "Math 141 PreCalc";
        todo[10, 1] = "8:00 am - 8:50 am";
        todo[10, 3] = "RM 4183";
        todo[11, 0] = "1/27/2017";
        todo[11, 2] = "ABC Legal";
        todo[11, 1] = "12:45 pm - 5:00 pm";
        todo[11, 3] = "";
        todo[12, 0] = "1/30/2017";
        todo[12, 2] = "Math 141 PreCalc";
        todo[12, 1] = "8:00 am - 8:50 am";
        todo[12, 3] = "RM 4183";
        todo[13, 0] = "1/30/2017";
        todo[13, 2] = "ICT 172 .Net Programming";
        todo[13, 1] = "10:00 am - 12:15 pm";
        todo[13, 3] = "RM 7931";
        todo[14, 0] = "1/30/2017";
        todo[14, 2] = "ABC Legal";
        todo[14, 1] = "12:45 pm - 5:00 pm";
        todo[14, 3] = "";
        todo[15, 0] = "1/31/2017";
        todo[15, 2] = "Math 141 PreCalc";
        todo[15, 1] = "8:00 am - 8:50 am";
        todo[15, 3] = "RM 4183";
        todo[16, 0] = "1/31/2017";
        todo[16, 2] = "ICT 222 SQL";
        todo[16, 1] = "10:00 am - 12:15 pm";
        todo[16, 3] = "RM 7931";
        todo[17, 0] = "1/31/2017";
        todo[17, 2] = "ABC Legal";
        todo[17, 1] = "12:45 pm - 5:00 pm";
        todo[17, 3] = "";
        todo[18, 0] = "2/1/2017";
        todo[18, 2] = "Math 141 PreCalc";
        todo[18, 1] = "8:00 am - 8:50 am";
        todo[18, 3] = "RM 4183";
        todo[19, 0] = "2/1/2017";
        todo[19, 2] = "ICT 172 .Net Programming";
        todo[19, 1] = "10:00 am - 12:15 pm";
        todo[19, 3] = "RM 7931";
        todo[20, 0] = "2/2/2017";
        todo[20, 2] = "Math 141 PreCalc";
        todo[20, 1] = "8:00 am - 8:50 am";
        todo[20, 3] = "RM 4183";
        todo[21, 0] = "2/2/2017";
        todo[21, 2] = "ICT 222 SQL";
        todo[21, 1] = "10:00 am - 12:15 pm";
        todo[21, 3] = "RM 7931";
        todo[22, 0] = "2/3/2017";
        todo[22, 2] = "Math 141 PreCalc";
        todo[22, 1] = "8:00 am - 8:50 am";
        todo[22, 3] = "RM 4183";
        todo[23, 0] = "2/3/2017";
        todo[23, 2] = "ABC Legal";
        todo[23, 1] = "12:45 pm - 5:00 pm";
        todo[23, 3] = "";
    }

    protected void todoCalendar_SelectionChanged(object sender, EventArgs e)
    {
        String DateSelected = todoCalendar.SelectedDate.ToShortDateString();

        ShowAgenda(DateSelected);
    }

    protected string PickMotD(string Date)
    {
        DateTime date = Convert.ToDateTime(Date);
        DateTime thisDay = DateTime.Today;
        if (date == thisDay)
        {
            return "Today's Agenda:";
        }
        else if (date == thisDay.Add(new TimeSpan(1, 0, 0, 0)))
        {
            return "Tomorrow's Agenda:";
        }
        else if (date == thisDay.Add(new TimeSpan(-1, 0, 0, 0)))
        {
            return "Yesterday's Agenda:";
        }
        else if (date == thisDay.Add(new TimeSpan(-2, 0, 0, 0)))
        {
            return "Last " + date.ToString("dddd");
        }
        else if (date == thisDay.Add(new TimeSpan(-3, 0, 0, 0)))
        {
            return "Last " + date.ToString("dddd");
        }
        else if (date == thisDay.Add(new TimeSpan(2, 0, 0, 0)))
        {
            return "Next " + date.ToString("dddd");
        }
        else if (date == thisDay.Add(new TimeSpan(3, 0, 0, 0)))
        {
            return "Next " + date.ToString("dddd");
        }
        return date.ToString("dddd") + "  the  " + CleanDate(date) + PickNumFormat(date);
    }


    protected string CleanDate(DateTime date)
    {
        string selectedDate = date.ToString("dd");
        int numdate = Convert.ToInt32(selectedDate);
        string Date = Convert.ToString(numdate);
        return Date;
    }

    protected string PickNumFormat(DateTime date)
    {
        string selectedDate = date.ToString("dd");
        int numDate = Convert.ToInt32(selectedDate);
        if (numDate == 1 || numDate == 21 || numDate == 31)
        {
            return "st";
        }
        else if (numDate == 2 || numDate == 22)
        {
            return "nd";
        }
        else if (numDate == 3)
        {
            return "rd";
        }
        else if (numDate > 3 || numDate < 31)
        {
            return "th";
        }
        return "";
    }

    protected void ShowAgenda(string Date)
    {
        TableHeaderCell date = new TableHeaderCell();
        TableRow header = new TableRow();
        string MotD;
        /*MotD = Date + " Today's Agenda:";*/
        MotD = PickMotD(Date);
        date.Controls.Add(new LiteralControl(MotD));
        header.Cells.Add(date);
        AgendaTable.Rows.Add(header);

        for (int i =0; i < todo.GetLength(0); i++)
        {
            TableRow r = new TableRow();

            if (Date == todo[i, 0])
            {
                for (int s = 1; s < 4; s++)
                {
                    TableCell c = new TableCell();
                    c.Controls.Add(new LiteralControl(todo[i, s]));
                    r.Cells.Add(c);
                }
                AgendaTable.Rows.Add(r);
            }
            else
            {

            }
        }
    }
}