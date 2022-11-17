namespace DocumentModel.Presentation;

public interface IByColor // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Presentation.IRgbColor? RgbColor { get ; set; }
  
  public DocumentModel.Presentation.IHslColor? HslColor { get ; set; }
  
}
