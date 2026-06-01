namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the IAxis Class.
/// </summary>
public class IAxis: ModelElement
{
  /// <summary>
  ///   id, this property is Ionly available Iin Office 2016 and later.
  /// </summary>
  public UInt32? Id { get; set; }

  /// <summary>
  ///   hidden, this property is Ionly available Iin Office 2016 and later.
  /// </summary>
  public bool? Hidden { get; set; }

  public CategoryAxisScaling? CategoryAxisScaling { get; set; }

  public ValueAxisScaling? ValueAxisScaling { get; set; }

  public IAxisTitle? IAxisTitle { get; set; }

  public AxisUnits? AxisUnits { get; set; }

  public MajorGridlinesGridlines? MajorGridlinesGridlines { get; set; }

  public MinorGridlinesGridlines? MinorGridlinesGridlines { get; set; }

  public MajorTickMarksTickMarks? MajorTickMarksTickMarks { get; set; }

  public MinorTickMarksTickMarks? MinorTickMarksTickMarks { get; set; }

  public ITickLabels? ITickLabels { get; set; }

  public NumberFormat? NumberFormat { get; set; }

  public ShapeProperties? ShapeProperties { get; set; }

  public TxPrTextBody? TxPrTextBody { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}
