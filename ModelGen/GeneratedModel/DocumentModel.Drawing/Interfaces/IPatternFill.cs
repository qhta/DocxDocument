namespace DocumentModel.Drawing;

public interface IPatternFill // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public PresetPattern? Preset { get ; set; }
  
  public DocumentModel.Drawing.IForegroundColor? ForegroundColor { get ; set; }
  
  public DocumentModel.Drawing.IBackgroundColor? BackgroundColor { get ; set; }
  
}
