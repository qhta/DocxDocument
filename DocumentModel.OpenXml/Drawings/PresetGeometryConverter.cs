namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Preset geometry.
/// </summary>
public static class PresetGeometryConverter
{
  /// <summary>
  /// Preset Shape
  /// </summary>
  private static DocumentModel.Drawings.ShapeKind? GetPreset(DocumentFormat.OpenXml.Drawing.PresetGeometry openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ShapeTypeValues, DocumentModel.Drawings.ShapeKind>(openXmlElement?.Preset?.Value);
  }
  
  private static void SetPreset(DocumentFormat.OpenXml.Drawing.PresetGeometry openXmlElement, DocumentModel.Drawings.ShapeKind? value)
  {
    openXmlElement.Preset = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ShapeTypeValues, DocumentModel.Drawings.ShapeKind>(value);
  }
  
  /// <summary>
  /// List of Shape Adjust Values.
  /// </summary>
  private static DocumentModel.Drawings.AdjustValueList? GetAdjustValueList(DocumentFormat.OpenXml.Drawing.PresetGeometry openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AdjustValueList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.AdjustValueListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAdjustValueList(DocumentFormat.OpenXml.Drawing.PresetGeometry openXmlElement, DocumentModel.Drawings.AdjustValueList? value)
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
  
  public static DocumentModel.Drawings.PresetGeometry? CreateModelElement(DocumentFormat.OpenXml.Drawing.PresetGeometry? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.PresetGeometry();
      value.Preset = GetPreset(openXmlElement);
      value.AdjustValueList = GetAdjustValueList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.PresetGeometry? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.PresetGeometry, new()
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
