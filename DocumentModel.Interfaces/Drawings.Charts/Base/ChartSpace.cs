namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Chart Space.
/// </summary>
public interface ChartSpace
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

  /// <summary>
  ///   Style.
  /// </summary>
  public Byte? Style { get; set; }

  /// <summary>
  ///   Color Map Override.
  /// </summary>
  public ColorMapOverride? ColorMapOverride { get; set; }

  /// <summary>
  ///   Pivot Source.
  /// </summary>
  public PivotSource? PivotSource { get; set; }

  /// <summary>
  ///   Protection.
  /// </summary>
  public Protection? Protection { get; set; }

  /// <summary>
  ///   Chart.
  /// </summary>
  public Chart? Chart { get; set; }

  /// <summary>
  ///   Shape Properties.
  /// </summary>
  public ShapeProperties? ShapeProperties { get; set; }

  /// <summary>
  ///   Text Properties.
  /// </summary>
  public TextProperties? TextProperties { get; set; }

  /// <summary>
  ///   External Data.
  /// </summary>
  public ExternalData? ExternalData { get; set; }

  /// <summary>
  ///   Print Settings.
  /// </summary>
  public PrintSettings? PrintSettings { get; set; }

  /// <summary>
  ///   User Shapes Reference.
  /// </summary>
  public RelationshipIdType? UserShapesReference { get; set; }

  /// <summary>
  ///   Chart Space Extension List.
  /// </summary>
  public ChartSpaceExtensionList? ChartSpaceExtensionList { get; set; }
}