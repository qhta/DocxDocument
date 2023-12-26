namespace DocumentModel.Drawings.Office;


/// <summary>
///   Defines the GroupShapeProperties Class.
/// </summary>
public partial class GroupShapeProperties: ModelElement<DXOD.GroupShapeProperties>
{
  public GroupShapeProperties(): base(){ }
  
  public GroupShapeProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GroupShapeProperties(DXOD.GroupShapeProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   2D Transform for Grouped Objects.
  /// </summary>
  [DataMember]
  public DMD.TransformGroup? TransformGroup
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
}
