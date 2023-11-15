namespace DocumentModel.Drawings.OEmbed;


/// <summary>
///   Defines the OEmbedShared Class.
/// </summary>
public partial class OEmbedShared: ModelElement<DXOD21OE.OEmbedShared>
{
  public OEmbedShared(): base(){ }
  
  public OEmbedShared(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public OEmbedShared(DXOD21OE.OEmbedShared openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   srcUrl, this property is only available in Microsoft365 and later.
  /// </summary>
  [DataMember]
  public String? SrcUrl
  {
    get => _Element?.SrcUrl;
    set => _ExistingElement.SrcUrl = value;
  }
  
  
  /// <summary>
  ///   type, this property is only available in Microsoft365 and later.
  /// </summary>
  [DataMember]
  public String? Type
  {
    get => _Element?.Type;
    set => _ExistingElement.Type = value;
  }
  
  
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  [DataMember]
  public DMDOE.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
