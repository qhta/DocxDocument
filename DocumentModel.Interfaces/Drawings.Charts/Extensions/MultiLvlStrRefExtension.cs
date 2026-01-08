namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the MultiLvlStrRefExtension Class.
/// </summary>
public interface MultiLvlStrRefExtension: Extension
{
  public FullReference? FullReference { get; set; }
  public LevelReference? LevelReference { get; set; }
  public FormulaReference? FormulaReference { get; set; }
}