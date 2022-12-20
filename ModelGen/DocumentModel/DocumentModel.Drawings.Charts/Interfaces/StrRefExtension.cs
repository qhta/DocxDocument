namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the StrRefExtension Class.
/// </summary>
public partial interface StrRefExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get; set; }
  
  public DocumentModel.Drawings.Charts.FullReference? FullReference { get; set; }
  
  public DocumentModel.Drawings.Charts.LevelReference? LevelReference { get; set; }
  
  public DocumentModel.Drawings.Charts.FormulaReference? FormulaReference { get; set; }
  
}
