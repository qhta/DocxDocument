namespace DocumentModel.Presentation;

/// <summary>
/// Web Properties.
/// </summary>
public interface IWebProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Show animation in HTML output
  /// </summary>
  public Boolean? ShowAnimation { get ; set; }
  
  /// <summary>
  /// Resize graphics in HTML output
  /// </summary>
  public Boolean? ResizeGraphics { get ; set; }
  
  /// <summary>
  /// Allow PNG in HTML output
  /// </summary>
  public Boolean? AllowPng { get ; set; }
  
  /// <summary>
  /// Rely on VML for HTML output
  /// </summary>
  public Boolean? RelyOnVml { get ; set; }
  
  /// <summary>
  /// Organize HTML output in folders
  /// </summary>
  public Boolean? OrganizeInFolders { get ; set; }
  
  /// <summary>
  /// Use long file names in HTML output
  /// </summary>
  public Boolean? UseLongFilenames { get ; set; }
  
  /// <summary>
  /// Image size for HTML output
  /// </summary>
  public WebScreenSizeValues? ImageSize { get ; set; }
  
  /// <summary>
  /// Encoding for HTML output
  /// </summary>
  public String? Encoding { get ; set; }
  
  /// <summary>
  /// Slide Navigation Colors for HTML output
  /// </summary>
  public WebColorValues? Color { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
