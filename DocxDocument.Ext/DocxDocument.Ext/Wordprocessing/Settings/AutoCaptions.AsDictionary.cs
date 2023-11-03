using System.Diagnostics.CodeAnalysis;

namespace DocumentModel.Wordprocessing;

public partial class AutoCaptions : IDictionary<string, string?>
{
  public void Add(string key, string? value)
  {
    var _element = _Element.Elements<DXW.AutoCaption>().FirstOrDefault(item => item.Name == key);
    if (_element != null)
      throw new InvalidOperationException($"Caption {key} already exists found");
    _Element.AppendChild(new DXW.AutoCaption { Name = key, Caption = value });
  }

  public bool ContainsKey(string key)
  {
    return _Element.Elements<DXW.AutoCaption>().FirstOrDefault(item => item.Name == key) != null;
  }

  public bool Remove(string key)
  {
    var _element = _Element.Elements<DXW.AutoCaption>().FirstOrDefault(item => item.Name == key);
    if (_element == null)
      return false;
    _element.Remove();
    return true;
  }

  public bool TryGetValue(string key, [MaybeNullWhen(false)] out string? value)
  {
    var _element = _Element.Elements<DXW.AutoCaption>().FirstOrDefault(item => item.Name == key);
    if (_element != null)
    {
      value = _element.Caption;
      return true;
    }
    value = null;
    return false;
  }

  public string? this[string key]
  {
    get
    {
      var _element = _Element.Elements<DXW.AutoCaption>().FirstOrDefault(item => item.Name == key);
      if (_element != null)
        return _element.Caption;
      return null;
    }
    set
    {
      var _element = _Element.Elements<DXW.AutoCaption>().FirstOrDefault(item => item.Name == key);
      if (_element != null)
      {
        _element.Caption = value;
      }
      else
      {
        _element = new DXW.AutoCaption { Name = key, Caption = value };
        _Element.AppendChild(_element);
      }
    }
  }

  public ICollection<string> Keys => (ICollection<string>)_Element.Elements<DXW.AutoCaption>().Select(item => item.Name).ToList();
  public ICollection<string?> Values => (ICollection<string?>)_Element.Elements<DXW.AutoCaption>().Select(item => item.Caption).ToList();

  public void Add(KeyValuePair<string, string?> item)
  {
    Add(item.Key, item.Value);
  }

  public bool Contains(KeyValuePair<string, string?> item)
  {
    return TryGetValue(item.Key, out var value) && value == item.Value;
  }

  public void CopyTo(KeyValuePair<string, string?>[] array, int arrayIndex)
  {
    var temp = _Element.Elements<DXW.AutoCaption>().Where(item=>item.Name!=null)
      .Select(item=> new KeyValuePair<string, string?>(item.Name!, item.Caption)).ToArray();
    temp.CopyTo(array, arrayIndex);
  }

  public bool Remove(KeyValuePair<string, string?> item)
  {
    if (TryGetValue(item.Key, out var value) && value == item.Value)
      return Remove(item.Key);
    return false;
  }

  IEnumerator<KeyValuePair<string, string?>> IEnumerable<KeyValuePair<string, string?>>.GetEnumerator()
  {
    foreach (var item in _Element.Elements<DXW.AutoCaption>().ToArray())
      yield return new KeyValuePair<string, string?>(item.Name!, item.Caption);
  }
}
