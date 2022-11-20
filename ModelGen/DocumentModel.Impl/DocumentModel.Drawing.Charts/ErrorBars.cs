namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the ErrorBars Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IChartShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.INoEndCap))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IErrorBarValue))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IErrorBarType))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IErrorDirection))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IErrorBarValueType))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IPlus))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IMinus))]
public class ErrorBars: IErrorBars
{
  /// <summary>
  /// Error Bar Direction.
  /// </summary>
  public IErrorDirection? ErrorDirection
  {
    get;
    set;
  }
  
  /// <summary>
  /// Error Bar Type.
  /// </summary>
  public IErrorBarType? ErrorBarType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Error Bar Value Type.
  /// </summary>
  public IErrorBarValueType? ErrorBarValueType
  {
    get;
    set;
  }
  
  /// <summary>
  /// No End Cap.
  /// </summary>
  public INoEndCap? NoEndCap
  {
    get;
    set;
  }
  
  /// <summary>
  /// Plus.
  /// </summary>
  public IPlus? Plus
  {
    get;
    set;
  }
  
  /// <summary>
  /// Minus.
  /// </summary>
  public IMinus? Minus
  {
    get;
    set;
  }
  
  /// <summary>
  /// Error Bar Value.
  /// </summary>
  public IErrorBarValue? ErrorBarValue
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
