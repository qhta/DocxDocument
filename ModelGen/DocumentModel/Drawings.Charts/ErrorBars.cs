namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the ErrorBars Class.
/// </summary>
public partial class ErrorBars
{
  
  /// <summary>
  ///   Error Bar Direction.
  /// </summary>
  public DMDC.ErrorBarDirectionKind? ErrorDirection { get; set; }
  
  
  /// <summary>
  ///   Error Bar Type.
  /// </summary>
  public DMDC.ErrorBarKind? ErrorBarType { get; set; }
  
  
  /// <summary>
  ///   Error Bar Value Type.
  /// </summary>
  public DMDC.ErrorKind? ErrorBarValueType { get; set; }
  
  
  /// <summary>
  ///   No End Cap.
  /// </summary>
  public DMDC.NoEndCap? NoEndCap { get; set; }
  
  
  /// <summary>
  ///   Plus.
  /// </summary>
  public DMDC.Plus? Plus { get; set; }
  
  
  /// <summary>
  ///   Minus.
  /// </summary>
  public DMDC.Minus? Minus { get; set; }
  
  
  /// <summary>
  ///   Error Bar Value.
  /// </summary>
  public DMDC.ErrorBarValue? ErrorBarValue { get; set; }
  
  
  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  public DMDC.ChartShapeProperties? ChartShapeProperties { get; set; }
  
  
  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  public DMDC.ExtensionList? ExtensionList { get; set; }
  
}
