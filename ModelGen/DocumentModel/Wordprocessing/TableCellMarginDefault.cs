namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a set of cell margins for all cells in the parent table row via a set of table-level property exceptions. These settings can be overridden by the table cell margin definition specified by the tcMar element contained within the table cell's properties.
/// </summary>
public partial class TableCellMarginDefault: ModelElement<DXW.TableCellMarginDefault>
{
  public TableCellMarginDefault(): base(){ }
  
  public TableCellMarginDefault(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TableCellMarginDefault(DXW.TableCellMarginDefault openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Table Cell Top Margin Default.
  /// </summary>
  [DataMember]
  public DMW.TopMargin? TopMargin
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.TableWidthType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.TableWidthType");
  }
  
  
  /// <summary>
  ///   Table Cell Left Margin Default.
  /// </summary>
  [DataMember]
  public DMW.TableCellLeftMargin? TableCellLeftMargin
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.TableWidthDxaNilType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.TableWidthDxaNilType");
  }
  
  
  /// <summary>
  ///   StartMargin, this property is only available in Office 2010 and later..
  /// </summary>
  [DataMember]
  public DMW.StartMargin? StartMargin
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.TableWidthType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.TableWidthType");
  }
  
  
  /// <summary>
  ///   Table Cell Bottom Margin Default.
  /// </summary>
  [DataMember]
  public DMW.BottomMargin? BottomMargin
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.TableWidthType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.TableWidthType");
  }
  
  
  /// <summary>
  ///   Table Cell Right Margin Default.
  /// </summary>
  [DataMember]
  public DMW.TableCellRightMargin? TableCellRightMargin
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.TableWidthDxaNilType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.TableWidthDxaNilType");
  }
  
  
  /// <summary>
  ///   EndMargin, this property is only available in Office 2010 and later..
  /// </summary>
  [DataMember]
  public DMW.EndMargin? EndMargin
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.TableWidthType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.TableWidthType");
  }
  
}
