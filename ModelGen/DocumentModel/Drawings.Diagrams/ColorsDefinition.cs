namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Color Transform Definitions.
/// </summary>
public partial class ColorsDefinition
{
  
  /// <summary>
  ///   Unique ID
  /// </summary>
  public String? UniqueId { get; set; }
  
  
  /// <summary>
  ///   Minimum Version
  /// </summary>
  public String? MinVersion { get; set; }
  
  public DocumentModel.Drawings.Diagrams.ColorTransformCategories? ColorTransformCategories { get; set; }
  
  public DocumentModel.Drawings.Diagrams.ExtensionList? ExtensionList { get; set; }
  
}
