namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ObjectDefaults Class.
/// </summary>
public interface IObjectDefaults // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Shape Default.
  /// </summary>
  public IShapeDefault? ShapeDefault { get ; set; }
  
  /// <summary>
  /// Line Default.
  /// </summary>
  public ILineDefault? LineDefault { get ; set; }
  
  /// <summary>
  /// Text Default.
  /// </summary>
  public ITextDefault? TextDefault { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
