namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies that a break shall be placed at the current location in the run content. 
///   A break is a special character which is used to override the normal line breaking 
///   that would be performed based on the normal layout of the document’s contents. 
///   The behavior of this break character (the location where text shall be restarted after this break) 
///   shall be determined by its type and clear attribute values.
/// </summary>
public class Break: ModelElement, IRunContent
{
  /// <summary>
  ///   Break type
  /// </summary>
  public BreakKind? Type { get; set; }

  /// <summary>
  ///   Restart location for text wrapping break
  /// </summary>
  public BreakTextRestartLocationKind? Clear { get; set; }

}