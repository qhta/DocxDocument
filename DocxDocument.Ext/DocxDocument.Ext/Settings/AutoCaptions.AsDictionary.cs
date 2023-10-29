using System.Diagnostics.CodeAnalysis;

namespace DocumentModel;

public partial class AutoCaptions : IDictionary<string, string?>
{
  public void Add(string key, string? value)
  {
    var _autoCaption = _AutoCaptions.Elements<DXW.AutoCaption>().FirstOrDefault(item => item.Name == key);
    if (_autoCaption != null)
      throw new InvalidOperationException($"Caption {key} aready exists found");
    _AutoCaptions.AddChild(new DXW.AutoCaption { Name = key, Caption = value });
  }

  public bool ContainsKey(string key)
  {
    return _AutoCaptions.Elements<DXW.AutoCaption>().FirstOrDefault(item => item.Name == key) != null;
  }

  public bool Remove(string key)
  {
    var _autoCaption = _AutoCaptions.Elements<DXW.AutoCaption>().FirstOrDefault(item => item.Name == key);
    if (_autoCaption == null)
      return false;
    _autoCaption.Remove();
    return true;
  }

  public bool TryGetValue(string key, [MaybeNullWhen(false)] out string? value)
  {
    var _autoCaption = _AutoCaptions.Elements<DXW.AutoCaption>().FirstOrDefault(item => item.Name == key);
    if (_autoCaption != null)
    {
      value = _autoCaption.Caption;
      return true;
    }
    value = null;
    return false;
  }

  public string? this[string key]
  {
    get
    {
      var _autoCaption = _AutoCaptions.Elements<DXW.AutoCaption>().FirstOrDefault(item => item.Name == key);
      if (_autoCaption != null)
        return _autoCaption.Caption;
      return null;
    }
    set
    {
      var _autoCaption = _AutoCaptions.Elements<DXW.AutoCaption>().FirstOrDefault(item => item.Name == key);
      if (_autoCaption != null)
      {
        _autoCaption.Caption = value;
      }
      else
      {
        _autoCaption = new DXW.AutoCaption { Name = key, Caption = value };
        _AutoCaptions.AddAnnotation(_autoCaption);
      }
    }
  }

  public ICollection<string> Keys => (ICollection<string>)_AutoCaptions.Elements<DXW.AutoCaption>().Select(item=>item.Name).ToList();
  public ICollection<string?> Values => (ICollection<string?>)_AutoCaptions.Elements<DXW.AutoCaption>().Select(item=>item.Caption).ToList();

  public void Add(KeyValuePair<string, string?> item)
  {
    throw new NotImplementedException();
  }

  public bool Contains(KeyValuePair<string, string?> item)
  {
    throw new NotImplementedException();
  }

  public void CopyTo(KeyValuePair<string, string?>[] array, int arrayIndex)
  {
    throw new NotImplementedException();
  }

  public bool Remove(KeyValuePair<string, string?> item)
  {
    throw new NotImplementedException();
  }

  IEnumerator<KeyValuePair<string, string?>> IEnumerable<KeyValuePair<string, string?>>.GetEnumerator()
  {
    throw new NotImplementedException();
  }
}
