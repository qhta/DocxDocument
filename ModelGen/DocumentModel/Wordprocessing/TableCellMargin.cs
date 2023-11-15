namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a set of cell margins for a single table cell in the parent table.
/// </summary>
public partial class TableCellMargin: ModelElement<DXW.TableCellMargin>
{
  public TableCellMargin(): base(){ }
  
  public TableCellMargin(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TableCellMargin(DXW.TableCellMargin openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Table Cell Top Margin Exception.
  /// </summary>
  [DataMember]
  public DMW.TopMargin? TopMargin
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.TableWidthType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.TableWidthType");
  }
  
  
  /// <summary>
  ///   Table Cell Left Margin Exception.
  /// </summary>
  [DataMember]
  public DMW.LeftMargin? LeftMargin
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.TableWidthType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.TableWidthType");
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
  ///   Table Cell Bottom Margin Exception.
  /// </summary>
  [DataMember]
  public DMW.BottomMargin? BottomMargin
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.TableWidthType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.TableWidthType");
  }
  
  
  /// <summary>
  ///   Table Cell Right Margin Exception.
  /// </summary>
  [DataMember]
  public DMW.RightMargin? RightMargin
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.TableWidthType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.TableWidthType");
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
