namespace DocumentModel;

/// <summary>
/// Collection of Values that is associated with an OpenXml collection.
/// </summary>
/// <typeparam name="ItemType">The type of items in the collection.</typeparam>
/// <typeparam name="OpenXmlCollectionType">The type of the OpenXml collection.</typeparam>
public abstract class ValueCollection<ItemType, OpenXmlCollectionType> : ElementCollection<ItemType>,
  IWordprocessingDocumentAware
  where OpenXmlCollectionType : DX.OpenXmlElement
{
  private OpenXmlCollectionType? _openXmlCollection;

  protected bool isLoading;

  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public DXPP.WordprocessingDocument? WordprocessingDocument { get; private set; }

  /// <summary>
  /// Attach this instance to the specified wordprocessingDocument. Data is loaded from the wordprocessingDocument's PackageProperties.
  /// </summary>
  /// <param name="wordprocessingDocument">Document to attach to.</param>
  public virtual void AttachAndLoad(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    WordprocessingDocument = wordprocessingDocument;
  }

  /// <summary>
  /// Attach this instance to the specified wordprocessingDocument. Data is stored to the wordprocessingDocument's PackageProperties.
  /// </summary>
  /// <param name="wordprocessingDocument">Document to attach to.</param>
  public virtual void AttachAndUpdate(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    WordprocessingDocument = wordprocessingDocument;
  }


  /// <summary>
  /// Detach this instance from the attached document.
  /// Underlying Open XML element is set to null, so further access to its properties will not work until re-attached.
  /// </summary>
  public virtual void Detach()
  {
    WordprocessingDocument = null;
    SetOpenXmlElement(null);
  }


  /// <summary>
  /// Initializes a new instance of the <see cref="ModelElement{OpenXmlItemType}"/> class.
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
  /// Initializes a new instance of the <see cref="ModelElement{OpenXmlItemType}"/> class with the specified OpenXml element.
  /// </summary>
  /// <param name="openXmlCollection">The OpenXml element to wrap.</param>
  protected ValueCollection(OpenXmlCollectionType? openXmlCollection) : this()
  {
    _openXmlCollection = openXmlCollection;
  }

  protected ValueCollection(IEnumerable<ItemType> items) : this()
  {
    foreach (var item in items)
    {
      Add(item);
    }
  }

  /// <summary>
  /// Returns the wrapped OpenXml element instance.
  /// </summary>
  /// <returns>The OpenXml element instance, or null if not set.</returns>
  public OpenXmlCollectionType? GetOpenXmlElement()
  {
    return _openXmlCollection;
  }

  /// <summary>
  /// Assigns the wrapped OpenXml element instance.
  /// </summary>
  /// <param name="element">The OpenXml element to assign.</param>
  public void SetOpenXmlElement(OpenXmlCollectionType? element)
  {
    _openXmlCollection = element;
  }

  /// <summary>
  /// Returns the OpenXml element instance for update operations.
  /// </summary>
  /// <returns>The OpenXml element instance, or null if not set.</returns>
  protected override object? GetUpdatableOpenXmlElement()
  {
    return _openXmlCollection;
  }


  /// <summary>
  /// Override to load data using the specified OpenXml element.
  /// </summary>
  /// <param name="openXmlElement">The OpenXml element to load data from.</param>
  /// <remarks>Sets the isLoading flag to true while loading data.
  /// It avoids unnecessary updates by OnCollectionChanged event.</remarks>
  public override void LoadData(object openXmlElement)
  {
    isLoading = true;
    if (openXmlElement is OpenXmlCollectionType openXmlModeledElement)
    {
      LoadDataCollection(openXmlModeledElement);
    }
    isLoading = false;
  }


  /// <summary>
  /// Abstract method to load data from the modeled OpenXml collection to this instance.
  /// </summary>
  /// <param name="openXmlModeledCollection">The OpenXml collection to load data from.</param>
  protected abstract void LoadDataCollection(OpenXmlCollectionType openXmlModeledCollection);


  /// <summary>
  /// Override to store data to the specified OpenXml element.
  /// </summary>
  /// <param name="openXmlElement">The OpenXml element to store data to.</param>
  public override void UpdateData(object openXmlElement)
  {
    if (openXmlElement is OpenXmlCollectionType openXmlModeledElement)
    {
      UpdateDataCollection(openXmlModeledElement);
    }
  }

  /// <summary>
  /// Abstract method to store data from this instance to the modeled OpenXml collection.
  /// </summary>
  /// <param name="openXmlModeledCollection">The OpenXml collection to store data to.</param>
  protected abstract void UpdateDataCollection(OpenXmlCollectionType openXmlModeledCollection);

}
