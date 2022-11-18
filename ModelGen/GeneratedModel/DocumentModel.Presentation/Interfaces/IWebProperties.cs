namespace DocumentModel.Presentation;

/// <summary>
/// Web Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IExtensionList))]
public interface IWebProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Show animation in HTML output
  /// </summary>
  public bool? ShowAnimation { get ; set; }
  
  /// <summary>
  /// Resize graphics in HTML output
  /// </summary>
  public bool? ResizeGraphics { get ; set; }
  
  /// <summary>
  /// Allow PNG in HTML output
  /// </summary>
  public bool? AllowPng { get ; set; }
  
  /// <summary>
  /// Rely on VML for HTML output
  /// </summary>
  public bool? RelyOnVml { get ; set; }
  
  /// <summary>
  /// Organize HTML output in folders
  /// </summary>
  public bool? OrganizeInFolders { get ; set; }
  
  /// <summary>
  /// Use long file names in HTML output
  /// </summary>
  public bool? UseLongFilenames { get ; set; }
  
  /// <summary>
  /// Image size for HTML output
  /// </summary>
  public WebScreenSize? ImageSize { get ; set; }
  
  /// <summary>
  /// Encoding for HTML output
  /// </summary>
  public string? Encoding { get ; set; }
  
  /// <summary>
  /// Slide Navigation Colors for HTML output
  /// </summary>
  public WebColor? Color { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Presentation.IExtensionList? ExtensionList { get ; set; }
  
}
