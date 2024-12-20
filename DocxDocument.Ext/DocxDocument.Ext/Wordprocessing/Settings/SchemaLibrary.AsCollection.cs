﻿namespace DocumentModel.Wordprocessing;
[CollectionDataContract]
public partial class SchemaLibrary : ICollection<Schema>
{

  public void Add(Schema value)
  {
    if (value.Uri == null)
      throw new InvalidOperationException($"Item.Uri must not be null");
    var _element = _Element?.Elements<DXCXSR.Schema>().FirstOrDefault(item => item.Uri == value.Uri);
    if (_element != null)
      throw new InvalidOperationException($"Schema {value.Uri} already exists found");
    _ExistingElement.AppendChild(value._Element);
  }

  public void Clear()
  {
    _ExistingElement.RemoveAllChildren<DXCXSR.Schema>();
  }

  public bool Contains(Schema value)
  {
    if (value.Uri == null)
      throw new InvalidOperationException($"Item.Uri must not be null");
    var _element = _Element?.Elements<DXCXSR.Schema>().FirstOrDefault(item => item.Uri == value.Uri);
    return _element != null;
  }

  public void CopyTo(Schema[] array, int arrayIndex)
  {
    _Element?.Elements<DXCXSR.Schema>().Select(item=>new Schema(item)).ToArray().CopyTo(array, arrayIndex);
  }

  public bool Remove(Schema value)
  {
    if (value.Uri == null)
      throw new InvalidOperationException($"Item.Uri must not be null");
    var _element = _Element?.Elements<DXCXSR.Schema>().FirstOrDefault(item => item.Uri == value.Uri);
    if (_element == null)
      return false;
    _element.Remove();
    return true;
  }

  public int Count => _Element?.Elements<DXCXSR.Schema>().Count() ?? 0;

  public bool IsReadOnly => false;

  public IEnumerator<Schema> GetEnumerator()
  {
    if (_Element != null)
    foreach (var item in _Element.Elements<DXCXSR.Schema>())
    {
      yield return new Schema(item);
    }
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return this.GetEnumerator();
  }
}
