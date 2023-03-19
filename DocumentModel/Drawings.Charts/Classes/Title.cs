namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Title.
/// </summary>
public class Title: ModelElement
{
  /// <summary>
  ///   Chart Text.
  /// </summary>
  public ChartText? ChartText { get; set; }

  /// <summary>
  ///   Layout.
  /// </summary>
  public Layout? Layout { get; set; }

  /// <summary>
  ///   Overlay.
  /// </summary>
  public Boolean? Overlay { get; set; }

  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties { get; set; }

  /// <summary>
  ///   TextProperties.
  /// </summary>
  public TextProperties? TextProperties { get; set; }

  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}