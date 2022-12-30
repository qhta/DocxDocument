namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the MultiLvlStrRefExtension Class.
/// </summary>
public partial class MultiLvlStrRefExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get; set; }
  
  public DocumentModel.Drawings.Charts.FullReference? FullReference { get; set; }
  
  public DocumentModel.Drawings.Charts.LevelReference? LevelReference { get; set; }
  
  public DocumentModel.Drawings.Charts.FormulaReference? FormulaReference { get; set; }
  
}
