namespace BaseballGame
{
    internal class CalcPoints
    {
        public static int Calc(string[] ops)
        {
            List<int> points = new List<int>();

            if (ops != null && ops.Length > 0)
            {
                foreach (string op in ops)
                    GetValue(ref points, op);
            }

            return points.Sum();
        }

        private static void GetValue(ref List<int> points, string op)
        {
            if (int.TryParse(op, out int val))
                points.Add(val);
            else if (op.ToUpper() == "C")
            {
                if (points.Any())
                    points.RemoveAt(points.Count - 1);
            }
            else if (op.ToUpper() == "D")
            {
                if (points.Any())
                    points.Add(points[points.Count - 1] * 2);
            }
            else if (op.ToUpper() == "+")
            {
                if (points.Count > 2)
                    points.Add(points[points.Count - 2] + points[points.Count - 1]);
            }
        }
    }
}
