namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Chart Space.
/// </summary>
public class ChartSpace: ModelElement
{
  /// <summary>
  ///   Date1904.
  /// </summary>
  public bool? Date1904 { get; set; }

  /// <summary>
  ///   EditingLanguage.
  /// </summary>
  public string? EditingLanguage { get; set; }

  /// <summary>
  ///   RoundedCorners.
  /// </summary>
  public bool? RoundedCorners { get; set; }

  public Byte? Style { get; set; }

  public ColorMapOverride? ColorMapOverride { get; set; }

  public PivotSource? PivotSource { get; set; }

  public Protection? Protection { get; set; }

  public Chart? Chart { get; set; }

  public ShapeProperties? ShapeProperties { get; set; }

  public TextProperties? TextProperties { get; set; }

  public ExternalData? ExternalData { get; set; }

  public PrintSettings? PrintSettings { get; set; }

  public RelationshipIdType? UserShapesReference { get; set; }

  public ChartSpaceExtensionList? ChartSpaceExtensionList { get; set; }
}