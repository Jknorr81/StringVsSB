using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace StringVsSB
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FamilyMember dad = new FamilyMember();
            dad.Age = 37;
            dad.Name = "James";
            dad.Role = "Father";

            FamilyMember mom = new FamilyMember() { Name = "Sarah", Age = 34, Role = "Mother" };
            FamilyMember son = new FamilyMember() { Name = "Ethan", Age = 0, Role = "Baby" };

            List<FamilyMember> family = new List<FamilyMember> { dad, mom, son };

            // string example

            string result = "";
            foreach (var familyMember in family)
            {
                result += string.Format("<br />The {0} of the family is {1}, they are {2} years old.",
                    familyMember.Role, familyMember.Name, familyMember.Age);
            }
            resultLabelString.Text = result;

            // StringBuilder example

            StringBuilder sb = new StringBuilder();
            foreach (var familyMember in family)
            {
                sb.Append("<br />");
                sb.Append("The ");
                sb.Append(familyMember.Role);
                sb.Append(" of the family is ");
                sb.Append(familyMember.Name);
                sb.Append(", they are ");
                sb.Append(familyMember.Age);
                sb.Append(" years old.");
            }
            resultLabelSB.Text = sb.ToString();

        }

        public class FamilyMember
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Role { get; set; }

        }
    }
}