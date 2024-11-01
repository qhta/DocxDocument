namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Display Units Label.
/// </summary>
public class DisplayUnitsLabel: ModelElement
{
  /// <summary>
  ///   Layout.
  /// </summary>
  public Layout? Layout { get; set; }

  /// <summary>
  ///   ChartText.
  /// </summary>
  public ChartText? ChartText { get; set; }

  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties { get; set; }

  /// <summary>
  ///   TextProperties.
  /// </summary>
  public TextProperties? TextProperties { get; set; }
}