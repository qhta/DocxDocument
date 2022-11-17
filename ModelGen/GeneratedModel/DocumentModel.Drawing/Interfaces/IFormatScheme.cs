namespace DocumentModel.Drawing;

public interface IFormatScheme // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public string? Name { get ; set; }
  
  public IFillStyleList? FillStyleList { get ; set; }
  
  public ILineStyleList? LineStyleList { get ; set; }
  
  public IEffectStyleList? EffectStyleList { get ; set; }
  
  public IBackgroundFillStyleList? BackgroundFillStyleList { get ; set; }
  
}
