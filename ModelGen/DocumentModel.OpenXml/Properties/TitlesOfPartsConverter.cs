namespace DocumentModel.OpenXml.Properties;

/// <summary>
/// Part Titles.
/// </summary>
public static class TitlesOfPartsConverter
{
  /// <summary>
  /// Vector.
  /// </summary>
  private static DM.VectorVariant? GetVTVector(DXExtProps.TitlesOfParts openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVT.VTVector>();
    if (element != null)
      return ObjectConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpVTVector(DXExtProps.TitlesOfParts openXmlElement, DM.VectorVariant? value, DiffList? diffs, string? objName)
  {
    return ObjectConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVT.VTVector>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetVTVector(DXExtProps.TitlesOfParts openXmlElement, DM.VectorVariant? value)
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
  
  public static DocumentModel.Properties.TitlesOfParts? CreateModelElement(DXExtProps.TitlesOfParts? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Properties.TitlesOfParts();
      value.VTVector = GetVTVector(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXExtProps.TitlesOfParts? openXmlElement, DMProps.TitlesOfParts? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMProps.TitlesOfParts value)
    where OpenXmlElementType: DXExtProps.TitlesOfParts, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXExtProps.TitlesOfParts openXmlElement, DMProps.TitlesOfParts value)
  {
    SetVTVector(openXmlElement, value?.VTVector);
  }
}
