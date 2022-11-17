namespace DocumentModel.Office2010.CustomUI;

public interface IBackstageRegularButton // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public string? Screentip { get ; set; }

  public string? GetScreentip { get ; set; }

  public string? Supertip { get ; set; }

  public string? GetSupertip { get ; set; }

  public string? Id { get ; set; }

  public string? QualifiedId { get ; set; }

  public string? Tag { get ; set; }

  public string? OnAction { get ; set; }

  public bool? IsDefinitive { get ; set; }

  public bool? Enabled { get ; set; }

  public string? GetEnabled { get ; set; }

  public string? Label { get ; set; }

  public string? GetLabel { get ; set; }

  public bool? Visible { get ; set; }

  public string? GetVisible { get ; set; }

  public string? Keytip { get ; set; }

  public string? GetKeytip { get ; set; }

  public string? Image { get ; set; }

  public string? ImageMso { get ; set; }

  public string? GetImage { get ; set; }

}
