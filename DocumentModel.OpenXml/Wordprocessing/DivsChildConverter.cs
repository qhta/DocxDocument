namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Child div Elements Contained within Current div.
/// </summary>
public static class DivsChildConverter
{
  private static DMW.Div? GetDiv(DXW.DivsChild openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.Div>();
    if (itemElement != null)
      return DMXW.DivConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDiv(DXW.DivsChild openXmlElement, DMW.Div? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Div>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.DivConverter.CreateOpenXmlElement<DXW.Div>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.DivsChild? CreateModelElement(DXW.DivsChild? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.DivsChild();
      value.Div = GetDiv(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.DivsChild? value)
    where OpenXmlElementType: DXW.DivsChild, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDiv(openXmlElement, value?.Div);
      return openXmlElement;
    }
    return default;
  }
}
