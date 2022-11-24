namespace DocumentModel.Presentation;

/// <summary>
/// A Guide.
/// </summary>
public interface IGuide // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Guide Orientation
  /// </summary>
  public DirectionValues? Orientation { get ; set; }
  
  /// <summary>
  /// Guide Position
  /// </summary>
  public Int32? Position { get ; set; }
  
}
