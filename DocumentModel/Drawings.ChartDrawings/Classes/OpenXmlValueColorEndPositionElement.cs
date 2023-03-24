namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the OpenXmlValueColorEndPositionElement Class.
/// </summary>
public class OpenXmlValueColorEndPositionElement: ModelElement
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