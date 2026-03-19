namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single instance of a custom property for a smart tag.
/// </summary>
public partial interface CustomProperty : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; }

  /// <summary>
  /// The value.
  /// </summary>
  public string Value { get; set; }
}
