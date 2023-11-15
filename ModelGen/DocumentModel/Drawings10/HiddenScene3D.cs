namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the HiddenScene3D Class.
/// </summary>
public partial class HiddenScene3D: ModelElement<DXO10D.HiddenScene3D>
{
  public HiddenScene3D(): base(){ }
  
  public HiddenScene3D(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HiddenScene3D(DXO10D.HiddenScene3D openXmlElement): base(openXmlElement) { }
  
  
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
