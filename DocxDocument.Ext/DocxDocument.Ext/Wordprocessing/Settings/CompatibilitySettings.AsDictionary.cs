using System.Diagnostics.CodeAnalysis;

namespace DocumentModel.Wordprocessing;

public partial class CompatibilitySettings : IDictionary<DXW.CompatSettingNameValues, string?>
{
  public void Add(DXW.CompatSettingNameValues key, string? value)
  {
    var _element = _Element.Elements<DXW.CompatibilitySetting>().FirstOrDefault(item => item.Name!=null && item.Name == key);
    if (_element != null)
      throw new InvalidOperationException($"CompatibilitySetting \"{key}\" aready exists");
    _Element.AppendChild(new DXW.CompatibilitySetting { Name = key, Val = value });
  }

  public bool ContainsKey(DXW.CompatSettingNameValues key)
  {
    return _Element.Elements<DXW.CompatibilitySetting>().FirstOrDefault(item => item.Name!=null && item.Name == key) != null;
  }

  public bool Remove(DXW.CompatSettingNameValues key)
  {
    var _element = _Element.Elements<DXW.CompatibilitySetting>().FirstOrDefault(item => item.Name!=null && item.Name == key);
    if (_element == null)
      return false;
    _element.Remove();
    return true;
  }

  public bool TryGetValue(DXW.CompatSettingNameValues key, [MaybeNullWhen(false)] out string? value)
  {
    var _element = _Element.Elements<DXW.CompatibilitySetting>().FirstOrDefault(item => item.Name!=null && item.Name == key);
    if (_element != null)
    {
      value = _element.Val;
      return true;
    }
    value = null;
    return false;
  }

  public string? this[DXW.CompatSettingNameValues key]
  {
    get
    {
      var _element = _Element.Elements<DXW.CompatibilitySetting>().FirstOrDefault(item => item.Name!=null && item.Name == key);
      if (_element != null)
        return _element.Val;
      return null;
    }
    set
    {
      var _element = _Element.Elements<DXW.CompatibilitySetting>().FirstOrDefault(item => item.Name!=null && item.Name == key);
      if (_element != null)
      {
        _element.Val = value;
      }
      else
      {
        _element = new DXW.CompatibilitySetting { Name = key, Val = value };
        _Element.AppendChild(_element);
      }
    }
  }

  public ICollection<DXW.CompatSettingNameValues> Keys => (ICollection<DXW.CompatSettingNameValues>)_Element.Elements<DXW.CompatibilitySetting>().Select(item=>item.Name).ToList();
  public ICollection<string?> Values => (ICollection<string?>)_Element.Elements<DXW.CompatibilitySetting>().Select(item=>item.Val).ToList();

  public void Add(KeyValuePair<DXW.CompatSettingNameValues, string?> item)
  {
    Add(item.Key, item.Value);
  }

  public bool Contains(KeyValuePair<DXW.CompatSettingNameValues, string?> item)
  {
    return TryGetValue(item.Key, out var value) && value == item.Value;
  }

  public void CopyTo(KeyValuePair<DXW.CompatSettingNameValues, string?>[] array, int arrayIndex)
  {
    var temp = _Element.Elements<DXW.CompatibilitySetting>().Where(item=>item.Name!=null)
      .Select(item=> new KeyValuePair<DXW.CompatSettingNameValues, string?>(item.Name!, item.Val)).ToArray();
    temp.CopyTo(array, arrayIndex);
  }

  public bool Remove(KeyValuePair<DXW.CompatSettingNameValues, string?> item)
  {
    if (TryGetValue(item.Key, out var value) && value == item.Value)
      return Remove(item.Key);
    return false;
  }

  IEnumerator<KeyValuePair<DXW.CompatSettingNameValues, string?>> IEnumerable<KeyValuePair<DXW.CompatSettingNameValues, string?>>.GetEnumerator()
  {
    foreach (var item in _Element.Elements<DXW.CompatibilitySetting>().ToArray())
      yield return new KeyValuePair<DXW.CompatSettingNameValues, string?>(item.Name!, item.Val);
  }
}
