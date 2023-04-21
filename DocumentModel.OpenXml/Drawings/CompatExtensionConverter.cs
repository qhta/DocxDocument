namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the CompatExtension Class.
/// </summary>
public static class CompatExtensionConverter
{
  /// <summary>
  /// spid, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetShapeId(DXO10D.CompatExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ShapeId);
  }
  
  private static bool CmpShapeId(DXO10D.CompatExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ShapeId, value, diffs, objName, "ShapeId");
  }
  
  private static void SetShapeId(DXO10D.CompatExtension openXmlElement, String? value)
  {
    openXmlElement.ShapeId = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Drawings.CompatExtension? CreateModelElement(DXO10D.CompatExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.CompatExtension();
      value.ShapeId = GetShapeId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10D.CompatExtension? openXmlElement, DMD.CompatExtension? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpShapeId(openXmlElement, value.ShapeId, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.CompatExtension value)
    where OpenXmlElementType: DXO10D.CompatExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10D.CompatExtension openXmlElement, DMD.CompatExtension value)
  {
    SetShapeId(openXmlElement, value?.ShapeId);
  }
}
