using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecthadash
{
    public class Mycanvas
    {
        public const int Max_Width = 800;
        public const int Max_Height = 600;

        private static int buttonIndex = 0;
        private static int MaxButtons = 3;

        private static MyButton[] buttons = new MyButton[MaxButtons];

        public static bool CreateNewButton(int x1, int y1, int x2, int y2)
        {
            if (buttonIndex < maxButtons && x1 <= MaxWidth && x2 <= MaxWidth && y1 <= MaxHeight && y2 <= MaxHeight)
            {
                Point topLeft = new Point(x1, y1);


                Point bottomRight = new Point(x2, y2);

                MyButton button = new MyButton(topLeft, bottomRight);

                buttons[buttonIndex] = button;

                buttonIndex++;

                return true;
            }
            else
                return false;
        }

        public static bool MoveButton(int x, int y, int index)
        {
            if (index < buttonIndex)
            {
                if (buttons[index].GetTopLeft().GetX() + x <= MaxWidth && buttons[index].GetTopLeft().GetY() + y <= MaxHeight && buttons[index].GetBottomRight().GetX() + x <= MaxWidth && buttons[index].GetBottomRight().GetY() + y <= MaxHeight)
                {
                    Point newT = new Point(x + buttons[index].GetTopLeft().GetX(), y + buttons[index].GetTopLeft().GetY());
                    Point newB = new Point(x + buttons[index].GetBottomRight().GetX(), y + buttons[index].GetBottomRight().GetY());
                    buttons[index].SetTopLeft(newT);
                    buttons[index].SetBottomRight(newB);
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        public static bool DeleteLasButton()
        {
            if (buttonIndex > 0)
            {
                MyButton[] temp = new MyButton[maxButtons - 1];
                for (int i = 0; i < maxButtons - 1; i++)
                {
                    temp[i] = buttons[i];
                }
                buttons = temp;
                return true;
            }
            else
                return false;

        }

        public static void ClearAllButtons()
        {
            if (buttonIndex > 0)
            {
                buttons = null;
            }

        }
        public static int GetCurrentNumberOfButtons()
        {
            return buttonIndex;
        }

        public static int GetMaxNumberOfButtons()
        {
            return maxButtons;
        }

        public static int GetMaxWidthOffAButton()
        {
            if (buttonIndex > 0)
            {
                int max = 0;
                for (int i = 0; i < buttonIndex; i++)
                {
                    if (buttons[i].GetWidth() > max)
                    {
                        max = buttons[i].GetWidth();
                    }
                }
                return max;
            }
            else
                return 0;

        }

        public static int GetMaxHeightOffAButtoon()
        {
            if (buttonIndex > 0)
            {
                int max = 0;
                for (int i = 0; i < buttonIndex; i++)
                {
                    if (buttons[i].GetHeight() > max)
                    {
                        max = buttons[i].GetHeight();
                    }
                }
                return max;
            }
            else
                return 0;
        }

        public override string ToString()
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                Console.WriteLine(buttons[i].ToString());
            }
            return "That is all";
        }

        public static bool IsPointeInsideAButton(int x, int y)
        {
            for (int i = 0; i < buttonIndex; i++)
            {
                int middleX = (buttons[i].GetTopLeft().GetX() + buttons[i].GetBottomRight().GetX()) / 2;
                int middleY = (buttons[i].GetTopLeft().GetY() + buttons[i].GetBottomRight().GetY()) / 2;
                double radius = Math.Sqrt(Math.Pow(middleX - buttons[i].GetBottomRight().GetX(), 2) + Math.Pow(middleY - buttons[i].GetBottomRight().GetY(), 2));
                if ((Math.Pow(x - middleX, 2) + Math.Pow(y - middleY, 2)) < Math.Pow(radius, 2))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CheckIfAnyButtonIsOverlapping()
        {
            for (int i = 0; i < buttonIndex; i++)
            {
                int middleX = (buttons[i].GetTopLeft().GetX() + buttons[i].GetBottomRight().GetX()) / 2;
                int middleY = (buttons[i].GetTopLeft().GetY() + buttons[i].GetBottomRight().GetY()) / 2;
                double radius = Math.Sqrt(Math.Pow(middleX - buttons[i].GetBottomRight().GetX(), 2) + Math.Pow(middleY - buttons[i].GetBottomRight().GetY(), 2));
                int middleX2 = (buttons[i + 1].GetTopLeft().GetX() + buttons[i + 1].GetBottomRight().GetX()) / 2;
                int middleY2 = (buttons[i + 1].GetTopLeft().GetY() + buttons[i + 1].GetBottomRight().GetY()) / 2;
                double radius2 = Math.Sqrt(Math.Pow(middleX - buttons[i + 1].GetBottomRight().GetX(), 2) + Math.Pow(middleY - buttons[i + 1].GetBottomRight().GetY(), 2));
                if ((Math.Abs(radius - radius2)) <= Math.Sqrt(Math.Pow(middleX - middleX2, 2) + Math.Pow(middleY - middleY2, 2)))
                {
                    return true;
                }
                else if (Math.Sqrt(Math.Pow(middleX - middleX2, 2) + Math.Pow(middleY - middleY2, 2)) <= radius + radius2)
                {
                    return true;
                }
            }
            return false;
        }








    }
}
