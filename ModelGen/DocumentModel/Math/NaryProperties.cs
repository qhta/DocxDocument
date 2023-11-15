namespace DocumentModel.Math;


/// <summary>
///   n-ary Properties.
/// </summary>
public partial class NaryProperties: ModelElement<DXM.NaryProperties>
{
  public NaryProperties(): base(){ }
  
  public NaryProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NaryProperties(DXM.NaryProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   n-ary Operator Character.
  /// </summary>
  [DataMember]
  public DMM.AccentChar? AccentChar
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.CharType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.CharType");
  }
  
  
  /// <summary>
  ///   n-ary Limit Location.
  /// </summary>
  [DataMember]
  public DMM.LimitLocation? LimitLocation
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.LimitLocationType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.LimitLocationType");
  }
  
  
  /// <summary>
  ///   n-ary Grow.
  /// </summary>
  [DataMember]
  public DMM.GrowOperators? GrowOperators
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OnOffType");
  }
  
  
  /// <summary>
  ///   Hide Subscript (n-ary).
  /// </summary>
  [DataMember]
  public DMM.HideSubArgument? HideSubArgument
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OnOffType");
  }
  
  
  /// <summary>
  ///   Hide Superscript (n-ary).
  /// </summary>
  [DataMember]
  public DMM.HideSuperArgument? HideSuperArgument
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OnOffType");
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
