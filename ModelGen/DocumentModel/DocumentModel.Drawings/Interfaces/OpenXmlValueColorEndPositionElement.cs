namespace DocumentModel.Drawings;

/// <summary>
/// Defines the OpenXmlValueColorEndPositionElement Class.
/// </summary>
public interface OpenXmlValueColorEndPositionElement // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// ExtremeValueColorPosition.
  /// </summary>
  public Boolean? ExtremeValueColorPosition { get ; set; }
  
  /// <summary>
  /// NumberColorPosition.
  /// </summary>
  public Double? NumberColorPosition { get ; set; }
  
  /// <summary>
  /// PercentageColorPosition.
  /// </summary>
  public Double? PercentageColorPosition { get ; set; }
  
}
