namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Path Gradient.
/// </summary>
public static class PathGradientFillConverter
{
  /// <summary>
  /// Gradient Fill Path
  /// </summary>
  public static DocumentModel.Drawings.PathShadeKind? GetPath(DocumentFormat.OpenXml.Drawing.PathGradientFill? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PathShadeValues, DocumentModel.Drawings.PathShadeKind>(openXmlElement?.Path?.Value);
  }
  
  public static void SetPath(DocumentFormat.OpenXml.Drawing.PathGradientFill? openXmlElement, DocumentModel.Drawings.PathShadeKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Path = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.PathShadeValues, DocumentModel.Drawings.PathShadeKind>(value);
  }
  
  /// <summary>
  /// Fill To Rectangle.
  /// </summary>
  public static DocumentModel.Drawings.RelativeRectangleType? GetFillToRectangle(DocumentFormat.OpenXml.Drawing.PathGradientFill? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.FillToRectangle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.RelativeRectangleTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFillToRectangle(DocumentFormat.OpenXml.Drawing.PathGradientFill? openXmlElement, DocumentModel.Drawings.RelativeRectangleType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.FillToRectangle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.RelativeRectangleTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.FillToRectangle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.PathGradientFill? CreateModelElement(DocumentFormat.OpenXml.Drawing.PathGradientFill? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.PathGradientFill();
      value.Path = GetPath(openXmlElement);
      value.FillToRectangle = GetFillToRectangle(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.PathGradientFill? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.PathGradientFill, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
