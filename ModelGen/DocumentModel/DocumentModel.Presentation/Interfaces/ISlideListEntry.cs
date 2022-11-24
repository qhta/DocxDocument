namespace DocumentModel.Presentation;

/// <summary>
/// Presentation Slide.
/// </summary>
public interface ISlideListEntry // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Relationship ID
  /// </summary>
  public String? Id { get ; set; }
  
}
