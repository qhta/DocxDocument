namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Title.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IChartShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ITextProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IOverlay))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ILayout))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IChartText))]
public class Title: ITitle
{
  /// <summary>
  /// Chart Text.
  /// </summary>
  public DocumentModel.Drawing.Charts.IChartText? ChartText
  {
    get;
    set;
  }
  
  /// <summary>
  /// Layout.
  /// </summary>
  public DocumentModel.Drawing.Charts.ILayout? Layout
  {
    get;
    set;
  }
  
  /// <summary>
  /// Overlay.
  /// </summary>
  public IOverlay? Overlay
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
  /// TextProperties.
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
