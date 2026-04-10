namespace DocumentModel;
/// <summary>
///   Predefined set of metadata properties that are applicable to Office Open XML documents. 
///   These properties extend the set of core properties which are common to all packages.
/// </summary>
[OpenXmlType(typeof(DXEP.Properties))]
[XmlRoot("ContentProperties", Namespace = "DocumentModel")]
public sealed partial class ContentProperties : ModelElement<DXEP.Properties>
{
 /// <summary>
 /// Gets the underlying Document instance associated with this object.
 /// </summary>
 static ContentProperties()
 {
  RegisterOpenXmlConversion();
 }

 /// <summary>
 /// Default constructor.
 /// </summary>
 public ContentProperties()
 {
  _IsNotificationEnabled = false;
  HeadingPairs = new HeadingPairs();
  _IsNotificationEnabled = null;
 }

 /// <summary>
 /// Initializing constructor.
 /// </summary>
 /// <param name = "document">Wordprocessing document model</param>
 public ContentProperties(Wordprocessing.Document document) : this()
 {
  SetParent(document);
  if (document.WordprocessingDocument != null)
   AttachAndLoad(document.WordprocessingDocument);
 }

 /// <summary>
 /// Attach this instance to the specified document. Data is loaded from the document's PackageProperties.
 /// </summary>
 /// <param name = "document">Document to attach to.</param>
 public override void AttachAndLoad(DXPP.WordprocessingDocument document)
 {
  base.AttachAndLoad(document);
  var extendedFileProperties = document.GetExtendedFileProperties();
  SetUpdatableElement(extendedFileProperties);
  LoadData(extendedFileProperties);
 }

 /// <summary>
 /// Attach this instance to the specified document. Data is stored to the document's PackageProperties.
 /// </summary>
 /// <param name = "document">Document to attach to.</param>
 public override void AttachAndUpdate(DXPP.WordprocessingDocument document)
 {
  base.AttachAndUpdate(document);
  var extendedFileProperties = document.GetExtendedFileProperties();
  SetUpdatableElement(extendedFileProperties);
  UpdateData(extendedFileProperties);
 }

 /// <summary>
 /// Detach this instance from the attached document.
 /// Underlying Open XML element is set to null, so further access to its properties will not work until re-attached.
 /// </summary>
 public override void Detach()
 {
  base.Detach();
  SetUpdatableElement(null);
 }

 /// <summary>
 /// Known properties that can be set in this class.
 /// </summary>
 public static KnownProperties KnownProperties
 {
  get
  {
   if (_KnownProperties == null)
    _KnownProperties = new KnownProperties(typeof(ContentProperties));
   return _KnownProperties;
  }
 }

 private static KnownProperties? _KnownProperties;
 /// <summary>
 ///   Specifies the name of an external document template containing format 
 ///   and style information used to create the current document.
 /// </summary>
 [MultiCategory("Base")]
 [BuiltInProperty("Template")]
 [DefaultValue("Normal.dotm")]
 public string? Template { get => _Template; set => UpdateField(ref _Template, value, nameof(Template)); }

 private string? _Template;
 /// <summary>
 ///   The name of a supervisor associated with the document.
 /// </summary>
 [MultiCategory("Base")]
 [BuiltInProperty("Manager")]
 public string? Manager { get => _Manager; set => UpdateField(ref _Manager, value, nameof(Manager)); }

 private string? _Manager;
 /// <summary>
 ///   The name of a company associated with the document.
 /// </summary>
 [MultiCategory("Base")]
 [BuiltInProperty("Company")]
 public string? Company { get => _Company; set => UpdateField(ref _Company, value, nameof(Company)); }

 private string? _Company;
 /// <summary>
 ///   The intended format for a presentation document. For example, a presentation intended
 ///   to be shown on video has PresentationFormat "Video".
 /// </summary>
 [MultiCategory("Presentation")]
 [BuiltInProperty("Format")]
 public string? PresentationFormat { get => _PresentationFormat; set => UpdateField(ref _PresentationFormat, value, nameof(PresentationFormat)); }

 private string? _PresentationFormat;
 /// <summary>
 ///   Indicates the display mode of the document thumbnail. 
 ///   TRUE means scaling of the document thumbnail to the display. 
 ///   FALSE means cropping of the document thumbnail to show only sections that fits the display.
 /// </summary>
 [MultiCategory("Presentation")]
 [BuiltInProperty("Scale crop")]
 public bool? ScaleCrop { get => _ScaleCrop; set => UpdateField(ref _ScaleCrop, value, nameof(ScaleCrop)); }

 private bool? _ScaleCrop;
 /// <summary>
 ///   Indicates the grouping of document parts and the number of parts in each group.
 ///   These parts are not document parts but conceptual representations of document sections.
 /// </summary>
 [MultiCategory("Structure")]
 [OpenXmlType(typeof(DXEP.HeadingPairs))]
 public HeadingPairs? HeadingPairs { get => _HeadingPairs; set => UpdateField(ref _HeadingPairs, value, nameof(HeadingPairs)); }

 private HeadingPairs? _HeadingPairs;
 /// <summary>
 ///   The title of each document. 
 ///   These parts are not document parts but conceptual representations of document sections.
 /// </summary>
 [MultiCategory("Structure")]
 [OpenXmlType(typeof(DXEP.TitlesOfParts))]
 public StringList? TitlesOfParts { get => _TitlesOfParts; set => UpdateField(ref _TitlesOfParts, value, nameof(TitlesOfParts)); }

 private StringList? _TitlesOfParts;
 /// <summary>
 ///   Indicates whether hyperlinks in a document are up-to-date.
 ///   TRUE means that hyperlinks are updated, FALSE means that hyperlinks are outdated.
 /// </summary>
 [MultiCategory("Structure")]
 [OpenXmlType(typeof(DXEP.LinksUpToDate))]
 public bool? LinksUpToDate { get => _LinksUpToDate; set => UpdateField(ref _LinksUpToDate, value, nameof(LinksUpToDate)); }

 private bool? _LinksUpToDate;
 /// <summary>
 ///   Indicates if this document is currently shared between multiple producers. 
 ///   If this element is set to TRUE, producers should take care when updating the document.
 /// </summary>
 [MultiCategory("Base")]
 [OpenXmlType(typeof(DXEP.SharedDocument))]
 public bool? SharedDocument { get => _SharedDocument; set => UpdateField(ref _SharedDocument, value, nameof(SharedDocument)); }

 private bool? _SharedDocument;
 /// <summary>
 ///   The base string used for evaluating relative hyperlinks in this document.
 /// </summary>
 [MultiCategory("Hyperlinks")]
 [BuiltInProperty("Hyperlink base")]
 [OpenXmlType(typeof(DXEP.HyperlinkBase))]
 public string? HyperlinkBase { get => _HyperlinkBase; set => UpdateField(ref _HyperlinkBase, value, nameof(HyperlinkBase)); }

 private string? _HyperlinkBase;
 /// <summary>
 ///   The set of hyperlinks that were in this document when last saved.
 /// </summary>
 [MultiCategory("Hyperlinks")]
 [OpenXmlType(typeof(DXEP.HyperlinkList))]
 public HyperlinkList? HyperlinkList { get => _HyperlinkList; set => UpdateField(ref _HyperlinkList, value, nameof(HyperlinkList)); }

 private HyperlinkList? _HyperlinkList;
 /// <summary>
 ///   Specifies that one or more hyperlinks in this part were updated exclusively in this part by a producer. 
 ///   The next producer to open this document shall update the hyperlink relationships with the new hyperlinks specified in this part.
 /// </summary>
 [MultiCategory("Hyperlinks")]
 [OpenXmlType(typeof(DXEP.HyperlinksChanged))]
 public bool? HyperlinksChanged { get => _HyperlinksChanged; set => UpdateField(ref _HyperlinksChanged, value, nameof(HyperlinksChanged)); }

 private bool? _HyperlinksChanged;
 /// <summary>
 ///   Specifies the security level of a document as a numeric value.
 ///   Document security is defined as:
 ///   1 - Document is password protected.
 ///   2 - Document is recommended to be opened as read-only.
 ///   4 - Document is enforced to be opened as read-only.
 ///   8 - Document is locked for annotation
 /// </summary>
 [MultiCategory("Security")]
 [BuiltInProperty("Security")]
 [OpenXmlType(typeof(DXEP.DocumentSecurity))]
 public DocumentSecurity? DocumentSecurity { get => (DocumentSecurity? )_DocumentSecurity; set => UpdateField(ref _DocumentSecurity, (int? )value, nameof(DocumentSecurity)); }

 private int? _DocumentSecurity;
 /// <summary>
 ///   This element contains the signature of a digitally signed document.
 ///   This property is a mechanism used by legacy documents to store the digital signature of its binary
 ///   representation, and should be avoided in favor of the well-defined mechanism defined in Part 2. Any use of this
 ///   property should be for legacy compatibility only, and is application-defined. 
 /// </summary>
 [MultiCategory("Security")]
 [OpenXmlType(typeof(DXEP.DigitalSignature))]
 public HexBinary? DigitalSignature { get => _DigitalSignature; set => UpdateField(ref _DigitalSignature, value, nameof(DigitalSignature)); }

 private HexBinary? _DigitalSignature;
 /// <summary>
 ///   Specifies the name of the application that created this document.
 /// </summary>
 [MultiCategory("Base")]
 [BuiltInProperty("Application name")]
 [DefaultValue("Microsoft Office Word")]
 [OpenXmlType(typeof(DXEP.Application))]
 public string? Application { get => _Application; set => UpdateField(ref _Application, value, nameof(Application)); }

 private string? _Application;
 /// <summary>
 ///   Specifies the version of the application which produced this document.
 /// </summary>
 [MultiCategory("Base")]
 [BuiltInProperty("Application version")]
 [DefaultValue("16.0000")]
 [OpenXmlType(typeof(DXEP.ApplicationVersion))]
 public string? ApplicationVersion { get => _ApplicationVersion; set => UpdateField(ref _ApplicationVersion, value, nameof(ApplicationVersion)); }

 private string? _ApplicationVersion;
}