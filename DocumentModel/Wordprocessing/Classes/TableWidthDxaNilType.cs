namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the TableWidthDxaNilType Class.
/// </summary>
public class TableWidthDxaNilType: ModelElement
{
  /// <summary>
  ///   w
  /// </summary>
  public Int16? Width { get; set; }

  /// <summary>
  ///   type
  /// </summary>
  public TableWidthKind? Type { get; set; }
}