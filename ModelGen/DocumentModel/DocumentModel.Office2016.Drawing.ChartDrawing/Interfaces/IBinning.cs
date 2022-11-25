namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the Binning Class.
/// </summary>
public interface IBinning // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// intervalClosed, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IntervalClosedSide? IntervalClosed { get ; set; }
  
  /// <summary>
  /// underflow, this property is only available in Office 2016 and later.
  /// </summary>
  public System.String? Underflow { get ; set; }
  
  /// <summary>
  /// overflow, this property is only available in Office 2016 and later.
  /// </summary>
  public System.String? Overflow { get ; set; }
  
  /// <summary>
  /// Xsddouble.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? Xsddouble { get ; set; }
  
  /// <summary>
  /// BinCountXsdunsignedInt.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? BinCountXsdunsignedInt { get ; set; }
  
}
