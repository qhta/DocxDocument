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
    return openXmlElement?.Name?.Value;
  }
  
  private static bool CmpName(DXW.Control openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Name?.Value == value) return true;
    diffs?.Add(objName, "Name", openXmlElement?.Name?.Value, value);
    return false;
  }
  
  private static void SetName(DXW.Control openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  /// <summary>
  /// Associated VML Data Reference
  /// </summary>
  private static String? GetShapeId(DXW.Control openXmlElement)
  {
    return openXmlElement?.ShapeId?.Value;
  }
  
  private static bool CmpShapeId(DXW.Control openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ShapeId?.Value == value) return true;
    diffs?.Add(objName, "ShapeId", openXmlElement?.ShapeId?.Value, value);
    return false;
  }
  
  private static void SetShapeId(DXW.Control openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ShapeId = new StringValue { Value = value };
    else
      openXmlElement.ShapeId = null;
  }
  
  /// <summary>
  /// Embedded Control Properties Relationship Reference
  /// </summary>
  private static String? GetId(DXW.Control openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXW.Control openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Id?.Value == value) return true;
    diffs?.Add(objName, "Id", openXmlElement?.Id?.Value, value);
    return false;
  }
  
  private static void SetId(DXW.Control openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  public static DocumentModel.Wordprocessing.Control? CreateModelElement(DXW.Control? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Control();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Control? value)
    where OpenXmlElementType: DXW.Control, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetShapeId(openXmlElement, value?.ShapeId);
      SetId(openXmlElement, value?.Id);
      return openXmlElement;
    }
    return default;
  }
}
