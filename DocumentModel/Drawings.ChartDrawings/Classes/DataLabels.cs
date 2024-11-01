namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the DataLabels Class.
/// </summary>
public class DataLabels: ModelElement
{
  /// <summary>
  ///   pos, this property is only available in Office 2016 and later.
  /// </summary>
  public DataLabelPos? Pos { get; set; }

  /// <summary>
  ///   NumberFormat.
  /// </summary>
  public NumberFormat? NumberFormat { get; set; }

  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  public ShapeProperties? ShapeProperties { get; set; }

  /// <summary>
  ///   TxPrTextBody.
  /// </summary>
  public TxPrTextBody? TxPrTextBody { get; set; }

  /// <summary>
  ///   DataLabelVisibilities.
  /// </summary>
  public DataLabelVisibilities? DataLabelVisibilities { get; set; }

  /// <summary>
  ///   SeparatorXsdstring.
  /// </summary>
  public string? SeparatorXsdstring { get; set; }

  public Collection<DataLabel>? Items { get; set; }

  public Collection<DataLabelHidden>? DataLabelHiddens { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}