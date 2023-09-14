namespace CodingChallenge.Server;

public static class StreamService
{
    /// <summary>
    /// Takes one string input of any number of integers separated by single whitespace.
    /// The function then outputs the longest increasing subsequence (increased by any number) present in that sequence.
    /// If more than 1 sequence exists with the longest length, output the earliest one
    /// </summary>
    public static string FindLongestIncreasingSequence(string stream)
    {
        var numbers = new List<int>();
    
        foreach (var token in stream.Split(' '))
        {
            if (int.TryParse(token, out var number))
            {
                numbers.Add(number);
            }
        }

        var result = FindLongestIncreasingSequence(numbers);

        return string.Join(' ', result);
    }

    private static IList<int> FindLongestIncreasingSequence(IReadOnlyList<int> numbers)
    {
        if (numbers.Any() is false)
            return Enumerable.Empty<int>().ToList();
            
        var longestSequence = new List<int>();
        var currentSequence = new List<int> { numbers[0] };

        for (var i = 1; i < numbers.Count; i++)
        {   
            // Check if current number is larger than the previous number  
            if (numbers[i] > numbers[i - 1])
            {
                currentSequence.Add(numbers[i]);
            }
            else
            {
                // Check if the current subsequence is longer than the longest one.
                if (currentSequence.Count > longestSequence.Count)
                {
                    longestSequence = new List<int>(currentSequence);
                }

                // Reset the current subsequence and starting index.
                currentSequence.Clear();
                currentSequence.Add(numbers[i]);
            }
        }

        // Check if the last subsequence is longer than the longest one.
        if (currentSequence.Count > longestSequence.Count)
        {
            longestSequence = new List<int>(currentSequence);
        }

        return longestSequence;
    }
}
