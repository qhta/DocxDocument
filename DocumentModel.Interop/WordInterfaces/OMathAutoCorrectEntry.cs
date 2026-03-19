namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an individual entry in the OMathAutoCorrectEntries collection.
/// </summary>
public partial interface OMathAutoCorrectEntry : InteropObject
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
  /// The value.
  /// </summary>
  public string Value { get; set; }
}
