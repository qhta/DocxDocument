namespace DocumentModel;
public partial class Captions : ICollection<Caption>
{

  public void Add(Caption value)
  {
    if (value.Name == null)
      throw new InvalidOperationException($"Item.Name must not be null");
    var _caption = _Captions.Elements<DXW.Caption>().FirstOrDefault(item => item.Name == value.Name);
    if (_caption != null)
      throw new InvalidOperationException($"Caption {value.Name} aready exists found");
    _Captions.AddChild(value._Caption);
  }

  public void Clear()
  {
    var _captions = _Captions.Elements<DXW.Caption>().ToArray();
    foreach (var item in _captions)
      item.Remove();
  }

  public bool Contains(Caption value)
  {
    if (value.Name == null)
      throw new InvalidOperationException($"Item.Name must not be null");
    var _caption = _Captions.Elements<DXW.Caption>().FirstOrDefault(item => item.Name == value.Name);
    return _caption != null;
  }

  public void CopyTo(Caption[] array, int arrayIndex)
  {
    var _captions = _Captions.Elements<DXW.Caption>().Select(item=>new Caption(item)).ToArray();
    _captions.CopyTo(array, arrayIndex);
  }

  public bool Remove(Caption value)
  {
    if (value.Name == null)
      throw new InvalidOperationException($"Item.Name must not be null");
    var _caption = _Captions.Elements<DXW.Caption>().FirstOrDefault(item => item.Name == value.Name);
    if (_caption == null)
      return false;
    _caption.Remove();
    return true;
  }

  public int Count => _Captions?.Elements<DXW.Caption>().Count() ?? 0;

  public bool IsReadOnly => false;

  public IEnumerator<Caption> GetEnumerator()
  {
    var _captions = _Captions.Elements<DXW.Caption>().ToArray();
    foreach (var item in _captions)
    {
      yield return new Caption(item);
    }
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return this.GetEnumerator();
  }
}
