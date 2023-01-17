namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the LineSketchStyleProperties Class.
/// </summary>
public static class LineSketchStylePropertiesConverter
{
  /// <summary>
  /// sd, this property is only available in Office 2021 and later.
  /// </summary>
  private static UInt32? GetSd(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchStyleProperties openXmlElement)
  {
    return openXmlElement.Sd?.Value;
  }
  
  private static void SetSd(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchStyleProperties openXmlElement, UInt32? value)
  {
    openXmlElement.Sd = value;
  }
  
  private static DocumentModel.Drawings.CustomGeometry? GetCustomGeometry(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchStyleProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.CustomGeometry>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.CustomGeometryConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCustomGeometry(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchStyleProperties openXmlElement, DocumentModel.Drawings.CustomGeometry? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.CustomGeometry>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.CustomGeometryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.CustomGeometry>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.PresetGeometry? GetPresetGeometry(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchStyleProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetGeometry>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.PresetGeometryConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPresetGeometry(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchStyleProperties openXmlElement, DocumentModel.Drawings.PresetGeometry? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetGeometry>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.PresetGeometryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.PresetGeometry>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.LineSketchTypeProperties? GetLineSketchTypeProperties(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchStyleProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchTypeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.LineSketchTypePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLineSketchTypeProperties(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchStyleProperties openXmlElement, DocumentModel.Drawings.LineSketchTypeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchTypeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.LineSketchTypePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchTypeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static String? GetLineSketchSeed(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchStyleProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchSeed>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetLineSketchSeed(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchStyleProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchSeed>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchSeed { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.OfficeArtExtensionList6? GetOfficeArtExtensionList(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchStyleProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.OfficeArtExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.OfficeArtExtensionList6Converter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetOfficeArtExtensionList(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchStyleProperties openXmlElement, DocumentModel.Drawings.OfficeArtExtensionList6? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.OfficeArtExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.OfficeArtExtensionList6Converter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.OfficeArtExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.LineSketchStyleProperties? CreateModelElement(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchStyleProperties? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchStyleProperties, new()
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
