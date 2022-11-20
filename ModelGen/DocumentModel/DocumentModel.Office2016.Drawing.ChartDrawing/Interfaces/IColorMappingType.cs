namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the ColorMappingType Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtensionList))]
public interface IColorMappingType // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Background 1
  /// </summary>
  public DocumentModel.Drawing.ColorSchemeIndexValues? Background1 { get ; set; }
  
  /// <summary>
  /// Text 1
  /// </summary>
  public DocumentModel.Drawing.ColorSchemeIndexValues? Text1 { get ; set; }
  
  /// <summary>
  /// Background 2
  /// </summary>
  public DocumentModel.Drawing.ColorSchemeIndexValues? Background2 { get ; set; }
  
  /// <summary>
  /// Text 2
  /// </summary>
  public DocumentModel.Drawing.ColorSchemeIndexValues? Text2 { get ; set; }
  
  /// <summary>
  /// Accent 1
  /// </summary>
  public DocumentModel.Drawing.ColorSchemeIndexValues? Accent1 { get ; set; }
  
  /// <summary>
  /// Accent 2
  /// </summary>
  public DocumentModel.Drawing.ColorSchemeIndexValues? Accent2 { get ; set; }
  
  /// <summary>
  /// Accent 3
  /// </summary>
  public DocumentModel.Drawing.ColorSchemeIndexValues? Accent3 { get ; set; }
  
  /// <summary>
  /// Accent 4
  /// </summary>
  public DocumentModel.Drawing.ColorSchemeIndexValues? Accent4 { get ; set; }
  
  /// <summary>
  /// Accent 5
  /// </summary>
  public DocumentModel.Drawing.ColorSchemeIndexValues? Accent5 { get ; set; }
  
  /// <summary>
  /// Accent 6
  /// </summary>
  public DocumentModel.Drawing.ColorSchemeIndexValues? Accent6 { get ; set; }
  
  /// <summary>
  /// Hyperlink
  /// </summary>
  public DocumentModel.Drawing.ColorSchemeIndexValues? Hyperlink { get ; set; }
  
  /// <summary>
  /// Followed Hyperlink
  /// </summary>
  public DocumentModel.Drawing.ColorSchemeIndexValues? FollowedHyperlink { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
