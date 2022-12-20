using DocumentFormat.OpenXml.Spreadsheet;

namespace DocxDocument.Model;

public class SettingsCollection : IEnumerable<KeyValuePair<string, object>> 
{
  
  private Dictionary<string, object> Items = new();

  public void Set(string name, object? value)
  {
    if (Items.ContainsKey(name))
    {
      if (value == null)
      {
        Items.Remove(name);
      }
      else
      {
        Items[name] = value;
      }
    }
    if (value !=null)
      Items.Add(name, value);
  }

  public object? Get(string name)
  {
    if (!Items.ContainsKey(name))
      return null;
    return Items[name];
  }

  public bool IsEmpty()
  {
    return Count==0;
  }

  public int Count => Items.Count;


  public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
  {
    return Items.GetEnumerator();
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return this.GetEnumerator();
  }
}