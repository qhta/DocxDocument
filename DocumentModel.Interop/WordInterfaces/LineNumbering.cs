namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents line numbers in the left margin or to the left of each newspaper-style column.
/// </summary>
public interface LineNumbering : InteropObject
{
  /// <summary>
  /// The restart mode.
  /// </summary>
  public WdNumberingRule RestartMode { get; set; }
  /// <summary>
  /// The starting number.
  /// </summary>
  public int StartingNumber { get; set; }
  /// <summary>
  /// The distance from text.
  /// </summary>
  public float DistanceFromText { get; set; }
  /// <summary>
  /// The count by.
  /// </summary>
  public int CountBy { get; set; }
  /// <summary>
  /// The active.
  /// </summary>
  public int Active { get; set; }

}
