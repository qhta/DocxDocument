namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of table cell properties which shall be applied to all regions within a table which match the conditional formatting type specified on the parent tblStylePr element. These properties are applied in the order specified via the style hierarchy.
/// </summary>
public partial class TableStyleConditionalFormattingTableCellProperties: ModelElement<DXW.TableStyleConditionalFormattingTableCellProperties>
{
  public TableStyleConditionalFormattingTableCellProperties(): base(){ }
  
  public TableStyleConditionalFormattingTableCellProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TableStyleConditionalFormattingTableCellProperties(DXW.TableStyleConditionalFormattingTableCellProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   TableCellBorders.
  /// </summary>
  [DataMember]
  public DMW.TableCellBorders? TableCellBorders
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Shading.
  /// </summary>
  [DataMember]
  public DMW.Shading? Shading
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   NoWrap.
  /// </summary>
  [DataMember]
  public DMW.NoWrap? NoWrap
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyType");
  }
  
  
  /// <summary>
  ///   TableCellMargin.
  /// </summary>
  [DataMember]
  public DMW.TableCellMargin? TableCellMargin
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   TableCellVerticalAlignment.
  /// </summary>
  [DataMember]
  public DMW.TableVerticalAlignmentKind? TableCellVerticalAlignment
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
}
