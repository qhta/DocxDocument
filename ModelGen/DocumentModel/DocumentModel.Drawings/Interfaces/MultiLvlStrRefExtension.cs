namespace DocumentModel.Drawings;

/// <summary>
/// Defines the MultiLvlStrRefExtension Class.
/// </summary>
public interface MultiLvlStrRefExtension
{
  public FullReference? FullReference { get ; set; }
  
  public LevelReference? LevelReference { get ; set; }
  
  public FormulaReference? FormulaReference { get ; set; }
  
}
