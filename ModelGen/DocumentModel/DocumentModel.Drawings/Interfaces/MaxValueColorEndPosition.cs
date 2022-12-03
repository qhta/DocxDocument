namespace DocumentModel.Drawings;

/// <summary>
/// Defines the MaxValueColorEndPosition Class.
/// </summary>
public interface MaxValueColorEndPosition // : DocumentModel.Drawings.OpenXmlValueColorEndPositionElement
{
  public Boolean? ExtremeValueColorPosition { get ; set; }
  
  public Double? NumberColorPosition { get ; set; }
  
  public Double? PercentageColorPosition { get ; set; }
  
}
