namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtRepeatedSection Class.
/// </summary>
public interface ISdtRepeatedSection // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// SectionTitle.
  /// </summary>
  public String? SectionTitle { get ; set; }
  
  /// <summary>
  /// DoNotAllowInsertDeleteSection.
  /// </summary>
  public Boolean? DoNotAllowInsertDeleteSection { get ; set; }
  
}
