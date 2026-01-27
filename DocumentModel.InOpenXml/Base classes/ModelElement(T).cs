namespace DocumentModel;

/// <summary>
/// Represents a model element that wraps an OpenXml element of the specified type.
/// </summary>
/// <typeparam name="OpenXmlType">The type of the underlying OpenXml element.</typeparam>
public abstract class ModelElement<OpenXmlType> : ModelElement, IWordprocessingDocumentAware
where OpenXmlType : DX.OpenXmlElement // this constraint can cause issue with PackageProperties
{
  private OpenXmlType? _openXmlElement;

  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public DXPP.WordprocessingDocument? WordprocessingDocument
  {
    get
    {
      if (_WordprocessingDocument != null)
        return _WordprocessingDocument;
      if (Collection != null)
        if (Collection is IWordprocessingDocumentAware collectionAware)
          return collectionAware.WordprocessingDocument;
      if (Parent != null)
        if (Parent is IWordprocessingDocumentAware parentAware)
          return parentAware.WordprocessingDocument;

      return null;
    }

    [DebuggerStepThrough]
    private set => _WordprocessingDocument = value;
  }

  private DXPP.WordprocessingDocument? _WordprocessingDocument;

  /// <summary>
  /// Initializes a new instance of the <see cref="ModelElement{OpenXmlItemType}"/> class.
  /// </summary>
  protected ModelElement()
  {
  }

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
  /// Initializes a new instance of the <see cref="ModelElement{OpenXmlItemType}"/> class with the specified OpenXml element.
  /// </summary>
  /// <param name="openXmlElement">The OpenXml element to wrap.</param>
  protected ModelElement(OpenXmlType? openXmlElement)
  {
    _openXmlElement = openXmlElement;
  }

  /// <summary>
  /// Returns the wrapped OpenXml element instance.
  /// </summary>
  /// <returns>The OpenXml element instance, or null if not set.</returns>
  public virtual OpenXmlType? GetOpenXmlElement()
  {
    return _openXmlElement;
  }

  /// <summary>
  /// Assigns the wrapped OpenXml element instance.
  /// </summary>
  /// <param name="element">The OpenXml element to assign.</param>
  public virtual void SetOpenXmlElement(OpenXmlType? element)
  {
    _openXmlElement = element;
  }

  /// <summary>
  /// Returns the OpenXml element instance for update operations.
  /// </summary>
  /// <returns>The OpenXml element instance, or null if not set.</returns>
  protected override object? GetUpdatableOpenXmlElement()
  {
    return _openXmlElement;
  }


}