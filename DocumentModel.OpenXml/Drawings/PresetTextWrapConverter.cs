namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Preset Text Warp.
/// </summary>
public static class PresetTextWrapConverter
{
  /// <summary>
  /// Preset Warp Shape
  /// </summary>
  public static DocumentModel.Drawings.TextShapeKind? GetPreset(DocumentFormat.OpenXml.Drawing.PresetTextWrap? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextShapeValues, DocumentModel.Drawings.TextShapeKind>(openXmlElement?.Preset?.Value);
  }
  
  public static void SetPreset(DocumentFormat.OpenXml.Drawing.PresetTextWrap? openXmlElement, DocumentModel.Drawings.TextShapeKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Preset = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextShapeValues, DocumentModel.Drawings.TextShapeKind>(value);
  }
  
  /// <summary>
  /// Adjust Value List.
  /// </summary>
  public static DocumentModel.Drawings.AdjustValueList? GetAdjustValueList(DocumentFormat.OpenXml.Drawing.PresetTextWrap? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AdjustValueList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.AdjustValueListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetAdjustValueList(DocumentFormat.OpenXml.Drawing.PresetTextWrap? openXmlElement, DocumentModel.Drawings.AdjustValueList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AdjustValueList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.AdjustValueListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.AdjustValueList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.PresetTextWrap? CreateModelElement(DocumentFormat.OpenXml.Drawing.PresetTextWrap? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.PresetTextWrap();
      value.Preset = GetPreset(openXmlElement);
      value.AdjustValueList = GetAdjustValueList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.PresetTextWrap? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.PresetTextWrap, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPreset(openXmlElement, value?.Preset);
      SetAdjustValueList(openXmlElement, value?.AdjustValueList);
      return openXmlElement;
    }
    return default;
  }
}
