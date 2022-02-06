using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayClassStudiesOptimised
{
    public partial class ArrayClassMethods : Form
    {
        string[] cities = { "Adana", "İzmir", "İstanbul", "Ankara", "Giresun", "Trabzon", "Rize", "İstanbul", "Samsun", "Newşehir" };
        string[] copyCities = new string[8];

        public ArrayClassMethods()
        {
            InitializeComponent();
        }


        #region On Load
        private void ArrayClassMethods_Load(object sender, EventArgs e)
        {
            PrintToListBox(lsOriginal, cities, false);
        }
        #endregion

        #region Button Click Events
        private void btnClearArray_Click(object sender, EventArgs e)
        {

            try
            {
                Array.Clear(cities, 2, 4);
            }
            #region Exceptions
            catch (ArgumentNullException ane)
            {
                MessageBox.Show(ane.Message);
            }
            catch (IndexOutOfRangeException ioore)
            {
                MessageBox.Show(ioore.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion

            PrintToListBox(lsChanged, cities, false);

        }

        private void btnCopyArray_Click(object sender, EventArgs e)
        {
            try
            {
                Array.Copy(cities, 5, copyCities, 2, 4);
                //Array.Copy(cities, copyCities, 4);
            }
            #region Exceptions
            catch (ArgumentNullException ane)
            {
                MessageBox.Show(ane.Message);
            }
            catch (RankException re)
            {
                MessageBox.Show(re.Message);
            }
            catch (ArrayTypeMismatchException atme)
            {
                MessageBox.Show(atme.Message);
            }
            catch (InvalidCastException ice)
            {
                MessageBox.Show(ice.Message);
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                MessageBox.Show(aoore.Message);
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion

            PrintToListBox(lsChanged, copyCities, false);
        }

        private void btnLastIndexOfArray_Click(object sender, EventArgs e)
        {
            ClearItemLists(lsChanged);

            try
            {
                lsChanged.Items.Add(Array.LastIndexOf(cities, "İstanbul"));
                lsChanged.Items.Add(Array.LastIndexOf(cities, "İstanbul", 6));
            }
            #region Exceptions
            catch (ArgumentNullException ane)
            {
                MessageBox.Show(ane.Message);
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                MessageBox.Show(aoore.Message);
            }
            catch (SystemException se)
            {
                MessageBox.Show(se.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion

        }

        private void btnIndexOfArray_Click(object sender, EventArgs e)
        {
            ClearItemLists(lsChanged);

            try
            {
                lsChanged.Items.Add(Array.IndexOf(cities, "İstanbul"));
                lsChanged.Items.Add(Array.IndexOf(cities, "İstanbul", 3));
            }
            #region Exceptions
            catch (ArgumentNullException ane)
            {
                MessageBox.Show(ane.Message);
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                MessageBox.Show(aoore.Message);
            }
            catch (SystemException se)
            {
                MessageBox.Show(se.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion

        }

        private void btnResiezeArray_Click(object sender, EventArgs e)
        {
            ClearItemLists(lsChanged);

            try
            {
                Array.Resize<string>(ref cities, 4);
                Array.Resize<string>(ref cities, 12);
            }
            #region Exceptions
            catch (ArgumentOutOfRangeException aoore)
            {

                MessageBox.Show(aoore.Message);
            }
            catch (Exception)
            {

                throw;
            }
            #endregion

            PrintToListBox(lsChanged, cities, false);

        }

        private void btnReverseArray_Click(object sender, EventArgs e)
        {
            try
            {
                Array.Reverse(cities);
            }
            #region Exceptions
            catch (ArgumentNullException ane)
            {

                MessageBox.Show(ane.Message);
            }
            catch (RankException re)
            {

                MessageBox.Show(re.Message);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            #endregion

            PrintToListBox(lsChanged, cities, false);

        }

        private void btnSortArray_Click(object sender, EventArgs e)
        {
            try
            {
                Array.Sort(cities);
            }
            #region Exceptions
            catch (ArgumentNullException ane)
            {

                MessageBox.Show(ane.Message);
            }
            catch (InvalidOperationException ioe)
            {

                MessageBox.Show(ioe.Message);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            #endregion
            PrintToListBox(lsChanged, cities, false);

        }

        private void btnResetArray_Click(object sender, EventArgs e)
        {
            cities = new string[10] { "Adana", "İzmir", "İstanbul", "Ankara", "Giresun", "Trabzon", "Rize", "İstanbul", "Samsun", "Newşehir" };

            PrintToListBox(lsChanged, cities, false);

        }

        private void btnMoreThanOne_Click(object sender, EventArgs e)
        {

            string search = "Newşehir";
            PrintMoreThanOne(cities, search, "city");
            search = "İstanbul";
            PrintMoreThanOne(cities, search, "city");
            search = "Berlin";
            PrintMoreThanOne(cities, search, "city");

        }
        #endregion

        #region Methods
        void PrintToListBox(ListBox lsToPrint, string[] valuesPrint, bool showMessageBox)
        {
            ClearItemLists(lsToPrint);

            try
            {
                foreach (string value in valuesPrint)
                {
                    if(showMessageBox)
                        MessageBox.Show(value);
                    if (value != null)
                    {
                        lsToPrint.Items.Add(value);
                    }
                    else
                    {
                        lsToPrint.Items.Add("null");
                    }
                }
            }
            #region Exceptions
            catch (ArgumentNullException ane)
            {
                MessageBox.Show(ane.Message);
            }
            catch (SystemException se)
            {
                MessageBox.Show(se.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion
        }

        bool IsMoreThanOne(string[] values, string search, out bool isThereCity)
        {
            try
            {
                int count = 0;
                foreach (string value in values)
                {
                    if (value == search)
                        count++;
                }

                isThereCity = !(count <= 0);
                return (count > 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                isThereCity = false;
                return false;
            }  
        }

        void PrintMoreThanOne(string[] values, string search, string nameOfArray)
        {
            try
            {
                bool isThere = false;

                if (IsMoreThanOne(values, search, out isThere))
                {
                    MessageBox.Show("There are more than one " + nameOfArray + " named as: " + search + " in the list.");
                }
                else
                {
                    if (isThere)
                    {
                        MessageBox.Show("There is only one " + nameOfArray + " named such: " + search + " in the list.");
                    }
                    else
                    {
                        MessageBox.Show("There is no " + nameOfArray + " named such: " + search + " in the list.");
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        void ClearItemLists(ListBox lsToClear)
        {
            lsToClear.Items.Clear();
        }
        #endregion

        
    }
}
