namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single AutoText entry.
/// </summary>
public partial interface AutoTextEntry : InteropObject
{
  /// <summary>
  /// The index.
  /// </summary>
  public int Index { get; }

  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; set; }

  /// <summary>
  /// The style name.
  /// </summary>
  public string StyleName { get; }

  /// <summary>
  /// The value.
  /// </summary>
  public string Value { get; set; }
}
