namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Text Field.
/// </summary>
public static class FieldConverter
{
  /// <summary>
  /// Field ID
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Drawing.Field? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Drawing.Field? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Field Type
  /// </summary>
  public static String? GetType(DocumentFormat.OpenXml.Drawing.Field? openXmlElement)
  {
    return openXmlElement?.Type?.Value;
  }
  
  public static void SetType(DocumentFormat.OpenXml.Drawing.Field? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Type = new StringValue { Value = value };
      else
        openXmlElement.Type = null;
  }
  
  /// <summary>
  /// Text Character Properties.
  /// </summary>
  public static DocumentModel.Drawings.RunProperties? GetRunProperties(DocumentFormat.OpenXml.Drawing.Field? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.RunProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.RunPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRunProperties(DocumentFormat.OpenXml.Drawing.Field? openXmlElement, DocumentModel.Drawings.RunProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.RunProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.RunPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.RunProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Text Paragraph Properties.
  /// </summary>
  public static DocumentModel.Drawings.ParagraphProperties? GetParagraphProperties(DocumentFormat.OpenXml.Drawing.Field? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ParagraphProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetParagraphProperties(DocumentFormat.OpenXml.Drawing.Field? openXmlElement, DocumentModel.Drawings.ParagraphProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ParagraphProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ParagraphPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ParagraphProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Text.
  /// </summary>
  public static String? GetText(DocumentFormat.OpenXml.Drawing.Field? openXmlElement)
  {
    return openXmlElement?.Text?.Text;
  }
  
  public static void SetText(DocumentFormat.OpenXml.Drawing.Field? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.Text = new DocumentFormat.OpenXml.Drawing.Text(value);
      else
        openXmlElement.Text = null;
    }
  }
  
  public static DocumentModel.Drawings.Field? CreateModelElement(DocumentFormat.OpenXml.Drawing.Field? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Field();
      value.Id = GetId(openXmlElement);
      value.Type = GetType(openXmlElement);
      value.RunProperties = GetRunProperties(openXmlElement);
      value.ParagraphProperties = GetParagraphProperties(openXmlElement);
      value.Text = GetText(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Field? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Field, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetType(openXmlElement, value?.Type);
      SetRunProperties(openXmlElement, value?.RunProperties);
      SetParagraphProperties(openXmlElement, value?.ParagraphProperties);
      SetText(openXmlElement, value?.Text);
      return openXmlElement;
    }
    return default;
  }
}
