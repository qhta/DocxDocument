namespace DocumentModel.Office2010.Drawing;

public interface IBackgroundRemoval // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public int? MarqueeTop { get ; set; }
  
  public int? MarqueeBottom { get ; set; }
  
  public int? MarqueeLeft { get ; set; }
  
  public int? MarqueeRight { get ; set; }
  
}
