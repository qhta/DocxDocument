namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a recently used file.
/// </summary>
public partial interface RecentFile : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; }

  /// <summary>
  /// The index.
  /// </summary>
  public int Index { get; }

  /// <summary>
  /// The read only.
  /// </summary>
  public bool ReadOnly { get; set; }

  /// <summary>
  /// The path.
  /// </summary>
  public string Path { get; }
}
