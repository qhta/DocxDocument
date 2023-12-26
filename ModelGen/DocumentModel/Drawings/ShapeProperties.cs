namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the visual shape properties that can be applied to a shape.
/// </summary>
public partial class ShapeProperties: ModelElement<DXD.ShapeProperties>
{
  public ShapeProperties(): base(){ }
  
  public ShapeProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ShapeProperties(DXD.ShapeProperties openXmlElement): base(openXmlElement) { }
  
  
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
