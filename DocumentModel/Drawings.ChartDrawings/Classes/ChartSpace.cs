namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ChartSpace Class.
/// </summary>
public class ChartSpace: ModelElement
{
  /// <summary>
  ///   ChartData.
  /// </summary>
  public ChartData? ChartData { get; set; }

  /// <summary>
  ///   Chart.
  /// </summary>
  public Chart? Chart { get; set; }

  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  public ShapeProperties? ShapeProperties { get; set; }

  /// <summary>
  ///   TxPrTextBody.
  /// </summary>
  public TxPrTextBody? TxPrTextBody { get; set; }

  /// <summary>
  ///   ColorMappingType.
  /// </summary>
  public ColorMappingType? ColorMappingType { get; set; }

  /// <summary>
  ///   FormatOverrides.
  /// </summary>
  public FormatOverrides? FormatOverrides { get; set; }

  /// <summary>
  ///   PrintSettings.
  /// </summary>
  public PrintSettings? PrintSettings { get; set; }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}