using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEMCNS.BCR_TML
{
    public partial class ucMessage : UserControl
    {
        public enum MESSAGE_TYPE
        {
            Login,
            Information,
            LotStart,
            LotEnd,
            Alarm,
        }

        public ucMessage()
        {
            InitializeComponent();
        }

        public void UpdateMessage(MESSAGE_TYPE type, string message)
        {
            switch (type)
            {
                case MESSAGE_TYPE.Login:

                    lblTitle.ForeColor = Color.Black;
                    lblTitle.BackColor = Color.Cyan;
                    lblMessage.ForeColor = Color.Black;
                    lblMessage.BackColor = Color.SteelBlue;

                    break;


                case MESSAGE_TYPE.Information:

                    lblTitle.ForeColor = Color.Black;
                    lblTitle.BackColor = Color.Cornsilk;
                    lblMessage.ForeColor = Color.Black;
                    lblMessage.BackColor = Color.LightSteelBlue;

                    break;

                case MESSAGE_TYPE.LotStart:

                    lblTitle.ForeColor = Color.Black;
                    lblTitle.BackColor = Color.PaleGreen;
                    lblMessage.ForeColor = Color.Black;
                    lblMessage.BackColor = Color.LimeGreen;

                    break;

                case MESSAGE_TYPE.LotEnd:

                    lblTitle.ForeColor = Color.Black;
                    lblTitle.BackColor = Color.Cyan;
                    lblMessage.ForeColor = Color.Black;
                    lblMessage.BackColor = Color.SteelBlue;

                    break;
            }

            lblMessage.Text = message;
        }
    }
}
