namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Person Class.
/// </summary>
public static class PersonConverter
{
  /// <summary>
  /// Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  private static String? GetContact(DXO13W.Person openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Contact);
  }
  
  private static bool CmpContact(DXO13W.Person openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Contact, value, diffs, objName, "Contact");
  }
  
  private static void SetContact(DXO13W.Person openXmlElement, String? value)
  {
    openXmlElement.Contact = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// author, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetAuthor(DXO13W.Person openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Author);
  }
  
  private static bool CmpAuthor(DXO13W.Person openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Author, value, diffs, objName, "Author");
  }
  
  private static void SetAuthor(DXO13W.Person openXmlElement, String? value)
  {
    openXmlElement.Author = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// PresenceInfo.
  /// </summary>
  private static DMW.PresenceInfo? GetPresenceInfo(DXO13W.Person openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13W.PresenceInfo>();
    if (element != null)
      return DMXW.PresenceInfoConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPresenceInfo(DXO13W.Person openXmlElement, DMW.PresenceInfo? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.PresenceInfoConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13W.PresenceInfo>(), value, diffs, objName, propName);
  }
  
  private static void SetPresenceInfo(DXO13W.Person openXmlElement, DMW.PresenceInfo? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13W.PresenceInfo>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.PresenceInfoConverter.CreateOpenXmlElement<DXO13W.PresenceInfo>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMW.Person? CreateModelElement(DXO13W.Person? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Person();
      value.Contact = GetContact(openXmlElement);
      value.Author = GetAuthor(openXmlElement);
      value.PresenceInfo = GetPresenceInfo(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO13W.Person? openXmlElement, DMW.Person? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpContact(openXmlElement, value.Contact, diffs, objName, propName))
        ok = false;
      if (!CmpAuthor(openXmlElement, value.Author, diffs, objName, propName))
        ok = false;
      if (!CmpPresenceInfo(openXmlElement, value.PresenceInfo, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Person value)
    where OpenXmlElementType: DXO13W.Person, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13W.Person openXmlElement, DMW.Person value)
  {
    SetContact(openXmlElement, value?.Contact);
    SetAuthor(openXmlElement, value?.Author);
    SetPresenceInfo(openXmlElement, value?.PresenceInfo);
  }
}
