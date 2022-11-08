namespace DocxDocument.Model;

public class Strings: Collection<String>
{
  public override string ToString()
  {
    var list = new List<string>();
    foreach (var item in this)
      list.Add(item.ToString());
    return "{"+String.Join(", ", list)+"}";
  }
}