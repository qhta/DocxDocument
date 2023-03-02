namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Chart Space.
/// </summary>
public record ChartSpace
{
  /// <summary>
  ///   Date1904.
  /// </summary>
  public Boolean? Date1904 { get; set; }

  /// <summary>
  ///   EditingLanguage.
  /// </summary>
  public String? EditingLanguage { get; set; }

  /// <summary>
  ///   RoundedCorners.
  /// </summary>
  public Boolean? RoundedCorners { get; set; }

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