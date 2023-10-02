using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QueryInternalForm {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        List<string> zFrom;

        private void button1_Click(object sender, EventArgs e) {
            
            List<string> zSelect = new List<string>();
            List<string> zSelectMathFunctions = new List<string>();
            zFrom = new List<string>();
            List<string> zWhere = new List<string>();
            List<string> zJoin = new List<string>();
            List<string> zWhereMathFunctions = new List<string>();
            List<string> zGroupBy = new List<string>();
            List<string> zHaving = new List<string>();
            List<string> zHavingMathFunctions = new List<string>();
            List<string> zOrderBy = new List<string>();

            bool Select, From, Where, GroupBy, Having, OrderBy;
            Select = From = Where = GroupBy = Having = OrderBy = false;
            string[] QueryLines = txt_Query.Text.Split(zEnter().ToCharArray());
            string Line = "";

            for (int c = 0; c < QueryLines.Length; c++) {
                Line = QueryLines[c].Trim().ToLower();
                if (Line != "") {
                    if (Line.Substring(Line.Length - 1, 1) == ",") {
                        Line = Line.Substring(0, Line.Length - 1);
                    }
                    if (Select == false) {
                        if (c == 0 && Line != "select") {
                            MessageBox.Show(this, "This is not a ''Select Query''", "!!! ERROR !!!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            return;
                        } else {
                            Select = true;
                        }
                    } else {
                        if (From == false) {
                            if (Line != "from") {
                                if (IsMath(Line) == true) {
                                    zSelectMathFunctions.Add(Line);
                                } else {
                                    zSelect.Add(Line);
                                }
                            } else {
                                if (zSelect.Count == 0) {
                                    MessageBox.Show(this, "This is not a ''Select Query''", "!!! ERROR !!!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                                    return;
                                }
                                From = true;
                            }
                        } else {
                            if (Where == false) {
                                if (Line != "where") {
                                    zFrom.Add(Line);
                                } else {
                                    Where = true;
                                }
                            } else {
                                if (GroupBy == false) {
                                    if (Line != "group by") {
                                        if (Line != "and" && Line != "or") {
                                            if (IsJoin(Line) == true) {
                                                zJoin.Add(Line);
                                            } else {
                                                if (IsMath(Line) == true) {
                                                    zWhereMathFunctions.Add(Line);
                                                }
                                                zWhere.Add(Line);
                                            }
                                        }
                                    } else {
                                        GroupBy = true;
                                    }
                                } else {
                                    if (Having == false) {
                                        if (Line != "having") {
                                            zGroupBy.Add(Line);
                                        } else {
                                            if (zGroupBy.Count > 0) {
                                                bool Err = false;
                                                if (zSelect.Count != zGroupBy.Count) {
                                                    Err = true;
                                                }
                                                for (int i = 0; i < zGroupBy.Count; i++) {
                                                    if (zSelect[i] != zGroupBy[i]) {
                                                        Err = true;
                                                    }
                                                }
                                                if (Err == true) {
                                                    MessageBox.Show(this, "This is not a ''Select Query''", "!!! ERROR !!!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                                                    return;
                                                }
                                            }
                                            Having = true;
                                        }
                                    } else {
                                        if (OrderBy == false) {
                                            if (Line != "order by") {
                                                if (zGroupBy.Count == 0) {
                                                    MessageBox.Show(this, "This is not a ''Select Query''", "!!! ERROR !!!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                                                    return;
                                                }
                                                if (IsMath(Line) == true) {
                                                    zHavingMathFunctions.Add(Line);
                                                }
                                                zHaving.Add(Line);
                                            } else {
                                                OrderBy = true;
                                            }
                                        } else {
                                            zOrderBy.Add(Line);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (Select && From && Where && GroupBy && Having && OrderBy) {



                // >>>>>>>>>>>>> ================ <<<<<<<<<<<<< \\
                // >>>>>>>>>>>>> Parenthesis Form <<<<<<<<<<<<< \\
                // >>>>>>>>>>>>> ================ <<<<<<<<<<<<< \\

                string PForm = "";
                // Join
                if (zWhere.Count > 0) {
                    PForm += "( ";
                }
                PForm += "JOIN ( ";
                for (int c = 0; c < zJoin.Count; c++) {
                    string[] Join = zJoin[c].Split('=');
                    PForm += Join[0].Split('.')[0].Trim() + " WITH " + Join[1].Split('.')[0].Trim() + " ON " + Join[0].Split('.')[1].Trim() + " , ";
                }
                PForm = PForm.Substring(0, PForm.Length - 3) + " ) ";
                // Where
                if (zWhere.Count > 0) {
                    PForm += "WHERE ( ";
                    for (int c = 0; c < zWhere.Count; c++) {
                        PForm += zWhere[c] + " , ";
                    }
                    PForm = PForm.Substring(0, PForm.Length - 3) + " ) ) ";
                }
                // Group By
                if (zHaving.Count > 0) {
                    PForm += "( ";
                }
                if (zGroupBy.Count > 0) {
                    PForm += "GROUP BY ( ";
                    for (int c = 0; c < zGroupBy.Count; c++) {
                        PForm += zGroupBy[c] + " , ";
                    }
                    PForm = PForm.Substring(0, PForm.Length - 3) + " ) ";
                }
                // Having
                if (zHaving.Count > 0) {
                    PForm += "WHERE ( ";
                    for (int c = 0; c < zHaving.Count; c++) {
                        PForm += zHaving[c] + " , ";
                    }
                    PForm = PForm.Substring(0, PForm.Length - 3) + " ) ) ";
                }
                // Project
                PForm += "{ ";
                for (int c = 0; c < zSelect.Count; c++) {
                    PForm += zSelect[c] + " , ";
                }
                for (int c = 0; c < zSelectMathFunctions.Count; c++) {
                    PForm += zSelectMathFunctions[c] + " , ";
                }
                PForm = PForm.Substring(0, PForm.Length - 3) + " }";
                // Order By
                if (zOrderBy.Count > 0) {
                    PForm += " ORDER BY ( ";
                    for (int c = 0; c < zOrderBy.Count; c++) {
                        PForm += zOrderBy[c] + " , ";
                    }
                    PForm = PForm.Substring(0, PForm.Length - 3) + " )";
                }
                // [TextBox]
                txt_PF.Text = PForm;



                // >>>>>>>>>>>>> ============= <<<<<<<<<<<<< \\
                // >>>>>>>>>>>>> Internal Form <<<<<<<<<<<<< \\
                // >>>>>>>>>>>>> ============= <<<<<<<<<<<<< \\

                int IFormStepsCounter = 0;
                string IForm = "";
                // Where Math Function
                if (zWhereMathFunctions.Count > 0) {
                    IForm += "[ " + ++IFormStepsCounter + " : Math Function (Select Where) ]" + zEnter();
                    for (int c = 0; c < zWhereMathFunctions.Count; c++) {
                        IForm += zWhereMathFunctions[c] + zEnter();
                    }
                    IForm += zEnter();
                }
                // Where
                if (zWhere.Count > 0) {
                    IForm += "[ " + ++IFormStepsCounter + " : Select Where ]" + zEnter();
                    for (int c = 0; c < zWhere.Count; c++) {
                        IForm += zWhere[c] + zEnter();
                    }
                    IForm += zEnter();
                }
                // Join
                IForm += "[ " + ++IFormStepsCounter + " : Join ]" + zEnter();
                for (int c = 0; c < zJoin.Count; c++) {
                    string[] Join = zJoin[c].Split('=');
                    IForm += Join[0].Split('.')[0].Trim() + " , " + Join[1].Split('.')[0].Trim() + " => " + Join[0].Split('.')[1].Trim() + zEnter();
                }
                IForm += zEnter();
                // Having Math Function
                if (zHavingMathFunctions.Count > 0) {
                    IForm += "[ " + ++IFormStepsCounter + " : Math Function (Having) ]" + zEnter();
                    for (int c = 0; c < zHavingMathFunctions.Count; c++) {
                        IForm += zHavingMathFunctions[c] + zEnter();
                    }
                    IForm += zEnter();
                }
                // Having
                if (zHaving.Count > 0) {
                    IForm += "[ " + ++IFormStepsCounter + " : Having ]" + zEnter();
                    for (int c = 0; c < zHaving.Count; c++) {
                        IForm += zHaving[c] + zEnter();
                    }
                    IForm += zEnter();
                }
                // Group By
                if (zGroupBy.Count > 0) {
                    IForm += "[ " + ++IFormStepsCounter + " : Group By ]" + zEnter();
                    for (int c = 0; c < zGroupBy.Count; c++) {
                        IForm += zGroupBy[c] + zEnter();
                    }
                    IForm += zEnter();
                }
                // Project Math Function
                if (zSelectMathFunctions.Count > 0) {
                    IForm += "[ " + ++IFormStepsCounter + " : Math Function (Project) ]" + zEnter();
                    for (int c = 0; c < zSelectMathFunctions.Count; c++) {
                        IForm += zSelectMathFunctions[c] + zEnter();
                    }
                    IForm += zEnter();
                }
                // Project
                IForm += "[ " + ++IFormStepsCounter + " : Project ]" + zEnter();
                for (int c = 0; c < zSelect.Count; c++) {
                    IForm += zSelect[c] + zEnter();
                }
                for (int c = 0; c < zSelectMathFunctions.Count; c++) {
                    IForm += zSelectMathFunctions[c].Split('=')[0].Trim() + zEnter();
                }
                IForm += zEnter();
                // Order By
                if (zOrderBy.Count > 0) {
                    IForm += "[ " + ++IFormStepsCounter + " : Order By ]" + zEnter();
                    for (int c = 0; c < zOrderBy.Count; c++) {
                        IForm += zOrderBy[c] + zEnter();
                    }
                    IForm += zEnter();
                }
                // [TextBox]
                IForm = IForm.Substring(0, IForm.Length - 3);
                txt_IF.Text = IForm;



            } else {
                MessageBox.Show(this, "This is not a ''Select Query''", "!!! ERROR !!!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btn_Q1_Click(object sender, EventArgs e) {
            txt_IF.Text = txt_PF.Text = "";
            txt_Query.Text = "Select" + zEnter() + "             S.SName" + zEnter() + "From" + zEnter() + "             S," + zEnter() + "             SP" + zEnter() + "Where" + zEnter() + "             S.S# = SP.S#" + zEnter() + "             And" + zEnter() + "             SP.P# = 'P2'" + zEnter() + "Group By" + zEnter() + "" + zEnter() + "Having" + zEnter() + "" + zEnter() + "Order By" + zEnter() + "";
        }

        private void btn_Q2_Click(object sender, EventArgs e) {
            txt_IF.Text = txt_PF.Text = "";
            txt_Query.Text = "Select" + zEnter() + "             S.SName" + zEnter() + "From" + zEnter() + "             S," + zEnter() + "             SP" + zEnter() + "Where" + zEnter() + "             S.S# = SP.S#" + zEnter() + "             And" + zEnter() + "             SP.P# = 'P2'" + zEnter() + "Group By" + zEnter() + "             S.SName" + zEnter() + "Having" + zEnter() + "             S.SName Like 'A%'" + zEnter() + "Order By" + zEnter() + "             S.SName Desc";
        }

        private void btn_Q3_Click(object sender, EventArgs e) {
            txt_IF.Text = txt_PF.Text = "";
            txt_Query.Text = "Select" + zEnter() + "             Product.Name," + zEnter() + "             Total = SUM(ProductInventory.Quantity)" + zEnter() + "From" + zEnter() + "             Product," + zEnter() + "             ProductInventory" + zEnter() + "Where" + zEnter() + "             Product.ProductId = ProductInventory.ProductId" + zEnter() + "             And" + zEnter() + "             Product.Name Like N'[A-G]%'" + zEnter() + "Group By" + zEnter() + "             Product.Name" + zEnter() + "Having" + zEnter() + "" + zEnter() + "Order By" + zEnter() + "";
        }

        private bool IsJoin(string Line) {
            string[] Arr = Line.Split('=');
            int Counter = 0;
            for (int i = 0; i < Arr.Length; i++) {
                string TableName = Arr[i].Split('.')[0].Trim();
                for (int j = 0; j < zFrom.Count; j++) {
                    if (TableName == zFrom[j]) {
                        Counter++;
                        break;
                    }
                }
            }
            return (Counter == 2 ? true : false);
        }

        private bool IsMath(string Line) {
            return (Line.IndexOf("min(") != -1 || Line.IndexOf("max(") != -1 || Line.IndexOf("avg(") != -1 || Line.IndexOf("sum(") != -1 || Line.IndexOf("count(") != -1);
        }

        private string zEnter() {
            return (char.ConvertFromUtf32(13) + char.ConvertFromUtf32(10));
        }

    }
}