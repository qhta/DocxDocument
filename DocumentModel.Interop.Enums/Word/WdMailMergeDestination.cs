namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a destination for mail merge results.
/// </summary>
public enum WdMailMergeDestination
{
  /// <summary>
  /// Send results to a new Word document.
  /// </summary>
  NewDocument = unchecked((int)0),
  /// <summary>
  /// Send results to a printer.
  /// </summary>
  Printer = unchecked((int)1),
  /// <summary>
  /// Send results to e-mail recipient.
  /// </summary>
  Email = unchecked((int)2),
  /// <summary>
  /// Send results to fax recipient.
  /// </summary>
  Fax = unchecked((int)3)
}
