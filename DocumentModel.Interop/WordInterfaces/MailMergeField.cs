namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single mail merge field in a document.
/// </summary>
public partial interface MailMergeField : InteropObject
{
  /// <summary>
  /// The type.
  /// </summary>
  public WdFieldType Type { get; }

  /// <summary>
  /// The locked.
  /// </summary>
  public bool Locked { get; set; }

  /// <summary>
  /// The code.
  /// </summary>
  public Range Code { get; set; }

  /// <summary>
  /// The next.
  /// </summary>
  public MailMergeField Next { get; }

  /// <summary>
  /// The previous.
  /// </summary>
  public MailMergeField Previous { get; }
}
