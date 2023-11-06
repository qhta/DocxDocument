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

  internal DXCP.CustomDocumentProperty _ExistingElement 
  { 
    get
    {
      if (_Element == null)
        _Element = new DXCP.CustomDocumentProperty();
      return _Element;
    }
    private set => _Element=value;
  }


  [DataMember]
  public string? Name
  {
    get => _Element?.Name?.Value;
    set
    {
      if (value != null)
        _ExistingElement.Name = value;
      else
        _ExistingElement.Name = null;
    }
  }

  [DataMember]
  public int? Id
  {
    get => _Element?.PropertyId?.Value;
    set
    {
      if (value != null)
        _ExistingElement.PropertyId = value;
      else
        _ExistingElement.PropertyId = null;
    }
  }

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
        if (childItem is DX.OpenXmlLeafTextElement vtOther)
          return vtOther.AsObject();
      }
      return null;
    }
  }
}
