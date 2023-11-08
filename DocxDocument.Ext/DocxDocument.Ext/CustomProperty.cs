namespace DocumentModel;

/// <summary>
/// This class specifies a single custom file property. 
/// Custom file property type is defined through child elements in the File Properties Variant Type namespace. 
/// Custom file property value can be set by setting the appropriate Variant Type child element value.
/// </summary>
[DataContract]
public class CustomProperty: ModelElement<DXCP.CustomDocumentProperty>
{
  public CustomProperty(): base(){ }

  public CustomProperty(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }

  public CustomProperty(DXCP.CustomDocumentProperty openXmlElement): base(openXmlElement) { } 

  [DataMember]
  public string? Name
  {
    get => _Element?.Name?.Value;
    set => _ExistingElement.Name = value;
  }

  [DataMember]
  public int? Id
  {
    get => _Element?.PropertyId?.Value;
    set => _ExistingElement.PropertyId = value;
  }

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

  [DataMember]
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
