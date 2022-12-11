namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableCellBorders Class.
/// </summary>
public class TableCellBordersImpl: ModelElementImpl, TableCellBorders
{
  public DocumentFormat.OpenXml.Wordprocessing.TableCellBorders? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.TableCellBorders?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TableCellBordersImpl(): base() {}
  
  public TableCellBordersImpl(DocumentFormat.OpenXml.Wordprocessing.TableCellBorders openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Table Cell Top Border.
  /// </summary>
  public BorderType? TopBorder
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Table Cell Left Border.
  /// </summary>
  public BorderType? LeftBorder
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// StartBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public BorderType? StartBorder
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Table Cell Bottom Border.
  /// </summary>
  public BorderType? BottomBorder
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Table Cell Right Border.
  /// </summary>
  public BorderType? RightBorder
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// EndBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public BorderType? EndBorder
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Table Cell Inside Horizontal Edges Border.
  /// </summary>
  public BorderType? InsideHorizontalBorder
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Table Cell Inside Vertical Edges Border.
  /// </summary>
  public BorderType? InsideVerticalBorder
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Table Cell Top Left to Bottom Right Diagonal Border.
  /// </summary>
  public BorderType? TopLeftToBottomRightCellBorder
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Table Cell Top Right to Bottom Left Diagonal Border.
  /// </summary>
  public BorderType? TopRightToBottomLeftCellBorder
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
