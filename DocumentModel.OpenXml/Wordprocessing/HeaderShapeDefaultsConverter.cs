using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.OpenXml.Vml;
using DocumentModel.Vml;
using ShapeDefaults = DocumentModel.Vml.ShapeDefaults;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Default Properties for VML Objects in Header and Footer.
/// </summary>
public static class HeaderShapeDefaultsConverter
{
  public static ShapeDefaults? GetShapeDefaults(HeaderShapeDefaults? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ShapeDefaults>();
    if (itemElement != null)
      return OpenXml.Vml.ShapeDefaultsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShapeDefaults(HeaderShapeDefaults? openXmlElement, ShapeDefaults? value)
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

  public static ShapeLayout? GetShapeLayout(HeaderShapeDefaults? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ShapeLayout>();
    if (itemElement != null)
      return ShapeLayoutConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShapeLayout(HeaderShapeDefaults? openXmlElement, ShapeLayout? value)
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

  public static DocumentModel.Wordprocessing.HeaderShapeDefaults? CreateModelElement(HeaderShapeDefaults? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.HeaderShapeDefaults();
      value.ShapeDefaults = GetShapeDefaults(openXmlElement);
      value.ShapeLayout = GetShapeLayout(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.HeaderShapeDefaults? value)
    where OpenXmlElementType : HeaderShapeDefaults, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetShapeDefaults(openXmlElement, value?.ShapeDefaults);
      SetShapeLayout(openXmlElement, value?.ShapeLayout);
      return openXmlElement;
    }
    return default;
  }
}