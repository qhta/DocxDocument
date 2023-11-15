namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   3-D Scene.
/// </summary>
public partial class Scene3D: ModelElement<DXDDD.Scene3D>
{
  public Scene3D(): base(){ }
  
  public Scene3D(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Scene3D(DXDDD.Scene3D openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Camera.
  /// </summary>
  [DataMember]
  public DMD.Camera? Camera
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Light Rig.
  /// </summary>
  [DataMember]
  public DMD.LightRig? LightRig
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Backdrop Plane.
  /// </summary>
  [DataMember]
  public DMD.Backdrop? Backdrop
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
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
