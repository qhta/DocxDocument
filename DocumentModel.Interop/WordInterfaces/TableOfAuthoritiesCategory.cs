namespace DocumentModel.Interop;

/// <summary>
/// Represents a single table of authorities category.
/// </summary>
public interface TableOfAuthoritiesCategory : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; set; }
  /// <summary>
  /// The index.
  /// </summary>
  public int Index { get; }

}
