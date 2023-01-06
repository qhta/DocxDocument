namespace DocumentModel.OpenXml.Properties;

/// <summary>
/// This class provides access to the "core properties", such as Title and
/// </summary>
public static class CorePropertiesConverter
{
  /// <summary>
  /// The title.
  /// </summary>
  public static String? GetTitle(System.IO.Packaging.PackageProperties? openXmlElement)
  {
    return openXmlElement?.Title;
  }
  
  public static void SetTitle(System.IO.Packaging.PackageProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      openXmlElement.Title = value;
  }
  
  /// <summary>
  /// The topic of the contents.
  /// </summary>
  public static String? GetSubject(System.IO.Packaging.PackageProperties? openXmlElement)
  {
    return openXmlElement?.Subject;
  }
  
  public static void SetSubject(System.IO.Packaging.PackageProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      openXmlElement.Subject = value;
  }
  
  /// <summary>
  /// The primary creator. The identification is environment-specific and
  /// </summary>
  public static String? GetCreator(System.IO.Packaging.PackageProperties? openXmlElement)
  {
    return openXmlElement?.Creator;
  }
  
  public static void SetCreator(System.IO.Packaging.PackageProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      openXmlElement.Creator = value;
  }
  
  /// <summary>
  /// A delimited set of keywords to support searching and indexing. This
  /// </summary>
  public static String? GetKeywords(System.IO.Packaging.PackageProperties? openXmlElement)
  {
    return openXmlElement?.Keywords;
  }
  
  public static void SetKeywords(System.IO.Packaging.PackageProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      openXmlElement.Keywords = value;
  }
  
  /// <summary>
  /// The description or abstract of the contents.
  /// </summary>
  public static String? GetDescription(System.IO.Packaging.PackageProperties? openXmlElement)
  {
    return openXmlElement?.Description;
  }
  
  public static void SetDescription(System.IO.Packaging.PackageProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      openXmlElement.Description = value;
  }
  
  /// <summary>
  /// The user who performed the last modification. The identification is
  /// </summary>
  public static String? GetLastModifiedBy(System.IO.Packaging.PackageProperties? openXmlElement)
  {
    return openXmlElement?.LastModifiedBy;
  }
  
  public static void SetLastModifiedBy(System.IO.Packaging.PackageProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      openXmlElement.LastModifiedBy = value;
  }
  
  /// <summary>
  /// The revision number. This value indicates the number of saves or
  /// </summary>
  public static String? GetRevision(System.IO.Packaging.PackageProperties? openXmlElement)
  {
    return openXmlElement?.Revision;
  }
  
  public static void SetRevision(System.IO.Packaging.PackageProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      openXmlElement.Revision = value;
  }
  
  /// <summary>
  /// The date and time of the last printing.
  /// </summary>
  public static DateTime? GetLastPrinted(System.IO.Packaging.PackageProperties? openXmlElement)
  {
    return openXmlElement?.LastPrinted;
  }
  
  public static void SetLastPrinted(System.IO.Packaging.PackageProperties? openXmlElement, DateTime? value)
  {
    if (openXmlElement != null)
      openXmlElement.LastPrinted = value;
  }
  
  /// <summary>
  /// The creation date and time.
  /// </summary>
  public static DateTime? GetCreated(System.IO.Packaging.PackageProperties? openXmlElement)
  {
    return openXmlElement?.Created;
  }
  
  public static void SetCreated(System.IO.Packaging.PackageProperties? openXmlElement, DateTime? value)
  {
    if (openXmlElement != null)
      openXmlElement.Created = value;
  }
  
  /// <summary>
  /// The date and time of the last modification.
  /// </summary>
  public static DateTime? GetModified(System.IO.Packaging.PackageProperties? openXmlElement)
  {
    return openXmlElement?.Modified;
  }
  
  public static void SetModified(System.IO.Packaging.PackageProperties? openXmlElement, DateTime? value)
  {
    if (openXmlElement != null)
      openXmlElement.Modified = value;
  }
  
  /// <summary>
  /// The category. This value is typically used by UI applications to create navigation
  /// </summary>
  public static String? GetCategory(System.IO.Packaging.PackageProperties? openXmlElement)
  {
    return openXmlElement?.Category;
  }
  
  public static void SetCategory(System.IO.Packaging.PackageProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      openXmlElement.Category = value;
  }
  
  /// <summary>
  /// A unique identifier.
  /// </summary>
  public static String? GetIdentifier(System.IO.Packaging.PackageProperties? openXmlElement)
  {
    return openXmlElement?.Identifier;
  }
  
  public static void SetIdentifier(System.IO.Packaging.PackageProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      openXmlElement.Identifier = value;
  }
  
  /// <summary>
  /// The type of content represented, generally defined by a specific
  /// </summary>
  public static String? GetContentType(System.IO.Packaging.PackageProperties? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  public static void SetContentType(System.IO.Packaging.PackageProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      openXmlElement.ContentType = value;
  }
  
  /// <summary>
  /// The primary language of the package content. The language tag is
  /// </summary>
  public static String? GetLanguage(System.IO.Packaging.PackageProperties? openXmlElement)
  {
    return openXmlElement?.Language;
  }
  
  public static void SetLanguage(System.IO.Packaging.PackageProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      openXmlElement.Language = value;
  }
  
  /// <summary>
  /// The version number. This value is set by the user or by the application.
  /// </summary>
  public static String? GetVersion(System.IO.Packaging.PackageProperties? openXmlElement)
  {
    return openXmlElement?.Version;
  }
  
  public static void SetVersion(System.IO.Packaging.PackageProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      openXmlElement.Version = value;
  }
  
  /// <summary>
  /// The status of the content. Example values include "Draft",
  /// </summary>
  public static String? GetContentStatus(System.IO.Packaging.PackageProperties? openXmlElement)
  {
    return openXmlElement?.ContentStatus;
  }
  
  public static void SetContentStatus(System.IO.Packaging.PackageProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      openXmlElement.ContentStatus = value;
  }
  
  public static DocumentModel.Properties.CoreProperties? GetValue(System.IO.Packaging.PackageProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Properties.CoreProperties();
      value.Title = GetTitle(openXmlElement);
      value.Subject = GetSubject(openXmlElement);
      value.Creator = GetCreator(openXmlElement);
      value.Keywords = GetKeywords(openXmlElement);
      value.Description = GetDescription(openXmlElement);
      value.LastModifiedBy = GetLastModifiedBy(openXmlElement);
      value.Revision = GetRevision(openXmlElement);
      value.LastPrinted = GetLastPrinted(openXmlElement);
      value.Created = GetCreated(openXmlElement);
      value.Modified = GetModified(openXmlElement);
      value.Category = GetCategory(openXmlElement);
      value.Identifier = GetIdentifier(openXmlElement);
      value.ContentType = GetContentType(openXmlElement);
      value.Language = GetLanguage(openXmlElement);
      value.Version = GetVersion(openXmlElement);
      value.ContentStatus = GetContentStatus(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static void SetValue(System.IO.Packaging.PackageProperties? openXmlElement, DocumentModel.Properties.CoreProperties? value)
  {
    if (openXmlElement != null)
    {
      SetTitle(openXmlElement, value?.Title);
      SetSubject(openXmlElement, value?.Subject);
      SetCreator(openXmlElement, value?.Creator);
      SetKeywords(openXmlElement, value?.Keywords);
      SetDescription(openXmlElement, value?.Description);
      SetLastModifiedBy(openXmlElement, value?.LastModifiedBy);
      SetRevision(openXmlElement, value?.Revision);
      SetLastPrinted(openXmlElement, value?.LastPrinted);
      SetCreated(openXmlElement, value?.Created);
      SetModified(openXmlElement, value?.Modified);
      SetCategory(openXmlElement, value?.Category);
      SetIdentifier(openXmlElement, value?.Identifier);
      SetContentType(openXmlElement, value?.ContentType);
      SetLanguage(openXmlElement, value?.Language);
      SetVersion(openXmlElement, value?.Version);
      SetContentStatus(openXmlElement, value?.ContentStatus);
    }
  }
}
