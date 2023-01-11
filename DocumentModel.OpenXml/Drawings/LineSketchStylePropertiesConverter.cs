namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the LineSketchStyleProperties Class.
/// </summary>
public static class LineSketchStylePropertiesConverter
{
  /// <summary>
  /// sd, this property is only available in Office 2021 and later.
  /// </summary>
  public static UInt32? GetSd(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchStyleProperties? openXmlElement)
  {
    return openXmlElement?.Sd?.Value;
  }
  
  public static void SetSd(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchStyleProperties? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Sd = value;
  }
  
  public static DocumentModel.Drawings.CustomGeometry? GetCustomGeometry(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchStyleProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.CustomGeometry>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.CustomGeometryConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomGeometry(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchStyleProperties? openXmlElement, DocumentModel.Drawings.CustomGeometry? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.PresetGeometry? GetPresetGeometry(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchStyleProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetGeometry>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.PresetGeometryConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPresetGeometry(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchStyleProperties? openXmlElement, DocumentModel.Drawings.PresetGeometry? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.LineSketchTypeProperties? GetLineSketchTypeProperties(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchStyleProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchTypeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.LineSketchTypePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLineSketchTypeProperties(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchStyleProperties? openXmlElement, DocumentModel.Drawings.LineSketchTypeProperties? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static String? GetLineSketchSeed(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchStyleProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchSeed");
  }
  
  public static void SetLineSketchSeed(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchStyleProperties? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchSeed");
  }
  
  public static DocumentModel.Drawings.OfficeArtExtensionList6? GetOfficeArtExtensionList(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchStyleProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.OfficeArtExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.OfficeArtExtensionList6Converter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetOfficeArtExtensionList(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchStyleProperties? openXmlElement, DocumentModel.Drawings.OfficeArtExtensionList6? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
