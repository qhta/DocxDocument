namespace DocumentModel.Wordprocessing;

[CollectionDataContract]
public partial class CompatibilitySettings: ICollection<CompatibilitySetting>
{
  public void Add(CompatibilitySetting value)
  {
    object valueName = value.Name;
    if (valueName.GetType() != typeof(DXW.CompatSettingNameValues))
    {
      var n = (int)Convert.ChangeType(valueName, typeof(int));
      valueName = Enum.ToObject(typeof(DXW.CompatSettingNameValues), n);
    }
    var _element = _Element.Elements<DXW.CompatibilitySetting>().FirstOrDefault(item=>item.Name!=null && item.Name==valueName);
    if (_element != null)
      throw new InvalidOperationException($"CompatibilitySetting \"{value.Name}\" already exists");
    _Element.AppendChild(value._Element);
  }

  public void Clear()
  {
    _Element.RemoveAllChildren<DXW.CompatibilitySetting>();
  }

  public bool Contains(CompatibilitySetting value)
  {
    object valueName = value.Name;
    if (valueName.GetType() != typeof(DXW.CompatSettingNameValues))
    {
      var n = (int)Convert.ChangeType(valueName, typeof(int));
      valueName = Enum.ToObject(typeof(DXW.CompatSettingNameValues), n);
    }
    return _Element.Elements<DXW.CompatibilitySetting>().FirstOrDefault(item => item.Name!=null && item.Name == valueName)!=null;
  }

  public void CopyTo(CompatibilitySetting[] array, int arrayIndex)
  {
    var temp = _Element.Elements<DXW.CompatibilitySetting>().ToArray();
    temp.CopyTo(array, arrayIndex);
  }

  public bool Remove(CompatibilitySetting value)
  {
    object valueName = value.Name;
    if (valueName.GetType() != typeof(DXW.CompatSettingNameValues))
    {
      var n = (int)Convert.ChangeType(valueName, typeof(int));
      valueName = Enum.ToObject(typeof(DXW.CompatSettingNameValues), n);
    }
    var _element = _Element.Elements<DXW.CompatibilitySetting>().FirstOrDefault(item => item.Name!=null && item.Name == valueName);
    if (_element == null)
      return false;
    _element.Remove();
    return true;
  }

  public int Count => _Element.Elements<DXW.CompatibilitySetting>().Count();

  public bool IsReadOnly => false;

  public IEnumerator<CompatibilitySetting> GetEnumerator()
  {
    foreach (var item in _Element.Elements<DXW.CompatibilitySetting>().ToArray())
      yield return new CompatibilitySetting(item);
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return this.GetEnumerator();
  }
}
