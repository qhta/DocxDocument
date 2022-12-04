namespace DocumentModel.Wordprocessing;

/// <summary>
/// Single Frame Properties.
/// </summary>
public class Frame
{
  /// <summary>
  /// Scrollbar Display Option.
  /// </summary>
  public FrameScrollbarVisibilityKind? ScrollbarVisibility
  {
    get;
    set;
  }
  
  /// <summary>
  /// Frame Cannot Be Resized.
  /// </summary>
  public OnOffOnlyKind? NoResizeAllowed
  {
    get;
    set;
  }
  
  /// <summary>
  /// Maintain Link to Existing File.
  /// </summary>
  public OnOffOnlyKind? LinkedToFile
  {
    get;
    set;
  }
  
}
