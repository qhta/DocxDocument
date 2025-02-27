namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Person Class.
/// </summary>
public static class PersonConverter
{
  /// <summary>
  /// Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  private static String? GetContact(DXO2013W.Person openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Contact);
  }
  
  private static bool CmpContact(DXO2013W.Person openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Contact, value, diffs, objName, "Contact");
  }
  
  private static void SetContact(DXO2013W.Person openXmlElement, String? value)
  {
    openXmlElement.Contact = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// author, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetAuthor(DXO2013W.Person openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Author);
  }
  
  private static bool CmpAuthor(DXO2013W.Person openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Author, value, diffs, objName, "Author");
  }
  
  private static void SetAuthor(DXO2013W.Person openXmlElement, String? value)
  {
    openXmlElement.Author = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// PresenceInfo.
  /// </summary>
  private static DMW.PresenceInfo? GetPresenceInfo(DXO2013W.Person openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2013W.PresenceInfo>();
    if (element != null)
      return DMXW.PresenceInfoConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPresenceInfo(DXO2013W.Person openXmlElement, DMW.PresenceInfo? value, DiffList? diffs, string? objName)
  {
    return DMXW.PresenceInfoConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013W.PresenceInfo>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPresenceInfo(DXO2013W.Person openXmlElement, DMW.PresenceInfo? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013W.PresenceInfo>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.PresenceInfoConverter.CreateOpenXmlElement<DXO2013W.PresenceInfo>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.Person? CreateModelElement(DXO2013W.Person? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Person();
      value.Contact = GetContact(openXmlElement);
      value.Author = GetAuthor(openXmlElement);
      value.PresenceInfo = GetPresenceInfo(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013W.Person? openXmlElement, DMW.Person? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpContact(openXmlElement, value.Contact, diffs, objName))
        ok = false;
      if (!CmpAuthor(openXmlElement, value.Author, diffs, objName))
        ok = false;
      if (!CmpPresenceInfo(openXmlElement, value.PresenceInfo, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Person value)
    where OpenXmlElementType: DXO2013W.Person, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2013W.Person openXmlElement, DMW.Person value)
  {
    SetContact(openXmlElement, value?.Contact);
    SetAuthor(openXmlElement, value?.Author);
    SetPresenceInfo(openXmlElement, value?.PresenceInfo);
  }
}
