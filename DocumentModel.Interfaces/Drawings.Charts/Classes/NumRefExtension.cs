namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the NumRefExtension Class.
/// </summary>
public class NumRefExtension: ModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public FullReference? FullReference { get; set; }
  public LevelReference? LevelReference { get; set; }
  public FormulaReference? FormulaReference { get; set; }
}