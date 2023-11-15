namespace DocumentModel.CustomXml;


/// <summary>
///   Associated XML Schema.
/// </summary>
public partial class SchemaReference: ModelElement<DXCXDP.SchemaReference>
{
  public SchemaReference(): base(){ }
  
  public SchemaReference(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SchemaReference(DXCXDP.SchemaReference openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Target Namespace of Associated XML Schema
  /// </summary>
  [DataMember]
  public String? Uri
  {
    get => _Element?.Uri;
    set => _ExistingElement.Uri = value;
  }
  
}
