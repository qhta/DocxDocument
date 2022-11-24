namespace DocumentModel.Wordprocessing;

/// <summary>
/// Entry Categorization.
/// </summary>
public interface ICategory // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Category Associated With Entry.
  /// </summary>
  public IName? Name { get ; set; }
  
  /// <summary>
  /// Gallery Associated With Entry.
  /// </summary>
  public IEnumValue<DocumentFormat.OpenXml.Wordprocessing.DocPartGalleryValues>? Gallery { get ; set; }
  
}
