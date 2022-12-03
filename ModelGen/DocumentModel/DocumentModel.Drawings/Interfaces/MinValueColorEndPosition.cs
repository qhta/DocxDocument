namespace DocumentModel.Drawings;

/// <summary>
/// Defines the MinValueColorEndPosition Class.
/// </summary>
public interface MinValueColorEndPosition // : DocumentModel.Drawings.OpenXmlValueColorEndPositionElement
{
  public Boolean? ExtremeValueColorPosition { get ; set; }
  
  public Double? NumberColorPosition { get ; set; }
  
  public Double? PercentageColorPosition { get ; set; }
  
}
