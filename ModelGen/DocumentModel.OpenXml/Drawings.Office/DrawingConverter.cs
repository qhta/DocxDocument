namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
/// Defines the Drawing Class.
/// </summary>
public static class DrawingConverter
{
  /// <summary>
  /// ShapeTree.
  /// </summary>
  private static DMDrawsO.ShapeTree? GetShapeTree(DXODraw.Drawing openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXODraw.ShapeTree>();
    if (element != null)
      return DMXDrawsO.ShapeTreeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeTree(DXODraw.Drawing openXmlElement, DMDrawsO.ShapeTree? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsO.ShapeTreeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXODraw.ShapeTree>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShapeTree(DXODraw.Drawing openXmlElement, DMDrawsO.ShapeTree? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXODraw.ShapeTree>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsO.ShapeTreeConverter.CreateOpenXmlElement<DXODraw.ShapeTree>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Office.Drawing? CreateModelElement(DXODraw.Drawing? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Office.Drawing();
      value.ShapeTree = GetShapeTree(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXODraw.Drawing? openXmlElement, DMDrawsO.Drawing? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpShapeTree(openXmlElement, value.ShapeTree, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsO.Drawing value)
    where OpenXmlElementType: DXODraw.Drawing, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXODraw.Drawing openXmlElement, DMDrawsO.Drawing value)
  {
    SetShapeTree(openXmlElement, value?.ShapeTree);
  }
}
