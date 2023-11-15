namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of borders for the edges of the current table cell, using the eight border types defined by its child elements.
/// </summary>
public partial class TableCellBorders: ModelElement<DXW.TableCellBorders>
{
  public TableCellBorders(): base(){ }
  
  public TableCellBorders(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TableCellBorders(DXW.TableCellBorders openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Table Cell Top Border.
  /// </summary>
  [DataMember]
  public DMW.TopBorder? TopBorder
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
  }
  
  
  /// <summary>
  ///   Table Cell Left Border.
  /// </summary>
  [DataMember]
  public DMW.LeftBorder? LeftBorder
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
  }
  
  
  /// <summary>
  ///   StartBorder, this property is only available in Office 2010 and later..
  /// </summary>
  [DataMember]
  public DMW.StartBorder? StartBorder
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
  }
  
  
  /// <summary>
  ///   Table Cell Bottom Border.
  /// </summary>
  [DataMember]
  public DMW.BottomBorder? BottomBorder
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
  }
  
  
  /// <summary>
  ///   Table Cell Right Border.
  /// </summary>
  [DataMember]
  public DMW.RightBorder? RightBorder
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
  }
  
  
  /// <summary>
  ///   EndBorder, this property is only available in Office 2010 and later..
  /// </summary>
  [DataMember]
  public DMW.EndBorder? EndBorder
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
  }
  
  
  /// <summary>
  ///   Table Cell Inside Horizontal Edges Border.
  /// </summary>
  [DataMember]
  public DMW.InsideHorizontalBorder? InsideHorizontalBorder
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
  }
  
  
  /// <summary>
  ///   Table Cell Inside Vertical Edges Border.
  /// </summary>
  [DataMember]
  public DMW.InsideVerticalBorder? InsideVerticalBorder
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
  }
  
  
  /// <summary>
  ///   Table Cell Top Left to Bottom Right Diagonal Border.
  /// </summary>
  [DataMember]
  public DMW.TopLeftToBottomRightCellBorder? TopLeftToBottomRightCellBorder
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
  }
  
  
  /// <summary>
  ///   Table Cell Top Right to Bottom Left Diagonal Border.
  /// </summary>
  [DataMember]
  public DMW.TopRightToBottomLeftCellBorder? TopRightToBottomLeftCellBorder
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
  }
  
}
