using DocumentFormat.OpenXml.Office.Drawing;
using DocumentModel.Drawings;

namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
///   Defines the NonVisualGroupDrawingShapeProperties Class.
/// </summary>
public static class NonVisualGroupDrawingShapePropertiesConverter
{
  /// <summary>
  ///   GroupShapeLocks.
  /// </summary>
  public static GroupShapeLocks? GetGroupShapeLocks(NonVisualGroupDrawingShapeProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.GroupShapeLocks>();
    if (itemElement != null)
      return GroupShapeLocksConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGroupShapeLocks(NonVisualGroupDrawingShapeProperties? openXmlElement, GroupShapeLocks? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.GroupShapeLocks>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GroupShapeLocksConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.GroupShapeLocks>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   NonVisualGroupDrawingShapePropsExtensionList.
  /// </summary>
  public static NonVisualGroupDrawingShapePropsExtensionList? GetNonVisualGroupDrawingShapePropsExtensionList(NonVisualGroupDrawingShapeProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList>();
    if (itemElement != null)
      return NonVisualGroupDrawingShapePropsExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNonVisualGroupDrawingShapePropsExtensionList(NonVisualGroupDrawingShapeProperties? openXmlElement, NonVisualGroupDrawingShapePropsExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NonVisualGroupDrawingShapePropsExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Office.NonVisualGroupDrawingShapeProperties? CreateModelElement(NonVisualGroupDrawingShapeProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Office.NonVisualGroupDrawingShapeProperties();
      value.GroupShapeLocks = GetGroupShapeLocks(openXmlElement);
      value.NonVisualGroupDrawingShapePropsExtensionList = GetNonVisualGroupDrawingShapePropsExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Office.NonVisualGroupDrawingShapeProperties? value)
    where OpenXmlElementType : NonVisualGroupDrawingShapeProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGroupShapeLocks(openXmlElement, value?.GroupShapeLocks);
      SetNonVisualGroupDrawingShapePropsExtensionList(openXmlElement, value?.NonVisualGroupDrawingShapePropsExtensionList);
      return openXmlElement;
    }
    return default;
  }
}