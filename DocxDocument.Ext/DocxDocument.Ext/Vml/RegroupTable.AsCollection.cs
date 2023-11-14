namespace DocumentModel.Vml;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

public partial class RegroupTable: ICollection<Entry>
{
  public void Add(Entry value)
  {
    _Element?.AppendChild(value._Element);
  }

  public void Clear()
  {
    _Element?.RemoveAllChildren<DXVO.Entry>();
  }

  public bool Contains(Entry value)
  {
    return _Element?.Elements<DXVO.Entry>().FirstOrDefault(item => item==value._Element) !=null;
  }

  public void CopyTo(Entry[] array, int arrayIndex)
  {
    _Element?.Elements<DXVO.Entry>().ToArray().CopyTo(array, arrayIndex);
  }

  public bool Remove(Entry value)
  {
    var _element = _Element?.Elements<DXVO.Entry>().FirstOrDefault(item => item==value._Element);
    if (_element == null)
      return false;
    _element.Remove();
    return true;
  }

  public int Count => _Element?.Elements<DXVO.Entry>().Count() ?? 0;

  public bool IsReadOnly => false;

  public IEnumerator<Entry> GetEnumerator()
  {
    if (_Element != null)
    foreach (var item in _Element.Elements<DXVO.Entry>().ToArray())
      yield return new Entry(item);
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return this.GetEnumerator();
  }
}
