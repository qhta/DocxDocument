namespace DocumentModel.Interop;

/// <summary>
/// Represents the math AutoCorrect feature in Microsoft Office Word. To access the math AutoCorrect entries, use the OMathAutoCorrectEntries collection.
/// </summary>
public interface OMathAutoCorrect : InteropObject
{
  /// <summary>
  /// The replace text.
  /// </summary>
  public bool ReplaceText { get; set; }
  /// <summary>
  /// The use outside omath.
  /// </summary>
  public bool UseOutsideOMath { get; set; }
  /// <summary>
  /// The entries.
  /// </summary>
  public OMathAutoCorrectEntries Entries { get; }
  /// <summary>
  /// The functions.
  /// </summary>
  public OMathRecognizedFunctions Functions { get; }

}
