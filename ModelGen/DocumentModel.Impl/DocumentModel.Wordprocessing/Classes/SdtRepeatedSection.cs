namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtRepeatedSection Class.
/// </summary>
public class SdtRepeatedSectionImpl: ModelElementImpl, SdtRepeatedSection
{
  public DocumentFormat.OpenXml.Office2013.Word.SdtRepeatedSection? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Word.SdtRepeatedSection?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// SectionTitle.
  /// </summary>
  public String? SectionTitle
  {
    get;
    set;
  }
  
  /// <summary>
  /// DoNotAllowInsertDeleteSection.
  /// </summary>
  public Boolean? DoNotAllowInsertDeleteSection
  {
    get;
    set;
  }
  
}
