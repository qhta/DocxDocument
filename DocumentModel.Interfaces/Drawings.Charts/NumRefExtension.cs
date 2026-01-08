namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the NumRefExtension Class.
/// </summary>
public interface NumRefExtension: Extension
{
  public FullReference? FullReference { get; set; }
  public LevelReference? LevelReference { get; set; }
  public FormulaReference? FormulaReference { get; set; }
}