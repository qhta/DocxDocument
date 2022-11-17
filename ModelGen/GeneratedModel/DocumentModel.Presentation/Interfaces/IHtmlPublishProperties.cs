namespace DocumentModel.Presentation;

public interface IHtmlPublishProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public bool? ShowSpeakerNotes { get ; set; }
  
  public HtmlPublishWebBrowserSupport? TargetBrowser { get ; set; }
  
  public string? Id { get ; set; }
  
}
