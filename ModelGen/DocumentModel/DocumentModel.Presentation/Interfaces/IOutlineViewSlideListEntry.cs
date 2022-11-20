namespace DocumentModel.Presentation;

/// <summary>
/// Presentation Slide.
/// </summary>
public interface IOutlineViewSlideListEntry // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Relationship Identifier
  /// </summary>
  public string? Id { get ; set; }
  
  /// <summary>
  /// Collapsed
  /// </summary>
  public bool? Collapse { get ; set; }
  
}
