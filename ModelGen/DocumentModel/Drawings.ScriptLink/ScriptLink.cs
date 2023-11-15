namespace DocumentModel.Drawings.ScriptLink;


/// <summary>
///   Defines the ScriptLink Class.
/// </summary>
public partial class ScriptLink: ModelElement<DXOD21SL.ScriptLink>
{
  public ScriptLink(): base(){ }
  
  public ScriptLink(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ScriptLink(DXOD21SL.ScriptLink openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   val, this property is only available in Microsoft365 and later.
  /// </summary>
  [DataMember]
  public String? Val
  {
    get => _Element?.Val;
    set => _ExistingElement.Val = value;
  }
  
  
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  [DataMember]
  public DMDSL.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
