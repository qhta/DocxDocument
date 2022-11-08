namespace DocxDocument.Model;

public interface IDocumentProperties: IEnumerable<IDocumentProperty>
{
  public int Count { get; }
  public IDocumentProperty this[int n] { get; }
  public IDocumentProperty this[string name] { get; }
  public void Add(IDocumentProperty property);
  public bool Remove(IDocumentProperty property);
  public void Add(string name, PropertyType type, object? value);
  public bool Remove(string name);
  public bool Change(string name, object? value);
  public void Set(string name, PropertyType type, object? value);
  public object? Get(string name);

}