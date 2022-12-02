namespace DocumentModel.Drawing;

/// <summary>
/// Defines the MaxValueColorEndPosition Class.
/// </summary>
public interface IMaxValueColorEndPosition // : DocumentModel.Drawing.IOpenXmlValueColorEndPositionElement
{
  public Boolean? ExtremeValueColorPosition { get ; set; }
  
  public Double? NumberColorPosition { get ; set; }
  
  public Double? PercentageColorPosition { get ; set; }
  
}
