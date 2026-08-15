namespace DocumentModel;
/// <summary>
///   Represents a collection of values associated with an OpenXml collection, providing synchronization between the document model and OpenXml elements.
///   Supports loading, updating, and detaching data from WordprocessingML or other OpenXml-based collections.
/// </summary>
/// <typeparam name = "ItemType">Specifies the type of items contained in the value collection.</typeparam>
/// <typeparam name = "OpenXmlCollectionType">Specifies the type of the OpenXml collection element being wrapped and synchronized.</typeparam>
[DataContract]
[XmlRoot("ValueCollection", Namespace = "DocumentModel")]
public abstract class ValueCollection<ItemType, OpenXmlCollectionType> : ElementCollection<ItemType>, IWordprocessingDocumentAware where ItemType : notnull where OpenXmlCollectionType : DX.OpenXmlElement
{
  /// <summary>
  /// OpenXml collection element that this model element collection wraps and synchronizes with. Can be null if not attached to an OpenXml element.
  /// </summary>
  protected OpenXmlCollectionType? SourceOpenXmlCompositeElement
  {
    get => DataSource as OpenXmlCollectionType;
    set => DataSource = value;
  }

  /// <summary>
  /// Data source for lazy loading. 
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public object? DataSource { [DebuggerStepThrough] get; set; }

  /// <summary>
  /// Source collection for lazy loading.
  /// If the DataSource is an OpenXmlCompositeElement, this property returns its child elements;
  /// otherwise, it returns DataSource as IEnumerable&lt;DX.OpenXmlElement&gt;.
  /// Setting this property updates the DataSource.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public virtual IEnumerable<DX.OpenXmlElement>? SourceCollection
  {
    get => DataSource is DX.OpenXmlCompositeElement openXmlElement ? openXmlElement.Elements() :
      DataSource as IEnumerable<DX.OpenXmlElement>;
    set => DataSource = value;
  }
  /// <summary>
  ///   The WordprocessingDocument instance to which this value collection is attached, or null if not attached.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public DXPP.WordprocessingDocument? WordprocessingDocument { get; private set; }


  /// <summary>
  ///   Initializes a new instance of the <see cref = "ValueCollection{ItemType, OpenXmlCollectionType}"/> class.
  ///   Subscribes to collection change events to synchronize with the underlying OpenXml collection.
  /// </summary>
  /// <remarks>
  /// It must be public to fulfill JsonSerialization requirements.
  /// </remarks>
  // ReSharper disable once PublicConstructorInAbstractClass
  public ValueCollection()
  {
    InitCollectionChangedEventHandler();
  }

  /// <summary>
  ///   Initializes a new instance of the <see cref = "ValueCollection{ItemType, OpenXmlCollectionType}"/> class with the specified OpenXml element.
  /// </summary>
  /// <param name="parent">The parent model element.</param>
  /// <param name = "openXmlElement">The OpenXml collection element to wrap and synchronize with.</param>
  protected ValueCollection(ModelElement parent, DX.OpenXmlElement? openXmlElement = null) : base(parent)
  {
    DataSource = openXmlElement;
    if (SourceOpenXmlCompositeElement != null && this.GetType().GetCustomAttribute<DirectAccessAttribute>() == null)
      LoadData(SourceOpenXmlCompositeElement);
    InitCollectionChangedEventHandler();
  }

  /// <summary>
  /// Initializes collection changed event handler to update data on change.
  /// </summary>
  private void InitCollectionChangedEventHandler()
  {
    CollectionChanged += (sender, e) =>
    {
      //Debug.WriteLine($"CollectionChanged event triggered. Action: {e.Action}, IsLoading: {IsLoading}, OpenXmlCollection: {SourceOpenXmlCompositeElement}");
      if (IsLoading || SourceOpenXmlCompositeElement == null)
        return;
      if (e.Action == NotifyCollectionChangedAction.Add || e.Action == NotifyCollectionChangedAction.Remove || e.Action == NotifyCollectionChangedAction.Replace || e.Action == NotifyCollectionChangedAction.Reset)
      {
        //Debug.WriteLine($"Updating data for OpenXmlCollection: {SourceOpenXmlCompositeElement}");
        UpdateData(SourceOpenXmlCompositeElement);
      }
    };
  }

  /// <summary>
  ///   Attaches this value collection to the specified WordprocessingDocument.
  /// </summary>
  /// <param name = "wordprocessingDocument">The WordprocessingDocument to attach to.</param>
  public virtual void Attach(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    WordprocessingDocument = wordprocessingDocument;
  }

  /// <summary>
  /// Attaches the specified WordprocessingDocument and loads its associated data into the current instance.
  /// </summary>
  /// <remarks>This method combines the attachment of a WordprocessingDocument with the loading of its data,
  /// ensuring that the current instance is initialized and ready for further operations. If the document is already
  /// attached, calling this method will reload its data.</remarks>
  /// <param name="wordprocessingDocument">The WordprocessingDocument to attach and load data from. Cannot be null.</param>
  public virtual void AttachAndLoad(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    Attach(wordprocessingDocument);
    LoadData();
  }

  /// <summary>
  /// Attaches the specified WordprocessingDocument to the current instance and updates its data.
  /// </summary>
  /// <param name="wordprocessingDocument">The WordprocessingDocument to attach and update. Cannot be null.</param>
  public virtual void AttachAndUpdate(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    Attach(wordprocessingDocument);
    UpdateData();
  }

  /// <summary>
  ///   Detaches this value collection from the attached document, clearing the underlying OpenXml element reference.
  ///   After detaching, further access to OpenXml properties is not possible until re-attached.
  /// </summary>
  public virtual void Detach()
  {
    WordprocessingDocument = null;
    SetUpdatableObject(null);
  }

  /// <summary>
  /// Override of LoadData that loads data from the attached OpenXmlCollection. Returns false if the OpenXmlCollection is not attached.
  /// </summary>
  public override bool LoadData()
  {
    if (SourceOpenXmlCompositeElement != null)
    {
      LoadData(SourceOpenXmlCompositeElement);
      return true;
    } 
    return false;
  }

  /// <summary>
  /// Override of UpdateData that updates the attached OpenXmlCollection with current data. Returns false if the OpenXmlCollection is not attached.
  /// </summary>
  public override bool UpdateData()
  {
    if (SourceOpenXmlCompositeElement != null)
    {
      UpdateData(SourceOpenXmlCompositeElement);
      return true;
    } 
    return false;
  }


  /// <summary>
  ///   Returns the wrapped OpenXml collection element instance, or null if not set.
  /// </summary>
  /// <returns>The OpenXml collection element instance, or null if not set.</returns>
  public override object? GetUpdatableObject()
  {
    return SourceOpenXmlCompositeElement ?? (Parent as IUpdatable)?.GetUpdatableObject() as OpenXmlCollectionType;
  }

  /// <summary>
  ///   Assigns the wrapped OpenXml collection element instance.
  /// </summary>
  /// <param name = "element">The OpenXml collection element to assign.</param>
  public void SetUpdatableObject(OpenXmlCollectionType? element)
  {
    if (element is null)
      SourceOpenXmlCompositeElement = null;
    else if (element is OpenXmlCollectionType openXmlCollection)
      SourceOpenXmlCompositeElement = openXmlCollection;
    else
      throw new ArgumentException($"Expected an element of type {typeof(OpenXmlCollectionType).FullName}, but received {element.GetType().FullName}.");
  }

  /// <summary>
  ///   Loads data from the specified OpenXml element into this value collection.
  ///   Sets the isLoading flag to true while loading data to avoid unnecessary updates by collection change events.
  /// </summary>
  /// <param name = "openXmlObject">The OpenXml element to load data from.</param>
  public new bool LoadData(object openXmlObject)
  {
    if (openXmlObject is OpenXmlCollectionType openXmlModeledElement)
    {
      return LoadDataCollection(openXmlModeledElement);
    }
    return false;
  }

  /// <summary>
  ///   Loads data from the modeled OpenXml collection into this value collection instance.
  ///   Must be implemented by derived classes to define the mapping logic.
  /// </summary>
  /// <param name = "openXmlModeledCollection">The OpenXml collection to load data from.</param>
  protected abstract bool LoadDataCollection(OpenXmlCollectionType openXmlModeledCollection);

  /// <summary>
  ///   Stores data from this value collection to the specified OpenXml element.
  ///   Calls the abstract <see cref = "UpdateDataCollection"/> method for the actual mapping logic.
  /// </summary>
  /// <param name = "openXmlObject">The OpenXml element to store data to.</param>
  public override bool UpdateData(object openXmlObject)
  {
    if (openXmlObject is OpenXmlCollectionType openXmlModeledElement)
    {
      return UpdateDataCollection(openXmlModeledElement);
    }
    return false;
  }

  /// <summary>
  ///   Stores data from this value collection instance to the modeled OpenXml collection.
  ///   Must be implemented by derived classes to define the mapping logic.
  /// </summary>
  /// <param name = "openXmlModeledCollection">The OpenXml collection to store data to.</param>
  protected abstract bool UpdateDataCollection(OpenXmlCollectionType openXmlModeledCollection);
}