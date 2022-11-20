namespace DocumentModel.Presentation;

/// <summary>
/// Normal View Restored Top Properties.
/// </summary>
public class RestoredTop: IRestoredTop
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
