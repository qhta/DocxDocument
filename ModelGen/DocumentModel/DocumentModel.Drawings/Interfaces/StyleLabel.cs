namespace DocumentModel.Drawings;

/// <summary>
/// Style Label.
/// </summary>
public interface StyleLabel
{
  /// <summary>
  /// Style Name
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// 3-D Scene.
  /// </summary>
  public DocumentModel.Drawings.Scene3D? Scene3D { get ; set; }
  
  /// <summary>
  /// 3-D Shape Properties.
  /// </summary>
  public DocumentModel.Drawings.Shape3D? Shape3D { get ; set; }
  
  /// <summary>
  /// Text Properties.
  /// </summary>
  public DocumentModel.Drawings.TextProperties? TextProperties { get ; set; }
  
  /// <summary>
  /// Shape Style.
  /// </summary>
  public DocumentModel.Drawings.Style? Style { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get ; set; }
  
}
