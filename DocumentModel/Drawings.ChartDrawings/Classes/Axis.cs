namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the Axis Class.
/// </summary>
public class Axis: ModelElement
{
  /// <summary>
  ///   id, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? Id { get; set; }

  /// <summary>
  ///   hidden, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? Hidden { get; set; }

  public CategoryAxisScaling? CategoryAxisScaling { get; set; }

  public ValueAxisScaling? ValueAxisScaling { get; set; }

  public AxisTitle? AxisTitle { get; set; }

  public AxisUnits? AxisUnits { get; set; }

  public MajorGridlinesGridlines? MajorGridlinesGridlines { get; set; }

  public MinorGridlinesGridlines? MinorGridlinesGridlines { get; set; }

  public MajorTickMarksTickMarks? MajorTickMarksTickMarks { get; set; }

  public MinorTickMarksTickMarks? MinorTickMarksTickMarks { get; set; }

  public TickLabels? TickLabels { get; set; }

  public NumberFormat? NumberFormat { get; set; }

  public ShapeProperties? ShapeProperties { get; set; }

  public TxPrTextBody? TxPrTextBody { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}