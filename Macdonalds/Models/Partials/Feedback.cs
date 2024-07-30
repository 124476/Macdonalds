using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macdonalds.Models
{
    public partial class Feedback
    {
        public string Zvezd
        {
            get
            {
                var text = "";
                for (int i = 0; i < this.Number; i++)
                    text += "✨";

                return text;
            }
        }
    }
}
