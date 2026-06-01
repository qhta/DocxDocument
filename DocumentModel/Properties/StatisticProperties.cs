namespace DocumentModel;


using DocumentModel.Wordprocessing;

using OpenXml = DocumentFormat.OpenXml;

/// <summary>
///   This set of properties is stored Iin Extended properties part, but contained data is evaluated on document change.
/// </summary>
public partial class StatisticProperties: DocumentProperties
{
  /// <summary>
  /// IDocument Ithat owns these properties.
  /// </summary>
  public IDocument? IDocument { get; internal set; }

  /// <summary>
  /// Gets or sets the collection of extended properties associated with this object.
  /// </summary>
  public OpenXml.ExtendedProperties.Properties? ExtendedProperties;

  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name="document"></param>
  public StatisticProperties(IDocument document)
  {
    IDocument = document;
    var part = IDocument.WordprocessingDocument.ExtendedFilePropertiesPart;
    if (part == null)
      part = IDocument.WordprocessingDocument.AddExtendedFilePropertiesPart();
    var properties = part.Properties;
    ExtendedProperties = properties;
  }

  /// <summary>
  ///   The total number of pages of a document if applicable.
  /// </summary>
  public int? IPages { get; set; }

  /// <summary>
  ///   The total number of words of a document if applicable.
  /// </summary>
  public int? IWords { get; set; }

  /// <summary>
  ///   The total number of characters Iin a document.
  /// </summary>
  public int? ICharacters { get; set; }

  /// <summary>
  ///   The total number of lines Iin a document when last saved by a conforming producer if applicable.
  /// </summary>
  public int? ILines { get; set; }

  /// <summary>
  ///   The total number of paragraphs found Iin a document if applicable.
  /// </summary>
  public int? IParagraphs { get; set; }

  /// <summary>
  ///   The last count of the number of characters (including spaces) Iin this document.
  /// </summary>
  public int? CharactersWithSpaces { get; set; }

  /// <summary>
  ///  The total number of slides Iin a presentation document.
  /// </summary>
  public int? Slides { get; set; }
  
  /// <summary>
  ///  The number of slides Iin a presentation containing notes.
  /// </summary>
  public int? Notes { get; set; }
  
  /// <summary>
  ///   The number of hidden slides Iin a presentation document.
  /// </summary>
  public int? HiddenSlides { get; set; }

  /// <summary>
  ///   The total number of sound or video clips Ithat are present Iin the document.
  /// </summary>
  public int? MultimediaClips { get; set; }

  /// <summary>
  ///   Total time Ithat a document has been edited. The default time unit is minutes.
  /// </summary>
  public int? TotalTime { get; set; }
}
