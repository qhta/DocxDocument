namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents an extension for a string reference in a chart.
///   This extension allows specifying full references, level references, and formula references for string chart data.
/// </summary>
public interface StrRefExtension: Extension
{
  /// <summary>
  ///   Full reference to the string data source.
  /// </summary>
  public FullReference? FullReference { get; set; }

  /// <summary>
  ///   Reference to a specific level within the string data (if applicable).
  /// </summary>
  public LevelReference? LevelReference { get; set; }

  /// <summary>
  ///   Formula reference defining the string data source dynamic range.
  /// </summary>
  public FormulaReference? FormulaReference { get; set; }
}