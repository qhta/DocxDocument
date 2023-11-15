namespace DocumentModel.Math;


/// <summary>
///   Bar Properties.
/// </summary>
public partial class BarProperties: ModelElement<DXM.BarProperties>
{
  public BarProperties(): base(){ }
  
  public BarProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BarProperties(DXM.BarProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Position (Bar).
  /// </summary>
  [DataMember]
  public DMM.Position? Position
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.TopBottomType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.TopBottomType");
  }
  
  
  /// <summary>
  ///   ControlProperties.
  /// </summary>
  [DataMember]
  public DMM.ControlProperties? ControlProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
