namespace DocumentModel.Wordprocessing;

public interface IShading // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public ShadingPattern? Val { get ; set; }
  
  public string? Color { get ; set; }
  
  public ThemeColor? ThemeColor { get ; set; }
  
  public string? ThemeTint { get ; set; }
  
  public string? ThemeShade { get ; set; }
  
  public string? Fill { get ; set; }
  
  public ThemeColor? ThemeFill { get ; set; }
  
  public string? ThemeFillTint { get ; set; }
  
  public string? ThemeFillShade { get ; set; }
  
}
