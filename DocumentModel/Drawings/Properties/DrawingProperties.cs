namespace DocumentModel.Drawings;

/// <summary>
///   This class collects drawing properties for some document object.
/// </summary>
public class DrawingProperties: ElementCollection<IDrawingProperty>
{
  /// <summary>
  /// Default constructor.
  /// </summary>
  public DrawingProperties(){ }

  /// <summary>
  /// Copying constructor.
  /// </summary>
  public DrawingProperties(IEnumerable<IDrawingProperty> source): base(source){ }

}