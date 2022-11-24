namespace DocumentModel.Office2013.Word;

/// <summary>
/// Defines the SdtRepeatedSection Class.
/// </summary>
public interface ISdtRepeatedSection // : DocumentModel.ITypedOpenXmlCompositeElement
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
