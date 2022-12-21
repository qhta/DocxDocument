namespace DocumentModel.Properties;

public partial class CorePropertiesImpl: ModelObjectImpl, CoreProperties
{
  [XmlIgnore]
  public System.IO.Packaging.PackageProperties? OpenXmlElement
  {
    get => (System.IO.Packaging.PackageProperties?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public CorePropertiesImpl(): base() {}
  
  public CorePropertiesImpl(System.IO.Packaging.PackageProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public String? Title
  {
    get => OpenXmlElement?.Title;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Title = value;
    }
  }
  
  public String? Subject
  {
    get => OpenXmlElement?.Subject;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Subject = value;
    }
  }
  
  public String? Creator
  {
    get => OpenXmlElement?.Creator;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Creator = value;
    }
  }
  
  public String? Keywords
  {
    get => OpenXmlElement?.Keywords;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Keywords = value;
    }
  }
  
  public String? Description
  {
    get => OpenXmlElement?.Description;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Description = value;
    }
  }
  
  public String? LastModifiedBy
  {
    get => OpenXmlElement?.LastModifiedBy;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LastModifiedBy = value;
    }
  }
  
  public String? Revision
  {
    get => OpenXmlElement?.Revision;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Revision = value;
    }
  }
  
  public DateTime? LastPrinted
  {
    get => OpenXmlElement?.LastPrinted;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LastPrinted = value;
    }
  }
  
  public DateTime? Created
  {
    get => OpenXmlElement?.Created;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Created = value;
    }
  }
  
  public DateTime? Modified
  {
    get => OpenXmlElement?.Modified;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Modified = value;
    }
  }
  
  public String? Category
  {
    get => OpenXmlElement?.Category;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Category = value;
    }
  }
  
  public String? Identifier
  {
    get => OpenXmlElement?.Identifier;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Identifier = value;
    }
  }
  
  public String? ContentType
  {
    get => OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ContentType = value;
    }
  }
  
  public String? Language
  {
    get => OpenXmlElement?.Language;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Language = value;
    }
  }
  
  public String? Version
  {
    get => OpenXmlElement?.Version;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Version = value;
    }
  }
  
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
