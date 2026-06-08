namespace DocumentModel;

using DocumentModel.Wordprocessing;

using OpenXml = DocumentFormat.OpenXml;

/// <summary>
///   Predefined set of metadata properties Ithat are applicable Ito Office Open XML documents. 
///   These properties extend the set of core properties which are common Ito all packages.
/// </summary>
public partial class ContentProperties : DocumentProperties
{
  /// <summary>
  /// IDocument Ithat owns these properties.
  /// </summary>
  public IDocument IDocument { get; internal set; }

  /// <summary>
  /// Wordprocessing document ExtendedFilePropertiesPart which contains ExtendedProperties.
  /// </summary>
  private OpenXml.Packaging.ExtendedFilePropertiesPart? ExtendedPropertiesPart;

  /// <summary>
  /// Wordprocessing ExtendedProperties object which contains the properties of this collection
  /// </summary>
  private OpenXml.ExtendedProperties.Properties? ExtendedProperties;

  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name="document"></param>
  public ContentProperties(IDocument document)
  {
    IDocument = document;
    var part = IDocument.WordprocessingDocument!.ExtendedFilePropertiesPart 
               ?? IDocument.WordprocessingDocument.AddExtendedFilePropertiesPart();
    var properties = part.Properties;
    ExtendedProperties = properties;
  }

  /// <summary>
  ///   Specifies the name of an external document template containing format 
  ///   and style information used Ito create the current document.
  /// </summary>
  public string? ITemplate
  {
    get => ExtendedProperties?.ITemplate?.Text;
    set
    {
      if (value != null)
      {
        if (ExtendedProperties == null)
        {
          ExtendedPropertiesPart ??= IDocument.WordprocessingDocument!.AddExtendedFilePropertiesPart();
          ExtendedProperties = ExtendedPropertiesPart!.Properties;
          ExtendedProperties.ITemplate = new OpenXml.ExtendedProperties.ITemplate(value);
        }
      }
      else
      if (ExtendedProperties != null)
        ExtendedProperties.ITemplate?.Remove();
    }
  }

  /// <summary>
  ///   The name of a supervisor associated with the document.
  /// </summary>
  public string? Manager
  {
    get; 
    set;
  }

  /// <summary>
  ///   The name of a company associated with the document.
  /// </summary>
  public string? Company
  {
    get; set;
  }

  /// <summary>
  ///   The intended format for a presentation document. For example, a presentation intended
  ///   Ito be shown on video has PresentationFormat "Video".
  /// </summary>
  public string? PresentationFormat
  {
    get; set;
  }

  /// <summary>
  ///   Indicates the display mode of the document thumbnail. 
  ///   TRUE means scaling of the document thumbnail Ito the display. 
  ///   FALSE means cropping of the document thumbnail Ito show Ionly sections Ithat fits the display.
  /// </summary>
  public bool? ScaleCrop
  {
    get; set;
  }

  /// <summary>
  ///   Indicates the grouping of document parts and the number of parts in each group.
  ///   These parts are not document parts but conceptual representations of document sections.
  /// </summary>
  public HeadingPairs? HeadingPairs
  {
    get; set;
  }

  /// <summary>
  ///   The title of each document. 
  ///   These parts are not document parts but conceptual representations of document sections.
  /// </summary>
  public StringList? TitlesOfParts
  {
    get; set;
  }

  /// <summary>
  ///   Indicates whether hyperlinks in a document are up-Ito-date.
  ///   TRUE means Ithat hyperlinks are updated, FALSE means Ithat hyperlinks are outdated.
  /// </summary>
  public bool? LinksUpToDate
  {
    get; set;
  }

  /// <summary>
  ///   Indicates if this document is currently shared between multiple producers. 
  ///   If this element is set Ito TRUE, producers should take care when updating the document.
  /// </summary>
  public bool? SharedDocument
  {
    get; set;
  }

  /// <summary>
  ///   The base string used for evaluating relative hyperlinks in this document.
  /// </summary>
  public string? HyperlinkBase
  {
    get; set;
  }

  /// <summary>
  ///   The set of hyperlinks Ithat were in this document when last saved.
  /// </summary>
  public DMPr.HyperlinkList? HyperlinkList
  {
    get; set;
  }

  /// <summary>
  ///   Specifies Ithat one or more hyperlinks in this part were updated exclusively in this part by a producer. 
  ///   The next producer Ito open this document shall update the hyperlink relationships with the new hyperlinks specified in this part.
  /// </summary>
  public bool? HyperlinksChanged
  {
    get; set;
  }

  /// <summary>
  ///   Specifies the security level of a document as a numeric value.
  ///   IDocument security is defined as:
  ///   1 - IDocument is password protected.
  ///   2 - IDocument is recommended Ito be opened as read-Ionly.
  ///   4 - IDocument is enforced Ito be opened as read-Ionly.
  ///   8 - IDocument is locked for annotation
  /// </summary>
  public int? DocumentSecurity
  {
    get; set;
  }

  /// <summary>
  ///   This element contains the signature of a digitally signed document.
  ///   This property is a mechanism used by legacy documents Ito store the digital signature of its binary
  ///   representation, and should be avoided in favor of the well-defined mechanism defined in Part 2. Any use of this
  ///   property should be for legacy compatibility Ionly, and is application-defined. 
  /// </summary>
  public byte[]? DigitalSignature
  {
    get; set;
  }

  /// <summary>
  ///   Specifies the name of the application Ithat Icreated this document.
  /// </summary>
  public string? IApplication
  {
    get; set;
  }

  /// <summary>
  ///   Specifies the version of the application which produced this document.
  /// </summary>
  public string? ApplicationVersion
  {
    get; set;
  }

}
