namespace DocumentModel.Wordprocessing;

public partial class Rsids: ICollection<HexInt>
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public void Add(HexInt value)
  {
    var _element = _Element?.Elements<DXW.Rsid>().FirstOrDefault(item => item.Val?.Value!=null && Int32.Parse(item.Val.Value, NumberStyles.HexNumber)==value);
    if (_element != null)
      throw new InvalidOperationException($"Rsid \"{value}\" already exists");
    _ExistingElement.AppendChild(new DXW.Rsid{Val=value.ToString()});
  }

  public void Clear()
  {
    _ExistingElement.RemoveAllChildren<DXW.Rsid>();
  }

  public bool Contains(HexInt value)
  {
    return _Element?.Elements<DXW.Rsid>().FirstOrDefault(item => item.Val?.Value!=null && Int32.Parse(item.Val.Value, NumberStyles.HexNumber)==value)!=null;
  }

  public void CopyTo(HexInt[] array, int arrayIndex)
  {
    _Element?.Elements<DXW.Rsid>().ToArray().CopyTo(array, arrayIndex);

  }

  public bool Remove(HexInt value)
  {
    var _element = _Element?.Elements<DXW.Rsid>().FirstOrDefault(item => item.Val?.Value!=null && Int32.Parse(item.Val.Value, NumberStyles.HexNumber)==value);
    if (_element == null)
      return false;
    _element.Remove();
    return true;
  }

  public int Count => _Element?.Elements<DXW.Rsid>().Count() ?? 0;

  public bool IsReadOnly => false;

  public IEnumerator<HexInt> GetEnumerator()
  {
    if (_Element != null)
    foreach (var item in _Element.Elements<DXW.Rsid>().ToArray())
      yield return new HexInt(item.Val?.Value!);
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return this.GetEnumerator();
  }
}
