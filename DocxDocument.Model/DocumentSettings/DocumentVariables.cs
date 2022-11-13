using System.Linq;

namespace DocxDocument.Model;

public class DocumentVariables : DocxBasedCollection<DM.DocumentVariable, IDocumentVariable, WD.DocumentVariables, WD.DocumentVariable>, IDocumentVariables
{
  public DocumentVariables() : base(new WD.DocumentVariables())
  {
  }

  public DocumentVariables(WD.DocumentVariables element) : base(element)
  {
  }


  IEnumerator<KeyValuePair<string, object?>> IEnumerable<KeyValuePair<string, object?>>.GetEnumerator()
  {
    foreach (DM.DocumentVariable item in this)
      yield return new KeyValuePair<string, object?>(item.Name, item.Value);
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return GetEnumerator();
  }

  public void Add(KeyValuePair<string, object?> item)
  {
    var newItem = new DM.DocumentVariable { Name = item.Key, Value = item.Value };
    base.Add(newItem);
  }

  public bool Contains(KeyValuePair<string, object?> item)
  {
    return DocxElement.Elements<WD.DocumentVariable>().Any(item1 => item1.Name?.Value == item.Key && item1.Val?.Value == item.Value?.ToString());
  }

  public void CopyTo(KeyValuePair<string, object?>[] array, int arrayIndex)
  {
    foreach (var wdDocumentVariable in DocxElement.Elements<WD.DocumentVariable>())
      array[arrayIndex++] = new KeyValuePair<string, object?>(wdDocumentVariable.Name?.Value ?? "", wdDocumentVariable.Val?.Value);
  }

  public bool Remove(KeyValuePair<string, object?> item)
  {
    var foundItem = DocxElement.Elements<WD.DocumentVariable>()
      .FirstOrDefault(item1 => item1.Name?.Value == item.Key && item1.Val?.Value == item.Value?.ToString());
    if (foundItem != null)
    {
      foundItem.Remove();
      return true;
    }
    return false;
  }


  public void Add(string key, object? value)
  {
    DocxElement.AddChild(new WD.DocumentVariable { Name = key, Val = value?.ToString() });
  }

  public bool ContainsKey(string key)
  {
    return DocxElement.Elements<WD.DocumentVariable>().Any(item1 => item1.Name?.Value == key);
  }

  public bool Remove(string key)
  {
    var foundItem = DocxElement.Elements<WD.DocumentVariable>()
      .FirstOrDefault(item1 => item1.Name?.Value == key);
    if (foundItem != null)
    {
      foundItem.Remove();
      return true;
    }
    return false;
  }

  public bool TryGetValue(string key, out object? value)
  {
    var foundItem = DocxElement.Elements<WD.DocumentVariable>()
      .FirstOrDefault(item1 => item1.Name?.Value == key);
    if (foundItem != null)
    {
      value = foundItem.Val?.Value;
      return true;
    }
    value = null;
    return false;
  }

  public object? this[string key]
  {
    get
    {
      var foundItem = DocxElement.Elements<WD.DocumentVariable>()
        .FirstOrDefault(item1 => item1.Name?.Value == key);
      if (foundItem != null)
      {
        return foundItem.Val?.Value;
      }
      throw new InvalidOperationException($"Document variable \"{key}\" not found");
    }
    set
    {
      var foundItem = DocxElement.Elements<WD.DocumentVariable>()
        .FirstOrDefault(item1 => item1.Name?.Value == key);
      if (foundItem != null)
      {
        foundItem.Val = value?.ToString();
      }
      throw new InvalidOperationException($"Document variable \"{key}\" not found");
    }
  }

  public ICollection<string> Keys => DocxElement.Elements<WD.DocumentVariable>().Select(item => item.Name?.Value ?? "").ToList();

  public ICollection<object?> Values => DocxElement.Elements<WD.DocumentVariable>().Select(item => item.Val?.Value).Cast<object?>().ToList();
}