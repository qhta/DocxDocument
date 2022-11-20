namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the Binning Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IXsddouble))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IBinCountXsdunsignedInt))]
public interface IBinning // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// intervalClosed, this property is only available in Office 2016 and later.
  /// </summary>
  public IntervalClosedSide? IntervalClosed { get ; set; }
  
  /// <summary>
  /// underflow, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Underflow { get ; set; }
  
  /// <summary>
  /// overflow, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Overflow { get ; set; }
  
  /// <summary>
  /// Xsddouble.
  /// </summary>
  public IXsddouble? Xsddouble { get ; set; }
  
  /// <summary>
  /// BinCountXsdunsignedInt.
  /// </summary>
  public IBinCountXsdunsignedInt? BinCountXsdunsignedInt { get ; set; }
  
}
