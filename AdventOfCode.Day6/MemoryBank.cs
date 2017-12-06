using System.Linq;

namespace AdventOfCode.Day6
{
    public class MemoryBank
    {
        public int[] Content;

        public MemoryBank Redistribute()
        {
            int[] newContent = new int[Content.Length];
            Content.CopyTo(newContent, 0);

            int distributingBlocks = Content.Max();
            int highestIndex = Content.ToList().IndexOf(distributingBlocks);
            newContent[highestIndex] = 0;

            for (int i = 0; i < distributingBlocks; ++i)
            {
                newContent[(highestIndex + i + 1) % newContent.Length]++;
            }

            return new MemoryBank { Content = newContent };
        }

        public override bool Equals(object obj)
        {
            var otherMemoryBank = obj as MemoryBank;
            if (otherMemoryBank != null)
            {
                return Enumerable.SequenceEqual(Content, otherMemoryBank.Content);
            }
            return false;
        }
    }
}
