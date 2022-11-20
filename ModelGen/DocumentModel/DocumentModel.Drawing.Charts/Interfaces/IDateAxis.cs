namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Date Axis.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IChartShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ITextProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IMajorUnit))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IMinorUnit))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IAxisPosition))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IDelete))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IAutoLabeled))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IMajorGridlines))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IMinorGridlines))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ICrosses))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IDateAxExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ICrossesAt))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ILabelOffset))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.INumberingFormat))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IScaling))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ITickLabelPosition))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IMajorTickMark))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IMinorTickMark))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IBaseTimeUnit))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IMajorTimeUnit))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IMinorTimeUnit))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ITitle))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IAxisId))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ICrossingAxis))]
public interface IDateAxis // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Axis ID.
  /// </summary>
  public DocumentModel.Drawing.Charts.IAxisId? AxisId { get ; set; }
  
  /// <summary>
  /// Scaling.
  /// </summary>
  public IScaling? Scaling { get ; set; }
  
  /// <summary>
  /// Delete.
  /// </summary>
  public IDelete? Delete { get ; set; }
  
  /// <summary>
  /// Axis Position.
  /// </summary>
  public IAxisPosition? AxisPosition { get ; set; }
  
  /// <summary>
  /// Major Gridlines.
  /// </summary>
  public IMajorGridlines? MajorGridlines { get ; set; }
  
  /// <summary>
  /// Minor Gridlines.
  /// </summary>
  public IMinorGridlines? MinorGridlines { get ; set; }
  
  /// <summary>
  /// Title.
  /// </summary>
  public DocumentModel.Drawing.Charts.ITitle? Title { get ; set; }
  
  /// <summary>
  /// Number Format.
  /// </summary>
  public DocumentModel.Drawing.Charts.INumberingFormat? NumberingFormat { get ; set; }
  
  /// <summary>
  /// Major Tick Mark.
  /// </summary>
  public IMajorTickMark? MajorTickMark { get ; set; }
  
  /// <summary>
  /// Minor Tick Mark.
  /// </summary>
  public IMinorTickMark? MinorTickMark { get ; set; }
  
  /// <summary>
  /// Tick Label Position.
  /// </summary>
  public ITickLabelPosition? TickLabelPosition { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public IChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// TextProperties.
  /// </summary>
  public DocumentModel.Drawing.Charts.ITextProperties? TextProperties { get ; set; }
  
  /// <summary>
  /// Crossing Axis ID.
  /// </summary>
  public ICrossingAxis? CrossingAxis { get ; set; }
  
}
