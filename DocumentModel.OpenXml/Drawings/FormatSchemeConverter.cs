namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Format Scheme.
/// </summary>
public static class FormatSchemeConverter
{
  /// <summary>
  /// Name
  /// </summary>
  private static String? GetName(DocumentFormat.OpenXml.Drawing.FormatScheme openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static void SetName(DocumentFormat.OpenXml.Drawing.FormatScheme openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  /// <summary>
  /// Fill Style List.
  /// </summary>
  private static DocumentModel.Drawings.FillStyleList? GetFillStyleList(DocumentFormat.OpenXml.Drawing.FormatScheme openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.FillStyleList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.FillStyleListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFillStyleList(DocumentFormat.OpenXml.Drawing.FormatScheme openXmlElement, DocumentModel.Drawings.FillStyleList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.FillStyleList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.FillStyleListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.FillStyleList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Line Style List.
  /// </summary>
  private static DocumentModel.Drawings.LineStyleList? GetLineStyleList(DocumentFormat.OpenXml.Drawing.FormatScheme openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.LineStyleList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.LineStyleListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLineStyleList(DocumentFormat.OpenXml.Drawing.FormatScheme openXmlElement, DocumentModel.Drawings.LineStyleList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.LineStyleList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.LineStyleListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.LineStyleList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Effect Style List.
  /// </summary>
  private static DocumentModel.Drawings.EffectStyleList? GetEffectStyleList(DocumentFormat.OpenXml.Drawing.FormatScheme openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectStyleList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.EffectStyleListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEffectStyleList(DocumentFormat.OpenXml.Drawing.FormatScheme openXmlElement, DocumentModel.Drawings.EffectStyleList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectStyleList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.EffectStyleListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.EffectStyleList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Background Fill Style List.
  /// </summary>
  private static DocumentModel.Drawings.BackgroundFillStyleList? GetBackgroundFillStyleList(DocumentFormat.OpenXml.Drawing.FormatScheme openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.BackgroundFillStyleList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.BackgroundFillStyleListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBackgroundFillStyleList(DocumentFormat.OpenXml.Drawing.FormatScheme openXmlElement, DocumentModel.Drawings.BackgroundFillStyleList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BackgroundFillStyleList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.BackgroundFillStyleListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.BackgroundFillStyleList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.FormatScheme? CreateModelElement(DocumentFormat.OpenXml.Drawing.FormatScheme? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.FormatScheme();
      value.Name = GetName(openXmlElement);
      value.FillStyleList = GetFillStyleList(openXmlElement);
      value.LineStyleList = GetLineStyleList(openXmlElement);
      value.EffectStyleList = GetEffectStyleList(openXmlElement);
      value.BackgroundFillStyleList = GetBackgroundFillStyleList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.FormatScheme? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.FormatScheme, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetFillStyleList(openXmlElement, value?.FillStyleList);
      SetLineStyleList(openXmlElement, value?.LineStyleList);
      SetEffectStyleList(openXmlElement, value?.EffectStyleList);
      SetBackgroundFillStyleList(openXmlElement, value?.BackgroundFillStyleList);
      return openXmlElement;
    }
    return default;
  }
}
