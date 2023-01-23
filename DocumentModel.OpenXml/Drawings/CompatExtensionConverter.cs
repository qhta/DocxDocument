namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the CompatExtension Class.
/// </summary>
public static class CompatExtensionConverter
{
  /// <summary>
  /// spid, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetShapeId(DXO2010Draw.CompatExtension openXmlElement)
  {
    return openXmlElement?.ShapeId?.Value;
  }
  
  private static bool CmpShapeId(DXO2010Draw.CompatExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ShapeId?.Value == value;
  }
  
  private static void SetShapeId(DXO2010Draw.CompatExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ShapeId = new StringValue { Value = value };
    else
      openXmlElement.ShapeId = null;
  }
  
  public static DMDraws.CompatExtension? CreateModelElement(DXO2010Draw.CompatExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.CompatExtension();
      value.ShapeId = GetShapeId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010Draw.CompatExtension? openXmlElement, DMDraws.CompatExtension? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpShapeId(openXmlElement, value.ShapeId, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.CompatExtension? value)
    where OpenXmlElementType: DXO2010Draw.CompatExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetShapeId(openXmlElement, value?.ShapeId);
      return openXmlElement;
    }
    return default;
  }
}
