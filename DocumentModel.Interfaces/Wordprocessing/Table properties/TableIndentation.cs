namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the TableIndentation Class.
/// </summary>
public class TableIndentation: ModelElement
{
  /// <summary>
  ///   w
  /// </summary>
  public Int32? Width { get; set; }
  /// <summary>
  ///   type
  /// </summary>
  public TableWidthUnitType? Type { get; set; }
}