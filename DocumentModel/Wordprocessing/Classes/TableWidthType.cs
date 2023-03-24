namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the TableWidthType Class.
/// </summary>
public class TableWidthType: ModelElement
{
  /// <summary>
  ///   Table Width Value
  /// </summary>
  public String? Width { get; set; }

  /// <summary>
  ///   Table Width Type
  /// </summary>
  public TableWidthUnitKind? Type { get; set; }
}