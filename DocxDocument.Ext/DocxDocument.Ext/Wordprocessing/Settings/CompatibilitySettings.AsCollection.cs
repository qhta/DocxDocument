namespace DocumentModel.Wordprocessing;

public partial class CompatibilitySettings: ICollection<CompatibilitySetting>
{
  public void Add(CompatibilitySetting value)
  {
    var _element = _Element.Elements<DXW.CompatibilitySetting>().FirstOrDefault(item=>item.Name!=null && item.Name==value.Name);
    if (_element != null)
      throw new InvalidOperationException($"CompatibilitySetting \"{value.Name}\" aready exists");
    _Element.AppendChild(value._Element);
  }

  public void Clear()
  {
    _Element.RemoveAllChildren<DXW.CompatibilitySetting>();
  }

  public bool Contains(CompatibilitySetting value)
  {
    return _Element.Elements<DXW.CompatibilitySetting>().FirstOrDefault(item => item.Name!=null && item.Name == value.Name)!=null;
  }

  public void CopyTo(CompatibilitySetting[] array, int arrayIndex)
  {
    var temp = _Element.Elements<DXW.CompatibilitySetting>().ToArray();
    temp.CopyTo(array, arrayIndex);
  }

  public bool Remove(CompatibilitySetting value)
  {
    var _element = _Element.Elements<DXW.CompatibilitySetting>().FirstOrDefault(item => item.Name!=null && item.Name == value.Name);
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
