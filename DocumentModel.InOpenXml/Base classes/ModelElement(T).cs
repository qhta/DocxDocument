namespace DocumentModel;
/// <summary>
///   Represents a model element that wraps an OpenXml element of the specified type, providing synchronization and data binding between the document model and OpenXml representation.
///   Supports loading, updating, and detaching data from WordprocessingML or other OpenXml-based elements.
/// </summary>
/// <typeparam name = "OpenXmlType">Specifies the type of the underlying OpenXml element being wrapped and synchronized.</typeparam>
[XmlRoot("ModelElement", Namespace = "DocumentModel")]
public abstract partial class ModelElement<OpenXmlType> : ModelElement, 
  IWordprocessingDocumentAware, IUpdatable, IDirectAccessElement
  where OpenXmlType : DX.OpenXmlElement // this constraint can cause issue with PackageProperties
{

  /// <summary>
  ///   Initializes a new instance of the <see cref = "ModelElement{Format}"/> class.
  /// </summary>
  protected ModelElement()
  {
  }

  /// <summary>
  /// Initializes a new instance of the ModelElement class with the specified parent element. 
  /// </summary>
  /// <param name="parent">The parent ModelElement that contains this element. Can be null if the element has no parent.</param>
  protected ModelElement(ModelElement parent) : base(parent)
  {
  }

  /// <summary>
  /// Initializes a new instance of the ModelElement class with the specified parent element and Open XML element.  
  /// </summary>
  /// <param name="parent">The parent ModelElement that contains this element. Can be null if this is a root element.</param>
  /// <param name="openXmlElement">The OpenXmlElement that provides the underlying Open XML data for this model element. Must not be null.</param>
  protected ModelElement(ModelElement parent, DX.OpenXmlElement? openXmlElement) : base(parent)
  {
    _UpdatableElement = (OpenXmlType?)openXmlElement;
  }


  /// <summary>
  ///   Initializes a new instance of the <see cref = "ModelElement{Format}"/> class with the specified OpenXml element.
  /// </summary>
  /// <param name = "openXmlElement">The OpenXml element to wrap and synchronize with. It can't be null</param>
  protected ModelElement(DX.OpenXmlElement openXmlElement)
  {
    _UpdatableElement = (OpenXmlType)openXmlElement;
  }

  /// <summary>
  /// Copies data from the specified other instance to this instance.
  /// </summary>
  /// <param name = "otherInstance">The instance containing the model property values to copy.</param>
  public override void CopyFrom(ModelElement otherInstance)
  {
    base.CopyFrom(otherInstance);

    var updatableElement = GetUpdatableElement();
    if (updatableElement != null)
      UpdateData(updatableElement);
  }

  /// <summary>
  /// Represents the underlying Open XML element associated with this instance, or null if no element is present.
  /// </summary>
  /// <remarks>This field is intended for use by derived classes to access or manipulate the Open XML element
  /// that backs the current object. The value may be null if the instance has not been initialized with an Open XML
  /// element.</remarks>
  protected OpenXmlType? _UpdatableElement;


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
  ///   Attaches this model element to the specified WordprocessingDocument.
  /// </summary>
  /// <param name = "wordprocessingDocument">The WordprocessingDocument to attach to.</param>
  public virtual void Attach(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    WordprocessingDocument = wordprocessingDocument;
  }

  /// <summary>
  ///   Attaches this model element to the specified WordprocessingDocument and loads data from the document's package properties or OpenXml part.
  /// </summary>
  /// <param name = "wordprocessingDocument">The WordprocessingDocument to attach to and load data from.</param>
  public virtual void AttachAndLoad(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    Attach(wordprocessingDocument);
    LoadData();
  }

  /// <summary>
  ///   Attaches this model element to the specified WordprocessingDocument and updates the document's package properties or OpenXml part with current data.
  /// </summary>
  /// <param name = "wordprocessingDocument">The WordprocessingDocument to attach to and update.</param>
  public virtual void AttachAndUpdate(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    Attach(wordprocessingDocument);
    UpdateData();
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
  ///   Assigns the wrapped OpenXml element instance.
  /// </summary>
  /// <param name = "element">The OpenXml element to assign.</param>
  public virtual void SetUpdatableElement(object? element)
  {
    if (element == null)
      _UpdatableElement = null;
    else if (element is OpenXmlType openXmlElement)
      _UpdatableElement = openXmlElement;
    else
      throw new ArgumentException($"Expected an element of type {typeof(OpenXmlType).FullName}, but received {element.GetType().FullName}.");
  }

  /// <summary>
  ///   Returns the OpenXml element instance for update operations, or null if not set.
  /// </summary>
  /// <returns>The OpenXml element instance, or null if not set.</returns>
  public override object? GetUpdatableElement()
  {
    return _UpdatableElement;
  }

  /// <summary>
  /// Override of LoadData that loads data from the attached OpenXmlElement.
  /// </summary>
  public override bool LoadData()
  {
    var updatableElement = GetUpdatableElement();
    if (updatableElement != null)
    {
      LoadData(updatableElement);
      return true;
    }
    return false;
  }

  /// <summary>
  /// Override of UpdateData that updates the attached OpenXmlElement with current data. 
  /// </summary>
  public override bool UpdateData()
  {
    var updatableElement = GetUpdatableElement(); 
    if (updatableElement != null)
    {
      UpdateData(updatableElement);
      return true;
    }
    return false;
  }

  /// <summary>
  /// Checks if the current model element has direct access to its underlying OpenXmlElement, based on the presence of the DirectAccessAttribute and the non-null state of the _openXmlElement field.
  /// </summary>
  public bool HasDirectAccess => _UpdatableElement != null 
                                 && this.GetType().GetCustomAttribute<DirectAccessAttribute>()?.IsEnabled == true;
}