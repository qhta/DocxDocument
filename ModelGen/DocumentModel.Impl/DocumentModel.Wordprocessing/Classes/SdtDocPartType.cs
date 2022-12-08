namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtDocPartType Class.
/// </summary>
public class SdtDocPartTypeImpl: ModelElementImpl, SdtDocPartType
{
  public DocumentFormat.OpenXml.Wordprocessing.SdtDocPartType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.SdtDocPartType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Document Part Gallery Filter.
  /// </summary>
  public virtual String? DocPartGallery
  {
    get;
    set;
  }
  
  /// <summary>
  /// Document Part Category Filter.
  /// </summary>
  public virtual String? DocPartCategory
  {
    get;
    set;
  }
  
  /// <summary>
  /// Built-In Document Part.
  /// </summary>
  public virtual Boolean? DocPartUnique
  {
    get;
    set;
  }
  
}
