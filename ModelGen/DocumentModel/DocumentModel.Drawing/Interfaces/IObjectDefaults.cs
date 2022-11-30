namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ObjectDefaults Class.
/// </summary>
public interface IObjectDefaults // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Shape Default.
  /// </summary>
  public DocumentModel.Drawing.IShapeDefault? ShapeDefault { get ; set; }
  
  /// <summary>
  /// Line Default.
  /// </summary>
  public DocumentModel.Drawing.ILineDefault? LineDefault { get ; set; }
  
  /// <summary>
  /// Text Default.
  /// </summary>
  public DocumentModel.Drawing.ITextDefault? TextDefault { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
