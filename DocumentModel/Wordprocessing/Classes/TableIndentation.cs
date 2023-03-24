namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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
  public TableWidthUnitKind? Type { get; set; }
}