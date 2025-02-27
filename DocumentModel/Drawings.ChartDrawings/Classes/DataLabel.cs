namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the DataLabel Class.
/// </summary>
public class DataLabel: ModelElement
{
  /// <summary>
  ///   idx, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? Idx { get; set; }

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

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}