namespace DocumentModel.Interop;

/// <summary>
/// Represents a recognized function. The OMathRecognizedFunction object is a member of the OMathRecognizedFunctions collection.
/// </summary>
public partial interface OMathRecognizedFunction : InteropObject
{
  /// <summary>
  /// The index.
  /// </summary>
  public int Index { get; }

  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; }
}
