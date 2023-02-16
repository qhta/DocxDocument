namespace DocumentModel.OpenXml.Properties;

/// <summary>
/// Defines the VectorVariantType Class.
/// </summary>
public static class VectorVariantTypeConverter
{
  /// <summary>
  /// Vector.
  /// </summary>
  private static DM.VectorVariant? GetVTVector(DXExtProps.VectorVariantType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVT.VTVector>();
    if (element != null)
      return DMX.VectorVariantConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpVTVector(DXExtProps.VectorVariantType openXmlElement, DM.VectorVariant? value, DiffList? diffs, string? objName)
  {
    return DMX.VectorVariantConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVT.VTVector>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetVTVector(DXExtProps.VectorVariantType openXmlElement, DM.VectorVariant? value)
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
  
  public static DocumentModel.Properties.VectorVariantType? CreateModelElement(DXExtProps.VectorVariantType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Properties.VectorVariantType();
      value.VTVector = GetVTVector(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXExtProps.VectorVariantType? openXmlElement, DMProps.VectorVariantType? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMProps.VectorVariantType? value)
    where OpenXmlElementType: DXExtProps.VectorVariantType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVTVector(openXmlElement, value?.VTVector);
      return openXmlElement;
    }
    return default;
  }
}
