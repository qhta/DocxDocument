namespace DocumentModel.Wordprocessing;

public interface IUnderline // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public DocumentModel.Wordprocessing.Underline? Val { get ; set; }

  public string? Color { get ; set; }

  public ThemeColor? ThemeColor { get ; set; }

  public string? ThemeTint { get ; set; }

  public string? ThemeShade { get ; set; }

}
