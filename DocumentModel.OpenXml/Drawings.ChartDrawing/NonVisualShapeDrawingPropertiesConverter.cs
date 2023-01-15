using DocumentFormat.OpenXml.Drawing.ChartDrawing;
using DocumentModel.Drawings;

namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
///   Non-Visual Shape Drawing Properties.
/// </summary>
public static class NonVisualShapeDrawingPropertiesConverter
{
  /// <summary>
  ///   Text Box
  /// </summary>
  public static Boolean? GetTextBox(NonVisualShapeDrawingProperties? openXmlElement)
  {
    return openXmlElement?.TextBox?.Value;
  }

  public static void SetTextBox(NonVisualShapeDrawingProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.TextBox = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.TextBox = null;
  }

  /// <summary>
  ///   Shape Locks.
  /// </summary>
  public static ShapeLocks? GetShapeLocks(NonVisualShapeDrawingProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ShapeLocks>();
    if (itemElement != null)
      return ShapeLocksConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShapeLocks(NonVisualShapeDrawingProperties? openXmlElement, ShapeLocks? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ShapeLocks>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapeLocksConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ShapeLocks>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.ExtensionList? GetExtensionList(NonVisualShapeDrawingProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(NonVisualShapeDrawingProperties? openXmlElement, DocumentModel.Drawings.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartDrawing.NonVisualShapeDrawingProperties? CreateModelElement(NonVisualShapeDrawingProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.NonVisualShapeDrawingProperties();
      value.TextBox = GetTextBox(openXmlElement);
      value.ShapeLocks = GetShapeLocks(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawing.NonVisualShapeDrawingProperties? value)
    where OpenXmlElementType : NonVisualShapeDrawingProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTextBox(openXmlElement, value?.TextBox);
      SetShapeLocks(openXmlElement, value?.ShapeLocks);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}