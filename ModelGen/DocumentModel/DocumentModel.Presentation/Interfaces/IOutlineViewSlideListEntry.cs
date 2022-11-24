namespace DocumentModel.Presentation;

/// <summary>
/// Presentation Slide.
/// </summary>
public interface IOutlineViewSlideListEntry // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Relationship Identifier
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// Collapsed
  /// </summary>
  public Boolean? Collapse { get ; set; }
  
}
