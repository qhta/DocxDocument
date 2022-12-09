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
  public Scene3D? Scene3D { get ; set; }
  
  /// <summary>
  /// 3-D Shape Properties.
  /// </summary>
  public Shape3D? Shape3D { get ; set; }
  
  /// <summary>
  /// Text Properties.
  /// </summary>
  public TextProperties2? TextProperties { get ; set; }
  
  /// <summary>
  /// Shape Style.
  /// </summary>
  public Style1? Style { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList1? ExtensionList { get ; set; }
  
}
