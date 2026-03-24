namespace DocumentModel;
/// <summary>
///   Represents a model element that wraps an OpenXml element of the specified type, providing synchronization and data binding between the document model and OpenXml representation.
///   Supports loading, updating, and detaching data from WordprocessingML or other OpenXml-based elements.
/// </summary>
/// <typeparam name="OpenXmlType">Specifies the type of the underlying OpenXml element being wrapped and synchronized.</typeparam>
public abstract partial class ModelElement<OpenXmlType> : ModelElement, IWordprocessingDocumentAware, IUpdatable
where OpenXmlType : DX.OpenXmlElement // this constraint can cause issue with PackageProperties
{
  private OpenXmlType? _openXmlElement;

  /// <summary>
  ///   The WordprocessingDocument instance to which this model element is attached, or null if not attached.
  ///   This property resolves the document context by checking the current element, its collection, or its parent.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public DXPP.WordprocessingDocument? WordprocessingDocument
  {
    //[DebuggerStepThrough]
    get
    {
      if (_WordprocessingDocument != null)
        return _WordprocessingDocument;
      if (Collection is IWordprocessingDocumentAware collectionAware)
        return collectionAware.WordprocessingDocument;
      if (Parent is IWordprocessingDocumentAware parentAware)
        return parentAware.WordprocessingDocument;
      return null;
    }
    [DebuggerStepThrough]
    private set => _WordprocessingDocument = value;
  }
  private DXPP.WordprocessingDocument? _WordprocessingDocument;

  /// <summary>
  ///   Initializes a new instance of the <see cref="ModelElement{Format}"/> class.
  /// </summary>
  protected ModelElement()
  {
  }

  /// <summary>
  ///   Attaches this model element to the specified WordprocessingDocument and loads data from the document's package properties or OpenXml part.
  /// </summary>
  /// <param name="wordprocessingDocument">The WordprocessingDocument to attach to and load data from.</param>
  public virtual void AttachAndLoad(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    WordprocessingDocument = wordprocessingDocument;
  }

  /// <summary>
  ///   Attaches this model element to the specified WordprocessingDocument and updates the document's package properties or OpenXml part with current data.
  /// </summary>
  /// <param name="wordprocessingDocument">The WordprocessingDocument to attach to and update.</param>
  public virtual void AttachAndUpdate(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    WordprocessingDocument = wordprocessingDocument;
  }

  /// <summary>
  ///   Detaches this model element from the attached document, clearing the underlying OpenXml element reference.
  ///   After detaching, further access to OpenXml properties is not possible until re-attached.
  /// </summary>
  public virtual void Detach()
  {
    WordprocessingDocument = null;
    SetUpdatableElement(null);
  }

  /// <summary>
  ///   Initializes a new instance of the <see cref="ModelElement{Format}"/> class with the specified OpenXml element.
  /// </summary>
  /// <param name="openXmlElement">The OpenXml element to wrap and synchronize with.</param>
  protected ModelElement(OpenXmlType? openXmlElement)
  {
    _openXmlElement = openXmlElement;
  }

  /// <summary>
  ///   Assigns the wrapped OpenXml element instance.
  /// </summary>
  /// <param name="element">The OpenXml element to assign.</param>
  public virtual void SetUpdatableElement(object? element)
  {
    if (element == null)
      _openXmlElement = null;
    else
    if (element is OpenXmlType openXmlElement)
      _openXmlElement = openXmlElement;
    else
      throw new ArgumentException(
        $"Expected an element of type {typeof(OpenXmlType).FullName}, but received {element.GetType().FullName}.");
  }

  /// <summary>
  ///   Returns the OpenXml element instance for update operations, or null if not set.
  /// </summary>
  /// <returns>The OpenXml element instance, or null if not set.</returns>
  public override object? GetUpdatableElement()
  {
    return _openXmlElement;
  }

}