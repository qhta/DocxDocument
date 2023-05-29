namespace DocumentModel.OpenXml.Properties;

/// <summary>
/// Heading Pairs.
/// </summary>
public static class HeadingPairsConverter
{
  private static DM.VectorVariant? GetVTVector(DXExtProps.HeadingPairs openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVT.VTVector>();
    if (element != null)
      return ObjectConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpVTVector(DXExtProps.HeadingPairs openXmlElement, DM.VectorVariant? value, DiffList? diffs, string? objName)
  {
    return ObjectConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVT.VTVector>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetVTVector(DXExtProps.HeadingPairs openXmlElement, DM.VectorVariant? value)
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
  
  public static DocumentModel.Properties.HeadingPairs? CreateModelElement(DXExtProps.HeadingPairs? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Properties.HeadingPairs();
      value.VTVector = GetVTVector(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXExtProps.HeadingPairs? openXmlElement, DMProps.HeadingPairs? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMProps.HeadingPairs value)
    where OpenXmlElementType: DXExtProps.HeadingPairs, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXExtProps.HeadingPairs openXmlElement, DMProps.HeadingPairs value)
  {
    SetVTVector(openXmlElement, value?.VTVector);
  }
}
