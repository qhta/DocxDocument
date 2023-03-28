namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Child div Elements Contained within Current div converter from/to OpenXml.
///</summary>
public static class DivsChildConverter
{
  private static DMW.Div? GetDiv(DXW.DivsChild openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Div>();
    if (element != null)
      return DMXW.DivConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDiv(DXW.DivsChild openXmlElement, DMW.Div? value, DiffList? diffs, string? objName)
  {
    return DMXW.DivConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Div>(), value, diffs, objName);
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
  
  public static bool CompareModelElement(DXW.DivsChild? openXmlElement, DMW.DivsChild? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDiv(openXmlElement, value.Div, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.DivsChild value)
    where OpenXmlElementType: DXW.DivsChild, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.DivsChild openXmlElement, DMW.DivsChild value)
  {
    SetDiv(openXmlElement, value?.Div);
  }
}
