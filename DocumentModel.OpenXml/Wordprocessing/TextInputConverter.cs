namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Text Box Form Field Properties.
/// </summary>
public static class TextInputConverter
{
  /// <summary>
  /// Text Box Form Field Type.
  /// </summary>
  private static DocumentModel.Wordprocessing.TextBoxFormFieldKind? GetTextBoxFormFieldType(DocumentFormat.OpenXml.Wordprocessing.TextInput openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TextBoxFormFieldType>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TextBoxFormFieldValues, DocumentModel.Wordprocessing.TextBoxFormFieldKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetTextBoxFormFieldType(DocumentFormat.OpenXml.Wordprocessing.TextInput openXmlElement, DocumentModel.Wordprocessing.TextBoxFormFieldKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TextBoxFormFieldType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TextBoxFormFieldType, DocumentFormat.OpenXml.Wordprocessing.TextBoxFormFieldValues, DocumentModel.Wordprocessing.TextBoxFormFieldKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Default Text Box Form Field String.
  /// </summary>
  private static String? GetDefaultTextBoxFormFieldString(DocumentFormat.OpenXml.Wordprocessing.TextInput openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DefaultTextBoxFormFieldString>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetDefaultTextBoxFormFieldString(DocumentFormat.OpenXml.Wordprocessing.TextInput openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DefaultTextBoxFormFieldString>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.DefaultTextBoxFormFieldString { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Text Box Form Field Maximum Length.
  /// </summary>
  private static Int16? GetMaxLength(DocumentFormat.OpenXml.Wordprocessing.TextInput openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MaxLength>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetMaxLength(DocumentFormat.OpenXml.Wordprocessing.TextInput openXmlElement, Int16? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MaxLength>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.MaxLength{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Text Box Form Field Formatting.
  /// </summary>
  private static String? GetFormat(DocumentFormat.OpenXml.Wordprocessing.TextInput openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Format>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetFormat(DocumentFormat.OpenXml.Wordprocessing.TextInput openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Format>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.Format { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.TextInput? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.TextInput? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TextInput();
      value.TextBoxFormFieldType = GetTextBoxFormFieldType(openXmlElement);
      value.DefaultTextBoxFormFieldString = GetDefaultTextBoxFormFieldString(openXmlElement);
      value.MaxLength = GetMaxLength(openXmlElement);
      value.Format = GetFormat(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.TextInput? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.TextInput, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTextBoxFormFieldType(openXmlElement, value?.TextBoxFormFieldType);
      SetDefaultTextBoxFormFieldString(openXmlElement, value?.DefaultTextBoxFormFieldString);
      SetMaxLength(openXmlElement, value?.MaxLength);
      SetFormat(openXmlElement, value?.Format);
      return openXmlElement;
    }
    return default;
  }
}
