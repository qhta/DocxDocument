namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtPlaceholder Class.
/// </summary>
public class SdtPlaceholderImpl: ModelElementImpl, SdtPlaceholder
{
  public DocumentFormat.OpenXml.Wordprocessing.SdtPlaceholder? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.SdtPlaceholder?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Document Part Reference.
  /// </summary>
  public String? DocPartReference
  {
    get;
    set;
  }
  
}
