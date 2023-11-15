namespace DocumentModel.Drawings;


/// <summary>
///   Defines the ColorMappingType Class.
/// </summary>
public partial class ColorMappingType: ModelElement<DXD.ColorMappingType>
{
  public ColorMappingType(): base(){ }
  
  public ColorMappingType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ColorMappingType(DXD.ColorMappingType openXmlElement): base(openXmlElement) { }
  
  
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
