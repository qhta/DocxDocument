namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtRepeatedSection Class.
/// </summary>
public interface ISdtRepeatedSection // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// SectionTitle.
  /// </summary>
  public System.String? SectionTitle { get ; set; }
  
  /// <summary>
  /// DoNotAllowInsertDeleteSection.
  /// </summary>
  public System.Boolean? DoNotAllowInsertDeleteSection { get ; set; }
  
}
