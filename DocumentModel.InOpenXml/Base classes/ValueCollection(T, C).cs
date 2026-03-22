namespace DocumentModel;
/// <summary>
///   Represents a collection of values associated with an OpenXml collection, providing synchronization between the document model and OpenXml elements.
///   Supports loading, updating, and detaching data from WordprocessingML or other OpenXml-based collections.
/// </summary>
/// <typeparam name="ItemType">Specifies the type of items contained in the value collection.</typeparam>
/// <typeparam name="OpenXmlCollectionType">Specifies the type of the OpenXml collection element being wrapped and synchronized.</typeparam>
public abstract class ValueCollection<ItemType, OpenXmlCollectionType> : ElementCollection<ItemType>,
  IWordprocessingDocumentAware
  where OpenXmlCollectionType : DX.OpenXmlElement
{
  private OpenXmlCollectionType? _openXmlCollection;
  
  /// <summary>
  /// Indicates whether a loading operation is currently in progress.
  /// </summary>
  protected bool isLoading;

  /// <summary>
  ///   The WordprocessingDocument instance to which this value collection is attached, or null if not attached.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public DXPP.WordprocessingDocument? WordprocessingDocument { get; private set; }

  /// <summary>
  ///   Attaches this value collection to the specified WordprocessingDocument and loads data from the document's package properties or OpenXml part.
  /// </summary>
  /// <param name="wordprocessingDocument">The WordprocessingDocument to attach to and load data from.</param>
  public virtual void AttachAndLoad(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    WordprocessingDocument = wordprocessingDocument;
  }

  /// <summary>
  ///   Attaches this value collection to the specified WordprocessingDocument and updates the document's package properties or OpenXml part with current data.
  /// </summary>
  /// <param name="wordprocessingDocument">The WordprocessingDocument to attach to and update.</param>
  public virtual void AttachAndUpdate(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    WordprocessingDocument = wordprocessingDocument;
  }

  /// <summary>
  ///   Detaches this value collection from the attached document, clearing the underlying OpenXml element reference.
  ///   After detaching, further access to OpenXml properties is not possible until re-attached.
  /// </summary>
  public virtual void Detach()
  {
    WordprocessingDocument = null;
    SetUpdatableElement(null);
  }

  /// <summary>
  ///   Initializes a new instance of the <see cref="ValueCollection{ItemType, OpenXmlCollectionType}"/> class.
  ///   Subscribes to collection change events to synchronize with the underlying OpenXml collection.
  /// </summary>
  protected ValueCollection()
  {
    base.CollectionChanged += (sender, e) =>
    {
      if (isLoading || _openXmlCollection == null)
        return;
      if (e.Action == NotifyCollectionChangedAction.Add
          || e.Action == NotifyCollectionChangedAction.Remove
          || e.Action == NotifyCollectionChangedAction.Replace
          || e.Action == NotifyCollectionChangedAction.Reset)
      {
        UpdateData(_openXmlCollection);
      }
    };
  }

  /// <summary>
  ///   Initializes a new instance of the <see cref="ValueCollection{ItemType, OpenXmlCollectionType}"/> class with the specified OpenXml element.
  /// </summary>
  /// <param name="openXmlCollection">The OpenXml collection element to wrap and synchronize with.</param>
  protected ValueCollection(OpenXmlCollectionType? openXmlCollection) : this()
  {
    _openXmlCollection = openXmlCollection;
  }

  /// <summary>
  ///   Initializes a new instance of the <see cref="ValueCollection{ItemType, OpenXmlCollectionType}"/> class with the specified items.
  /// </summary>
  /// <param name="items">The items to add to the collection.</param>
  protected ValueCollection(IEnumerable<ItemType> items) : this()
  {
    foreach (var item in items)
    {
      Add(item);
    }
  }

  /// <summary>
  ///   Returns the wrapped OpenXml collection element instance, or null if not set.
  /// </summary>
  /// <returns>The OpenXml collection element instance, or null if not set.</returns>
  public override OpenXmlCollectionType? GetUpdatableElement()
  {
    return _openXmlCollection;
  }

  /// <summary>
  ///   Assigns the wrapped OpenXml collection element instance.
  /// </summary>
  /// <param name="element">The OpenXml collection element to assign.</param>
  public void SetUpdatableElement(OpenXmlCollectionType? element)
  {
    _openXmlCollection = element;
  }
  /// <summary>
  ///   Loads data from the specified OpenXml element into this value collection.
  ///   Sets the isLoading flag to true while loading data to avoid unnecessary updates by collection change events.
  /// </summary>
  /// <param name="openXmlObject">The OpenXml element to load data from.</param>
  public override void LoadData(object openXmlObject)
  {
    isLoading = true;
    if (openXmlObject is OpenXmlCollectionType openXmlModeledElement)
    {
      LoadDataCollection(openXmlModeledElement);
    }
    isLoading = false;
  }

  /// <summary>
  ///   Loads data from the modeled OpenXml collection into this value collection instance.
  ///   Must be implemented by derived classes to define the mapping logic.
  /// </summary>
  /// <param name="openXmlModeledCollection">The OpenXml collection to load data from.</param>
  protected abstract void LoadDataCollection(OpenXmlCollectionType openXmlModeledCollection);

  /// <summary>
  ///   Stores data from this value collection to the specified OpenXml element.
  ///   Calls the abstract <see cref="UpdateDataCollection"/> method for the actual mapping logic.
  /// </summary>
  /// <param name="openXmlObject">The OpenXml element to store data to.</param>
  public override void UpdateData(object openXmlObject)
  {
    if (openXmlObject is OpenXmlCollectionType openXmlModeledElement)
    {
      UpdateDataCollection(openXmlModeledElement);
    }
  }

  /// <summary>
  ///   Stores data from this value collection instance to the modeled OpenXml collection.
  ///   Must be implemented by derived classes to define the mapping logic.
  /// </summary>
  /// <param name="openXmlModeledCollection">The OpenXml collection to store data to.</param>
  protected abstract void UpdateDataCollection(OpenXmlCollectionType openXmlModeledCollection);
}
