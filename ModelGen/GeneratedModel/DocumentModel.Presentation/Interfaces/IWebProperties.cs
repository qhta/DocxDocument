namespace DocumentModel.Presentation;

public interface IWebProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public bool? ShowAnimation { get ; set; }

  public bool? ResizeGraphics { get ; set; }

  public bool? AllowPng { get ; set; }

  public bool? RelyOnVml { get ; set; }

  public bool? OrganizeInFolders { get ; set; }

  public bool? UseLongFilenames { get ; set; }

  public WebScreenSize? ImageSize { get ; set; }

  public string? Encoding { get ; set; }

  public WebColor? Color { get ; set; }

  public DocumentModel.Presentation.IExtensionList? ExtensionList { get ; set; }

}
