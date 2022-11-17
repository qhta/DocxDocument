namespace DocumentModel.Wordprocessing;

public interface IColor // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public string? Val { get ; set; }

  public ThemeColor? ThemeColor { get ; set; }

  public string? ThemeTint { get ; set; }

  public string? ThemeShade { get ; set; }

}
