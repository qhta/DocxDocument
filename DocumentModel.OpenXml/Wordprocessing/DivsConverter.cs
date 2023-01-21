namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Divs Class.
/// </summary>
public static class DivsConverter
{
  private static DMW.Div? GetDiv(DXW.Divs openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.Div>();
    if (itemElement != null)
      return DMXW.DivConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDiv(DXW.Divs openXmlElement, DMW.Div? value)
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
  
  public static DMW.Divs? CreateModelElement(DXW.Divs? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Divs();
      value.Div = GetDiv(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Divs? value)
    where OpenXmlElementType: DXW.Divs, new()
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
