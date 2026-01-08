namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents an extension for a multi-level string reference in a chart.
///   This extension allows specifying full references, level references, and formula references for hierarchical data.
/// </summary>
public interface MultiLvlStrRefExtension: Extension
{
  /// <summary>
  ///   Full reference to the data source.
  /// </summary>
  public FullReference? FullReference { get; set; }

  /// <summary>
  ///   Reference to a specific level within the multi-level data.
  /// </summary>
  public LevelReference? LevelReference { get; set; }

  /// <summary>
  ///   Formula reference defining the data source dynamic range.
  /// </summary>
  public FormulaReference? FormulaReference { get; set; }
}