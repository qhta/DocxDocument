namespace DocxDocument.Model;

public interface IContentDocumentProperties
{
  /// <summary> 
  /// This element specifies the name of the application that created this document.
  ///</summary> 
  public String? Application { get; set; }

  /// <summary> 
  /// This element specifies the version of the application which produced this document. The content of this element shall be of the form XX.YYYY where X and Y represent numerical values, or the document shall be considered non-conformant.
  ///</summary> 
  public String? ApplicationVersion { get; set; }

  /// <summary> 
  /// This element specifies the name of a company associated with the document.
  ///</summary> 
  public String? Company { get; set; }

  /// <summary> 
  /// This element contains the signature of a digitally signed document.
  /// [Note: This property is a mechanism used by legacy documents to store the digital signature of its binary representation, and should be avoided in favor of the well-defined mechanism defined in Part 2. Any use of this
  /// property should be for legacy compatibility only, and is application-defined.end note]
  /// </summary>
  public byte[]? DigitalSignature { get; set; }

  /// <summary> 
  /// This metadata element specifies the security level of a document.
  ///</summary> 
  public DocSecurity? DocumentSecurity { get; set; }

  /// <summary> 
  /// Heading pairs indicates the grouping of document parts and the number of parts in each group. These parts are not document parts but conceptual representations of document sections.
  ///</summary> 
  public HeadingPairs? HeadingPairs { get; set; }

  /// <summary> 
  /// This element specifies the set of hyperlinks that were in this document when last saved.
  ///</summary> 
  public HyperlinkList? HyperlinkList { get; set; }

  /// <summary> 
  /// This element specifies the base string used for evaluating relative hyperlinks in this document.
  ///</summary> 
  public String? HyperlinkBase { get; set; }

  /// <summary> 
  /// This element specifies that one or more hyperlinks in this part were updated exclusively in this part by a producer. The next producer to open this document shall update the hyperlink relationships with the new hyperlinks specified in this part.
  ///</summary> 
  public Boolean? HyperlinksChanged { get; set; }

  /// <summary> 
  /// This element indicates whether hyperlinks in a document are up-to-date. Set this element to TRUE to indicate that hyperlinks are updated. Set this element to FALSE to indicate that hyperlinks are outdated.
  ///</summary> 
  public Boolean? LinksUpToDate { get; set; }

  /// <summary> 
  /// This element specifies the name of a supervisor associated with the document.
  ///</summary> 
  public String? Manager { get; set; }

  /// <summary> 
  /// This element specifies the intended format for a presentation document. For example, a presentation intended to be shown on video has PresentationFormat Video.
  ///</summary> 
  public String? PresentationFormat { get; set; }

  /// <summary> 
  /// This element indicates the display mode of the document thumbnail. Set this element to TRUE to enable scaling
  /// of the document thumbnail to the display.Set this element to FALSE to enable cropping of the document
  /// thumbnail to show only sections that fits the display.
  ///</summary> 
  public Boolean? ScaleCrop { get; set; }

  /// <summary> 
  /// This element indicates if this document is currently shared between multiple producers. If this element is set to TRUE, producers should take care when updating the document.
  ///</summary> 
  public Boolean? SharedDocument { get; set; }

  /// <summary> 
  /// This element specifies the name of an external document template containing format and style information used to create the current document.
  ///</summary> 
  public String? Template { get; set; }

  /// <summary> 
  /// This element specifies the title of each document. These parts are not document parts but conceptual representations of document sections.
  ///</summary> 
  public Strings? TitlesOfParts { get; set; }

}