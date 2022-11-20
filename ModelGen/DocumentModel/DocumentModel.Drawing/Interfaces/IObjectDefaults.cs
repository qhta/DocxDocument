namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ObjectDefaults Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IShapeDefault))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ILineDefault))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ITextDefault))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtensionList))]
public interface IObjectDefaults // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
