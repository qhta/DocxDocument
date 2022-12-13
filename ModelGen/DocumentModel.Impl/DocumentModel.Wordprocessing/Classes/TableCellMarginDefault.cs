namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableCellMarginDefault Class.
/// </summary>
public class TableCellMarginDefaultImpl: ModelElementImpl, TableCellMarginDefault
{
  public DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TableCellMarginDefaultImpl(): base() {}
  
  public TableCellMarginDefaultImpl(DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Table Cell Top Margin Default.
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthType? TopMargin
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Table Cell Left Margin Default.
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthDxaNilType? TableCellLeftMargin
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
  /// Table Cell Bottom Margin Default.
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthType? BottomMargin
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Table Cell Right Margin Default.
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthDxaNilType? TableCellRightMargin
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
