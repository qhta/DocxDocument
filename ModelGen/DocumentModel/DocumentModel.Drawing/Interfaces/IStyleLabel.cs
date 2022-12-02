namespace DocumentModel.Drawing;

/// <summary>
/// Style Label.
/// </summary>
public interface IStyleLabel // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Style Name
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// 3-D Scene.
  /// </summary>
  public IScene3D? Scene3D { get ; set; }
  
  /// <summary>
  /// 3-D Shape Properties.
  /// </summary>
  public IShape3D? Shape3D { get ; set; }
  
  /// <summary>
  /// Text Properties.
  /// </summary>
  public ITextProperties? TextProperties { get ; set; }
  
  /// <summary>
  /// Shape Style.
  /// </summary>
  public IStyle? Style { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
