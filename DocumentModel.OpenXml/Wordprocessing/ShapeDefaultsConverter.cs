using DocumentModel.OpenXml.Vml;
using DocumentModel.Vml;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Default Properties for VML Objects in Main Document.
/// </summary>
public static class ShapeDefaultsConverter
{
  public static ShapeDefaults? GetChildShapeDefaults(DocumentFormat.OpenXml.Wordprocessing.ShapeDefaults? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ShapeDefaults>();
    if (itemElement != null)
      return OpenXml.Vml.ShapeDefaultsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetChildShapeDefaults(DocumentFormat.OpenXml.Wordprocessing.ShapeDefaults? openXmlElement, ShapeDefaults? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ShapeDefaults>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OpenXml.Vml.ShapeDefaultsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.ShapeDefaults>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ShapeLayout? GetShapeLayout(DocumentFormat.OpenXml.Wordprocessing.ShapeDefaults? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ShapeLayout>();
    if (itemElement != null)
      return ShapeLayoutConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShapeLayout(DocumentFormat.OpenXml.Wordprocessing.ShapeDefaults? openXmlElement, ShapeLayout? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ShapeLayout>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapeLayoutConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.ShapeLayout>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.ShapeDefaults? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.ShapeDefaults? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.ShapeDefaults();
      value.ChildShapeDefaults = GetChildShapeDefaults(openXmlElement);
      value.ShapeLayout = GetShapeLayout(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.ShapeDefaults? value)
    where OpenXmlElementType : DocumentFormat.OpenXml.Wordprocessing.ShapeDefaults, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetChildShapeDefaults(openXmlElement, value?.ChildShapeDefaults);
      SetShapeLayout(openXmlElement, value?.ShapeLayout);
      return openXmlElement;
    }
    return default;
  }
}