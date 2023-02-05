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
    return openXmlElement?.Contact?.Value;
  }
  
  private static bool CmpContact(DXO2013W.Person openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Contact?.Value == value) return true;
    diffs?.Add(objName, "Contact", openXmlElement?.Contact?.Value, value);
    return false;
  }
  
  private static void SetContact(DXO2013W.Person openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Contact = new StringValue { Value = value };
    else
      openXmlElement.Contact = null;
  }
  
  /// <summary>
  /// author, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetAuthor(DXO2013W.Person openXmlElement)
  {
    return openXmlElement?.Author?.Value;
  }
  
  private static bool CmpAuthor(DXO2013W.Person openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Author?.Value == value) return true;
    diffs?.Add(objName, "Author", openXmlElement?.Author?.Value, value);
    return false;
  }
  
  private static void SetAuthor(DXO2013W.Person openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Author = new StringValue { Value = value };
    else
      openXmlElement.Author = null;
  }
  
  /// <summary>
  /// PresenceInfo.
  /// </summary>
  private static DMW.PresenceInfo? GetPresenceInfo(DXO2013W.Person openXmlElement)
  {
    return DMXW.PresenceInfoConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2013W.PresenceInfo>());
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
  
  public static DMW.Person? CreateModelElement(DXO2013W.Person? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Person? value)
    where OpenXmlElementType: DXO2013W.Person, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetContact(openXmlElement, value?.Contact);
      SetAuthor(openXmlElement, value?.Author);
      SetPresenceInfo(openXmlElement, value?.PresenceInfo);
      return openXmlElement;
    }
    return default;
  }
}
