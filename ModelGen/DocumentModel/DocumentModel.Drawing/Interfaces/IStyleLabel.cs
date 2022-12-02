namespace DocumentModel.Drawing;

/// <summary>
/// Style Label.
/// </summary>
public interface IStyleLabel // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Style Name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// 3-D Scene.
  /// </summary>
  public DocumentModel.Drawing.IScene3D? Scene3D { get ; set; }
  
  /// <summary>
  /// 3-D Shape Properties.
  /// </summary>
  public DocumentModel.Drawing.IShape3D? Shape3D { get ; set; }
  
  /// <summary>
  /// Text Properties.
  /// </summary>
  public DocumentModel.Drawing.ITextProperties? TextProperties { get ; set; }
  
  /// <summary>
  /// Shape Style.
  /// </summary>
  public DocumentModel.Drawing.IStyle? Style { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
