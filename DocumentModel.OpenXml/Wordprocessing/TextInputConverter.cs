namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Text Box Form Field Properties.
/// </summary>
public static class TextInputConverter
{
  /// <summary>
  /// Text Box Form Field Type.
  /// </summary>
  public static DocumentModel.Wordprocessing.TextBoxFormFieldKind? GetTextBoxFormFieldType(DocumentFormat.OpenXml.Wordprocessing.TextInput? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TextBoxFormFieldType>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TextBoxFormFieldValues, DocumentModel.Wordprocessing.TextBoxFormFieldKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetTextBoxFormFieldType(DocumentFormat.OpenXml.Wordprocessing.TextInput? openXmlElement, DocumentModel.Wordprocessing.TextBoxFormFieldKind? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Default Text Box Form Field String.
  /// </summary>
  public static String? GetDefaultTextBoxFormFieldString(DocumentFormat.OpenXml.Wordprocessing.TextInput? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.DefaultTextBoxFormFieldString");
  }
  
  public static void SetDefaultTextBoxFormFieldString(DocumentFormat.OpenXml.Wordprocessing.TextInput? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.DefaultTextBoxFormFieldString");
  }
  
  /// <summary>
  /// Text Box Form Field Maximum Length.
  /// </summary>
  public static Int16? GetMaxLength(DocumentFormat.OpenXml.Wordprocessing.TextInput? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.MaxLength");
  }
  
  public static void SetMaxLength(DocumentFormat.OpenXml.Wordprocessing.TextInput? openXmlElement, Int16? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.MaxLength");
  }
  
  /// <summary>
  /// Text Box Form Field Formatting.
  /// </summary>
  public static String? GetFormat(DocumentFormat.OpenXml.Wordprocessing.TextInput? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.Format");
  }
  
  public static void SetFormat(DocumentFormat.OpenXml.Wordprocessing.TextInput? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Wordprocessing.Format");
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
