namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Style Definition.
/// </summary>
public partial class StyleDefinition
{
  
  /// <summary>
  ///   Unique Style ID
  /// </summary>
  public String? UniqueId { get; set; }
  
  
  /// <summary>
  ///   Minimum Version
  /// </summary>
  public String? MinVersion { get; set; }
  
  public DocumentModel.Drawings.Diagrams.StyleDisplayCategories? StyleDisplayCategories { get; set; }
  
  public DocumentModel.Drawings.Diagrams.Scene3D? Scene3D { get; set; }
  
  public DocumentModel.Drawings.Diagrams.ExtensionList? ExtensionList { get; set; }
  
  public DM.ElementCollection<IModelElement>? Items { get; set; }
  
}
