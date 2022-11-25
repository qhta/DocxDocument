namespace DocumentModel.Presentation;

/// <summary>
/// Presentation Slide.
/// </summary>
public interface IOutlineViewSlideListEntry // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Relationship Identifier
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// Collapsed
  /// </summary>
  public System.Boolean? Collapse { get ; set; }
  
}
