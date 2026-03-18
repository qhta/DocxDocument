namespace DocumentModel.Interop;

/// <summary>
/// Represents a single tab stop.
/// </summary>
public partial interface TabStop : InteropObject
{
  /// <summary>
  /// The alignment.
  /// </summary>
  public WdTabAlignment Alignment { get; set; }

  /// <summary>
  /// The leader.
  /// </summary>
  public WdTabLeader Leader { get; set; }

  /// <summary>
  /// The position.
  /// </summary>
  public float Position { get; set; }

  /// <summary>
  /// The custom tab.
  /// </summary>
  public bool CustomTab { get; }

  /// <summary>
  /// The next.
  /// </summary>
  public TabStop Next { get; }

  /// <summary>
  /// The previous.
  /// </summary>
  public TabStop Previous { get; }
}
