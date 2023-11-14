namespace DocumentModel;

/// <summary>
/// This class specifies a single custom file property. 
/// Custom file property type is defined through child elements in the File Properties Variant Type namespace. 
/// Custom file property value can be set by setting the appropriate Variant Type child element value.
/// </summary>
[DataContract]
public class CustomProperty: ModelElement<DXCP.CustomDocumentProperty>, IIdentifiedElement
{
  /// <summary>
  /// Default constructor.
  /// </summary>
  public CustomProperty(): base(){ }

  /// <summary>
  /// Constructor with any OpenXmlElement parameter.
  /// </summary>
  /// <param name="openXmlElement"></param>
  public CustomProperty(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }

  /// <summary>
  /// Constructor with OpenXml CustomDocumentProperty parameter.
  /// </summary>
  /// <param name="openXmlCustomDocumentProperty"></param>
  public CustomProperty(DXCP.CustomDocumentProperty openXmlCustomDocumentProperty): base(openXmlCustomDocumentProperty) { } 

  /// <summary>
  /// Readable name of the property.
  /// </summary>
  [DataMember]
  public string? Name
  {
    get => _Element?.Name?.Value;
    set => _ExistingElement.Name = value;
  }

  /// <summary>
  /// Persistent Id of the property. Should start from 2.
  /// </summary>
  [DataMember]
  public int? Id
  {
    get => _Element?.PropertyId?.Value;
    set => _ExistingElement.PropertyId = value;
  }

  /// <summary>
  /// Format identifier of the property. Should be set to {D5CDD505-2E9C-101B-9397-08002B2CF9AE}.
  /// </summary>
  [DataMember]
  public Guid? FormatId
  {
    get => _Element?.FormatId?.AsGuid();
    set
    {
      if (value != null)
        _ExistingElement.FormatId = value.ToString();
      else
        _ExistingElement.FormatId = null;
    }
  }

  /// <summary>
  /// Optional bookmark link target.
  /// </summary>
  [DataMember]
  public string? LinkTarget
  {
    get => _Element?.LinkTarget?.Value;
    set
    {
      if (value != null)
        _ExistingElement.LinkTarget = value;
      else
        _ExistingElement.LinkTarget = null;
    }
  }

  /// <summary>
  /// Object value of the property. Must be convertible to any OpenXml VTVariant type.
  /// </summary>
  [DataMember]
  [TypeConverter(typeof(Qhta.Conversion.ValueTypeConverter))]
  public object? Value
  {
    get
    {
      var childItem = _ExistingElement.ChildElements.FirstOrDefault();
      if (childItem!=null)
      {
        if (childItem is DXVT.VTVector vtVector)
          return vtVector.AsArray();
        if (childItem is DXVT.VTArray vtArray)
          return vtArray.AsArray();
        return childItem.AsObject();
      }
      return null;
    }
    set
    {
      var _element = _ExistingElement.Elements().FirstOrDefault();
      if (_element!=null)
        _element.Remove();
      var childItem = value.AsVTVariant();
      if (childItem != null) 
        _ExistingElement.AddChildElement(childItem);
    }
  }
}
