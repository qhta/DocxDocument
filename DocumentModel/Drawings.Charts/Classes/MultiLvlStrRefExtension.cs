namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the MultiLvlStrRefExtension Class.
/// </summary>
public record MultiLvlStrRefExtension
{
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }

  public FullReference? FullReference { get; set; }

  public LevelReference? LevelReference { get; set; }

  public FormulaReference? FormulaReference { get; set; }
}