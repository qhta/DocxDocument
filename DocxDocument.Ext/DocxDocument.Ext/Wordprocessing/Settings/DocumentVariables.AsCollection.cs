namespace DocumentModel.Wordprocessing;
[CollectionDataContract]
public partial class DocumentVariables : ICollection<DocumentVariable>
{

  public void Add(DocumentVariable value)
  {
    if (value.Name == null)
      throw new InvalidOperationException($"Item.Name must not be null");
    var _element = _Element.Elements<DXW.DocumentVariable>().FirstOrDefault(item => item.Name == value.Name);
    if (_element != null)
      throw new InvalidOperationException($"DocumentVariable {value.Name} already exists found");
    _Element.AppendChild(value._Element);
  }

  public void Clear()
  {
    _Element.RemoveAllChildren<DXW.DocumentVariable>();
  }

  public bool Contains(DocumentVariable value)
  {
    if (value.Name == null)
      throw new InvalidOperationException($"Item.Name must not be null");
    var _element = _Element.Elements<DXW.DocumentVariable>().FirstOrDefault(item => item.Name == value.Name);
    return _element != null;
  }

  public void CopyTo(DocumentVariable[] array, int arrayIndex)
  {
    var _elements = _Element.Elements<DXW.DocumentVariable>().Select(item=>new DocumentVariable(item)).ToArray();
    _elements.CopyTo(array, arrayIndex);
  }

  public bool Remove(DocumentVariable value)
  {
    if (value.Name == null)
      throw new InvalidOperationException($"Item.Name must not be null");
    var _element = _Element.Elements<DXW.DocumentVariable>().FirstOrDefault(item => item.Name == value.Name);
    if (_element == null)
      return false;
    _element.Remove();
    return true;
  }

  public int Count => _Element?.Elements<DXW.DocumentVariable>().Count() ?? 0;

  public bool IsReadOnly => false;

  public IEnumerator<DocumentVariable> GetEnumerator()
  {
    var _elements = _Element.Elements<DXW.DocumentVariable>().ToArray();
    foreach (var item in _elements)
    {
      yield return new DocumentVariable(item);
    }
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return this.GetEnumerator();
  }
}
