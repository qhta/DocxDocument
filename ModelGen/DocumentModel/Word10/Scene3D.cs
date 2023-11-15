namespace DocumentModel.Word10;


/// <summary>
///   This element specifies 3-D scene properties of text, including camera and lighting. By default, text does not have 3-D scene properties
/// </summary>
public partial class Scene3D: ModelElement<DXO10W.Scene3D>
{
  public Scene3D(): base(){ }
  
  public Scene3D(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Scene3D(DXO10W.Scene3D openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Camera.
  /// </summary>
  [DataMember]
  public DMW10.Camera? Camera
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   LightRig.
  /// </summary>
  [DataMember]
  public DMW10.LightRig? LightRig
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
