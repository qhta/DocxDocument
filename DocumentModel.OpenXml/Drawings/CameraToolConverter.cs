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
    return StringValueConverter.GetValue(openXmlElement?.CellRange);
  }
  
  private static bool CmpCellRange(DXO2010Draw.CameraTool openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.CellRange, value, diffs, objName, "CellRange");
  }
  
  private static void SetCellRange(DXO2010Draw.CameraTool openXmlElement, String? value)
  {
    openXmlElement.CellRange = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// spid, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetShapeId(DXO2010Draw.CameraTool openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ShapeId);
  }
  
  private static bool CmpShapeId(DXO2010Draw.CameraTool openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ShapeId, value, diffs, objName, "ShapeId");
  }
  
  private static void SetShapeId(DXO2010Draw.CameraTool openXmlElement, String? value)
  {
    openXmlElement.ShapeId = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Drawings.CameraTool? CreateModelElement(DXO2010Draw.CameraTool? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.CameraTool();
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.CameraTool value)
    where OpenXmlElementType: DXO2010Draw.CameraTool, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010Draw.CameraTool openXmlElement, DMDraws.CameraTool value)
  {
    SetCellRange(openXmlElement, value?.CellRange);
    SetShapeId(openXmlElement, value?.ShapeId);
    }
  }
