namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the ColorMapOverride Class.
/// </summary>
public partial class ColorMapOverride: ModelElement<DXDC.ColorMapOverride>
{
  public ColorMapOverride(): base(){ }
  
  public ColorMapOverride(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ColorMapOverride(DXDC.ColorMapOverride openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [DataMember]
  public DMD.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
