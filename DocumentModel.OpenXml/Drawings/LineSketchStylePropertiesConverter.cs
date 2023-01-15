using DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes;
using DocumentModel.Drawings;
using LineSketchStyleProperties = DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchStyleProperties;
using LineSketchTypeProperties = DocumentModel.Drawings.LineSketchTypeProperties;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the LineSketchStyleProperties Class.
/// </summary>
public static class LineSketchStylePropertiesConverter
{
  /// <summary>
  ///   sd, this property is only available in Office 2021 and later.
  /// </summary>
  public static UInt32? GetSd(LineSketchStyleProperties? openXmlElement)
  {
    return openXmlElement?.Sd?.Value;
  }

  public static void SetSd(LineSketchStyleProperties? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Sd = value;
  }

  public static CustomGeometry? GetCustomGeometry(LineSketchStyleProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.CustomGeometry>();
    if (itemElement != null)
      return CustomGeometryConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomGeometry(LineSketchStyleProperties? openXmlElement, CustomGeometry? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.CustomGeometry>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CustomGeometryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.CustomGeometry>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static PresetGeometry? GetPresetGeometry(LineSketchStyleProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetGeometry>();
    if (itemElement != null)
      return PresetGeometryConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPresetGeometry(LineSketchStyleProperties? openXmlElement, PresetGeometry? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetGeometry>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PresetGeometryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.PresetGeometry>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static LineSketchTypeProperties? GetLineSketchTypeProperties(LineSketchStyleProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchTypeProperties>();
    if (itemElement != null)
      return LineSketchTypePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLineSketchTypeProperties(LineSketchStyleProperties? openXmlElement, LineSketchTypeProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchTypeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LineSketchTypePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchTypeProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static String? GetLineSketchSeed(LineSketchStyleProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<LineSketchSeed>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetLineSketchSeed(LineSketchStyleProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LineSketchSeed>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new LineSketchSeed { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static OfficeArtExtensionList6? GetOfficeArtExtensionList(LineSketchStyleProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.OfficeArtExtensionList>();
    if (itemElement != null)
      return OfficeArtExtensionList6Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetOfficeArtExtensionList(LineSketchStyleProperties? openXmlElement, OfficeArtExtensionList6? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.OfficeArtExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OfficeArtExtensionList6Converter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.OfficeArtExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.LineSketchStyleProperties? CreateModelElement(LineSketchStyleProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.LineSketchStyleProperties();
      value.Sd = GetSd(openXmlElement);
      value.CustomGeometry = GetCustomGeometry(openXmlElement);
      value.PresetGeometry = GetPresetGeometry(openXmlElement);
      value.LineSketchTypeProperties = GetLineSketchTypeProperties(openXmlElement);
      value.LineSketchSeed = GetLineSketchSeed(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.LineSketchStyleProperties? value)
    where OpenXmlElementType : LineSketchStyleProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSd(openXmlElement, value?.Sd);
      SetCustomGeometry(openXmlElement, value?.CustomGeometry);
      SetPresetGeometry(openXmlElement, value?.PresetGeometry);
      SetLineSketchTypeProperties(openXmlElement, value?.LineSketchTypeProperties);
      SetLineSketchSeed(openXmlElement, value?.LineSketchSeed);
      SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
      return openXmlElement;
    }
    return default;
  }
}