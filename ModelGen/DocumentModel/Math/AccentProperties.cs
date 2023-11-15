namespace DocumentModel.Math;


/// <summary>
///   Accent Properties.
/// </summary>
public partial class AccentProperties: ModelElement<DXM.AccentProperties>
{
  public AccentProperties(): base(){ }
  
  public AccentProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AccentProperties(DXM.AccentProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Accent Character.
  /// </summary>
  [DataMember]
  public DMM.AccentChar? AccentChar
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.CharType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.CharType");
  }
  
  
  /// <summary>
  ///   Control Properties.
  /// </summary>
  [DataMember]
  public DMM.ControlProperties? ControlProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
