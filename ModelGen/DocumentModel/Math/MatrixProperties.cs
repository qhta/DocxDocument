namespace DocumentModel.Math;


/// <summary>
///   Matrix Properties.
/// </summary>
public partial class MatrixProperties: ModelElement<DXM.MatrixProperties>
{
  public MatrixProperties(): base(){ }
  
  public MatrixProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MatrixProperties(DXM.MatrixProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Matrix Base Justification.
  /// </summary>
  [DataMember]
  public DMM.VerticalAlignmentKind? BaseJustification
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Hide Placeholders (Matrix).
  /// </summary>
  [DataMember]
  public DMM.HidePlaceholder? HidePlaceholder
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.OnOffType");
  }
  
  
  /// <summary>
  ///   Row Spacing Rule.
  /// </summary>
  [DataMember]
  public DMM.RowSpacingRule? RowSpacingRule
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.SpacingRuleType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.SpacingRuleType");
  }
  
  
  /// <summary>
  ///   Matrix Column Gap Rule.
  /// </summary>
  [DataMember]
  public DMM.ColumnGapRule? ColumnGapRule
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.SpacingRuleType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.SpacingRuleType");
  }
  
  
  /// <summary>
  ///   Row Spacing (Matrix).
  /// </summary>
  [DataMember]
  public DMM.RowSpacing? RowSpacing
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.UnsignedShortType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.UnsignedShortType");
  }
  
  
  /// <summary>
  ///   Matrix Column Spacing.
  /// </summary>
  [DataMember]
  public DMM.ColumnSpacing? ColumnSpacing
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.TwipsMeasureType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.TwipsMeasureType");
  }
  
  
  /// <summary>
  ///   Matrix Column Gap.
  /// </summary>
  [DataMember]
  public DMM.ColumnGap? ColumnGap
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Math.UnsignedShortType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Math.UnsignedShortType");
  }
  
  
  /// <summary>
  ///   Matrix Columns.
  /// </summary>
  [DataMember]
  public DMM.MatrixColumns? MatrixColumns
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
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
