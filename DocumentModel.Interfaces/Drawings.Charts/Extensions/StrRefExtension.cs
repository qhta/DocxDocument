namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the StrRefExtension Class.
/// </summary>
public interface StrRefExtension: Extension
{
  public FullReference? FullReference { get; set; }
  public LevelReference? LevelReference { get; set; }
  public FormulaReference? FormulaReference { get; set; }
}