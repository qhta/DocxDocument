namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the parent structured document tag is a container for repeated items.
/// </summary>
public partial class SdtRepeatedSection
{
  
  /// <summary>
  ///   SectionTitle.
  /// </summary>
  public String? SectionTitle { get; set; }
  
  
  /// <summary>
  ///   DoNotAllowInsertDeleteSection.
  /// </summary>
  public DocumentModel.Wordprocessing.DoNotAllowInsertDeleteSection? DoNotAllowInsertDeleteSection { get; set; }
  
}
