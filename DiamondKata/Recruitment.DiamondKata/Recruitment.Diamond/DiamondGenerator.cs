using System.Text;

namespace Recruitment.Diamond
{
    public class DiamondGenerator : IDiamondGenerator
    {
        public string Generate(char middleLetter)
        {
            var diamond = new StringBuilder();

            char targetChar = char.ToUpper(middleLetter);
            int diamondSize = targetChar - 'A' + 1;

            TopLevelTree(diamond, diamondSize);
            BottomLevelTree(diamond, diamondSize);

            return diamond.ToString();
        }

        private static void TopLevelTree(StringBuilder diamond, int diamondSize)
        {
            // to the middle of the diamond
            //  A
            // B B
            //C   C
            for (int i = 0; i < diamondSize; i++)
            {
                for (int j = 0; j < diamondSize - i - 1; j++)
                {
                    diamond.Append(" ");
                }
                diamond.Append((char)('A' + i));

                if (i > 0) //if not first row of the diamond then add the right side of the diamond
                {
                    for (int k = 0; k < 2 * i - 1; k++)
                    {
                        diamond.Append(" ");
                    }
                    diamond.Append((char)('A' + i));
                }

                diamond.AppendLine();
            }
        }


        private static void BottomLevelTree(StringBuilder diamond, int diamondSize)
        {
            // from the middle of the diamond to the bottom
            // B B
            //  A

            for (int i = diamondSize - 2; i >= 0; i--)
            {
                for (int j = 0; j < diamondSize - i - 1; j++)
                {
                    diamond.Append(" ");
                }
                diamond.Append((char)('A' + i));

                if (i > 0)
                {
                    for (int k = 0; k < 2 * i - 1; k++)
                    {
                        diamond.Append(" ");
                    }
                    diamond.Append((char)('A' + i));
                }

                diamond.AppendLine();
            }
        }
    }
}
