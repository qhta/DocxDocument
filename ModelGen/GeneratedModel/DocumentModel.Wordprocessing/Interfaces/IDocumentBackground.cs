namespace DocumentModel.Wordprocessing;

public interface IDocumentBackground // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public string? Color { get ; set; }

  public ThemeColor? ThemeColor { get ; set; }

  public string? ThemeTint { get ; set; }

  public string? ThemeShade { get ; set; }

  public DocumentModel.Vml.IBackground? Background { get ; set; }

}
