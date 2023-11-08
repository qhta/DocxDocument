namespace DocumentModel.CustomProperties;


/// <summary>
///   Custom File Property.
/// </summary>
public partial class CustomDocumentProperty: ModelElement<DXCP.CustomDocumentProperty>
{
  public CustomDocumentProperty(): base(){ }
  
  public CustomDocumentProperty(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CustomDocumentProperty(DXCP.CustomDocumentProperty openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Format ID
  /// </summary>
  [DataMember]
  public String? FormatId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.FormatId);
    }
    set
    {
      _ExistingElement.FormatId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Property ID
  /// </summary>
  [DataMember]
  public Int32? PropertyId
  {
    get
    {
      return _Element?.PropertyId?.Value;
    }
    set
    {
      _ExistingElement.PropertyId = value;
    }
  }
  
  
  /// <summary>
  ///   Custom File Property Name
  /// </summary>
  [DataMember]
  public String? Name
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Name);
    }
    set
    {
      _ExistingElement.Name = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Bookmark Link Target
  /// </summary>
  [DataMember]
  public String? LinkTarget
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.LinkTarget);
    }
    set
    {
      _ExistingElement.LinkTarget = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
