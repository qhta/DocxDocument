namespace DocumentModel.Presentation;

/// <summary>
/// A Guide.
/// </summary>
public interface IGuide // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Guide Orientation
  /// </summary>
  public DocumentModel.Presentation.DirectionKind? Orientation { get ; set; }
  
  /// <summary>
  /// Guide Position
  /// </summary>
  public System.Int32? Position { get ; set; }
  
}
