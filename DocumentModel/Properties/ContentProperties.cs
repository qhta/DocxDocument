namespace DocumentModel;

/// <summary>
///   Predefined set of metadata properties that are applicable to Office Open XML documents. 
///   These properties extend the set of core properties which are common to all packages.
/// </summary>
public partial class ContentProperties: KnownDocumentProperties
{
  /// <summary>
  ///   Specifies the name of an external document template containing format 
  ///   and style information used to create the current document.
  /// </summary>
  public string? Template { get; set; }

  /// <summary>
  ///   The name of a supervisor associated with the document.
  /// </summary>
  public string? Manager { get; set; }

  /// <summary>
  ///   The name of a company associated with the document.
  /// </summary>
  public string? Company { get; set; }

  /// <summary>
  ///   The intended format for a presentation document. For example, a presentation intended
  ///   to be shown on video has PresentationFormat "Video"..
  /// </summary>
  public string? PresentationFormat { get; set; }

  /// <summary>
  ///   Indicates the display mode of the document thumbnail. 
  ///   Set this element to TRUE to enable scaling of the document thumbnail to the display. 
  ///   Set this element to FALSE to enable cropping of the document thumbnail to show only sections that fits the display.
  /// </summary>
  public bool? ScaleCrop { get; set; }

  /// <summary>
  ///   Indicates the grouping of document parts and the number of parts in each group. These parts are
  ///   not document parts but conceptual representations of document sections.
  /// </summary>
  public HeadingPairs? HeadingPairs { get; set; }

  /// <summary>
  ///   The title of each document. 
  ///   These parts are not document parts but conceptual representations of document sections.
  /// </summary>
  public StringList? TitlesOfParts { get; set; }

  /// <summary>
  ///   Indicates whether hyperlinks in a document are up-to-date. Set this element to TRUE to indicate
  ///   that hyperlinks are updated. Set this element to FALSE to indicate that hyperlinks are outdated.
  /// </summary>
  public bool? LinksUpToDate { get; set; }

  /// <summary>
  ///   Indicates if this document is currently shared between multiple producers. 
  ///   If this element is set to TRUE, producers should take care when updating the document.
  /// </summary>
  public bool? SharedDocument { get; set; }

  /// <summary>
  ///   The base string used for evaluating relative hyperlinks in this document.
  /// </summary>
  public string? HyperlinkBase { get; set; }

  /// <summary>
  ///   The set of hyperlinks that were in this document when last saved.
  /// </summary>
  public DMPr.HyperlinkList? HyperlinkList { get; set; }

  /// <summary>
  ///   Specifies that one or more hyperlinks in this part were updated exclusively in this part by a producer. 
  ///   The next producer to open this document shall update the hyperlink relationships with the new hyperlinks specified in this part.
  /// </summary>
  public bool? HyperlinksChanged { get; set; }

  /// <summary>
  ///   Specifies the security level of a document as a numeric value.
  ///   Document security is defined as:
  ///   1 - Document is password protected.
  ///   2 - Document is recommended to be opened as read-only.
  ///   4 - Document is enforced to be opened as read-only.
  ///   8 - Document is locked for annotation
  /// </summary>
  public int? DocumentSecurity { get; set; }

  /// <summary>
  ///   This element contains the signature of a digitally signed document.
  ///   This property is a mechanism used by legacy documents to store the digital signature of its binary
  ///   representation, and should be avoided in favor of the well-defined mechanism defined in Part 2. Any use of this
  ///   property should be for legacy compatibility only, and is application-defined. 
  /// </summary>
  public byte[]? DigitalSignature { get; set; }

  /// <summary>
  ///   Specifies the name of the application that created this document.
  /// </summary>
  public string? Application { get; set; }

  /// <summary>
  ///   Specifies the version of the application which produced this document.
  /// </summary>
  public string? ApplicationVersion { get; set; }

}