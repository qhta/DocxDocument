namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Control Class.
/// </summary>
public static class ControlConverter
{
  /// <summary>
  /// Unique Name for Embedded Control
  /// </summary>
  private static String? GetName(DXW.Control openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Name);
  }
  
  private static bool CmpName(DXW.Control openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Name, value, diffs, objName, "Name");
  }
  
  private static void SetName(DXW.Control openXmlElement, String? value)
  {
    openXmlElement.Name = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Associated VML Data Reference
  /// </summary>
  private static String? GetShapeId(DXW.Control openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ShapeId);
  }
  
  private static bool CmpShapeId(DXW.Control openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ShapeId, value, diffs, objName, "ShapeId");
  }
  
  private static void SetShapeId(DXW.Control openXmlElement, String? value)
  {
    openXmlElement.ShapeId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Embedded Control Properties Relationship Reference
  /// </summary>
  private static String? GetId(DXW.Control openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXW.Control openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "Id");
  }
  
  private static void SetId(DXW.Control openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  public static DMW.Control? CreateModelElement(DXW.Control? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Control();
      value.Name = GetName(openXmlElement);
      value.ShapeId = GetShapeId(openXmlElement);
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.Control? openXmlElement, DMW.Control? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpName(openXmlElement, value.Name, diffs, objName))
        ok = false;
      if (!CmpShapeId(openXmlElement, value.ShapeId, diffs, objName))
        ok = false;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Control value)
    where OpenXmlElementType: DXW.Control, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.Control openXmlElement, DMW.Control value)
  {
    SetName(openXmlElement, value?.Name);
    SetShapeId(openXmlElement, value?.ShapeId);
    SetId(openXmlElement, value?.Id);
  }
}
