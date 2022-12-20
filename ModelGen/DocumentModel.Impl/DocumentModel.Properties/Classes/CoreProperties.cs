namespace DocumentModel.Properties;

/// <summary>
/// This class provides access to the "core properties", such as Title and
/// </summary>
public partial class CorePropertiesImpl: ModelObjectImpl, CoreProperties
{
  public System.IO.Packaging.PackageProperties? OpenXmlElement
  {
    get => (System.IO.Packaging.PackageProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public CorePropertiesImpl(): base() {}
  
  public CorePropertiesImpl(System.IO.Packaging.PackageProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// The title.
  /// </summary>
  public String? Title
  {
    get => OpenXmlElement?.Title;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Title = value;
    }
  }
  
  /// <summary>
  /// The topic of the contents.
  /// </summary>
  public String? Subject
  {
    get => OpenXmlElement?.Subject;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Subject = value;
    }
  }
  
  /// <summary>
  /// The primary creator. The identification is environment-specific and
  /// </summary>
  public String? Creator
  {
    get => OpenXmlElement?.Creator;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Creator = value;
    }
  }
  
  /// <summary>
  /// A delimited set of keywords to support searching and indexing. This
  /// </summary>
  public String? Keywords
  {
    get => OpenXmlElement?.Keywords;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Keywords = value;
    }
  }
  
  /// <summary>
  /// The description or abstract of the contents.
  /// </summary>
  public String? Description
  {
    get => OpenXmlElement?.Description;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Description = value;
    }
  }
  
  /// <summary>
  /// The user who performed the last modification. The identification is
  /// </summary>
  public String? LastModifiedBy
  {
    get => OpenXmlElement?.LastModifiedBy;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LastModifiedBy = value;
    }
  }
  
  /// <summary>
  /// The revision number. This value indicates the number of saves or
  /// </summary>
  public String? Revision
  {
    get => OpenXmlElement?.Revision;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Revision = value;
    }
  }
  
  /// <summary>
  /// The date and time of the last printing.
  /// </summary>
  public DateTime? LastPrinted
  {
    get => OpenXmlElement?.LastPrinted;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LastPrinted = value;
    }
  }
  
  /// <summary>
  /// The creation date and time.
  /// </summary>
  public DateTime? Created
  {
    get => OpenXmlElement?.Created;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Created = value;
    }
  }
  
  /// <summary>
  /// The date and time of the last modification.
  /// </summary>
  public DateTime? Modified
  {
    get => OpenXmlElement?.Modified;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Modified = value;
    }
  }
  
  /// <summary>
  /// The category. This value is typically used by UI applications to create navigation
  /// </summary>
  public String? Category
  {
    get => OpenXmlElement?.Category;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Category = value;
    }
  }
  
  /// <summary>
  /// A unique identifier.
  /// </summary>
  public String? Identifier
  {
    get => OpenXmlElement?.Identifier;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Identifier = value;
    }
  }
  
  /// <summary>
  /// The type of content represented, generally defined by a specific
  /// </summary>
  public String? ContentType
  {
    get => OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ContentType = value;
    }
  }
  
  /// <summary>
  /// The primary language of the package content. The language tag is
  /// </summary>
  public String? Language
  {
    get => OpenXmlElement?.Language;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Language = value;
    }
  }
  
  /// <summary>
  /// The version number. This value is set by the user or by the application.
  /// </summary>
  public String? Version
  {
    get => OpenXmlElement?.Version;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Version = value;
    }
  }
  
  /// <summary>
  /// The status of the content. Example values include "Draft",
  /// </summary>
  public String? ContentStatus
  {
    get => OpenXmlElement?.ContentStatus;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ContentStatus = value;
    }
  }
  
}
