namespace DocumentModel.Office2013.Word;

/// <summary>
/// Defines the SdtRepeatedSection Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Word.IDoNotAllowInsertDeleteSection))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Word.ISectionTitle))]
public interface ISdtRepeatedSection // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// SectionTitle.
  /// </summary>
  public ISectionTitle? SectionTitle { get ; set; }
  
  /// <summary>
  /// DoNotAllowInsertDeleteSection.
  /// </summary>
  public IDoNotAllowInsertDeleteSection? DoNotAllowInsertDeleteSection { get ; set; }
  
}
