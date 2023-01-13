namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Defines the TextBox Class.
/// </summary>
public static class TextBoxConverter
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Vml.TextBox? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Vml.TextBox? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Shape Styling Properties
  /// </summary>
  public static String? GetStyle(DocumentFormat.OpenXml.Vml.TextBox? openXmlElement)
  {
    return openXmlElement?.Style?.Value;
  }
  
  public static void SetStyle(DocumentFormat.OpenXml.Vml.TextBox? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Style = new StringValue { Value = value };
      else
        openXmlElement.Style = null;
  }
  
  /// <summary>
  /// Text Box Inset
  /// </summary>
  public static String? GetInset(DocumentFormat.OpenXml.Vml.TextBox? openXmlElement)
  {
    return openXmlElement?.Inset?.Value;
  }
  
  public static void SetInset(DocumentFormat.OpenXml.Vml.TextBox? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Inset = new StringValue { Value = value };
      else
        openXmlElement.Inset = null;
  }
  
  /// <summary>
  /// Text Box Single-Click Selection Toggle
  /// </summary>
  public static Boolean? GetSingleClick(DocumentFormat.OpenXml.Vml.TextBox? openXmlElement)
  {
    return openXmlElement?.SingleClick?.Value;
  }
  
  public static void SetSingleClick(DocumentFormat.OpenXml.Vml.TextBox? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.SingleClick = value;
      else
        openXmlElement.SingleClick = null;
  }
  
  public static DocumentModel.Wordprocessing.TextBoxContent? GetTextBoxContent(DocumentFormat.OpenXml.Vml.TextBox? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TextBoxContent>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TextBoxContentConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTextBoxContent(DocumentFormat.OpenXml.Vml.TextBox? openXmlElement, DocumentModel.Wordprocessing.TextBoxContent? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TextBoxContent>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.TextBoxContentConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TextBoxContent>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Vml.TextBox? CreateModelElement(DocumentFormat.OpenXml.Vml.TextBox? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.TextBox();
      value.Id = GetId(openXmlElement);
      value.Style = GetStyle(openXmlElement);
      value.Inset = GetInset(openXmlElement);
      value.SingleClick = GetSingleClick(openXmlElement);
      value.TextBoxContent = GetTextBoxContent(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.TextBox? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Vml.TextBox, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetStyle(openXmlElement, value?.Style);
      SetInset(openXmlElement, value?.Inset);
      SetSingleClick(openXmlElement, value?.SingleClick);
      SetTextBoxContent(openXmlElement, value?.TextBoxContent);
      return openXmlElement;
    }
    return default;
  }
}
