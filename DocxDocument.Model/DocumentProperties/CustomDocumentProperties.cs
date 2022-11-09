namespace DocxDocument.Model;

public class CustomDocumentProperties: ICustomDocumentProperties
{
  private Collection<string, CustomDocumentProperty> Items = new();


  public IEnumerator<ICustomDocumentProperty> GetEnumerator()
  {
    return Items.GetEnumerator();
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return GetEnumerator();
  }

  public int Count => Items.Count;

  public void Add(ICustomDocumentProperty property)
  {
    Items.Add((CustomDocumentProperty)property);
  }

  public bool Remove(ICustomDocumentProperty property)
  {
    return Items.Remove((CustomDocumentProperty)property);
  }
}