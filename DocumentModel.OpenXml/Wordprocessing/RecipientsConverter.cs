namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines Recipients.
/// </summary>
public static class RecipientsConverter
{
  private static DMW.RecipientData? GetRecipientData(DXW.Recipients openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.RecipientData>();
    if (itemElement != null)
      return DMXW.RecipientDataConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMW.Recipients? CreateModelElement(DXW.Recipients? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Recipients();
      value.RecipientData = GetRecipientData(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Recipients? value)
    where OpenXmlElementType: DXW.Recipients, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRecipientData(openXmlElement, value?.RecipientData);
      return openXmlElement;
    }
    return default;
  }
}
