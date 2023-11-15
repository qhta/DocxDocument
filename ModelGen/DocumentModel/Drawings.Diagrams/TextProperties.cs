namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Text Properties.
/// </summary>
public partial class TextProperties: ModelElement<DXDDD.TextProperties>
{
  public TextProperties(): base(){ }
  
  public TextProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextProperties(DXDDD.TextProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Apply 3D shape properties.
  /// </summary>
  [DataMember]
  public DMD.Shape3DType? Shape3DType
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   No text in 3D scene.
  /// </summary>
  [DataMember]
  public DMD.FlatText? FlatText
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
}
