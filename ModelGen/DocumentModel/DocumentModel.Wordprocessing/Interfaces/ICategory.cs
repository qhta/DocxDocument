namespace DocumentModel.Wordprocessing;

/// <summary>
/// Entry Categorization.
/// </summary>
public interface ICategory // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Category Associated With Entry.
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// Gallery Associated With Entry.
  /// </summary>
  public DocumentModel.Wordprocessing.DocPartGalleryKind? Gallery { get ; set; }
  
}
