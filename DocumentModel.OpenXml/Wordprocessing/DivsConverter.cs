namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Divs Class.
/// </summary>
public static class DivsConverter
{
  private static DMW.Div? GetDiv(DXW.Divs openXmlElement)
  {
    return DMXW.DivConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.Div>());
  }
  
  private static bool CmpDiv(DXW.Divs openXmlElement, DMW.Div? value, DiffList? diffs, string? objName)
  {
    return DMXW.DivConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.Div>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static bool CompareModelElement(DXW.Divs? openXmlElement, DMW.Divs? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDiv(openXmlElement, value.Div, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
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
