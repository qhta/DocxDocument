namespace DocumentModel.Drawing.Diagrams;

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
  public DocumentModel.Drawing.Diagrams.IScene3D? Scene3D { get ; set; }
  
  /// <summary>
  /// 3-D Shape Properties.
  /// </summary>
  public DocumentModel.Drawing.Diagrams.IShape3D? Shape3D { get ; set; }
  
  /// <summary>
  /// Text Properties.
  /// </summary>
  public DocumentModel.Drawing.Diagrams.ITextProperties? TextProperties { get ; set; }
  
  /// <summary>
  /// Shape Style.
  /// </summary>
  public DocumentModel.Drawing.Diagrams.IStyle? Style { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
