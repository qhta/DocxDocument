namespace DocumentModel.OpenXml.Properties;

public static class CorePropertiesConverter
{
  public static String? GetTitle(System.IO.Packaging.PackageProperties openXmlElement)
  {
    return openXmlElement?.Title;
  }
  public static void SetTitle(System.IO.Packaging.PackageProperties openXmlElement, String? value)
  {
    if (openXmlElement != null)
      openXmlElement.Title = value;
  }
  
  public static String? GetSubject(System.IO.Packaging.PackageProperties openXmlElement)
  {
    return openXmlElement?.Subject;
  }
  public static void SetSubject(System.IO.Packaging.PackageProperties openXmlElement, String? value)
  {
    if (openXmlElement != null)
      openXmlElement.Subject = value;
  }
  
  public static String? GetCreator(System.IO.Packaging.PackageProperties openXmlElement)
  {
    return openXmlElement?.Creator;
  }
  public static void SetCreator(System.IO.Packaging.PackageProperties openXmlElement, String? value)
  {
    if (openXmlElement != null)
      openXmlElement.Creator = value;
  }
  
  public static String? GetKeywords(System.IO.Packaging.PackageProperties openXmlElement)
  {
    return openXmlElement?.Keywords;
  }
  public static void SetKeywords(System.IO.Packaging.PackageProperties openXmlElement, String? value)
  {
    if (openXmlElement != null)
      openXmlElement.Keywords = value;
  }
  
  public static String? GetDescription(System.IO.Packaging.PackageProperties openXmlElement)
  {
    return openXmlElement?.Description;
  }
  public static void SetDescription(System.IO.Packaging.PackageProperties openXmlElement, String? value)
  {
    if (openXmlElement != null)
      openXmlElement.Description = value;
  }
  
  public static String? GetLastModifiedBy(System.IO.Packaging.PackageProperties openXmlElement)
  {
    return openXmlElement?.LastModifiedBy;
  }
  public static void SetLastModifiedBy(System.IO.Packaging.PackageProperties openXmlElement, String? value)
  {
    if (openXmlElement != null)
      openXmlElement.LastModifiedBy = value;
  }
  
  public static String? GetRevision(System.IO.Packaging.PackageProperties openXmlElement)
  {
    return openXmlElement?.Revision;
  }
  public static void SetRevision(System.IO.Packaging.PackageProperties openXmlElement, String? value)
  {
    if (openXmlElement != null)
      openXmlElement.Revision = value;
  }
  
  public static DateTime? GetLastPrinted(System.IO.Packaging.PackageProperties openXmlElement)
  {
    return openXmlElement?.LastPrinted;
  }
  public static void SetLastPrinted(System.IO.Packaging.PackageProperties openXmlElement, DateTime? value)
  {
    if (openXmlElement != null)
      openXmlElement.LastPrinted = value;
  }
  
  public static DateTime? GetCreated(System.IO.Packaging.PackageProperties openXmlElement)
  {
    return openXmlElement?.Created;
  }
  public static void SetCreated(System.IO.Packaging.PackageProperties openXmlElement, DateTime? value)
  {
    if (openXmlElement != null)
      openXmlElement.Created = value;
  }
  
  public static DateTime? GetModified(System.IO.Packaging.PackageProperties openXmlElement)
  {
    return openXmlElement?.Modified;
  }
  public static void SetModified(System.IO.Packaging.PackageProperties openXmlElement, DateTime? value)
  {
    if (openXmlElement != null)
      openXmlElement.Modified = value;
  }
  
  public static String? GetCategory(System.IO.Packaging.PackageProperties openXmlElement)
  {
    return openXmlElement?.Category;
  }
  public static void SetCategory(System.IO.Packaging.PackageProperties openXmlElement, String? value)
  {
    if (openXmlElement != null)
      openXmlElement.Category = value;
  }
  
  public static String? GetIdentifier(System.IO.Packaging.PackageProperties openXmlElement)
  {
    return openXmlElement?.Identifier;
  }
  public static void SetIdentifier(System.IO.Packaging.PackageProperties openXmlElement, String? value)
  {
    if (openXmlElement != null)
      openXmlElement.Identifier = value;
  }
  
  public static String? GetContentType(System.IO.Packaging.PackageProperties openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  public static void SetContentType(System.IO.Packaging.PackageProperties openXmlElement, String? value)
  {
    if (openXmlElement != null)
      openXmlElement.ContentType = value;
  }
  
  public static String? GetLanguage(System.IO.Packaging.PackageProperties openXmlElement)
  {
    return openXmlElement?.Language;
  }
  public static void SetLanguage(System.IO.Packaging.PackageProperties openXmlElement, String? value)
  {
    if (openXmlElement != null)
      openXmlElement.Language = value;
  }
  
  public static String? GetVersion(System.IO.Packaging.PackageProperties openXmlElement)
  {
    return openXmlElement?.Version;
  }
  public static void SetVersion(System.IO.Packaging.PackageProperties openXmlElement, String? value)
  {
    if (openXmlElement != null)
      openXmlElement.Version = value;
  }
  
  public static String? GetContentStatus(System.IO.Packaging.PackageProperties openXmlElement)
  {
    return openXmlElement?.ContentStatus;
  }
  public static void SetContentStatus(System.IO.Packaging.PackageProperties openXmlElement, String? value)
  {
    if (openXmlElement != null)
      openXmlElement.ContentStatus = value;
  }
  
  public static DocumentModel.Properties.CoreProperties? GetValue(System.IO.Packaging.PackageProperties openXmlElement)
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
  
  public static void SetValue(System.IO.Packaging.PackageProperties openXmlElement, DocumentModel.Properties.CoreProperties value)
  {
    SetTitle(openXmlElement, value.Title);
    SetSubject(openXmlElement, value.Subject);
    SetCreator(openXmlElement, value.Creator);
    SetKeywords(openXmlElement, value.Keywords);
    SetDescription(openXmlElement, value.Description);
    SetLastModifiedBy(openXmlElement, value.LastModifiedBy);
    SetRevision(openXmlElement, value.Revision);
    SetLastPrinted(openXmlElement, value.LastPrinted);
    SetCreated(openXmlElement, value.Created);
    SetModified(openXmlElement, value.Modified);
    SetCategory(openXmlElement, value.Category);
    SetIdentifier(openXmlElement, value.Identifier);
    SetContentType(openXmlElement, value.ContentType);
    SetLanguage(openXmlElement, value.Language);
    SetVersion(openXmlElement, value.Version);
    SetContentStatus(openXmlElement, value.ContentStatus);
  }
}
