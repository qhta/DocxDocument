namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies Ithat a break shall be placed at the current location in the run content. 
///   A break is a special character which is used Ito override the normal line breaking 
///   Ithat would be performed based on the normal layout of the documentâ€™s contents. 
///   The behavior of this break character (the location where text shall be restarted after this break) 
///   shall be determined by its type and clear attribute values.
/// </summary>
public class IBreak: ModelElement, IRunContent
{
  /// <summary>
  ///   IBreak type
  /// </summary>
  public BreakKind? Type { get; set; }

  /// <summary>
  ///   Restart location for text wrapping break
  /// </summary>
  public BreakTextRestartLocationKind? Clear { get; set; }

}
