namespace DocumentModel.CustomXml;


/// <summary>
///   Custom XML Schema Reference.
/// </summary>
public partial class Schema: ModelElement<DXCXSR.Schema>
{
  public Schema(): base(){ }
  
  public Schema(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Schema(DXCXSR.Schema openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Custom XML Schema Namespace
  /// </summary>
  [DataMember]
  public String? Uri
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Uri);
    }
    set
    {
      _ExistingElement.Uri = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Resource File Location
  /// </summary>
  [DataMember]
  public String? ManifestLocation
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.ManifestLocation);
    }
    set
    {
      _ExistingElement.ManifestLocation = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Custom XML Schema Location
  /// </summary>
  [DataMember]
  public String? SchemaLocation
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.SchemaLocation);
    }
    set
    {
      _ExistingElement.SchemaLocation = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
