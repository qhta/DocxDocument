namespace DocumentModel.Presentation;

/// <summary>
/// Normal View Restored Left Properties.
/// </summary>
public class RestoredLeft: IRestoredLeft
{
  /// <summary>
  /// Normal View Dimension Size
  /// </summary>
  public int? Size
  {
    get;
    set;
  }
  
  /// <summary>
  /// Auto Adjust Normal View
  /// </summary>
  public bool? AutoAdjust
  {
    get;
    set;
  }
  
}
