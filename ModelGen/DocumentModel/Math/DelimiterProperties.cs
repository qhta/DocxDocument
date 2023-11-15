namespace DocumentModel.Math;


/// <summary>
///   Delimiter Properties.
/// </summary>
public partial class DelimiterProperties: ModelElement<DXM.DelimiterProperties>
{
  public DelimiterProperties(): base(){ }
  
  public DelimiterProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DelimiterProperties(DXM.DelimiterProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Delimiter Beginning Character.
  /// </summary>
  [DataMember]
  public DMM.BeginChar? BeginChar
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.CharType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.CharType");
  }
  
  
  /// <summary>
  ///   Delimiter Separator Character.
  /// </summary>
  [DataMember]
  public DMM.SeparatorChar? SeparatorChar
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.CharType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.CharType");
  }
  
  
  /// <summary>
  ///   Delimiter Ending Character.
  /// </summary>
  [DataMember]
  public DMM.EndChar? EndChar
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.CharType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.CharType");
  }
  
  
  /// <summary>
  ///   Delimiter Grow.
  /// </summary>
  [DataMember]
  public DMM.GrowOperators? GrowOperators
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OnOffType");
  }
  
  
  /// <summary>
  ///   Shape (Delimiters).
  /// </summary>
  [DataMember]
  public DMM.ShapeDelimiterKind? Shape
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
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
