namespace DocumentModel.Drawings;

/// <summary>
/// Style Label.
/// </summary>
public interface StyleLabel // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Style Name
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// 3-D Scene.
  /// </summary>
  public Scene3D? Scene3D { get ; set; }
  
  /// <summary>
  /// 3-D Shape Properties.
  /// </summary>
  public Shape3D? Shape3D { get ; set; }
  
  /// <summary>
  /// Text Properties.
  /// </summary>
  public TextProperties? TextProperties { get ; set; }
  
  /// <summary>
  /// Shape Style.
  /// </summary>
  public Style? Style { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get ; set; }
  
}
