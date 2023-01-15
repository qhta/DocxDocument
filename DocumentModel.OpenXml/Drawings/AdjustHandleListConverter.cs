using DocumentModel.Drawings;
using AdjustHandleList = DocumentFormat.OpenXml.Drawing.AdjustHandleList;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   List of Shape Adjust Handles.
/// </summary>
public static class AdjustHandleListConverter
{
  public static AdjustHandleXY? GetAdjustHandleXY(AdjustHandleList? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AdjustHandleXY>();
    if (itemElement != null)
      return AdjustHandleXYConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAdjustHandleXY(AdjustHandleList? openXmlElement, AdjustHandleXY? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AdjustHandleXY>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AdjustHandleXYConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.AdjustHandleXY>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static AdjustHandlePolar? GetAdjustHandlePolar(AdjustHandleList? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AdjustHandlePolar>();
    if (itemElement != null)
      return AdjustHandlePolarConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAdjustHandlePolar(AdjustHandleList? openXmlElement, AdjustHandlePolar? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AdjustHandlePolar>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AdjustHandlePolarConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.AdjustHandlePolar>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.AdjustHandleList? CreateModelElement(AdjustHandleList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.AdjustHandleList();
      value.AdjustHandleXY = GetAdjustHandleXY(openXmlElement);
      value.AdjustHandlePolar = GetAdjustHandlePolar(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.AdjustHandleList? value)
    where OpenXmlElementType : AdjustHandleList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAdjustHandleXY(openXmlElement, value?.AdjustHandleXY);
      SetAdjustHandlePolar(openXmlElement, value?.AdjustHandlePolar);
      return openXmlElement;
    }
    return default;
  }
}