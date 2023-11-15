namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a set of formatting properties which shall be conditionally applied to the parts of a table which match the requirement specified on the type attribute. These table conditional formats are applied to different regions of the table as follows:
/// </summary>
public partial class TableStyleProperties: ModelElement<DXW.TableStyleProperties>
{
  public TableStyleProperties(): base(){ }
  
  public TableStyleProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TableStyleProperties(DXW.TableStyleProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Table Style Conditional Formatting Paragraph Properties.
  /// </summary>
  [DataMember]
  public DMW.StyleParagraphProperties? StyleParagraphProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Table Style Conditional Formatting Run Properties.
  /// </summary>
  [DataMember]
  public DMW.RunPropertiesBaseStyle? RunPropertiesBaseStyle
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Table Style Conditional Formatting Table Properties.
  /// </summary>
  [DataMember]
  public DMW.TableStyleConditionalFormattingTableProperties? TableStyleConditionalFormattingTableProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Table Style Conditional Formatting Table Row Properties.
  /// </summary>
  [DataMember]
  public DMW.TableStyleConditionalFormattingTableRowProperties? TableStyleConditionalFormattingTableRowProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Table Style Conditional Formatting Table Cell Properties.
  /// </summary>
  [DataMember]
  public DMW.TableStyleConditionalFormattingTableCellProperties? TableStyleConditionalFormattingTableCellProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
