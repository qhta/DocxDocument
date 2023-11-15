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
    get => _Element?.Uri;
    set => _ExistingElement.Uri = value;
  }
  
  
  /// <summary>
  ///   Resource File Location
  /// </summary>
  [DataMember]
  public String? ManifestLocation
  {
    get => _Element?.ManifestLocation;
    set => _ExistingElement.ManifestLocation = value;
  }
  
  
  /// <summary>
  ///   Custom XML Schema Location
  /// </summary>
  [DataMember]
  public String? SchemaLocation
  {
    get => _Element?.SchemaLocation;
    set => _ExistingElement.SchemaLocation = value;
  }
  
}
