namespace DocumentModel.Vml;

public partial class RegroupTable: ICollection<Entry>
{
  public void Add(Entry value)
  {
    _Element.AppendChild(value._Element);
  }

  public void Clear()
  {
    _Element.RemoveAllChildren<DXVO.Entry>();
  }

  public bool Contains(Entry value)
  {
    return _Element.Elements<DXVO.Entry>().FirstOrDefault(item => item==value._Element) !=null;
  }

  public void CopyTo(Entry[] array, int arrayIndex)
  {
    var temp = _Element.Elements<DXVO.Entry>().ToArray();
    temp.CopyTo(array, arrayIndex);

  }

  public bool Remove(Entry value)
  {
    var _element = _Element.Elements<DXVO.Entry>().FirstOrDefault(item => item==value._Element);
    if (_element == null)
      return false;
    _element.Remove();
    return true;
  }

  public int Count => _Element.Elements<DXVO.Entry>().Count();

  public bool IsReadOnly => false;

  public IEnumerator<Entry> GetEnumerator()
  {
    foreach (var item in _Element.Elements<DXVO.Entry>().ToArray())
      yield return new Entry(item);
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return this.GetEnumerator();
  }
}
