namespace DocumentModel.Wordprocessing;

/// <summary>
/// Gallery Associated With Entry.
/// </summary>
public interface IGallery // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Gallery Value
  /// </summary>
  public DocPartGalleryValues? Val { get ; set; }
  
}
