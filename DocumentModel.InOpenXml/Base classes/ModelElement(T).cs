using Qhta.OpenXmlTools;

namespace DocumentModel;
/// <summary>
///   Represents a model element that wraps an OpenXml element of the specified type, providing synchronization and data binding between the document model and OpenXml representation.
///   Supports loading, updating, and detaching data from WordprocessingML or other OpenXml-based elements.
/// </summary>
/// <typeparam name = "OpenXmlType">Specifies the type of the underlying OpenXml element being wrapped and synchronized.</typeparam>
[DataContract]
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
    _HasDirectAccess = this.GetType().GetCustomAttribute<DirectAccessAttribute>()?.IsEnabled == true;
  }

  /// <summary>
  /// Initializes a new instance of the ModelElement class with the specified parent element. 
  /// </summary>
  /// <param name="parent">The parent ModelElement that contains this element. Can be null if the element has no parent.</param>
  protected ModelElement(ModelElement parent) : base(parent)
  {
    _HasDirectAccess = this.GetType().GetCustomAttribute<DirectAccessAttribute>()?.IsEnabled == true;
  }

  /// <summary>
  /// Initializes a new instance of the ModelElement class with the specified parent element and Open XML element.  
  /// </summary>
  /// <param name="parent">The parent ModelElement that contains this element. Can be null if this is a root element.</param>
  /// <param name="openXmlElement">The OpenXmlElement that provides the underlying Open XML data for this model element. Must not be null.</param>
  protected ModelElement(ModelElement parent, DX.OpenXmlElement? openXmlElement) : base(parent)
  {
    _HasDirectAccess = this.GetType().GetCustomAttribute<DirectAccessAttribute>()?.IsEnabled == true;
    SetUpdatableObject((OpenXmlType?)openXmlElement);
  }


  /// <summary>
  ///   Initializes a new instance of the <see cref = "ModelElement{Format}"/> class with the specified OpenXml element.
  /// </summary>
  /// <param name = "openXmlElement">The OpenXml element to wrap and synchronize with. It can't be null</param>
  protected ModelElement(DX.OpenXmlElement openXmlElement)
  {
    _HasDirectAccess = this.GetType().GetCustomAttribute<DirectAccessAttribute>()?.IsEnabled == true;
    SetUpdatableObject((OpenXmlType)openXmlElement);
  }

  /// <summary>
  ///  Gets the underlying Open XML element that can be updated by this model element.
  /// </summary>
  public object? DataSource => GetUpdatableObject();

  /// <summary>
  /// Gets the target model item type corresponding to the specified OpenXml element type, based on the defined mapping between OpenXml element types and model element types.
  /// </summary>
  /// <param name="openXmlElement">The OpenXml element for which to get the corresponding model item type.</param>
  /// <returns>The target model item type corresponding to the specified OpenXml element.</returns>
  /// <exception cref="NotSupportedException"></exception>
  public virtual Type GetTargetModelItemType(DX.OpenXmlElement openXmlElement)
  {
    return OpenXmlElementMapper.OpenXml2ModelElementTypeMapping[openXmlElement.GetType()];
  }

  /// <summary>
  /// Gets or sets the underlying Open XML element that can be updated by this model element.
  /// It can be an OpenXmlElement or any other object that represents the data source for this model.
  /// If null, no updates will be performed.
  /// </summary>
  public OpenXmlType? GetUpdatableElement()
  {
    return base.GetUpdatableObject() as OpenXmlType;
  }

  ///// <summary>
  ///// Copies data from the specified other instance to this instance.
  ///// </summary>
  ///// <param name = "otherInstance">The instance containing the model property values to copy.</param>
  //public override void CopyFrom(ModelElement otherInstance)
  //{
  //  base.CopyFrom(otherInstance);

  //  var updatableElement = GetUpdatableElement();
  //  if (updatableElement != null)
  //    UpdateData(updatableElement);
  //}


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
    SetUpdatableObject(null);
  }

  /// <summary>
  /// Override of LoadData that loads data from the attached OpenXmlElement.
  /// </summary>
  public override bool LoadData()
  {
    var updatableObject = GetUpdatableObject();
    if (updatableObject != null)
    {
      LoadData(updatableObject);
      return true;
    }
    return base.LoadData();
  }

  /// <summary>
  /// Override of UpdateData that updates the attached OpenXmlElement with current data. 
  /// </summary>
  public override bool UpdateData()
  {
    var updatableObject = GetUpdatableObject();
    if (updatableObject != null)
    {
      UpdateData(updatableObject);
      return true;
    }
    return base.UpdateData();
  }

  /// <summary>
  /// Checks if the current model element has direct access to its underlying OpenXmlElement, based on the presence of the DirectAccessAttribute and the non-null state of the _openXmlElement field.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  public bool HasDirectAccess => _HasDirectAccess;

  private bool _HasDirectAccess;

  /// <summary>
  /// Sets the HasDirectAccess property to the specified value, indicating whether the model element has direct access to its underlying OpenXml element.
  /// </summary>
  /// <param name="value"></param>
  public void SetHasDirectAccess(bool value) => _HasDirectAccess = value;

  public override ModelElement? Next
  {
    get
    {
      if (Collection is IList list)
      {
        int index = list.IndexOf(this);
        if (index >= 0 && index < list.Count - 1)
          return list[index + 1] as ModelElement;
      }
      if (DataSource is DX.OpenXmlCompositeElement sourceCompositeElement)
      {
        var nextElement = sourceCompositeElement.NextElement();
        if (nextElement != null)
          return (ModelElement?)OpenXmlElementConverter.ConvertFrom(nextElement, GetTargetModelItemType(nextElement));
      }

      if (Parent is IDirectAccessElement directAccessElement && directAccessElement.HasDirectAccess)
      {
        var dataSource = directAccessElement.DataSource;
        if (dataSource is DX.OpenXmlCompositeElement compositeElement)
        {
          var nextElement = compositeElement.NextElement();
          if (nextElement != null)
            return (ModelElement?)OpenXmlElementConverter.ConvertFrom(nextElement, directAccessElement.GetTargetModelItemType(nextElement));
        }

        //var updatableObject = GetUpdatableObject();
        //if (updatableObject is DX.OpenXmlCompositeElement openXmlElement)
        //{
        //  var nextElement = openXmlElement.NextSibling();
        //  if (nextElement!=null)
        //    return OpenXmlElementConverter.ConvertFrom(nextElement, GetTargetModelItemType(nextElement));
      }
      return null;
    }
  }
}