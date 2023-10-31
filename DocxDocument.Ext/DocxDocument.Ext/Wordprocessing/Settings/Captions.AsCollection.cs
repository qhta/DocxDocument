namespace DocumentModel.Wordprocessing;
public partial class Captions : ICollection<Caption>
{

  public void Add(Caption value)
  {
    if (value.Name == null)
      throw new InvalidOperationException($"Item.Name must not be null");
    var _element = _Element.Elements<DXW.Caption>().FirstOrDefault(item => item.Name == value.Name);
    if (_element != null)
      throw new InvalidOperationException($"Caption {value.Name} aready exists found");
    _Element.AppendChild(value._Element);
  }

  public void Clear()
  {
    var _captions = _Element.Elements<DXW.Caption>().ToArray();
    foreach (var item in _captions)
      item.Remove();
  }

  public bool Contains(Caption value)
  {
    if (value.Name == null)
      throw new InvalidOperationException($"Item.Name must not be null");
    var _element = _Element.Elements<DXW.Caption>().FirstOrDefault(item => item.Name == value.Name);
    return _element != null;
  }

  public void CopyTo(Caption[] array, int arrayIndex)
  {
    var _elements = _Element.Elements<DXW.Caption>().Select(item=>new Caption(item)).ToArray();
    _elements.CopyTo(array, arrayIndex);
  }

  public bool Remove(Caption value)
  {
    if (value.Name == null)
      throw new InvalidOperationException($"Item.Name must not be null");
    var _element = _Element.Elements<DXW.Caption>().FirstOrDefault(item => item.Name == value.Name);
    if (_element == null)
      return false;
    _element.Remove();
    return true;
  }

  public int Count => _Element?.Elements<DXW.Caption>().Count() ?? 0;

  public bool IsReadOnly => false;

  public IEnumerator<Caption> GetEnumerator()
  {
    var _elements = _Element.Elements<DXW.Caption>().ToArray();
    foreach (var item in _elements)
    {
      yield return new Caption(item);
    }
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return this.GetEnumerator();
  }
}
