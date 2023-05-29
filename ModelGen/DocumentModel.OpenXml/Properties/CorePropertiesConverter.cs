namespace DocumentModel.OpenXml.Properties;

/// <summary>
/// This class provides access to the "core properties", such as Title and
/// </summary>
public static class CorePropertiesConverter
{
  /// <summary>
  /// The title.
  /// </summary>
  private static String? GetTitle(PackageProperties openXmlElement)
  {
    return openXmlElement?.Title;
  }
  
  private static bool CmpTitle(PackageProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Title == value) return true;
    diffs?.Add(objName, "Title", openXmlElement?.Title, value);
    return false;
  }
  
  private static void SetTitle(PackageProperties openXmlElement, String? value)
  {
    openXmlElement.Title = value;
  }
  
  /// <summary>
  /// The topic of the contents.
  /// </summary>
  private static String? GetSubject(PackageProperties openXmlElement)
  {
    return openXmlElement?.Subject;
  }
  
  private static bool CmpSubject(PackageProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Subject == value) return true;
    diffs?.Add(objName, "Subject", openXmlElement?.Subject, value);
    return false;
  }
  
  private static void SetSubject(PackageProperties openXmlElement, String? value)
  {
    openXmlElement.Subject = value;
  }
  
  /// <summary>
  /// The primary creator. The identification is environment-specific and
  /// </summary>
  private static String? GetCreator(PackageProperties openXmlElement)
  {
    return openXmlElement?.Creator;
  }
  
  private static bool CmpCreator(PackageProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Creator == value) return true;
    diffs?.Add(objName, "Creator", openXmlElement?.Creator, value);
    return false;
  }
  
  private static void SetCreator(PackageProperties openXmlElement, String? value)
  {
    openXmlElement.Creator = value;
  }
  
  /// <summary>
  /// A delimited set of keywords to support searching and indexing. This
  /// </summary>
  private static String? GetKeywords(PackageProperties openXmlElement)
  {
    return openXmlElement?.Keywords;
  }
  
  private static bool CmpKeywords(PackageProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Keywords == value) return true;
    diffs?.Add(objName, "Keywords", openXmlElement?.Keywords, value);
    return false;
  }
  
  private static void SetKeywords(PackageProperties openXmlElement, String? value)
  {
    openXmlElement.Keywords = value;
  }
  
  /// <summary>
  /// The description or abstract of the contents.
  /// </summary>
  private static String? GetDescription(PackageProperties openXmlElement)
  {
    return openXmlElement?.Description;
  }
  
  private static bool CmpDescription(PackageProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Description == value) return true;
    diffs?.Add(objName, "Description", openXmlElement?.Description, value);
    return false;
  }
  
  private static void SetDescription(PackageProperties openXmlElement, String? value)
  {
    openXmlElement.Description = value;
  }
  
  /// <summary>
  /// The user who performed the last modification. The identification is
  /// </summary>
  private static String? GetLastModifiedBy(PackageProperties openXmlElement)
  {
    return openXmlElement?.LastModifiedBy;
  }
  
  private static bool CmpLastModifiedBy(PackageProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.LastModifiedBy == value) return true;
    diffs?.Add(objName, "LastModifiedBy", openXmlElement?.LastModifiedBy, value);
    return false;
  }
  
  private static void SetLastModifiedBy(PackageProperties openXmlElement, String? value)
  {
    openXmlElement.LastModifiedBy = value;
  }
  
  /// <summary>
  /// The revision number. This value indicates the number of saves or
  /// </summary>
  private static String? GetRevision(PackageProperties openXmlElement)
  {
    return openXmlElement?.Revision;
  }
  
  private static bool CmpRevision(PackageProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Revision == value) return true;
    diffs?.Add(objName, "Revision", openXmlElement?.Revision, value);
    return false;
  }
  
  private static void SetRevision(PackageProperties openXmlElement, String? value)
  {
    openXmlElement.Revision = value;
  }
  
  /// <summary>
  /// The date and time of the last printing.
  /// </summary>
  private static DateTime? GetLastPrinted(PackageProperties openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<Nullable<DateTime>>()?.Val);
  }
  
  private static bool CmpLastPrinted(PackageProperties openXmlElement, DateTime? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<Nullable<DateTime>>()?.Val, value, diffs, objName, "Nullable`1");
  }
  
  private static void SetLastPrinted(PackageProperties openXmlElement, DateTime? value)
  {
    SimpleValueConverter.SetValue<Nullable<DateTime>,System.DateTime>(openXmlElement, value);
  }
  
  /// <summary>
  /// The creation date and time.
  /// </summary>
  private static DateTime? GetCreated(PackageProperties openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<Nullable<DateTime>>()?.Val);
  }
  
  private static bool CmpCreated(PackageProperties openXmlElement, DateTime? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<Nullable<DateTime>>()?.Val, value, diffs, objName, "Nullable`1");
  }
  
  private static void SetCreated(PackageProperties openXmlElement, DateTime? value)
  {
    SimpleValueConverter.SetValue<Nullable<DateTime>,System.DateTime>(openXmlElement, value);
  }
  
  /// <summary>
  /// The date and time of the last modification.
  /// </summary>
  private static DateTime? GetModified(PackageProperties openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<Nullable<DateTime>>()?.Val);
  }
  
  private static bool CmpModified(PackageProperties openXmlElement, DateTime? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<Nullable<DateTime>>()?.Val, value, diffs, objName, "Nullable`1");
  }
  
  private static void SetModified(PackageProperties openXmlElement, DateTime? value)
  {
    SimpleValueConverter.SetValue<Nullable<DateTime>,System.DateTime>(openXmlElement, value);
  }
  
  /// <summary>
  /// The category. This value is typically used by UI applications to create navigation
  /// </summary>
  private static String? GetCategory(PackageProperties openXmlElement)
  {
    return openXmlElement?.Category;
  }
  
  private static bool CmpCategory(PackageProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Category == value) return true;
    diffs?.Add(objName, "Category", openXmlElement?.Category, value);
    return false;
  }
  
  private static void SetCategory(PackageProperties openXmlElement, String? value)
  {
    openXmlElement.Category = value;
  }
  
  /// <summary>
  /// A unique identifier.
  /// </summary>
  private static String? GetIdentifier(PackageProperties openXmlElement)
  {
    return openXmlElement?.Identifier;
  }
  
  private static bool CmpIdentifier(PackageProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Identifier == value) return true;
    diffs?.Add(objName, "Identifier", openXmlElement?.Identifier, value);
    return false;
  }
  
  private static void SetIdentifier(PackageProperties openXmlElement, String? value)
  {
    openXmlElement.Identifier = value;
  }
  
  /// <summary>
  /// The type of content represented, generally defined by a specific
  /// </summary>
  private static String? GetContentType(PackageProperties openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static bool CmpContentType(PackageProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ContentType == value) return true;
    diffs?.Add(objName, "ContentType", openXmlElement?.ContentType, value);
    return false;
  }
  
  private static void SetContentType(PackageProperties openXmlElement, String? value)
  {
    openXmlElement.ContentType = value;
  }
  
  /// <summary>
  /// The primary language of the package content. The language tag is
  /// </summary>
  private static String? GetLanguage(PackageProperties openXmlElement)
  {
    return openXmlElement?.Language;
  }
  
  private static bool CmpLanguage(PackageProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Language == value) return true;
    diffs?.Add(objName, "Language", openXmlElement?.Language, value);
    return false;
  }
  
  private static void SetLanguage(PackageProperties openXmlElement, String? value)
  {
    openXmlElement.Language = value;
  }
  
  /// <summary>
  /// The version number. This value is set by the user or by the application.
  /// </summary>
  private static String? GetVersion(PackageProperties openXmlElement)
  {
    return openXmlElement?.Version;
  }
  
  private static bool CmpVersion(PackageProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Version == value) return true;
    diffs?.Add(objName, "Version", openXmlElement?.Version, value);
    return false;
  }
  
  private static void SetVersion(PackageProperties openXmlElement, String? value)
  {
    openXmlElement.Version = value;
  }
  
  /// <summary>
  /// The status of the content. Example values include "Draft",
  /// </summary>
  private static String? GetContentStatus(PackageProperties openXmlElement)
  {
    return openXmlElement?.ContentStatus;
  }
  
  private static bool CmpContentStatus(PackageProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ContentStatus == value) return true;
    diffs?.Add(objName, "ContentStatus", openXmlElement?.ContentStatus, value);
    return false;
  }
  
  private static void SetContentStatus(PackageProperties openXmlElement, String? value)
  {
    openXmlElement.ContentStatus = value;
  }
  
  public static DocumentModel.Properties.CoreProperties? CreateModelElement(PackageProperties? openXmlElement)
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
  
  public static bool CompareModelElement(PackageProperties? openXmlElement, DMProps.CoreProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTitle(openXmlElement, value.Title, diffs, objName))
        ok = false;
      if (!CmpSubject(openXmlElement, value.Subject, diffs, objName))
        ok = false;
      if (!CmpCreator(openXmlElement, value.Creator, diffs, objName))
        ok = false;
      if (!CmpKeywords(openXmlElement, value.Keywords, diffs, objName))
        ok = false;
      if (!CmpDescription(openXmlElement, value.Description, diffs, objName))
        ok = false;
      if (!CmpLastModifiedBy(openXmlElement, value.LastModifiedBy, diffs, objName))
        ok = false;
      if (!CmpRevision(openXmlElement, value.Revision, diffs, objName))
        ok = false;
      if (!CmpLastPrinted(openXmlElement, value.LastPrinted, diffs, objName))
        ok = false;
      if (!CmpCreated(openXmlElement, value.Created, diffs, objName))
        ok = false;
      if (!CmpModified(openXmlElement, value.Modified, diffs, objName))
        ok = false;
      if (!CmpCategory(openXmlElement, value.Category, diffs, objName))
        ok = false;
      if (!CmpIdentifier(openXmlElement, value.Identifier, diffs, objName))
        ok = false;
      if (!CmpContentType(openXmlElement, value.ContentType, diffs, objName))
        ok = false;
      if (!CmpLanguage(openXmlElement, value.Language, diffs, objName))
        ok = false;
      if (!CmpVersion(openXmlElement, value.Version, diffs, objName))
        ok = false;
      if (!CmpContentStatus(openXmlElement, value.ContentStatus, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMProps.CoreProperties value)
    where OpenXmlElementType: PackageProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(PackageProperties openXmlElement, DMProps.CoreProperties value)
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
