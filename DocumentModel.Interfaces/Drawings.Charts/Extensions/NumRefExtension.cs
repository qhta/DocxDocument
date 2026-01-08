namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents an extension for a number reference in a chart.
///   This extension allows specifying full references, level references, and formula references for numeric chart data.
/// </summary>
public interface NumRefExtension: Extension
{
  /// <summary>
  ///   Full reference to the numeric data source.
  /// </summary>
  public FullReference? FullReference { get; set; }

  /// <summary>
  ///   Reference to a specific level within the numeric data (if applicable).
  /// </summary>
  public LevelReference? LevelReference { get; set; }

  /// <summary>
  ///   Formula reference defining the numeric data source dynamic range.
  /// </summary>
  public FormulaReference? FormulaReference { get; set; }
}