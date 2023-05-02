namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the TableLayout Class.
/// </summary>
public class TableLayout: ModelElement
{
  /// <summary>
  ///   Table Layout Setting
  /// </summary>
  public TableLayoutKind? Type { get; set; }
}