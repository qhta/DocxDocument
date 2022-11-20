namespace DocumentModel.Presentation;

/// <summary>
/// A Guide.
/// </summary>
public interface IGuide // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Guide Orientation
  /// </summary>
  public DocumentModel.Presentation.DirectionValues? Orientation { get ; set; }
  
  /// <summary>
  /// Guide Position
  /// </summary>
  public int? Position { get ; set; }
  
}
