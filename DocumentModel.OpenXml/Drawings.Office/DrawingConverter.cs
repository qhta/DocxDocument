using DocumentModel.Drawings.Office;
using Drawing = DocumentFormat.OpenXml.Office.Drawing.Drawing;

namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
///   Defines the Drawing Class.
/// </summary>
public static class DrawingConverter
{
  /// <summary>
  ///   ShapeTree.
  /// </summary>
  public static ShapeTree? GetShapeTree(Drawing? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.ShapeTree>();
    if (itemElement != null)
      return ShapeTreeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShapeTree(Drawing? openXmlElement, ShapeTree? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.ShapeTree>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapeTreeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Drawing.ShapeTree>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Office.Drawing? CreateModelElement(Drawing? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Office.Drawing();
      value.ShapeTree = GetShapeTree(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Office.Drawing? value)
    where OpenXmlElementType : Drawing, new()
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