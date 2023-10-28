namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Style Label.
/// </summary>
public partial class StyleLabel
{
  
  /// <summary>
  ///   Style Name
  /// </summary>
  public String? Name { get; set; }
  
  
  /// <summary>
  ///   3-D Scene.
  /// </summary>
  public DMDD.Scene3D? Scene3D { get; set; }
  
  
  /// <summary>
  ///   3-D Shape Properties.
  /// </summary>
  public DMDD.Shape3D? Shape3D { get; set; }
  
  
  /// <summary>
  ///   Text Properties.
  /// </summary>
  public DMDD.TextProperties? TextProperties { get; set; }
  
  
  /// <summary>
  ///   Shape Style.
  /// </summary>
  public DMDD.Style? Style { get; set; }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public DMDD.ExtensionList? ExtensionList { get; set; }
  
}
