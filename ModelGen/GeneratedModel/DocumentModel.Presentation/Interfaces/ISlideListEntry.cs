namespace DocumentModel.Presentation;

/// <summary>
/// Presentation Slide.
/// </summary>
public interface ISlideListEntry // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Relationship ID
  /// </summary>
  public string? Id { get ; set; }
  
}
