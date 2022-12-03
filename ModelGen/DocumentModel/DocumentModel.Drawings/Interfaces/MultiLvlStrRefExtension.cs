namespace DocumentModel.Drawings;

/// <summary>
/// Defines the MultiLvlStrRefExtension Class.
/// </summary>
public interface MultiLvlStrRefExtension // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public FullReference? FullReference { get ; set; }
  
  public LevelReference? LevelReference { get ; set; }
  
  public FormulaReference? FormulaReference { get ; set; }
  
}
