namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the OpenXmlValueColorEndPositionElement Class.
/// </summary>
public interface OpenXmlValueColorEndPositionElement: IModelElement
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