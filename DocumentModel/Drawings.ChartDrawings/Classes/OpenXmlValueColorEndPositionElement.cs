namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the OpenXmlValueColorEndPositionElement Class.
/// </summary>
public record OpenXmlValueColorEndPositionElement
{
  /// <summary>
  ///   ExtremeValueColorPosition.
  /// </summary>
  public Boolean? ExtremeValueColorPosition { get; set; }

  /// <summary>
  ///   NumberColorPosition.
  /// </summary>
  public Double? NumberColorPosition { get; set; }

  /// <summary>
  ///   PercentageColorPosition.
  /// </summary>
  public Double? PercentageColorPosition { get; set; }
}