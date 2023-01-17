
using UnityEngine;
using TMPro;



public class Calculator : MonoBehaviour
{
    //field
    public TextMeshProUGUI InputField;

    private decimal ValueFirst = 0.0m;
    private decimal Hundred;
    private decimal ValueSecond = 0.0m;
    private decimal Result = 0.0m;
    private string Operators = "+";


    //end field




    // Start is called before the first frame update

    //methods
    void Start()
    {

    }

    public void PeriodBtnClick()
    {
        if (!InputField.text.Contains("."))
        {
            InputField.text += ".";
        }
    }

    public void zeroBtnClick()
    {
        if (InputField.text == "0")
        {
            InputField.text = "0";
        }
        else
        {
            InputField.text += "0";
        }
    }

    public void OneBnClick()
    {
        if (InputField.text == "0")
        {
            InputField.text = "1";
        }

        else
        {
            InputField.text += "1";
        }
    }

    public void TwoBtnClick()
    {
        if (InputField.text == "0")
        {
            InputField.text = "2";
        }

        else
        {
            InputField.text += "2";
        }
    }


    public void ThreeBtnClick()
    {
        if (InputField.text == "0")
        {
            InputField.text = "3";
        }

        else
        {
            InputField.text += "3";
        }
    }

    public void FourBtnClick()
    {
        if (InputField.text == "0")
        {
            InputField.text = "4";
        }

        else
        {
            InputField.text += "4";
        }
    }

    public void FiveBtnClick()
    {
        if (InputField.text == "0")
        {
            InputField.text = "5";
        }

        else
        {
            InputField.text += "5";
        }
    }

    public void sixBtnClick()
    {
        if (InputField.text == "0")
        {
            InputField.text = "6";
        }

        else
        {
            InputField.text += "6";
        }
    }

    public void SevenBtnClick()
    {
        if (InputField.text == "0")
        {
            InputField.text = "7";
        }

        else
        {
            InputField.text += "7";
        }
    }

    public void EightBtnClick()
    {
        if (InputField.text == "0")
        {
            InputField.text = "8";
        }

        else
        {
            InputField.text += "8";
        }
    }

    public void NineBtnClick()
    {
        if (InputField.text == "0")
        {
            InputField.text = "9";
        }

        else
        {
            InputField.text += "9";
        }
    }

    public void MinusPlusBtnClick()
    {
        if (InputField.text.Contains("-"))
        {
            InputField.text = InputField.text.Trim('-');
        }

        else
        {
            InputField.text = "-" + InputField.text;
        }
    }

    public void MinusBtnClick()
    {
        ValueFirst = decimal.Parse(InputField.text);
        InputField.text = "";
        Operators = "-";


    }

    public void PlusBtnClick()
    {
        ValueFirst = decimal.Parse(InputField.text);
        InputField.text = "";
        Operators = "+";
    }

    public void DivideBtnClick()
    {
        ValueFirst = decimal.Parse(InputField.text);
        InputField.text = "";
        Operators = "÷";

    }

    public void MultiplyBtnClick()
    {
        ValueFirst = decimal.Parse(InputField.text);
        InputField.text = "";
        Operators = "×";

    }

    public void ModuleBtnClick()
    {
        ValueFirst = decimal.Parse(InputField.text);
        InputField.text = "";
        Operators = "%";


    }

    public void EqualBtn(string val)
    {
        switch (Operators)
        {
            case "-":
                ValueSecond = decimal.Parse(InputField.text);
                Result = ValueFirst - ValueSecond;
                InputField.text = Result.ToString();
                ClearInput();
                break;

            case "+":
                ValueSecond = decimal.Parse(InputField.text);
                Result = ValueFirst + ValueSecond;
                InputField.text = Result.ToString();
                ClearInput();
                break;

            case "×":
                ValueSecond = decimal.Parse(InputField.text);
                Result = ValueFirst*ValueSecond;
                InputField.text = Result.ToString();
                ClearInput();
                break;

            case "÷":
                ValueSecond = decimal.Parse(InputField.text);
                Result = ValueFirst/ValueSecond;
                InputField.text = Result.ToString();
                ClearInput();
                break;

            case "%":
                Hundred = decimal.Parse("100");
                Result = ValueFirst / Hundred;
                InputField.text = Result.ToString();
                ClearInput();
                break;

            case null:
                Result = decimal.Parse(InputField.text);
                ClearInput();
                break;
        }
    }

    public void Clearbtn(int val)
    {

        InputField.text = $"{val}";
    }

    //end methods

    private void ClearInput()
    {
        ValueFirst = 0;
        ValueSecond = 0;
    }

}

