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
    var itemElement = openXmlElement?.GetFirstChild<DXODraw.ShapeTree>();
    if (itemElement != null)
      return DMXDrawsO.ShapeTreeConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMDrawsO.Drawing? CreateModelElement(DXODraw.Drawing? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsO.Drawing();
      value.ShapeTree = GetShapeTree(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsO.Drawing? value)
    where OpenXmlElementType: DXODraw.Drawing, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetShapeTree(openXmlElement, value?.ShapeTree);
      return openXmlElement;
    }
    return default;
  }
}
