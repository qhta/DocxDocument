namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the OpenXmlValueColorEndPositionElement Class.
/// </summary>
public class OpenXmlValueColorEndPositionElement: ModelElement
{
  /// <summary>
  ///   ExtremeValueColorPosition.
  /// </summary>
  public bool? ExtremeValueColorPosition { get; set; }
  /// <summary>
  ///   NumberColorPosition.
  /// </summary>
  public Double? NumberColorPosition { get; set; }
  /// <summary>
  ///   PercentageColorPosition.
  /// </summary>
  public Double? PercentageColorPosition { get; set; }
}