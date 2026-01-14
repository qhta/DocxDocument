namespace DocumentModel;

/// <summary>
///   Predefined set of metadata properties that are applicable to Office Open XML documents. 
///   These properties extend the set of core properties which are common to all packages.
/// </summary>
public class ContentProperties : ModelElement
{
  /// <summary>
  /// Properties from the Open XML Extended File Properties part.
  /// </summary>
  internal DXEP.Properties? ExtendedFileProperties { get; private set; }

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
    ExtendedFileProperties = document.WordprocessingDocument?.GetExtendedFileProperties();
    document.PropertyChanged += Document_PropertyChanged;
  }

  /// <summary>
  /// Triggered when the underlying document's WordprocessingDocument changes.
  /// </summary>
  /// <param name="sender">Should be the Wordprocessing.Document instance</param>
  /// <param name="e">PropertyChangedEventArgs with propertyName = "WordprocessingDocument"</param>
  /// <remarks>
  /// If new value is null then ExtendedFileProperties are set to null to avoid errors on properties access.
  /// If new value is not null then ExtendedFileProperties are updated to the new document's PackageProperties.
  /// </remarks>
  private void Document_PropertyChanged(object? sender, PropertyChangedEventArgs e)
  {
    if (sender is Wordprocessing.Document document)
      if (e.PropertyName == nameof(Wordprocessing.Document.WordprocessingDocument))
      {
        if (document.WordprocessingDocument == null)
        {
          ExtendedFileProperties = null;
        }
        else
        {
          var isEmpty = ExtendedFileProperties == null;
          ExtendedFileProperties = document.WordprocessingDocument?.GetExtendedFileProperties();
          if (isEmpty)
            GetValuesFromExtendedFileProperties();
          else
            SetValuesToExtendedFileProperties();
        }
      }
  }

  /// <summary>
  /// Gets values from ExtendedFileProperties to this instance.
  /// </summary>
  private void GetValuesFromExtendedFileProperties()
  {
    foreach (var propertyInfo in typeof(ContentProperties).GetProperties())
    {
      var value = propertyInfo.GetValue(ExtendedFileProperties);
      propertyInfo.SetValue(this, value);
    }
  }

  /// <summary>
  /// Sets values from this instance to ExtendedFileProperties.
  /// </summary>
  private void SetValuesToExtendedFileProperties()
  {
    foreach (var propertyInfo in typeof(ContentProperties).GetProperties())
    {
      var value = propertyInfo.GetValue(this);
      propertyInfo.SetValue(ExtendedFileProperties, value);
    }
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
    get
    {
      var value = ExtendedFileProperties?.Template?.InnerText ?? _Template;
      _Template = value;
      return value;
    }
    set
    {
      if (value != _Template)

      {
        _Template = value;
        if (ExtendedFileProperties != null)
          ExtendedFileProperties.Template = (value != null) ? new DXEP.Template(value) : null;
        NotifyPropertyChanged(nameof(Template));
      }
    }
  }
  private string? _Template;

  /// <summary>
  ///   The name of a supervisor associated with the document.
  /// </summary>
  public string? Manager
  {
    get
    {
      var value = ExtendedFileProperties?.Manager?.InnerText ?? _Manager;
      _Manager = value;
      return value;
    }
    set
    {
      if (value != _Manager)

      {
        _Manager = value;
        if (ExtendedFileProperties != null)
          ExtendedFileProperties.Manager = (value != null) ? new DXEP.Manager(value) : null;
        NotifyPropertyChanged(nameof(Manager));
      }
    }
  }

  private string? _Manager;

  /// <summary>
  ///   The name of a company associated with the document.
  /// </summary>
  public string? Company
  {
    get
    {
      var value = ExtendedFileProperties?.Company?.InnerText ?? _Company;
      _Company = value;
      return value;
    }
    set
    {
      if (value != _Company)
      {
        _Company = value;
        if (ExtendedFileProperties != null)
          ExtendedFileProperties.Company = (value != null) ? new DXEP.Company(value) : null;
        NotifyPropertyChanged(nameof(Company));
      }
    }
  }
  private string? _Company;

  /// <summary>
  ///   The intended format for a presentation document. For example, a presentation intended
  ///   to be shown on video has PresentationFormat "Video".
  /// </summary>
  public string? PresentationFormat
  {
    get
    {
      var value = ExtendedFileProperties?.PresentationFormat?.InnerText ?? _PresentationFormat;
      _PresentationFormat = value;
      return value;
    }
    set
    {
      if (value != _PresentationFormat)
      {
        _PresentationFormat = value;
        if (ExtendedFileProperties != null)
          ExtendedFileProperties.PresentationFormat = (value != null) ? new DXEP.PresentationFormat(value) : null;
        NotifyPropertyChanged(nameof(PresentationFormat));
      }
    }
  }
  private string? _PresentationFormat;

  /// <summary>
  ///   Indicates the display mode of the document thumbnail. 
  ///   TRUE means scaling of the document thumbnail to the display. 
  ///   FALSE means cropping of the document thumbnail to show only sections that fits the display.
  /// </summary>
  public bool? ScaleCrop
  {
    get
    {
      var str = ExtendedFileProperties?.ScaleCrop?.InnerText ?? _ScaleCrop.ToString();
      bool? value = null;
      if (bool.TryParse(str, out bool val))
        value = val;
      _ScaleCrop = value;
      return value;
    }
    set
    {
      if (value != _ScaleCrop)
      {
        _ScaleCrop = value;
        if (ExtendedFileProperties != null)
          ExtendedFileProperties.ScaleCrop = value != null ? new DXEP.ScaleCrop(value.ToString()!) : null;
        NotifyPropertyChanged(nameof(ScaleCrop));
      }
    }
  }
  private bool? _ScaleCrop;

  /// <summary>
  ///   Indicates the grouping of document parts and the number of parts in each group.
  ///   These parts are not document parts but conceptual representations of document sections.
  /// </summary>
  public HeadingPairs? HeadingPairs //{ get; set; }
  {
    get
    {
      HeadingPairs? value;
      var vector = ExtendedFileProperties?.HeadingPairs?.VTVector;
      if (vector != null) 
        value = vector.AsHeadingPairs(); 
      else
        value = _HeadingPairs;
      _HeadingPairs = value;
      return value;
    }
    set
    {
      if (value != _HeadingPairs)
      {
        _HeadingPairs = value;
        if (ExtendedFileProperties != null)
        {
          if (value != null)
          {
            var vector = value.AsVTVector();
            ExtendedFileProperties.HeadingPairs = new DXEP.HeadingPairs(vector!.ToString()!);
          }
          else
            ExtendedFileProperties.HeadingPairs = null;
        }
        NotifyPropertyChanged(nameof(HeadingPairs));
      }
    }
  }
  private HeadingPairs? _HeadingPairs;

  /// <summary>
  ///   The title of each document. 
  ///   These parts are not document parts but conceptual representations of document sections.
  /// </summary>
  public StringList? TitlesOfParts
  {
    get
    {
      var str = ExtendedFileProperties?.TitlesOfParts?.InnerText ?? _TitlesOfParts?.ToString(CultureInfo.InvariantCulture);
      StringList? value = null;
      if (StringList.TryParse(str, out StringList? val))
        value = val;
      _TitlesOfParts = value;
      return value;
    }
    set
    {
      if (value != _TitlesOfParts)
      {
        _TitlesOfParts = value;
        if (ExtendedFileProperties != null)
          ExtendedFileProperties.TitlesOfParts = value != null ?
            new DXEP.TitlesOfParts(value.ToString(CultureInfo.InvariantCulture)) : null;
        NotifyPropertyChanged(nameof(TitlesOfParts));
      }
    }
  }
  private StringList? _TitlesOfParts;

  /// <summary>
  ///   Indicates whether hyperlinks in a document are up-to-date.
  ///   TRUE means that hyperlinks are updated, FALSE means that hyperlinks are outdated.
  /// </summary>
  public bool? LinksUpToDate
  {
    get
    {
      var str = ExtendedFileProperties?.LinksUpToDate?.InnerText ?? _LinksUpToDate.ToString();
      bool? value = null;
      if (bool.TryParse(str, out bool val))
        value = val;
      _LinksUpToDate = value;
      return value;
    }
    set
    {
      if (value != _LinksUpToDate)
      {
        _LinksUpToDate = value;
        if (ExtendedFileProperties != null)
          ExtendedFileProperties.LinksUpToDate = value != null ? new DXEP.LinksUpToDate(value.ToString()!) : null;
        NotifyPropertyChanged(nameof(LinksUpToDate));
      }
    }
  }
  private bool? _LinksUpToDate;

  /// <summary>
  ///   Indicates if this document is currently shared between multiple producers. 
  ///   If this element is set to TRUE, producers should take care when updating the document.
  /// </summary>
  public bool? SharedDocument
  {
    get
    {
      var str = ExtendedFileProperties?.SharedDocument?.InnerText ?? _SharedDocument.ToString();
      bool? value = null;
      if (bool.TryParse(str, out bool val))
        value = val;
      _SharedDocument = value;
      return value;
    }
    set
    {
      if (value != _SharedDocument)
      {
        _SharedDocument = value;
        if (ExtendedFileProperties != null)
          ExtendedFileProperties.SharedDocument = value != null ? new DXEP.SharedDocument(value.ToString()!) : null;
        NotifyPropertyChanged(nameof(SharedDocument));
      }
    }
  }
  private bool? _SharedDocument;

  /// <summary>
  ///   The base string used for evaluating relative hyperlinks in this document.
  /// </summary>
  public string? HyperlinkBase
  {
    get
    {
      var value = ExtendedFileProperties?.HyperlinkBase?.InnerText ?? _HyperlinkBase;
      _HyperlinkBase = value;
      return value;
    }
    set
    {
      if (value != _HyperlinkBase)

      {
        _HyperlinkBase = value;
        if (ExtendedFileProperties != null)
          ExtendedFileProperties.HyperlinkBase = (value != null) ? new DXEP.HyperlinkBase(value) : null;
        NotifyPropertyChanged(nameof(HyperlinkBase));
      }
    }
  }
  private string? _HyperlinkBase;

  /// <summary>
  ///   The set of hyperlinks that were in this document when last saved.
  /// </summary>
  public HyperlinkList? HyperlinkList { get; set; }

  /// <summary>
  ///   Specifies that one or more hyperlinks in this part were updated exclusively in this part by a producer. 
  ///   The next producer to open this document shall update the hyperlink relationships with the new hyperlinks specified in this part.
  /// </summary>
  public bool? HyperlinksChanged
  {
    get
    {
      var str = ExtendedFileProperties?.HyperlinksChanged?.InnerText ?? _HyperlinksChanged.ToString();
      bool? value = null;
      if (bool.TryParse(str, out bool val))
        value = val;
      _HyperlinksChanged = value;
      return value;
    }
    set
    {
      if (value != _HyperlinksChanged)
      {
        _HyperlinksChanged = value;
        if (ExtendedFileProperties != null)
          ExtendedFileProperties.HyperlinksChanged = value != null ? new DXEP.HyperlinksChanged(value.ToString()!) : null;
        NotifyPropertyChanged(nameof(HyperlinksChanged));
      }
    }
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
    get
    {
      var str = ExtendedFileProperties?.DocumentSecurity?.InnerText ?? _DocumentSecurity.ToString();
      int? value = null;
      if (int.TryParse(str, out var val))
        value = val;
      _DocumentSecurity = value;
      return (DocumentSecurityKind?)value;
    }
    set
    {
      int? val = (int?)value;
      if (val != _DocumentSecurity)
      {
        _DocumentSecurity = val;
        NotifyPropertyChanged(nameof(DocumentSecurity));
      }
    }
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
    get
    {
      var value = ExtendedFileProperties?.Application?.InnerText ?? _Application;
      _Application = value;
      return value;
    }
    set
    {
      if (value != _Application)

      {
        _Application = value;
        if (ExtendedFileProperties != null)
          ExtendedFileProperties.Application = (value != null) ? new DXEP.Application(value) : null;
        NotifyPropertyChanged(nameof(Application));
      }
    }
  }

  private string? _Application;

  /// <summary>
  ///   Specifies the version of the application which produced this document.
  /// </summary>
  public string? ApplicationVersion
  {
    get
    {
      var value = ExtendedFileProperties?.ApplicationVersion?.InnerText ?? _ApplicationVersion;
      _ApplicationVersion = value;
      return value;
    }
    set
    {
      if (value != _ApplicationVersion)

      {
        _ApplicationVersion = value;
        if (ExtendedFileProperties != null)
          ExtendedFileProperties.ApplicationVersion = (value != null) ? new DXEP.ApplicationVersion(value) : null;
        NotifyPropertyChanged(nameof(ApplicationVersion));
      }
    }
  }

  private string? _ApplicationVersion;
}