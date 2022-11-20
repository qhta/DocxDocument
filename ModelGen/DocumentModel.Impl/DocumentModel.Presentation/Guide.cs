namespace DocumentModel.Presentation;

/// <summary>
/// A Guide.
/// </summary>
public class Guide: IGuide
{
  /// <summary>
  /// Guide Orientation
  /// </summary>
  public DocumentModel.Presentation.DirectionValues? Orientation
  {
    get;
    set;
  }
  
  /// <summary>
  /// Guide Position
  /// </summary>
  public int? Position
  {
    get;
    set;
  }
  
}
