namespace DocumentModel;

/// <summary>
///   Predefined set of metadata properties that are applicable to Office Open XML documents. 
///   These properties extend the set of core properties which are common to all packages.
/// </summary>
[OpenXmlType(typeof(DXEP.Properties))]
public class ContentProperties : ModelElement<DXEP.Properties>
{

  /// <summary>
  /// Gets the underlying WordprocessingDocument instance associated with this object.
  /// </summary>
  internal DXPP.WordprocessingDocument? WordprocessingDocument { get; private set; }

  /// <summary>
  /// Default constructor.
  /// </summary>
  public ContentProperties()
  {
  }

  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name="document">Wordprocessing document model</param>
  public ContentProperties(Wordprocessing.Document document)
  {
    AttachAndLoad(document);
  }

  /// <summary>
  /// Attach this instance to the specified document. Data is loaded from the document's PackageProperties.
  /// </summary>
  /// <param name="document">Document to attach to.</param>
  public void AttachAndLoad(Wordprocessing.Document document)
  {
    WordprocessingDocument = document.WordprocessingDocument;
    var extendedFileProperties = document.WordprocessingDocument?.GetExtendedFileProperties();
    if (extendedFileProperties != null)
    {
      SetOpenXmlElement(extendedFileProperties);
      LoadData(extendedFileProperties);
    }
  }

  /// <summary>
  /// Attach this instance to the specified document. Data is stored to the document's PackageProperties.
  /// </summary>
  /// <param name="document">Document to attach to.</param>
  public void AttachAndUpdate(Wordprocessing.Document document)
  {
    WordprocessingDocument = document.WordprocessingDocument;
    var extendedFileProperties = document.WordprocessingDocument?.GetExtendedFileProperties();
    if (extendedFileProperties != null)
    {
      SetOpenXmlElement(extendedFileProperties);
      UpdateData(extendedFileProperties);
    }
  }

  /// <summary>
  /// Detach this instance from the specified document.
  /// Underlying Open XML element is set to null, so further access to its properties will not work until re-attached.
  /// </summary>
  /// <param name="document">Document to detach from. Must be the same as the one attached.</param>
  public void Detach(Wordprocessing.Document document)
  {
    if (WordprocessingDocument != document.WordprocessingDocument)
      return;
    WordprocessingDocument = null;
    SetOpenXmlElement(null);
  }

  /// <summary>
  /// Converts an OpenXml typed value to a model object.
  /// Supported types include HeadingPairs, TitlesOfParts, HyperlinkList, and DigitalSignature.
  /// </summary>
  /// <param name="value">The OpenXml typed value to convert.</param>
  /// <param name="targetType">The target type to convert to.</param>
  /// <returns>An object representing the converted model value, or null if the input value is null or cannot
  /// be converted.</returns>
  public override object? ConvertToOpenXml(object? value, Type targetType)
  {
    if (targetType == typeof(DXEP.HeadingPairs))
    {
      if (value is DocumentModel.HeadingPairs headingPairs)
        return new DXEP.HeadingPairs(headingPairs.AsVTVector()!);
      return null;
    }
    if (targetType == typeof(DXEP.TitlesOfParts))
    {
      if (value is DocumentModel.StringList titlesOfParts)
        return new DXEP.TitlesOfParts(titlesOfParts.AsVTVector()!);
      return null;
    }
    if (targetType == typeof(DXEP.HyperlinkList))
    {
      if (value is DocumentModel.HyperlinkList hyperlinkList)
        return new DXEP.HyperlinkList(hyperlinkList.AsVTVector()!);
      return null;
    }
    if (targetType == typeof(DXEP.DigitalSignature))
    {
      if (value is byte[] digitalSignature)
        return new DXEP.DigitalSignature {  VTBlob = 
          new DXVT.VTBlob(new Base64Binary(digitalSignature)) };
      return null;
    }
    return base.ConvertToOpenXml(value, targetType);
  }

  /// <summary>
  /// Changes the type of the given value from the specified OpenXml type.
  /// Supported types include HeadingPairs, TitlesOfParts, HyperlinkList, and DigitalSignature </summary>
  /// <param name="value">The value to convert. It should be of OpenXml type.</param>
  /// <param name="targetType">The target type to convert to. It should be a model type.</param>
  /// <returns>The converted value, or null if the conversion is not supported.</returns>
  public override object? ConvertFromOpenXml(object? value, Type targetType)
  {
    if (value == null) return null;
    if (value is DXEP.HeadingPairs headingPairs)
    {
      var variant = headingPairs.VTVector;
      return variant?.AsHeadingPairs();
    }
    if (value is DXEP.TitlesOfParts titlesOfParts)
    {
      var variant = titlesOfParts.VTVector;
      return variant?.AsStringList();
    }
    if (value is DXEP.HyperlinkList hyperlinkList)
    {
      var variant = hyperlinkList.VTVector;
      return variant?.AsHyperlinkList();
    }
    if (value is DXEP.DigitalSignature digitalSignature)
    {
      var variant = digitalSignature.VTBlob;
      return variant?.AsByteArray();
    }
    return base.ConvertFromOpenXml(value, targetType);
  }

  /// <summary>
  /// Known properties that can be set in this class.
  /// </summary>
  public static KnownProperties KnownProperties { get; } = new KnownProperties(typeof(ContentProperties));

  /// <summary>
  ///   Specifies the name of an external document template containing format 
  ///   and style information used to create the current document.
  /// </summary>
  public string? Template
  {
    get => _Template;
    set => UpdateField(ref _Template, value, nameof(Template));
  }
  private string? _Template;

  /// <summary>
  ///   The name of a supervisor associated with the document.
  /// </summary>
  public string? Manager
  {
    get => _Manager;
    set => UpdateField(ref _Manager, value, nameof(Manager));
  }
  private string? _Manager;

  /// <summary>
  ///   The name of a company associated with the document.
  /// </summary>
  public string? Company
  {
    get => _Company;
    set => UpdateField(ref _Company, value, nameof(Company));
  }
  private string? _Company;

  /// <summary>
  ///   The intended format for a presentation document. For example, a presentation intended
  ///   to be shown on video has PresentationFormat "Video".
  /// </summary>
  public string? PresentationFormat
  {
    get => _PresentationFormat;
    set => UpdateField(ref _PresentationFormat, value, nameof(PresentationFormat));
  }
  private string? _PresentationFormat;

  /// <summary>
  ///   Indicates the display mode of the document thumbnail. 
  ///   TRUE means scaling of the document thumbnail to the display. 
  ///   FALSE means cropping of the document thumbnail to show only sections that fits the display.
  /// </summary>
  public bool? ScaleCrop
  {
    get => _ScaleCrop;
    set => UpdateField(ref _ScaleCrop, value, nameof(ScaleCrop));
  }
  private bool? _ScaleCrop;

  /// <summary>
  ///   Indicates the grouping of document parts and the number of parts in each group.
  ///   These parts are not document parts but conceptual representations of document sections.
  /// </summary>
  public HeadingPairs? HeadingPairs //{ get; set; }
  {
    get => _HeadingPairs;
    set => UpdateField(ref _HeadingPairs, value, nameof(HeadingPairs));
  }
  private HeadingPairs? _HeadingPairs;

  /// <summary>
  ///   The title of each document. 
  ///   These parts are not document parts but conceptual representations of document sections.
  /// </summary>
  public StringList? TitlesOfParts
  {
    get => _TitlesOfParts;
    set => UpdateField(ref _TitlesOfParts, value, nameof(TitlesOfParts));
  }
  private StringList? _TitlesOfParts;

  /// <summary>
  ///   Indicates whether hyperlinks in a document are up-to-date.
  ///   TRUE means that hyperlinks are updated, FALSE means that hyperlinks are outdated.
  /// </summary>
  public bool? LinksUpToDate
  {
    get => _LinksUpToDate;
    set => UpdateField(ref _LinksUpToDate, value, nameof(LinksUpToDate));
  }
  private bool? _LinksUpToDate;

  /// <summary>
  ///   Indicates if this document is currently shared between multiple producers. 
  ///   If this element is set to TRUE, producers should take care when updating the document.
  /// </summary>
  public bool? SharedDocument
  {
    get => _SharedDocument;
    set => UpdateField(ref _SharedDocument, value, nameof(SharedDocument));
  }
  private bool? _SharedDocument;

  /// <summary>
  ///   The base string used for evaluating relative hyperlinks in this document.
  /// </summary>
  public string? HyperlinkBase
  {
    get => _HyperlinkBase;
    set => UpdateField(ref _HyperlinkBase, value, nameof(HyperlinkBase));
  }
  private string? _HyperlinkBase;

  /// <summary>
  ///   The set of hyperlinks that were in this document when last saved.
  /// </summary>
  public HyperlinkList? HyperlinkList
  {
    get => _HyperlinkList;
    set => UpdateField(ref _HyperlinkList, value, nameof(HyperlinkList));
  }
  private HyperlinkList? _HyperlinkList;

  /// <summary>
  ///   Specifies that one or more hyperlinks in this part were updated exclusively in this part by a producer. 
  ///   The next producer to open this document shall update the hyperlink relationships with the new hyperlinks specified in this part.
  /// </summary>
  public bool? HyperlinksChanged
  {
    get => _HyperlinksChanged;
    set => UpdateField(ref _HyperlinksChanged, value, nameof(HyperlinksChanged));
  }
  private bool? _HyperlinksChanged;

  /// <summary>
  ///   Specifies the security level of a document as a numeric value.
  ///   Document security is defined as:
  ///   1 - Document is password protected.
  ///   2 - Document is recommended to be opened as read-only.
  ///   4 - Document is enforced to be opened as read-only.
  ///   8 - Document is locked for annotation
  /// </summary>
  public DocumentSecurityKind? DocumentSecurity
  {
    get => (DocumentSecurityKind?)_DocumentSecurity;
    set => UpdateField(ref _DocumentSecurity, (int?)value, nameof(DocumentSecurity));
  }
  private int? _DocumentSecurity;

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
  public string? Application
  {
    get => _Application;
    set => UpdateField(ref _Application, value, nameof(Application));
  }
  private string? _Application;

  /// <summary>
  ///   Specifies the version of the application which produced this document.
  /// </summary>
  public string? ApplicationVersion
  {
    get => _ApplicationVersion;
    set => UpdateField(ref _ApplicationVersion, value, nameof(ApplicationVersion));
  }
  private string? _ApplicationVersion;
}