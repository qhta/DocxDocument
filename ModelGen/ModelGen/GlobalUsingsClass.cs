namespace ModelGen;
public class GlobalUsingsClass: HashSet<string>
{
  public new void Add(string? str)
  {
    if (str != null) base.Add(str);
  }
}
