﻿namespace DocumentModel;
/// <summary>
/// Collection of model elements that itself is a model of OpenXmlCompositeElement.
/// ModelElements must have unique "Id" integer properties.
/// </summary>
/// <typeparam name="OpenXmlElementType">Type of modeled OpenXmlCompositeElement</typeparam>
/// <typeparam name="OpenXmlItemType">Type of modeled OpenXmlElement item</typeparam>
/// <typeparam name="ModelItemType">Type of ModelElement items</typeparam>

public class IdentifiedElementCollection<OpenXmlElementType, OpenXmlItemType, ModelItemType> :
  ModelElement<OpenXmlElementType>, ICollection, ICollection<ModelItemType>, INotifyCollectionChanged
where OpenXmlElementType : DX.OpenXmlCompositeElement
where OpenXmlItemType : DX.OpenXmlElement
where ModelItemType : IModelElement<OpenXmlItemType>, IIdentifiedElement, new()
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

  private PropertyInfo IdProperty
  {
    get
    {
      if (_IdProperty == null)
        _IdProperty = typeof(OpenXmlItemType).GetProperty("Id")
             ?? typeof(OpenXmlItemType).GetProperties().FirstOrDefault(item=>item.Name.EndsWith("Id"))
                 ?? throw new InvalidCastException($"{typeof(OpenXmlItemType)} must have \"Id\" property");
      return _IdProperty;
    }
  }
  private PropertyInfo? _IdProperty;

  private MethodInfo GetMethod
  {
    get
    {
      if (_GetMethod == null)
        _GetMethod = IdProperty.GetGetMethod()
                 ?? throw new InvalidCastException($"{typeof(OpenXmlItemType)} \"Id\" property does not have \"get\" accessor");
      return _GetMethod;
    }
  }
  private MethodInfo? _GetMethod;

  private MethodInfo SetMethod
  {
    get
    {
      if (_SetMethod == null)
        _SetMethod = IdProperty.GetSetMethod()
                 ?? throw new InvalidCastException($"{typeof(OpenXmlItemType)} \"Id\" property does not have \"set\" accessor");
      return _SetMethod;
    }
  }
  private MethodInfo? _SetMethod;

  private Int32? GetId(OpenXmlItemType item) => GetMethod.Invoke(item, null) as Int32?;

  private void SetName(OpenXmlItemType item, string? value) => SetMethod.Invoke(item, new object?[] { value });

  public IdentifiedElementCollection() { }

  public IdentifiedElementCollection(DX.OpenXmlElement openXmlElement) : base(openXmlElement) { }

  public IdentifiedElementCollection(OpenXmlElementType openXmlElement) : base(openXmlElement) { }

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
    if (value.Id == null)
      throw new InvalidOperationException($"{value.GetType()}.Id must not be null");
    else 
    {
      var element = _Element?.Elements<OpenXmlItemType>().FirstOrDefault(item => GetId(item) == value.Id);
      if (element != null)
        throw new InvalidOperationException($"{value.GetType()} {value.Id} already exists found");
      var childElement = value._ExistingElement;
        _ExistingElement.AppendChild(childElement);
    }
  }

  public void Clear()
  {
    _ExistingElement.RemoveAllChildren<OpenXmlItemType>();
  }

  public bool Contains(ModelItemType value)
  {
    if (value.Id == null)
      throw new InvalidOperationException($"{value.GetType()}.Id must not be null");
    var element = _Element?.Elements<OpenXmlItemType>().FirstOrDefault(item => GetId(item) == value.Id);
    return element != null;
  }

  public void CopyTo(ModelItemType[] array, int arrayIndex)
  {
    _Element?.Elements<OpenXmlItemType>().Select(item => new ModelItemType() { _Element = item }).ToArray().CopyTo(array, arrayIndex);
  }

  public bool Remove(ModelItemType value)
  {
    if (value.Id == null)
      throw new InvalidOperationException($"{value.GetType()}.Id must not be null");
    var _element = _Element?.Elements<OpenXmlItemType>().FirstOrDefault(item => GetId(item) == value.Id);
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

  #region Dictionary methods
  public bool TryGetValue(int key, [MaybeNullWhen(false)][NotNullWhen(true)] out ModelItemType value)
  {
    var element = _Element?.Elements<OpenXmlItemType>().FirstOrDefault(item => GetId(item) == key);
    if (element != null)
    {
      value = new ModelItemType { _Element = element };
      return true;
    }
    value = default;
    return false;
  }
  #endregion
}
