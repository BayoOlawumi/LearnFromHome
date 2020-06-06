using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string fullname { get; set; }
        public string MatNum{ get; set; }
        public double TotalUnit = 0;
        public double TotalLoad = 0;
        public double cgpa{ get; set; }
        public List<Dictionary<char, double>> grade_loadList = new List<Dictionary<char, double>>();
        private void Calculate_Click(object sender, EventArgs e)
        {
            //Remember Try and exception class we had
            //This help to catch any form of error
            try
            {

                //This handles situations whereby any of the textboxes has no value supplied
                if (Course1Score.Text == string.Empty ||
                Course2Score.Text == string.Empty ||
                Course3Score.Text == string.Empty ||
                Course4Score.Text == string.Empty ||
                Course5Score.Text == string.Empty ||
                Course6Score.Text == string.Empty)
                {
                    MessageBox.Show("Kindly check the Text Box(es), score(s) are missing");
                }
                else
                {
                    fullname = Fullname.Text;
                    MatNum = MatricNum.Text;

                    //Creation of non-generic collections for each course
                    //Having the grade as key and the point obtained based on the score as Value
                    //The score in every text box is passed into a function called gradeMaker
                    Dictionary<char, int> FirstCourse = gradeMaker(Convert.ToInt32(Course1Score.Text));
                    Dictionary<char, int> SecondCourse = gradeMaker(Convert.ToInt32(Course2Score.Text));
                    Dictionary<char, int> ThirdCourse = gradeMaker(Convert.ToInt32(Course3Score.Text));
                    Dictionary<char, int> FourthCourse = gradeMaker(Convert.ToInt32(Course4Score.Text));
                    Dictionary<char, int> FifthCourse = gradeMaker(Convert.ToInt32(Course5Score.Text));
                    Dictionary<char, int> SixthCourse = gradeMaker(Convert.ToInt32(Course6Score.Text));





                    // A dictionary is also created to hold the grade and the load advantage obtained
                    Dictionary<char, double> FirstCourse_GradeLoad = UnitEvaluator(FirstCourse, Convert.ToDouble(Course1Unit.SelectedItem));
                   //The line below supply the key which the grade as a data to the grade1 label created
                    grade1.Text = FirstCourse.FirstOrDefault().Key.ToString();
                    
                    //Repeated below


                    Dictionary<char, double> SecondCourse_GradeLoad = UnitEvaluator(SecondCourse, Convert.ToDouble(Course2Unit.SelectedItem));
                    grade2.Text = SecondCourse.FirstOrDefault().Key.ToString();
                    Dictionary<char, double> ThirdCourse_GradeLoad = UnitEvaluator(ThirdCourse, Convert.ToDouble(Course3Unit.SelectedItem));
                    grade3.Text = ThirdCourse.FirstOrDefault().Key.ToString();
                    Dictionary<char, double> FourthCourse_GradeLoad = UnitEvaluator(FourthCourse, Convert.ToDouble(Course4Unit.SelectedItem));
                    grade4.Text = FourthCourse.FirstOrDefault().Key.ToString();
                    Dictionary<char, double> FifthCourse_GradeLoad = UnitEvaluator(FifthCourse, Convert.ToDouble(Course5Unit.SelectedItem));
                    grade5.Text = FifthCourse.FirstOrDefault().Key.ToString();
                    Dictionary<char, double> SixthCourse_GradeLoad = UnitEvaluator(SixthCourse, Convert.ToDouble(Course6Unit.SelectedItem));
                    grade6.Text = SixthCourse.FirstOrDefault().Key.ToString();



                    //This add a the dictionary to the list created, to harmonize them
                    grade_loadList.Add(FirstCourse_GradeLoad);
                    grade_loadList.Add(SecondCourse_GradeLoad);
                    grade_loadList.Add(ThirdCourse_GradeLoad);
                    grade_loadList.Add(FourthCourse_GradeLoad);
                    grade_loadList.Add(FifthCourse_GradeLoad);
                    grade_loadList.Add(SixthCourse_GradeLoad);


                    //This add all the units tgether
                    TotalUnit = Convert.ToDouble(Course1Unit.SelectedItem) + Convert.ToDouble(Course2Unit.SelectedItem) + Convert.ToDouble(Course3Unit.SelectedItem) + Convert.ToDouble(Course4Unit.SelectedItem) + Convert.ToDouble(Course5Unit.SelectedItem) + Convert.ToDouble(Course6Unit.SelectedItem);
                    //Calling the function that iterates over the list and calculate the Load
                    cgpa_calculator(grade_loadList);

                    //Dividing the Total load by the Total Unit
                    cgpa = TotalLoad / TotalUnit;
                    //Printing result to the assigned Label
                    Result.Text = fullname + " with matric number : " + MatNum + " has GPA of: " + cgpa;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There is a bug somewhere");
                throw;
            }
        }

        /// <summary>
        /// This function adds all the load advantage acquired by iterating over the List of Dictionaries
        /// </summary>
        /// <param name="grade_loadlist"> This is a dictionary containing the grades and the load acquired</param>
        private void cgpa_calculator(List<Dictionary<char,double>> grade_loadlist)
        {
            TotalLoad = 0;
            foreach (var item in grade_loadlist)
            {
                TotalLoad = TotalLoad + item.FirstOrDefault().Value;
            }
            
        }


        /// <summary>
        /// Creating a dictionary from the grade, point and the unit
        /// </summary>
        /// <param name="grade_point">This is a dictionary carrying the grades and the points</param>
        /// <param name="unit">The unit assigned to each course</param>
        /// <returns> A dictionary of grade and load advantage</returns>
        private Dictionary<char,double> UnitEvaluator(Dictionary<char,int> grade_point, double unit)
        {
            Dictionary<char, double> grade_load = new Dictionary<char, double>();
            grade_load[grade_point.FirstOrDefault().Key] = grade_point.FirstOrDefault().Value * unit;
            return grade_load;

        }



        /// <summary>
        /// Evaluates the grade and point based on the score supplied
        /// </summary>
        /// <param name="score"></param>
        /// <returns>A dictionary of grade and point gained</returns>
        private Dictionary<char,int> gradeMaker(int score)
        {
            char grade;
            int  point;
            Dictionary<char, int> grade_point = new Dictionary<char, int>();
            //Conditional statement that check the point and grade acquired based on the score
            if (score >= 70 && score <= 100)
            {
                grade = 'A'; point = 5;
            }
            else if (score >= 60 && score <= 69)
            {
                grade = 'B'; point = 4;
            }
            else if (score >= 50 && score <= 59)
            {
                grade = 'C'; point = 3;
            }
            else if (score >= 40 && score <= 49)
            {
                grade = 'D'; point = 2;
            }
            else
            {
                grade = 'F'; point = 0;
            }
            grade_point[grade] = point;
            return grade_point;
        }



        /// <summary>
        /// This EventHandler clears all the data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //Empty the Score TextBoxes
            Course6Score.Text =
            Course5Score.Text =
            Course4Score.Text =
            Course3Score.Text =
            Course2Score.Text =
            Course1Score.Text = string.Empty;

            //Empty the grade Label
            grade1.Text = grade2.Text = 
            grade3.Text = grade4.Text = 
            grade5.Text = grade6.Text = string.Empty;

            //Empty the result
            Result.Text = string.Empty;

            //Empty name and matric number
            Fullname.Text = MatricNum.Text = string.Empty;

        }
    }
}
