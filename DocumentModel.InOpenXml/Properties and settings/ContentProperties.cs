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

  static ContentProperties()
  {
    RegisterOpenXmlConversion();
  }


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

  public override void UpdatePropertyData(string propertyName)
  {
    base.UpdatePropertyData(propertyName);
  }

  #region OpenXml Conversion Registration and Methods
  /// <summary>
  /// Registers conversion delegates for OpenXml property types to enable conversion between OpenXml elements and their
  /// corresponding domain objects.
  /// </summary>
  /// <remarks>Call this method before performing conversions using the OpenXmlConverter to ensure that the
  /// necessary type mappings are available. This method is typically invoked during application initialization to
  /// configure conversion support for HeadingPairs, TitlesOfParts, HyperlinkList, and DigitalSignature
  /// elements.</remarks>
  public new static void RegisterOpenXmlConversion()
  {
    OpenXmlConverter.ConvertFromOpenDelegates[typeof(DXEP.HeadingPairs)] = ConvertFromOpenXmlHeadingPairs;
    OpenXmlConverter.ConvertFromOpenDelegates[typeof(DXEP.TitlesOfParts)] = ConvertFromOpenXmlTitlesOfParts;
    OpenXmlConverter.ConvertFromOpenDelegates[typeof(DXEP.HyperlinkList)] = ConvertFromOpenXmlHyperlinkList;
    OpenXmlConverter.ConvertFromOpenDelegates[typeof(DXEP.DigitalSignature)] = ConvertFromOpenXmlDigitalSignature;
    OpenXmlConverter.ConvertToOpenDelegates[typeof(DXEP.HeadingPairs)] = ConvertToOpenXmlHeadingPairs;
    OpenXmlConverter.ConvertToOpenDelegates[typeof(DXEP.TitlesOfParts)] = ConvertToOpenXmlTitlesOfParts;
    OpenXmlConverter.ConvertToOpenDelegates[typeof(DXEP.HyperlinkList)] = ConvertToOpenXmlHyperlinkList;
    OpenXmlConverter.ConvertToOpenDelegates[typeof(DXEP.DigitalSignature)] = ConvertToOpenXmlDigitalSignature;
  }

  /// <summary>
  /// Converts an Open XML HeadingPairs element to its corresponding domain model representation.
  /// </summary>
  /// <param name="openXmlElement"></param>
  /// <param name="modelType"></param>
  /// <returns></returns>
  private static object? ConvertFromOpenXmlHeadingPairs(object? openXmlElement, Type modelType)
  {
    if (openXmlElement is DXEP.HeadingPairs headingPairs)
    {
      var variant = headingPairs.VTVector;
      return variant?.AsHeadingPairs();
    }
    return null;
  }
  /// <summary>
  /// Converts a model object representing heading pairs to an Open XML HeadingPairs object if the specified type
  /// matches.
  /// </summary>
  /// <remarks>This method is intended for internal use when mapping model objects to Open XML types. If the
  /// provided model object is not compatible with the specified Open XML type, the method returns null without throwing
  /// an exception.</remarks>
  /// <param name="modelObject">The model object to convert. Must be an instance of DocumentModel.HeadingPairs to perform the conversion;
  /// otherwise, the method returns null.</param>
  /// <param name="openXmlType">The target Open XML type. Conversion is performed only if this is typeof(DXEP.HeadingPairs).</param>
  /// <returns>An Open XML HeadingPairs object if the conversion is successful; otherwise, null.</returns>
  private static object? ConvertToOpenXmlHeadingPairs(object? modelObject, Type openXmlType)
  {
    if (openXmlType == typeof(DXEP.HeadingPairs))
    {
      if (modelObject is DocumentModel.HeadingPairs headingPairs)
        return new DXEP.HeadingPairs(headingPairs.AsVTVector()!);
    }
    return null;
  }

  /// <summary>
  /// Converts an OpenXml TitlesOfParts element to a list of string titles, if available.
  /// </summary>
  /// <param name="openXmlElement">The OpenXml element to convert. If not a TitlesOfParts element, the method returns null.</param>
  /// <param name="modelType">The target model type for conversion. This parameter is reserved for future extensibility and does not affect the
  /// current conversion logic.</param>
  /// <returns>A list of strings representing the titles contained in the OpenXml TitlesOfParts element; or null if the input is
  /// not a valid TitlesOfParts element or contains no titles.</returns>
  private static object? ConvertFromOpenXmlTitlesOfParts(object? openXmlElement, Type modelType)
  {
    if (openXmlElement is DXEP.TitlesOfParts titlesOfParts)
    {
      var variant = titlesOfParts.VTVector;
      return variant?.AsStringList();
    }
    return null;
  }

  /// <summary>
  /// Converts a model object representing a list of titles of parts to an OpenXml TitlesOfParts instance if the
  /// specified type matches.
  /// </summary>
  /// <remarks>This method returns null if the model object is not a DocumentModel.StringList or if the
  /// openXmlType does not match DXEP.TitlesOfParts.</remarks>
  /// <param name="modelObject">The model object to convert. Must be a DocumentModel.StringList representing the titles of parts, or null.</param>
  /// <param name="openXmlType">The target OpenXml type. Conversion is performed only if this is typeof(DXEP.TitlesOfParts).</param>
  /// <returns>An instance of DXEP.TitlesOfParts if conversion is successful; otherwise, null.</returns>
  private static object? ConvertToOpenXmlTitlesOfParts(object? modelObject, Type openXmlType)
  {
    if (openXmlType == typeof(DXEP.TitlesOfParts))
    {
      if (modelObject is DocumentModel.StringList titlesOfParts)
        return new DXEP.TitlesOfParts(titlesOfParts.AsVTVector()!);
    }
    return null;
  }

  /// <summary>
  /// Converts an Open XML HyperlinkList element to its corresponding model representation.
  /// </summary>
  /// <param name="openXmlElement">The Open XML element to convert. This should be an instance of a HyperlinkList or null.</param>
  /// <param name="modelType">The target model type to which the Open XML element should be converted.</param>
  /// <returns>An object representing the converted HyperlinkList, or null if the input is not a valid HyperlinkList element.</returns>
  private static object? ConvertFromOpenXmlHyperlinkList(object? openXmlElement, Type modelType)
  {
    if (openXmlElement is DXEP.HyperlinkList hyperlinkList)
    {
      var variant = hyperlinkList.VTVector;
      return variant?.AsHyperlinkList();
    }
    return null;
  }

  /// <summary>
  /// Converts a model object representing a hyperlink list to an Open XML HyperlinkList instance if the specified type
  /// matches.
  /// </summary>
  /// <remarks>This method is intended for internal use when mapping model hyperlink lists to their Open XML
  /// equivalents. No conversion is performed if the type does not match or if the model object is not of the expected
  /// type.</remarks>
  /// <param name="modelObject">The model object to convert. Expected to be a DocumentModel.HyperlinkList instance if conversion is desired. Can
  /// be null.</param>
  /// <param name="openXmlType">The target Open XML type. Conversion is performed only if this is typeof(DXEP.HyperlinkList).</param>
  /// <returns>An instance of DXEP.HyperlinkList if the conversion is successful; otherwise, null.</returns>
  private static object? ConvertToOpenXmlHyperlinkList(object? modelObject, Type openXmlType)
  {
    if (openXmlType == typeof(DXEP.HyperlinkList))
    {
      if (modelObject is DocumentModel.HyperlinkList hyperlinkList)
        return new DXEP.HyperlinkList(hyperlinkList.AsVTVector()!);
    }
    return null;
  }

  /// <summary>
  /// Converts an Open XML digital signature element to its corresponding byte array representation, if available.
  /// </summary>
  /// <param name="openXmlElement">The Open XML element to convert. Expected to be a digital signature element or null.</param>
  /// <param name="modelType">The target model type for the conversion. This parameter is reserved for future extensibility and is not currently
  /// used.</param>
  /// <returns>A byte array containing the digital signature data if the input is a valid digital signature element with a value;
  /// otherwise, null.</returns>
  private static object? ConvertFromOpenXmlDigitalSignature(object? openXmlElement, Type modelType)
  {
    if (openXmlElement is DXEP.DigitalSignature digitalSignature)
    {
      var variant = digitalSignature.VTBlob;
      return variant?.AsByteArray();
    }
    return null;
  }

  /// <summary>
  /// Converts a model object representing a digital signature to an Open XML DigitalSignature object, if compatible.
  /// </summary>
  /// <param name="modelObject">The model object to convert. Must be a byte array representing the digital signature, or null.</param>
  /// <param name="openXmlType">The target Open XML type for conversion. Must be typeof(DigitalSignature) to perform the conversion.</param>
  /// <returns>An instance of DigitalSignature if the model object is a byte array and the target type is DigitalSignature;
  /// otherwise, null.</returns>
  private static object? ConvertToOpenXmlDigitalSignature(object? modelObject, Type openXmlType)
  {
    if (openXmlType == typeof(DXEP.DigitalSignature) && modelObject is byte[] digitalSignature)
      return new DXEP.DigitalSignature
      {
        VTBlob = new DXVT.VTBlob(new Base64Binary(digitalSignature))
      };
    return null;
  }
  #endregion

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
  [OpenXmlType(typeof(DXEP.HeadingPairs))]
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
  [OpenXmlType(typeof(DXEP.TitlesOfParts))]
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
  [OpenXmlType(typeof(DXEP.HyperlinkList))]
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
  [OpenXmlType(typeof(DXEP.DigitalSignature))]
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