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
  
  public DMDD.StyleDisplayCategories? StyleDisplayCategories { get; set; }
  
  public DMDD.Scene3D? Scene3D { get; set; }
  
  public DMDD.ExtensionList? ExtensionList { get; set; }
  
}
