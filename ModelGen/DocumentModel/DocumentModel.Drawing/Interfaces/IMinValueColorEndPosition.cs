namespace DocumentModel.Drawing;

/// <summary>
/// Defines the MinValueColorEndPosition Class.
/// </summary>
public interface IMinValueColorEndPosition // : DocumentModel.Drawing.IOpenXmlValueColorEndPositionElement
{
  public System.Boolean? ExtremeValueColorPosition { get ; set; }
  
  public System.Double? NumberColorPosition { get ; set; }
  
  public System.Double? PercentageColorPosition { get ; set; }
  
}
