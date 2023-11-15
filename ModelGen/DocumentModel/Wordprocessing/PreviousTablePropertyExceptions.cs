namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a set of table properties which shall be applied to the contents of this row in place of the table properties specified in the tblPr element.
/// </summary>
public partial class PreviousTablePropertyExceptions: ModelElement<DXW.PreviousTablePropertyExceptions>
{
  public PreviousTablePropertyExceptions(): base(){ }
  
  public PreviousTablePropertyExceptions(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PreviousTablePropertyExceptions(DXW.PreviousTablePropertyExceptions openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Preferred Table Width Exception.
  /// </summary>
  [DataMember]
  public DMW.TableWidth? TableWidth
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.TableWidthType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.TableWidthType");
  }
  
  
  /// <summary>
  ///   Table Alignment Exception.
  /// </summary>
  [DataMember]
  public DMW.TableRowAlignmentKind? TableJustification
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Table Cell Spacing Exception.
  /// </summary>
  [DataMember]
  public DMW.TableCellSpacing? TableCellSpacing
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.TableWidthType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.TableWidthType");
  }
  
  
  /// <summary>
  ///   Table Indent from Leading Margin Exception.
  /// </summary>
  [DataMember]
  public DMW.TableIndentation? TableIndentation
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Table Borders Exceptions.
  /// </summary>
  [DataMember]
  public DMW.TableBorders? TableBorders
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Table Shading Exception.
  /// </summary>
  [DataMember]
  public DMW.Shading? Shading
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Table Layout Exception.
  /// </summary>
  [DataMember]
  public DMW.TableLayout? TableLayout
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Table Cell Margin Exceptions.
  /// </summary>
  [DataMember]
  public DMW.TableCellMarginDefault? TableCellMarginDefault
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Table Style Conditional Formatting Settings Exception.
  /// </summary>
  [DataMember]
  public DMW.TableLook? TableLook
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
}
