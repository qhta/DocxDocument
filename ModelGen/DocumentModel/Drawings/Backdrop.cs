namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a plane in which effects, such as glow and shadow, are applied in relation to the shape they are being applied to.  The points and vectors contained within the backdrop define a plane in 3D space.
/// </summary>
public partial class Backdrop: ModelElement<DXD.Backdrop>
{
  public Backdrop(): base(){ }
  
  public Backdrop(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Backdrop(DXD.Backdrop openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Anchor Point.
  /// </summary>
  [DataMember]
  public DMD.Anchor? Anchor
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Normal.
  /// </summary>
  [DataMember]
  public DMD.Normal? Normal
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Vector3DType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Vector3DType");
  }
  
  
  /// <summary>
  ///   Up Vector.
  /// </summary>
  [DataMember]
  public DMD.UpVector? UpVector
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Vector3DType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Vector3DType");
  }
  
  
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
