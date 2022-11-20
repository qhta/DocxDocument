namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Marker.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IChartShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ISize))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ISymbol))]
public class Marker: IMarker
{
  /// <summary>
  /// Symbol.
  /// </summary>
  public ISymbol? Symbol
  {
    get;
    set;
  }
  
  /// <summary>
  /// Size.
  /// </summary>
  public ISize? Size
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
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawing.Charts.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
