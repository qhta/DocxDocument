namespace DocumentModel.Drawing;

/// <summary>
/// Defines the MaxValueColorEndPosition Class.
/// </summary>
public interface IMaxValueColorEndPosition // : DocumentModel.Drawing.IOpenXmlValueColorEndPositionElement
{
  public System.Boolean? ExtremeValueColorPosition { get ; set; }
  
  public System.Double? NumberColorPosition { get ; set; }
  
  public System.Double? PercentageColorPosition { get ; set; }
  
}
