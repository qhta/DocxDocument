using DocumentModel.Drawings.ChartsStyle;
namespace DocumentModel.Packaging;

/// <summary>
///   Defines the ChartColorStylePart
/// </summary>
public interface ChartColorStylePart: IModelElement
{
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public ColorStyle? ColorStyle { get; set; }
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}