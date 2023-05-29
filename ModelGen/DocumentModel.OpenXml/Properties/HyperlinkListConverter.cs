namespace DocumentModel.OpenXml.Properties;

/// <summary>
/// Hyperlink List.
/// </summary>
public static class HyperlinkListConverter
{
  private static DM.VectorVariant? GetVTVector(DXExtProps.HyperlinkList openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVT.VTVector>();
    if (element != null)
      return ObjectConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpVTVector(DXExtProps.HyperlinkList openXmlElement, DM.VectorVariant? value, DiffList? diffs, string? objName)
  {
    return ObjectConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVT.VTVector>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetVTVector(DXExtProps.HyperlinkList openXmlElement, DM.VectorVariant? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVT.VTVector>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.VectorVariantConverter.CreateOpenXmlElement<DXVT.VTVector>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Properties.HyperlinkList? CreateModelElement(DXExtProps.HyperlinkList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Properties.HyperlinkList();
      value.VTVector = GetVTVector(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXExtProps.HyperlinkList? openXmlElement, DMProps.HyperlinkList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpVTVector(openXmlElement, value.VTVector, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMProps.HyperlinkList value)
    where OpenXmlElementType: DXExtProps.HyperlinkList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXExtProps.HyperlinkList openXmlElement, DMProps.HyperlinkList value)
  {
    SetVTVector(openXmlElement, value?.VTVector);
  }
}
