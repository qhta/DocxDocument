namespace DocumentModel.Drawing;

/// <summary>
/// Defines the MinValueColorEndPosition Class.
/// </summary>
public interface IMinValueColorEndPosition // : DocumentModel.Drawing.IOpenXmlValueColorEndPositionElement
{
  public Boolean? ExtremeValueColorPosition { get ; set; }
  
  public Double? NumberColorPosition { get ; set; }
  
  public Double? PercentageColorPosition { get ; set; }
  
}
