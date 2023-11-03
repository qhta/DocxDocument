namespace DocumentModel.Wordprocessing;

public partial class AutoCaptions: ICollection<AutoCaption>
{
  public void Add(AutoCaption value)
  {
    if (value.Name == null)
      throw new InvalidOperationException($"Item.Name must not be null");
    var _element = _Element.Elements<DXW.AutoCaption>().FirstOrDefault(item=>item.Name == value.Name);
    if (_element != null)
      throw new InvalidOperationException($"Caption \"{value.Name}\" already exists");
    _Element.AppendChild(value._Element);
  }

  public void Clear()
  {
    _Element.RemoveAllChildren();
  }

  public bool Contains(AutoCaption value)
  {
    return _Element.Elements<DXW.AutoCaption>().FirstOrDefault(item => item.Name == value.Name)!=null;
  }

  public void CopyTo(AutoCaption[] array, int arrayIndex)
  {
    var temp = _Element.Elements<DXW.AutoCaption>().ToArray();
    temp.CopyTo(array, arrayIndex);

  }

  public bool Remove(AutoCaption value)
  {
    var _element = _Element.Elements<DXW.AutoCaption>().FirstOrDefault(item => item.Name == value.Name);
    if (_element == null)
      return false;
    _element.Remove();
    return true;
  }

  public int Count => _Element.Elements<DXW.AutoCaption>().Count();

  public bool IsReadOnly => false;

  public IEnumerator<AutoCaption> GetEnumerator()
  {
    foreach (var item in _Element.Elements<DXW.AutoCaption>().ToArray())
      yield return new AutoCaption(item);
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return this.GetEnumerator();
  }
}
