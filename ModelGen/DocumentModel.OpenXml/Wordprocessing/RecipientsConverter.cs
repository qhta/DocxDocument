namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines Recipients.
/// </summary>
public static class RecipientsConverter
{
  private static DMW.RecipientData? GetRecipientData(DXW.Recipients openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.RecipientData>();
    if (element != null)
      return DMXW.RecipientDataConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRecipientData(DXW.Recipients openXmlElement, DMW.RecipientData? value, DiffList? diffs, string? objName)
  {
    return DMXW.RecipientDataConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.RecipientData>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRecipientData(DXW.Recipients openXmlElement, DMW.RecipientData? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RecipientData>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RecipientDataConverter.CreateOpenXmlElement<DXW.RecipientData>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.Recipients? CreateModelElement(DXW.Recipients? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Recipients();
      value.RecipientData = GetRecipientData(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.Recipients? openXmlElement, DMW.Recipients? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRecipientData(openXmlElement, value.RecipientData, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Recipients value)
    where OpenXmlElementType: DXW.Recipients, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.Recipients openXmlElement, DMW.Recipients value)
  {
    SetRecipientData(openXmlElement, value?.RecipientData);
  }
}
