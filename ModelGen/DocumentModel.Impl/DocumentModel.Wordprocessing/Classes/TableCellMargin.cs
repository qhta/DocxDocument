namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableCellMargin Class.
/// </summary>
public class TableCellMarginImpl: ModelElementImpl, TableCellMargin
{
  public DocumentFormat.OpenXml.Wordprocessing.TableCellMargin? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.TableCellMargin?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TableCellMarginImpl(): base() {}
  
  public TableCellMarginImpl(DocumentFormat.OpenXml.Wordprocessing.TableCellMargin openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Table Cell Top Margin Exception.
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthType? TopMargin
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Table Cell Left Margin Exception.
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthType? LeftMargin
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// StartMargin, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthType? StartMargin
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Table Cell Bottom Margin Exception.
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthType? BottomMargin
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Table Cell Right Margin Exception.
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthType? RightMargin
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// EndMargin, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthType? EndMargin
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
