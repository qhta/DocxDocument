namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the MultiLvlStrRefExtension Class.
/// </summary>
public interface MultiLvlStrRefExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public DocumentModel.Drawings13.Charts.FullReference? FullReference { get ; set; }
  
  public DocumentModel.Drawings13.Charts.LevelReference? LevelReference { get ; set; }
  
  public DocumentModel.Drawings13.Charts.FormulaReference? FormulaReference { get ; set; }
  
}
