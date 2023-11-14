namespace DocumentModel;

/// <summary>
/// Collection of model elements that itself is a model of OpenXmlCompositeElement.
/// </summary>
/// <typeparam name="OpenXmlElementType">Type of modeled OpenXmlCompositeElement</typeparam>
/// <typeparam name="OpenXmlItemType">Type of modeled OpenXmlElement item</typeparam>
/// <typeparam name="ModelItemType">Type of ModelElement items</typeparam>
public class ModelElementCollection<OpenXmlElementType, OpenXmlItemType, ModelItemType> :
  ModelElement<OpenXmlElementType>, ICollection, ICollection<ModelItemType>, INotifyCollectionChanged
where OpenXmlElementType : DX.OpenXmlCompositeElement
where OpenXmlItemType : DX.OpenXmlElement
where ModelItemType : IModelElement<OpenXmlItemType>, new()
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

  public ModelElementCollection() { }

  public ModelElementCollection(DX.OpenXmlElement openXmlElement) : base(openXmlElement) { }

  public ModelElementCollection(OpenXmlElementType openXmlElement) : base(openXmlElement) { }

  protected override void SetParent(ModelElement? parent)
  {
    base.SetParent(parent);
    foreach (var item in this)
      if (item is IModelElement iModelElement)
        iModelElement.Parent = parent;
  }

  #region ICollection<ModelItemType> implementation
  public void Add(ModelItemType value)
  {
    var element = _Element?.Elements<OpenXmlItemType>().FirstOrDefault(item => item == value._Element);
    if (element != null)
      throw new InvalidOperationException($"{value.GetType()} element already exists found");
    var childElement = value._ExistingElement;
    _ExistingElement.AppendChild(childElement);
  }

  public void Clear()
  {
    _ExistingElement.RemoveAllChildren<OpenXmlItemType>();
  }

  public bool Contains(ModelItemType value)
  {
    var element = _Element?.Elements<OpenXmlItemType>().FirstOrDefault(item => item == value._Element);
    return element != null;
  }

  public void CopyTo(ModelItemType[] array, int arrayIndex)
  {
    _Element?.Elements<OpenXmlItemType>().Select(item => new ModelItemType() { _Element = item }).ToArray().CopyTo(array, arrayIndex);
  }

  public bool Remove(ModelItemType value)
  {
    var _element = _Element?.Elements<OpenXmlItemType>().FirstOrDefault(item => item == value._Element);
    if (_element == null)
      return false;
    _element.Remove();
    return true;
  }

  public int Count => _Element?.Elements<OpenXmlItemType>().Count() ?? 0;

  public bool IsReadOnly => false;

  public IEnumerator<ModelItemType> GetEnumerator()
  {
    if (_Element != null)
      foreach (var item in _Element.Elements<OpenXmlItemType>())
      {
        yield return new ModelItemType { _Element = item };
      }
  }
  #endregion

  #region ICollection implementation
  IEnumerator IEnumerable.GetEnumerator()
  {
    return this.GetEnumerator();
  }

  public void CopyTo(System.Array array, int index)
  {
    throw new NotImplementedException();
  }

  public bool IsSynchronized { get { throw new NotImplementedException(); } }

  public object SyncRoot { get { throw new NotImplementedException(); } }

  #endregion

  #region INotifyCollectionChangedEvent implementation

  public event NotifyCollectionChangedEventHandler? CollectionChanged
  {
    add
    {
      OnCollectionChanged += value;
    }

    remove
    {
      OnCollectionChanged -= value;
    }
  }
  protected NotifyCollectionChangedEventHandler? OnCollectionChanged;

  #endregion

}
