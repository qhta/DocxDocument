namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
/// Defines the Drawing Class.
/// </summary>
public static class DrawingConverter
{
  /// <summary>
  /// ShapeTree.
  /// </summary>
  private static DMDO.ShapeTree? GetShapeTree(DXOD.Drawing openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOD.ShapeTree>();
    if (element != null)
      return DMXDO.ShapeTreeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeTree(DXOD.Drawing openXmlElement, DMDO.ShapeTree? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDO.ShapeTreeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOD.ShapeTree>(), value, diffs, objName, propName);
  }
  
  private static void SetShapeTree(DXOD.Drawing openXmlElement, DMDO.ShapeTree? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOD.ShapeTree>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDO.ShapeTreeConverter.CreateOpenXmlElement<DXOD.ShapeTree>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMDO.Drawing? CreateModelElement(DXOD.Drawing? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDO.Drawing();
      value.ShapeTree = GetShapeTree(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOD.Drawing? openXmlElement, DMDO.Drawing? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpShapeTree(openXmlElement, value.ShapeTree, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDO.Drawing value)
    where OpenXmlElementType: DXOD.Drawing, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOD.Drawing openXmlElement, DMDO.Drawing value)
  {
    SetShapeTree(openXmlElement, value?.ShapeTree);
  }
}
