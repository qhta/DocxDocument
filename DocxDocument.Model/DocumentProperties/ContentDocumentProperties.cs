using DocumentFormat.OpenXml.Packaging;

namespace DocxDocument.Model;

public class ContentDocumentProperties : IContentDocumentProperties
{
  public ContentDocumentProperties(XP.Properties docxProperties)
  {
    DocxElement = docxProperties;
  }

  public XP.Properties DocxElement { get; set; }

  /// <summary> 
  /// This element specifies the name of the application that created this document.
  ///</summary> 
  public string? Application
  {
    get => DocxElement.Application?.Text;
    set => DocxElement.Application = (value != null) ? new XP.Application { Text = value } : null;
  }

  /// <summary> 
  /// This element specifies the version of the application which produced this document. The content of this element shall be of the form XX.YYYY where X and Y represent numerical values, or the document shall be considered non-conformant.
  ///</summary> 
  public string? ApplicationVersion
  {
    get => DocxElement.ApplicationVersion?.Text;
    set => DocxElement.ApplicationVersion = (value != null) ? new XP.ApplicationVersion { Text = value } : null;
  }

  /// <summary> 
  /// This element specifies the name of a company associated with the document.
  ///</summary> 
  public string? Company
  {
    get => DocxElement.Company?.Text;
    set => DocxElement.Company = (value != null) ? new XP.Company { Text = value } : null;
  }

  /// <summary> 
  /// This element contains the signature of a digitally signed document.
  /// [Note: This property is a mechanism used by legacy documents to store the digital signature of its binary representation, and should be avoided in favor of the well-defined mechanism defined in Part 2. Any use of this
  /// property should be for legacy compatibility only, and is application-defined.end note]
  /// </summary>
  public byte[]? DigitalSignature { get; set; }

  /// <summary> 
  /// This metadata element specifies the security level of a document.
  ///</summary> 
  public DocSecurity? DocumentSecurity
  {
    get => (DocSecurity?)DocxRead.ReadInteger(DocxElement.DocumentSecurity);
    set { }
  }

  /// <summary> 
  /// This element specifies the base string used for evaluating relative hyperlinks in this document.
  ///</summary> 
  public string? HyperlinkBase { get => DocxElement.HyperlinkBase?.Text; set => DocxElement.HyperlinkBase = (value != null) ? new XP.HyperlinkBase { Text = value } : null; }

  /// <summary> 
  /// This element specifies that one or more hyperlinks in this part were updated exclusively in this part by a producer. The next producer to open this document shall update the hyperlink relationships with the new hyperlinks specified in this part.
  ///</summary> 
  public bool? HyperlinksChanged
  {
    get { if (bool.TryParse(DocxElement.HyperlinksChanged?.Text, out var bv)) return bv; else return null; }
    set => DocxElement.HyperlinksChanged = (value != null) ? new XP.HyperlinksChanged { Text = value.ToString().ToLower() } : null;
  }

  /// <summary> 
  /// This element indicates whether hyperlinks in a document are up-to-date. Set this element to TRUE to indicate that hyperlinks are updated. Set this element to FALSE to indicate that hyperlinks are outdated.
  ///</summary> 
  public bool? LinksUpToDate
  {
    get { if (bool.TryParse(DocxElement.LinksUpToDate?.Text, out var bv)) return bv; else return null; }
    set => DocxElement.LinksUpToDate = (value != null) ? new XP.LinksUpToDate { Text = value.ToString().ToLower() } : null;
  }

  /// <summary> 
  /// This element specifies the name of a supervisor associated with the document.
  ///</summary> 
  public string? Manager
  {
    get => DocxElement.Manager?.Text;
    set => DocxElement.Manager = (value != null) ? new XP.Manager { Text = value } : null;
  }

  /// <summary> 
  /// This element specifies the intended format for a presentation document. For example, a presentation intended to be shown on video has PresentationFormat Video.
  ///</summary> 
  public string? PresentationFormat
  {
    get => DocxElement.PresentationFormat?.Text;
    set => DocxElement.PresentationFormat = (value != null) ? new XP.PresentationFormat { Text = value } : null;
  }

  /// <summary> 
  /// This element indicates the display mode of the document thumbnail. Set this element to TRUE to enable scaling
  /// of the document thumbnail to the display.Set this element to FALSE to enable cropping of the document
  /// thumbnail to show only sections that fits the display.
  ///</summary> 
  public bool? ScaleCrop
  {
    get { if (bool.TryParse(DocxElement.ScaleCrop?.Text, out var bv)) return bv; else return null; }
    set => DocxElement.ScaleCrop = (value != null) ? new XP.ScaleCrop { Text = value.ToString().ToLower() } : null;
  }

  /// <summary> 
  /// This element indicates if this document is currently shared between multiple producers. If this element is set to TRUE, producers should take care when updating the document.
  ///</summary> 
  public bool? SharedDocument
  {
    get { if (bool.TryParse(DocxElement.SharedDocument?.Text, out var bv)) return bv; else return null; }
    set => DocxElement.SharedDocument = (value != null) ? new XP.SharedDocument { Text = value.ToString().ToLower() } : null;
  }

  /// <summary> 
  /// This element specifies the name of an external document template containing format and style information used to create the current document.
  ///</summary> 
  public string? Template
  {
    get => DocxElement.Template?.Text;
    set => DocxElement.Template = (value != null) ? new XP.Template { Text = value } : null;
  }


  /// <summary> 
  /// Heading pairs indicates the grouping of document parts and the number of parts in each group. These parts are not document parts but conceptual representations of document sections.
  ///</summary> 
  public HeadingPairs? HeadingPairs
  {
    get => DocxRead.ReadHeadingParts(DocxElement.HeadingPairs);
    set { }
  }

  /// <summary> 
  /// This element specifies the set of hyperlinks that were in this document when last saved.
  ///</summary> 
  public HyperlinkList? HyperlinkList
  {
    get => DocxRead.ReadHyperlinks(DocxElement.HyperlinkList);
    set { }
  }

  /// <summary> 
  /// This element specifies the title of each document. These parts are not document parts but conceptual representations of document sections.
  ///</summary> 
  public Strings? TitlesOfParts
  {
    get => DocxRead.ReadTitlesOfPairs(DocxElement.TitlesOfParts);
    set { }
  }

}