#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()

namespace DocumentModel;
/// <summary>
///   Represents a collection of model elements associated with an OpenXml element, providing synchronization between the document model and OpenXml elements.
///   Supports loading, updating, and detaching data from WordprocessingML or other OpenXml-based collections.
/// </summary>
/// <typeparam name = "ItemType">Specifies the type of model elements contained in the collection.</typeparam>
/// <typeparam name = "OpenXmlCollectionType">Specifies the type of the associated OpenXml element being wrapped and synchronized.</typeparam>
[XmlRoot("ModelElementCollection", Namespace = "DocumentModel")]
public abstract class ModelElementCollection<ItemType, OpenXmlCollectionType> : ModelElementCollection<ItemType>, IWordprocessingDocumentAware, IUpdatable where ItemType : ModelElement where OpenXmlCollectionType : DX.OpenXmlElement
{
  /// <summary>
  /// OpenXml collection element that this model element collection wraps and synchronizes with. Can be null if not attached to an OpenXml element.
  /// </summary>
  protected OpenXmlCollectionType? _openXmlCollection;


  /// <summary>
  ///   The WordprocessingDocument instance to which this model element collection is attached, or null if not attached.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public DXPP.WordprocessingDocument? WordprocessingDocument { get; protected set; }


  /// <summary>
  ///   Initializes a new instance of the <see cref = "ModelElementCollection{ItemType, OpenXmlCollectionType}"/> class.
  ///   Subscribes to collection change events to synchronize with the underlying OpenXml collection.
  /// </summary>
  protected ModelElementCollection()
  {
    InitCollectionChangedEventHandler();
  }

  /// <summary>
  /// Initializes a new instance of the <see cref = "ModelElementCollection{ItemType, OpenXmlCollectionType}"/> class with the specified parent element.
  /// </summary>
  /// <param name="parent">The parent model element that owns this collection. Cannot be null.</param>
  /// <param name="openXmlCollection">The OpenXml collection element to wrap and synchronize with. Can be null.</param>
  protected ModelElementCollection(ModelElement parent, DX.OpenXmlElement? openXmlCollection = null) : base(parent, openXmlCollection)
  {
    _openXmlCollection = openXmlCollection as OpenXmlCollectionType;
    if (_openXmlCollection != null && this.GetType().GetCustomAttribute<DirectAccessAttribute>()==null)
      LoadData(_openXmlCollection);
    InitCollectionChangedEventHandler();
  }

  /// <summary>
  /// Initializes collection changed event handler to update data on change.
  /// </summary>
  private void InitCollectionChangedEventHandler()
  {
    CollectionChanged += (sender, e) =>
    {
      //Debug.WriteLine($"CollectionChanged event triggered. Action: {e.Action}, IsLoading: {IsLoading}, OpenXmlCollection: {_openXmlCollection}");
      if (IsLoading || _openXmlCollection == null)
        return;
      if (e.Action == NotifyCollectionChangedAction.Add || e.Action == NotifyCollectionChangedAction.Remove || e.Action == NotifyCollectionChangedAction.Replace || e.Action == NotifyCollectionChangedAction.Reset)
      {
        //Debug.WriteLine($"Updating data for OpenXmlCollection: {_openXmlCollection}");
        UpdateData(_openXmlCollection);
      }
    };
  }

  /// <summary>
  ///   Attaches this model element collection to the specified WordprocessingDocument.
  /// </summary>
  /// <param name = "wordprocessingDocument">The WordprocessingDocument to attach to.</param>
  public virtual void Attach(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    WordprocessingDocument = wordprocessingDocument;
  }

  /// <summary>
  ///   Detaches this model element collection from the attached document, clearing the underlying OpenXml element reference.
  ///   After detaching, further access to OpenXml properties is not possible until re-attached.
  /// </summary>
  public virtual void Detach()
  {
    WordprocessingDocument = null;
    SetUpdatableElement(null);
  }

  /// <summary>
  /// Override of LoadData that loads data from the attached OpenXmlCollection. Throws an ArgumentException if the OpenXmlCollection is not attached.
  /// </summary>
  /// <exception cref="ArgumentException"></exception>
  public override void LoadData()
  {
    if (_openXmlCollection != null)
      LoadData(_openXmlCollection);
    else
      throw new ArgumentException($"LoadData() must not be called if the OpenXmlCollection is not attached.");
  }

  /// <summary>
  /// Override of UpdateData that updates the attached OpenXmlCollection with current data. Throws an ArgumentException if the OpenXmlCollection is not attached.
  /// </summary>
  /// <exception cref="ArgumentException"></exception>
  public override void UpdateData()
  {
    if (_openXmlCollection != null)
      UpdateData(_openXmlCollection);
    else
      throw new ArgumentException($"UpdateData() must not be called if the OpenXmlCollection is not attached.");
  }


  /// <summary>
  ///   Returns the OpenXml collection element instance for update operations, or null if not set.
  /// </summary>
  /// <returns>The OpenXml collection element instance, or null if not set.</returns>
  public override DX.OpenXmlElement? GetUpdatableElement()
  {
    return _openXmlCollection ?? (Parent as IUpdatable)?.GetUpdatableElement() as DX.OpenXmlElement;
  }

  /// <summary>
  /// Sets the OpenXml collection element instance for update operations.
  /// </summary>
  /// <param name = "element"></param>
  /// <exception cref = "NotImplementedException"></exception>
  public void SetUpdatableElement(object? element)
  {
    if (element is null)
      _openXmlCollection = null;
    else if (element is OpenXmlCollectionType openXmlCollection)
      _openXmlCollection = openXmlCollection;
    else
      throw new ArgumentException($"Expected an element of type {typeof(OpenXmlCollectionType).FullName}, but received {element.GetType().FullName}.");
  }

  /// <summary>
  ///   Loads data from the specified OpenXml element into this model element collection.
  ///   Sets the isLoading flag to true while loading data to avoid unnecessary updates by collection change events.
  /// </summary>
  /// <param name = "openXmlObject">The OpenXml element to load data from.</param>
  public sealed override void LoadData(object openXmlObject)
  {
    SetLoading(true);
    if (openXmlObject is OpenXmlCollectionType openXmlModeledElement)
    {
      LoadDataCollection(openXmlModeledElement);
    }
    SetLoading(false);
  }

  /// <summary>
  ///   Loads data from the modeled OpenXml collection into this model element collection instance.
  ///   Must be implemented by derived classes to define the mapping logic.
  /// </summary>
  /// <param name = "openXmlModeledCollection">The OpenXml collection to load data from.</param>
  protected abstract void LoadDataCollection(OpenXmlCollectionType openXmlModeledCollection);

  /// <summary>
  ///   Stores data from this model element collection to the specified OpenXml element.
  ///   Calls the abstract <see cref = "UpdateDataCollection"/> method for the actual mapping logic.
  /// </summary>
  /// <param name = "openXmlObject">The OpenXml element to store data to.</param>
  public override void UpdateData(object openXmlObject)
  {
    if (openXmlObject is OpenXmlCollectionType openXmlModeledElement)
    {
      UpdateDataCollection(openXmlModeledElement);
    }
  }

  /// <summary>
  ///   Stores data from this model element collection instance to the modeled OpenXml collection.
  ///   Must be implemented by derived classes to define the mapping logic.
  /// </summary>
  /// <param name = "openXmlModeledCollection">The OpenXml collection to store data to.</param>
  protected abstract void UpdateDataCollection(OpenXmlCollectionType openXmlModeledCollection);
}