namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Data Table.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IChartShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ITextProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IShowHorizontalBorder))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IShowVerticalBorder))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IShowOutlineBorder))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IShowKeys))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IExtensionList))]
public class DataTable: IDataTable
{
  /// <summary>
  /// Show Horizontal Border.
  /// </summary>
  public IShowHorizontalBorder? ShowHorizontalBorder
  {
    get;
    set;
  }
  
  /// <summary>
  /// Show Vertical Border.
  /// </summary>
  public IShowVerticalBorder? ShowVerticalBorder
  {
    get;
    set;
  }
  
  /// <summary>
  /// Show Outline Border.
  /// </summary>
  public IShowOutlineBorder? ShowOutlineBorder
  {
    get;
    set;
  }
  
  /// <summary>
  /// Show Legend Keys.
  /// </summary>
  public IShowKeys? ShowKeys
  {
    get;
    set;
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public IChartShapeProperties? ChartShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Text Properties.
  /// </summary>
  public DocumentModel.Drawing.Charts.ITextProperties? TextProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawing.Charts.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
