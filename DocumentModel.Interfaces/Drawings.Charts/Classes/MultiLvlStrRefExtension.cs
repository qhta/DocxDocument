namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the MultiLvlStrRefExtension Class.
/// </summary>
public interface MultiLvlStrRefExtension: IModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public FullReference? FullReference { get; set; }
  public LevelReference? LevelReference { get; set; }
  public FormulaReference? FormulaReference { get; set; }
}