namespace DocxDocument.Model;

public class HeadingPairs : Collection<HeadingPair>
{
  public override string ToString()
  {
    var list = new List<string>();
    foreach (var item in this)
      list.Add(item.ToString());
    return "{" + String.Join(", ", list) + "}";
  }
}