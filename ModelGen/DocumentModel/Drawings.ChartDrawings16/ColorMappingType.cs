namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the ColorMappingType Class.
/// </summary>
public partial class ColorMappingType: ModelElement<DXO16DCD.ColorMappingType>
{
  public ColorMappingType(): base(){ }
  
  public ColorMappingType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ColorMappingType(DXO16DCD.ColorMappingType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [DataMember]
  public DMD.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
}
