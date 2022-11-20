namespace DocumentModel.Presentation;

/// <summary>
/// Presentation Slide.
/// </summary>
public class OutlineViewSlideListEntry: IOutlineViewSlideListEntry
{
  /// <summary>
  /// Relationship Identifier
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// Collapsed
  /// </summary>
  public bool? Collapse
  {
    get;
    set;
  }
  
}
