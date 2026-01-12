namespace DocumentModel;

/// <summary>
///   Collection of core properties, which represents document properties defined in Dublin Core standard
/// and Open Packaging Conventions
/// </summary>
public class CoreProperties : DocumentProperties
{
  /// <summary>
  /// Documents that owns the core properties.
  /// </summary>
#pragma warning disable OOXML0001
  internal PackageProperties? CoreFileProperties { get; }
#pragma warning restore OOXML0001

  /// <summary>
  /// Initializes a new instance of the CoreProperties class.
  /// </summary>
  /// <remarks>This constructor creates an in-memory WordprocessingDocument of type Document. Use this instance
  /// to work with core properties in a temporary context without persisting changes to disk.</remarks>
  public CoreProperties()
  {
    KnownProperties = new KnownProperties(typeof(CoreProperties));
  }

  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name="wordprocessingDocument">Package properties from packaging system.</param>
  public CoreProperties(PP.WordprocessingDocument wordprocessingDocument)
  {
    CoreFileProperties = wordprocessingDocument.GetPackageProperties();
    KnownProperties = new KnownProperties(typeof(CoreProperties));
  }

  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name="packageProperties">Package properties from packaging system.</param>
#pragma warning disable OOXML0001
  public CoreProperties(PackageProperties packageProperties)
#pragma warning restore OOXML0001
  {
    CoreFileProperties = packageProperties;
    KnownProperties = new KnownProperties(typeof(CoreProperties));
  }

  /// <summary>
  /// Known properties that can be set in CoreProperties
  /// </summary>
  public KnownProperties KnownProperties { get; }

  /// <summary>
  ///   Title the document.
  /// </summary>
  public string? Title
  {
    get
    {
      var value = CoreFileProperties?.Title ?? _Title;
      _Title = value;
      return value;
    }
    set
    {
      if (value != _Title)

      {
        _Title = value;
        if (CoreFileProperties!=null)
          CoreFileProperties.Title = value;
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
      var value = CoreFileProperties?.Subject ?? _Subject;
      _Subject = value;
      return value;
    }
    set
    {
      if (value != _Subject)
      {
        _Subject = value;
        if (CoreFileProperties != null)
          CoreFileProperties.Subject = value;
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
      var value = CoreFileProperties?.Creator ?? _Creator;
      _Creator = value;
      return value;
    }
    set
    {
      if (value != _Creator)
      {
        _Creator = value;
        if (CoreFileProperties != null)
          CoreFileProperties.Creator = value;
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
      var value = CoreFileProperties?.Keywords ?? _Keywords;
      _Keywords = value;
      return value;
    }
    set
    {
      if (value != _Keywords)
      {
        _Keywords = value;
        if (CoreFileProperties != null)
          CoreFileProperties.Keywords = value;
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
      var value = CoreFileProperties?.Description ?? _Description;
      _Description = value;
      return value;
    }
    set
    {
      if (value != _Description)
      {
        _Description = value;
        if (CoreFileProperties != null)
          CoreFileProperties.Description = value;
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
      var value = CoreFileProperties?.LastModifiedBy ?? _LastModifiedBy;
      _LastModifiedBy = value;
      return value;
    }
    set
    {
      if (value != _LastModifiedBy)
      {
        _LastModifiedBy = value;
        if (CoreFileProperties != null)
          CoreFileProperties.LastModifiedBy = value;
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
      if (int.TryParse(CoreFileProperties?.Revision, out var val))
        value = val;
      _Revision = value;
      return value;
    }
    set
    {
      if (value != _Revision)
      {
        _Revision = value;
        if (CoreFileProperties != null)
          CoreFileProperties.Revision = value.ToString();
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
      var value = CoreFileProperties?.LastPrinted ?? _LastPrinted;
      _LastPrinted = value;
      return value;
    }
    set
    {
      if (value != _LastPrinted)
      {
        _LastPrinted = value;
        if (CoreFileProperties != null)
          CoreFileProperties.LastPrinted = value;
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
      var value = CoreFileProperties?.Created ?? _Created;
      _Created = value;
      return value;
    }
    set
    {
      if (value != _Created)
      {
        _Created = value;
        if (CoreFileProperties != null)
          CoreFileProperties.Created = value;
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
      var value = CoreFileProperties?.Modified ?? _Modified;
      _Modified = value;
      return value;
    }
    set
    {
      if (value != _Modified)
      {
        _Modified = value;
        if (CoreFileProperties != null)
          CoreFileProperties.Modified = value;
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
      var value = CoreFileProperties?.Category ?? _Category;
      _Category = value;
      return value;
    }
    set
    {
      if (value != _Category)
      {
        _Category = value;
        if (CoreFileProperties != null)
          CoreFileProperties.Category = value;
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
      var value = CoreFileProperties?.Identifier ?? _Identifier;
      _Identifier = value;
      return value;
    }
    set
    {
      if (value != _Identifier)
      {
        _Identifier = value;
        if (CoreFileProperties != null)
          CoreFileProperties.Identifier = value;
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
      var value = CoreFileProperties?.ContentType ?? _ContentType;
      _ContentType = value;
      return value;
    }
    set
    {
      if (value != _ContentType)
      {
        _ContentType = value;
        if (CoreFileProperties != null)
          CoreFileProperties.ContentType = value;
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
      var value = CoreFileProperties?.Language ?? _Language;
      _Language = value;
      return value;
    }
    set
    {
      if (value != _Language)
      {
        _Language = value;
        if (CoreFileProperties != null)
          CoreFileProperties.Language = value;
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
      var value = CoreFileProperties?.Version ?? _Version;
      _Version = value;
      return value;
    }
    set
    {
      if (value != _Version)
      {
        _Version = value;
        if (CoreFileProperties != null)
          CoreFileProperties.Version = value;
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
      var value = CoreFileProperties?.ContentStatus ?? _ContentStatus;
      _ContentStatus = value;
      return value;
    }
    set
    {
      if (value != _ContentStatus)
      {
        _ContentStatus = value;
        if (CoreFileProperties != null)
          CoreFileProperties.ContentStatus = value;
        NotifyPropertyChanged(nameof(ContentStatus));
      }
    }
  }
  private string? _ContentStatus;
}