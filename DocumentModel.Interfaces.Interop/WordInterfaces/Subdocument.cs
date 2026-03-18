namespace DocumentModel.Interop;

/// <summary>
/// Represents a subdocument within a document or range.
/// </summary>
public partial interface Subdocument : InteropObject
{
  /// <summary>
  /// The locked.
  /// </summary>
  public bool Locked { get; set; }

  /// <summary>
  /// The range.
  /// </summary>
  public Range Range { get; }

  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; }

  /// <summary>
  /// The path.
  /// </summary>
  public string Path { get; }

  /// <summary>
  /// The has file.
  /// </summary>
  public bool HasFile { get; }

  /// <summary>
  /// The level.
  /// </summary>
  public int Level { get; }
}
