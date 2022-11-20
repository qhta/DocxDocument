namespace DocumentModel.Presentation;

/// <summary>
/// Slide Range.
/// </summary>
public class SlideRange: ISlideRange
{
  /// <summary>
  /// Start
  /// </summary>
  public uint? Start
  {
    get;
    set;
  }
  
  /// <summary>
  /// End
  /// </summary>
  public uint? End
  {
    get;
    set;
  }
  
}
