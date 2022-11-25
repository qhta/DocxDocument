namespace DocumentModel.Presentation;

/// <summary>
/// Web Properties.
/// </summary>
public interface IWebProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Show animation in HTML output
  /// </summary>
  public System.Boolean? ShowAnimation { get ; set; }
  
  /// <summary>
  /// Resize graphics in HTML output
  /// </summary>
  public System.Boolean? ResizeGraphics { get ; set; }
  
  /// <summary>
  /// Allow PNG in HTML output
  /// </summary>
  public System.Boolean? AllowPng { get ; set; }
  
  /// <summary>
  /// Rely on VML for HTML output
  /// </summary>
  public System.Boolean? RelyOnVml { get ; set; }
  
  /// <summary>
  /// Organize HTML output in folders
  /// </summary>
  public System.Boolean? OrganizeInFolders { get ; set; }
  
  /// <summary>
  /// Use long file names in HTML output
  /// </summary>
  public System.Boolean? UseLongFilenames { get ; set; }
  
  /// <summary>
  /// Image size for HTML output
  /// </summary>
  public DocumentModel.Presentation.WebScreenSizeKind? ImageSize { get ; set; }
  
  /// <summary>
  /// Encoding for HTML output
  /// </summary>
  public System.String? Encoding { get ; set; }
  
  /// <summary>
  /// Slide Navigation Colors for HTML output
  /// </summary>
  public DocumentModel.Presentation.WebColorKind? Color { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
