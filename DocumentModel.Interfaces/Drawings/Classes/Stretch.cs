namespace DocumentModel.Drawings;

/// <summary>
///   Stretch.
/// </summary>
public interface Stretch: IModelElement
{
  /// <summary>
  ///   Fill Rectangle.
  /// </summary>
  public RelativeRectangleType? FillRectangle { get; set; }
}