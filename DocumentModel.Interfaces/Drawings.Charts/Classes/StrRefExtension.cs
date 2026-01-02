namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the StrRefExtension Class.
/// </summary>
public class StrRefExtension: ModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public FullReference? FullReference { get; set; }
  public LevelReference? LevelReference { get; set; }
  public FormulaReference? FormulaReference { get; set; }
}