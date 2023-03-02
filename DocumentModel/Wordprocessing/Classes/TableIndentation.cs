namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the TableIndentation Class.
/// </summary>
public record TableIndentation
{
  /// <summary>
  ///   w
  /// </summary>
  public Int32? Width { get; set; }

  /// <summary>
  ///   type
  /// </summary>
  public TableWidthUnitKind? Type { get; set; }
}