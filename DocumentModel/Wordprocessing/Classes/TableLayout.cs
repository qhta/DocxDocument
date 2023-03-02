namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the TableLayout Class.
/// </summary>
public record TableLayout
{
  /// <summary>
  ///   Table Layout Setting
  /// </summary>
  public TableLayoutKind? Type { get; set; }
}