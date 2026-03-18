namespace DocumentModel.Interop;

/// <summary>
/// Represents an item in a drop-down form field.
/// </summary>
public partial interface ListEntry : InteropObject
{
  /// <summary>
  /// The index.
  /// </summary>
  public int Index { get; }

  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; set; }
}
