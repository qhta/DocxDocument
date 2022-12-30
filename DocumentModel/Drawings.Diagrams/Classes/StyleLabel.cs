namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Style Label.
/// </summary>
public partial class StyleLabel
{
  /// <summary>
  /// Style Name
  /// </summary>
  public String? Name { get; set; }
  
  /// <summary>
  /// 3-D Scene.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.Scene3D? Scene3D { get; set; }
  
  /// <summary>
  /// 3-D Shape Properties.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.Shape3D? Shape3D { get; set; }
  
  /// <summary>
  /// Text Properties.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.TextProperties? TextProperties { get; set; }
  
  /// <summary>
  /// Shape Style.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.Style? Style { get; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.ExtensionList? ExtensionList { get; set; }
  
}
