#nullable enable
using DP = DocumentFormat.OpenXml.Wordprocessing;

namespace DocxDocument.Model;

public interface IContentDocumentProperties
{
  /// <summary> 
  /// This element specifies the name of the application that created this document.
  ///</summary> 
  String? Application { get; set; }

  /// <summary> 
  /// This element specifies the version of the application which produced this document. The content of this element shall be of the form XX.YYYY where X and Y represent numerical values, or the document shall be considered non-conformant.
  ///</summary> 
  String? ApplicationVersion { get; set; }

  /// <summary> 
  /// This element specifies the name of a company associated with the document.
  ///</summary> 
  String? Company { get; set; }

  /// <summary> 
  /// This element contains the signature of a digitally signed document.
  /// [Note: This property is a mechanism used by legacy documents to store the digital signature of its binary representation, and should be avoided in favor of the well-defined mechanism defined in Part 2. Any use of this
  /// property should be for legacy compatibility only, and is application-defined.end note]
  /// </summary>
  byte[]? DigitalSignature { get; set; }

  /// <summary> 
  /// This metadata element specifies the security level of a document.
  ///</summary> 
  DocSecurity? DocumentSecurity { get; set; }

  /// <summary> 
  /// Heading pairs indicates the grouping of document parts and the number of parts in each group. These parts are not document parts but conceptual representations of document sections.
  ///</summary> 
  HeadingPairs? HeadingPairs { get; set; }

  /// <summary> 
  /// This element specifies the set of hyperlinks that were in this document when last saved.
  ///</summary> 
  HyperlinkList? HyperlinkList { get; set; }

  /// <summary> 
  /// This element specifies the base string used for evaluating relative hyperlinks in this document.
  ///</summary> 
  String? HyperlinkBase { get; set; }

  /// <summary> 
  /// This element specifies that one or more hyperlinks in this part were updated exclusively in this part by a producer. The next producer to open this document shall update the hyperlink relationships with the new hyperlinks specified in this part.
  ///</summary> 
  Boolean? HyperlinksChanged { get; set; }

  /// <summary> 
  /// This element indicates whether hyperlinks in a document are up-to-date. Set this element to TRUE to indicate that hyperlinks are updated. Set this element to FALSE to indicate that hyperlinks are outdated.
  ///</summary> 
  Boolean? LinksUpToDate { get; set; }

  /// <summary> 
  /// This element specifies the name of a supervisor associated with the document.
  ///</summary> 
  String? Manager { get; set; }

  /// <summary> 
  /// This element specifies the intended format for a presentation document. For example, a presentation intended to be shown on video has PresentationFormat Video.
  ///</summary> 
  String? PresentationFormat { get; set; }

  /// <summary> 
  /// This element indicates the display mode of the document thumbnail. Set this element to TRUE to enable scaling
  /// of the document thumbnail to the display.Set this element to FALSE to enable cropping of the document
  /// thumbnail to show only sections that fits the display.
  ///</summary> 
  Boolean? ScaleCrop { get; set; }

  /// <summary> 
  /// This element indicates if this document is currently shared between multiple producers. If this element is set to TRUE, producers should take care when updating the document.
  ///</summary> 
  Boolean? SharedDocument { get; set; }

  /// <summary> 
  /// This element specifies the name of an external document template containing format and style information used to create the current document.
  ///</summary> 
  String? Template { get; set; }

  /// <summary> 
  /// This element specifies the title of each document. These parts are not document parts but conceptual representations of document sections.
  ///</summary> 
  Strings? TitlesOfParts { get; set; }

}