﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Number(string _number)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = "";
            txtNumber.Text = txtNumber.Text + _number;
        }

        private void Select_Operator(int _operator)
        {
            firstNumber = Convert.ToSingle(txtNumber.Text); //將輸入文字框轉換成浮點數，存入第一個數字的全域變數
            txtNumber.Text = "0"; //重新將輸入文字框重新設定為0
            operators = _operator; //選擇「加」號
        }

            // 全域變數
            float firstNumber, secondNumber; // firstNumber 儲存第一個數字，secondNumber 儲存第二個數字
        int operators = -1; // 記錄選擇哪一種運算符號？0:加、1:減、2:乘、3:除、-1:重新設定

        private void btnZero_Click(object sender, EventArgs e)
        {
            Add_Number("0"); // 只需要呼叫Add_Number函式，並且設定參數為數字0

        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            Add_Number("1"); // 只需要呼叫Add_Number函式，並且設定參數為數字1

        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            Add_Number("2"); // 只需要呼叫Add_Number函式，並且設定參數為數字2

        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            Add_Number("3"); 

        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            Add_Number("4");
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            Add_Number("5");
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            Add_Number("6");
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            Add_Number("7");
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            Add_Number("8");
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            Add_Number("9");
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            // 確認輸入文字框中完全沒有小數點
            if (txtNumber.Text.IndexOf(".") == -1)
                txtNumber.Text = txtNumber.Text + ".";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            float finalResults = 0f; //宣告最後計算結果變數
            secondNumber = Convert.ToSingle(txtNumber.Text); //將輸入文字框轉換成浮點數，存入第二個數字的全域變數

            //依照四則運算符號的選擇，進行加減乘除
            switch (operators)
            {
                case 0:
                    finalResults = firstNumber + secondNumber;
                    break;
                case 1:
                    finalResults = firstNumber - secondNumber;
                    break;
                case 2:
                    finalResults = firstNumber * secondNumber;
                    break;
                case 3:
                    finalResults = firstNumber / secondNumber;
                    break;
            }
            txtNumber.Text = string.Format("{0:0.##########}", finalResults); //在輸入文字框中，顯示最後計算結果，並且轉換成格式化的字串內容

            //重置所有全域變數
            firstNumber = 0f;
            secondNumber = 0f;
            operators = -1;
        }

            private void btnAdd_Click(object sender, EventArgs e)
        {
                Select_Operator(0);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
                Select_Operator(1);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
                Select_Operator(2);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
                Select_Operator(3);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "0";
            firstNumber = 0f;
            secondNumber = 0f;
            operators = -1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int n = txtNumber.Text.Length;
            txtNumber.Text = txtNumber.Text.Substring(0, n-1);
            if (n == 1)
            {
                txtNumber.Text = "0";
            }
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            //string.Format("{0:P2}", finalResults);

            firstNumber = Convert.ToSingle(txtNumber.Text);
            float finalResults = 0f; 
            finalResults = firstNumber / 100f;
            txtNumber.Text = string.Format("{0:0.##########}", finalResults);
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
