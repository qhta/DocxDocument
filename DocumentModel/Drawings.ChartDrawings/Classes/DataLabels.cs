namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the IDataLabels Class.
/// </summary>
public class IDataLabels: ModelElement
{
  /// <summary>
  ///   pos, this property is Ionly available Iin Office 2016 and later.
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

  public Collection<IDataLabel>? Items { get; set; }

  public Collection<DataLabelHidden>? DataLabelHiddens { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}
