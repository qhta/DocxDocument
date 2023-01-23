namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the CameraTool Class.
/// </summary>
public static class CameraToolConverter
{
  /// <summary>
  /// cellRange, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetCellRange(DXO2010Draw.CameraTool openXmlElement)
  {
    return openXmlElement?.CellRange?.Value;
  }
  
  private static bool CmpCellRange(DXO2010Draw.CameraTool openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.CellRange?.Value == value;
  }
  
  private static void SetCellRange(DXO2010Draw.CameraTool openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.CellRange = new StringValue { Value = value };
    else
      openXmlElement.CellRange = null;
  }
  
  /// <summary>
  /// spid, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetShapeId(DXO2010Draw.CameraTool openXmlElement)
  {
    return openXmlElement?.ShapeId?.Value;
  }
  
  private static bool CmpShapeId(DXO2010Draw.CameraTool openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ShapeId?.Value == value;
  }
  
  private static void SetShapeId(DXO2010Draw.CameraTool openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ShapeId = new StringValue { Value = value };
    else
      openXmlElement.ShapeId = null;
  }
  
  public static DMDraws.CameraTool? CreateModelElement(DXO2010Draw.CameraTool? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.CameraTool();
      value.CellRange = GetCellRange(openXmlElement);
      value.ShapeId = GetShapeId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010Draw.CameraTool? openXmlElement, DMDraws.CameraTool? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpCellRange(openXmlElement, value.CellRange, diffs, objName))
        ok = false;
      if (!CmpShapeId(openXmlElement, value.ShapeId, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.CameraTool? value)
    where OpenXmlElementType: DXO2010Draw.CameraTool, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCellRange(openXmlElement, value?.CellRange);
      SetShapeId(openXmlElement, value?.ShapeId);
      return openXmlElement;
    }
    return default;
  }
}
