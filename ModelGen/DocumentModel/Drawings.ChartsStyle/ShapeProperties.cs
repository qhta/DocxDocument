namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the ShapeProperties Class.
/// </summary>
public partial class ShapeProperties: ModelElement<DXO13DCS.ShapeProperties>
{
  public ShapeProperties(): base(){ }
  
  public ShapeProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ShapeProperties(DXO13DCS.ShapeProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   2D Transform for Individual Objects.
  /// </summary>
  [DataMember]
  public DMD.Transform2D? Transform2D
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
}
