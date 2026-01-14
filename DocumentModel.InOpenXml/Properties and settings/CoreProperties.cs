namespace DocumentModel;

/// <summary>
///   Collection of core properties, which represents document properties defined in Dublin Core standard
/// and Open Packaging Conventions
/// </summary>
public partial class CoreProperties : ModelElement
{

  /// <summary>
  /// Package properties from packaging system.
  /// </summary>
#pragma warning disable OOXML0001
  internal PackageProperties? PackageProperties { get; private set; }
#pragma warning restore OOXML0001

 /// <summary>
 /// Default constructor.
 /// </summary>
 public CoreProperties()
 {
 }

  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name="document">Wordprocessing document model</param>
  public CoreProperties(Wordprocessing.Document document)
  {
    PackageProperties = document.WordprocessingDocument?.GetPackageProperties();
    document.PropertyChanged += Document_PropertyChanged;
  }

  /// <summary>
  /// Triggered when the underlying document's WordprocessingDocument changes.
  /// </summary>
  /// <param name="sender">Should be the Wordprocessing.Document instance</param>
  /// <param name="e">PropertyChangedEventArgs with propertyName = "WordprocessingDocument"</param>
  /// <remarks>
  /// If new value is null then CoreFileProperties are set to null to avoid errors on properties access.
  /// If new value is not null then CoreFileProperties are updated to the new document's PackageProperties.
  /// </remarks>
  private void Document_PropertyChanged(object? sender, PropertyChangedEventArgs e)
  {
    if (sender is Wordprocessing.Document document)
      if (e.PropertyName == nameof(Wordprocessing.Document.WordprocessingDocument))
      {
        if (document.WordprocessingDocument == null)
        {
          PackageProperties = null;
        }
        else
        {
          var isEmpty = PackageProperties == null;
          PackageProperties = document.WordprocessingDocument?.GetPackageProperties();
          if (isEmpty)
            GetValuesFromPackageProperties();
          else
            SetValuesToPackageProperties();
        }
      }
  }

  /// <summary>
  /// Gets values from PackageProperties to this instance.
  /// </summary>
  private void GetValuesFromPackageProperties()
  {
    foreach (var propertyInfo in typeof(CoreProperties).GetProperties())
    {
      var value = propertyInfo.GetValue(PackageProperties);
      propertyInfo.SetValue(this, value);
    }
  }

  /// <summary>
  /// Sets values from this instance to PackageProperties.
  /// </summary>
  private void SetValuesToPackageProperties()
  {
    foreach (var propertyInfo in typeof(CoreProperties).GetProperties())
    {
      var value = propertyInfo.GetValue(this);
      propertyInfo.SetValue(PackageProperties, value);
    }
  }

  /// <summary>
  /// Known properties that can be set in CoreProperties
  /// </summary>
  public static KnownProperties KnownProperties { get; }
  = new KnownProperties(typeof(CoreProperties));

  /// <summary>
  ///   Title the document.
  /// </summary>
  public string? Title
  {
    get
    {
      var value = PackageProperties?.Title ?? _Title;
      _Title = value;
      return value;
    }
    set
    {
      if (value != _Title)

      {
        _Title = value;
        if (PackageProperties != null)
          PackageProperties.Title = value;
        NotifyPropertyChanged(nameof(Title));
      }
    }
  }
  private string? _Title;

  /// <summary>
  ///   The topic of the content of the resource.
  /// </summary>
  public string? Subject
  {
    get
    {
      var value = PackageProperties?.Subject ?? _Subject;
      _Subject = value;
      return value;
    }
    set
    {
      if (value != _Subject)
      {
        _Subject = value;
        if (PackageProperties != null)
          PackageProperties.Subject = value;
        NotifyPropertyChanged(nameof(Subject));
      }
    }
  }
  private string? _Subject;


  /// <summary>
  ///   An entity primarily responsible for making the content of the resource.
  /// </summary>
  public string? Creator
  {
    get
    {
      var value = PackageProperties?.Creator ?? _Creator;
      _Creator = value;
      return value;
    }
    set
    {
      if (value != _Creator)
      {
        _Creator = value;
        if (PackageProperties != null)
          PackageProperties.Creator = value;
        NotifyPropertyChanged(nameof(Creator));
      }
    }
  }
  private string? _Creator;

  /// <summary>
  ///   A delimited set of keywords to support searching and indexing. 
  ///   This is typically a list of terms that are not available elsewhere in the properties. 
  ///   The definition of this element uniquely allows for: 
  ///   Use of the xml:lang attribute to identify languages 
  ///   A mixed content model, such that keywords can be flagged individually 
  /// </summary>
  public string? Keywords
  {
    get
    {
      var value = PackageProperties?.Keywords ?? _Keywords;
      _Keywords = value;
      return value;
    }
    set
    {
      if (value != _Keywords)
      {
        _Keywords = value;
        if (PackageProperties != null)
          PackageProperties.Keywords = value;
        NotifyPropertyChanged(nameof(Keywords));
      }
    }
  }
  private string? _Keywords;

  /// <summary>
  ///   An explanation of the content of the resource. [Example: Values might include 
  ///   an abstract, table of contents, reference to a graphical representation of content, 
  ///   and a free-text account of the content. 
  /// </summary>
  public string? Description
  {
    get
    {
      var value = PackageProperties?.Description ?? _Description;
      _Description = value;
      return value;
    }
    set
    {
      if (value != _Description)
      {
        _Description = value;
        if (PackageProperties != null)
          PackageProperties.Description = value;
        NotifyPropertyChanged(nameof(Description));
      }
    }
  }
  private string? _Description;

  /// <summary>
  ///   The user who performed the last modification. The identification is environment-specific. 
  ///   A name, email address, or employee ID. It is recommended that this value be as concise as possible.
  /// </summary>
  public string? LastModifiedBy
  {
    get
    {
      var value = PackageProperties?.LastModifiedBy ?? _LastModifiedBy;
      _LastModifiedBy = value;
      return value;
    }
    set
    {
      if (value != _LastModifiedBy)
      {
        _LastModifiedBy = value;
        if (PackageProperties != null)
          PackageProperties.LastModifiedBy = value;
        NotifyPropertyChanged(nameof(LastModifiedBy));
      }
    }
  }
  private string? _LastModifiedBy;

  /// <summary>
  ///   The revision number. This value might indicate the number of saves or revisions, 
  ///   provided the application updates it after each revision.
  /// </summary>
  public int? Revision
  {
    get
    {
      var value = _Revision;
      if (int.TryParse(PackageProperties?.Revision, out var val))
        value = val;
      _Revision = value;
      return value;
    }
    set
    {
      if (value != _Revision)
      {
        _Revision = value;
        if (PackageProperties != null)
          PackageProperties.Revision = value.ToString();
        NotifyPropertyChanged(nameof(Revision));
      }
    }
  }
  private int? _Revision;

  /// <summary>
  ///   The date and time of the last printing.
  /// </summary>
  public DateTime? LastPrinted
  {
    get
    {
      var value = PackageProperties?.LastPrinted ?? _LastPrinted;
      _LastPrinted = value;
      return value;
    }
    set
    {
      if (value != _LastPrinted)
      {
        _LastPrinted = value;
        if (PackageProperties != null)
          PackageProperties.LastPrinted = value;
        NotifyPropertyChanged(nameof(LastPrinted));
      }
    }
  }
  private DateTime? _LastPrinted;

  /// <summary>
  ///   Date of creation of the resource.
  /// </summary>
  public DateTime? Created
  {
    get
    {
      var value = PackageProperties?.Created ?? _Created;
      _Created = value;
      return value;
    }
    set
    {
      if (value != _Created)
      {
        _Created = value;
        if (PackageProperties != null)
          PackageProperties.Created = value;
        NotifyPropertyChanged(nameof(Created));
      }
    }
  }
  private DateTime? _Created;

  /// <summary>
  ///   The date and time of the last modification.
  /// </summary>
  public DateTime? Modified
  {
    get
    {
      var value = PackageProperties?.Modified ?? _Modified;
      _Modified = value;
      return value;
    }
    set
    {
      if (value != _Modified)
      {
        _Modified = value;
        if (PackageProperties != null)
          PackageProperties.Modified = value;
        NotifyPropertyChanged(nameof(Modified));
      }
    }
  }
  private DateTime? _Modified;

  /// <summary>
  ///   A categorization of the content of this package. 
  ///   Example values for this property might include: 
  ///   Resume, Letter, Financial Forecast, Proposal, Technical Presentation, and so on.
  ///   This value might be used by an application's user class toClass facilitate navigation of a large set of documents.
  /// </summary>
  public string? Category
  {
    get
    {
      var value = PackageProperties?.Category ?? _Category;
      _Category = value;
      return value;
    }
    set
    {
      if (value != _Category)
      {
        _Category = value;
        if (PackageProperties != null)
          PackageProperties.Category = value;
        NotifyPropertyChanged(nameof(Category));
      }
    }
  }
  private string? _Category;

  /// <summary>
  ///   An unambiguous reference to the resource within a given context.
  /// </summary>
  public string? Identifier
  {
    get
    {
      var value = PackageProperties?.Identifier ?? _Identifier;
      _Identifier = value;
      return value;
    }
    set
    {
      if (value != _Identifier)
      {
        _Identifier = value;
        if (PackageProperties != null)
          PackageProperties.Identifier = value;
        NotifyPropertyChanged(nameof(Identifier));
      }
    }
  }
  private string? _Identifier;

  /// <summary>
  ///   The type of content represented, generally defined by a specific application.
  /// </summary>
  public string? ContentType
  {
    get
    {
      var value = PackageProperties?.ContentType ?? _ContentType;
      _ContentType = value;
      return value;
    }
    set
    {
      if (value != _ContentType)
      {
        _ContentType = value;
        if (PackageProperties != null)
          PackageProperties.ContentType = value;
        NotifyPropertyChanged(nameof(ContentType));
      }
    }
  }
  private string? _ContentType;

  /// <summary>
  ///   The language of the intellectual content of the resource. 
  ///   IETF RFC 3066 provides guidance on encoding to represent languages. 
  /// </summary>
  public string? Language
  {
    get
    {
      var value = PackageProperties?.Language ?? _Language;
      _Language = value;
      return value;
    }
    set
    {
      if (value != _Language)
      {
        _Language = value;
        if (PackageProperties != null)
          PackageProperties.Language = value;
        NotifyPropertyChanged(nameof(Language));
      }
    }
  }
  private string? _Language;

  /// <summary>
  ///   The version number. This value is set by the user or by the application.
  /// </summary>
  public string? Version
  {
    get
    {
      var value = PackageProperties?.Version ?? _Version;
      _Version = value;
      return value;
    }
    set
    {
      if (value != _Version)
      {
        _Version = value;
        if (PackageProperties != null)
          PackageProperties.Version = value;
        NotifyPropertyChanged(nameof(Version));
      }
    }
  }
  private string? _Version;

  /// <summary>
  ///   The status of the content. Values might include “Draft”, “Reviewed”, and “Final”.
  /// </summary>
  public string? ContentStatus
  {
    get
    {
      var value = PackageProperties?.ContentStatus ?? _ContentStatus;
      _ContentStatus = value;
      return value;
    }
    set
    {
      if (value != _ContentStatus)
      {
        _ContentStatus = value;
        if (PackageProperties != null)
          PackageProperties.ContentStatus = value;
        NotifyPropertyChanged(nameof(ContentStatus));
      }
    }
  }
  private string? _ContentStatus;

}