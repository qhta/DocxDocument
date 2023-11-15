namespace DocumentModel.Math;


/// <summary>
///   Math Properties.
/// </summary>
public partial class MathProperties: ModelElement<DXM.MathProperties>
{
  public MathProperties(): base(){ }
  
  public MathProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MathProperties(DXM.MathProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Math Font.
  /// </summary>
  [DataMember]
  public String? MathFont
  {
    get => _Element?.GetStringVal<DXM.MathFont>();
    set => _ExistingElement.SetStringVal<DXM.MathFont>(value);
  }
  
  
  /// <summary>
  ///   Break on Binary Operators.
  /// </summary>
  [DataMember]
  public DMM.BreakBinaryOperatorKind? BreakBinary
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Break on Binary Subtraction.
  /// </summary>
  [DataMember]
  public DMM.BreakBinarySubtractionKind? BreakBinarySubtraction
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Small Fraction.
  /// </summary>
  [DataMember]
  public DMM.SmallFraction? SmallFraction
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OnOffType");
  }
  
  
  /// <summary>
  ///   Use Display Math Defaults.
  /// </summary>
  [DataMember]
  public DMM.DisplayDefaults? DisplayDefaults
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OnOffType");
  }
  
  
  /// <summary>
  ///   Left Margin.
  /// </summary>
  [DataMember]
  public DMM.LeftMargin? LeftMargin
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.TwipsMeasureType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.TwipsMeasureType");
  }
  
  
  /// <summary>
  ///   Right Margin.
  /// </summary>
  [DataMember]
  public DMM.RightMargin? RightMargin
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.TwipsMeasureType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.TwipsMeasureType");
  }
  
  
  /// <summary>
  ///   Default Justification.
  /// </summary>
  [DataMember]
  public DMM.DefaultJustification? DefaultJustification
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OfficeMathJustificationType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OfficeMathJustificationType");
  }
  
  
  /// <summary>
  ///   Pre-Equation Spacing.
  /// </summary>
  [DataMember]
  public DMM.PreSpacing? PreSpacing
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.TwipsMeasureType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.TwipsMeasureType");
  }
  
  
  /// <summary>
  ///   Post-Equation Spacing.
  /// </summary>
  [DataMember]
  public DMM.PostSpacing? PostSpacing
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.TwipsMeasureType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.TwipsMeasureType");
  }
  
  
  /// <summary>
  ///   Inter-Equation Spacing.
  /// </summary>
  [DataMember]
  public DMM.InterSpacing? InterSpacing
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.TwipsMeasureType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.TwipsMeasureType");
  }
  
  
  /// <summary>
  ///   Intra-Equation Spacing.
  /// </summary>
  [DataMember]
  public DMM.IntraSpacing? IntraSpacing
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.TwipsMeasureType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.TwipsMeasureType");
  }
  
  [DataMember]
  public DMM.WrapIndent? WrapIndent
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.TwipsMeasureType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.TwipsMeasureType");
  }
  
  [DataMember]
  public DMM.WrapRight? WrapRight
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OnOffType");
  }
  
  [DataMember]
  public DMM.IntegralLimitLocation? IntegralLimitLocation
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.LimitLocationType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.LimitLocationType");
  }
  
  [DataMember]
  public DMM.NaryLimitLocation? NaryLimitLocation
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.LimitLocationType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.LimitLocationType");
  }
  
}
