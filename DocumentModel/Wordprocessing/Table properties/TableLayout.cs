namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the TableLayout Class.
/// </summary>
public class TableLayout: ModelElement
{
  /// <summary>
  ///   ITable Layout Setting
  /// </summary>
  public TableLayoutKind? Type { get; set; }
}
