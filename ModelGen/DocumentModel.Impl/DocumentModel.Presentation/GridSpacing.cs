namespace DocumentModel.Presentation;

/// <summary>
/// Grid Spacing.
/// </summary>
public class GridSpacing: IGridSpacing
{
  /// <summary>
  /// Extent Length
  /// </summary>
  public long? Cx
  {
    get;
    set;
  }
  
  /// <summary>
  /// Extent Width
  /// </summary>
  public long? Cy
  {
    get;
    set;
  }
  
}
