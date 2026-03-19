namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single user who has been given specific permissions to edit portions of a document.
/// </summary>
public partial interface Editor : InteropObject
{
  /// <summary>
  /// The id.
  /// </summary>
  public string ID { get; }

  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; }

  /// <summary>
  /// The range.
  /// </summary>
  public Range Range { get; }

  /// <summary>
  /// The next range.
  /// </summary>
  public Range NextRange { get; }
}
