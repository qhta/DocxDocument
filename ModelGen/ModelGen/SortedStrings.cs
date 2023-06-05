using Qhta.TextUtils;

namespace ModelGen;

public class SortedStrings : SortedSet<string>
{
  public override bool Contains(string str)
  {
    return this.AsEnumerable<string>().Any(item => item == str
    //|| item.StartsWith("*") && item.EndsWith("*") && str.Contains(item.Substring(1, item.Length - 2))
    //|| item.StartsWith("*") && str.EndsWith(item.Substring(1))
    //|| item.EndsWith("*") && str.StartsWith(item.Substring(0, item.Length - 1))
    || item.Contains("*") && str.IsLike(item));
  }
}