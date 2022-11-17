namespace DocumentModel.Drawing;

public interface IHyperlinkOnHover // : DocumentFormat.OpenXml.Drawing.HyperlinkType
{
  public string? Id { get ; set; }

  public string? InvalidUrl { get ; set; }

  public string? Action { get ; set; }

  public string? TargetFrame { get ; set; }

  public string? Tooltip { get ; set; }

  public bool? History { get ; set; }

  public bool? HighlightClick { get ; set; }

  public bool? EndSound { get ; set; }

  public IHyperlinkSound? HyperlinkSound { get ; set; }

  public IHyperlinkExtensionList? HyperlinkExtensionList { get ; set; }

}
