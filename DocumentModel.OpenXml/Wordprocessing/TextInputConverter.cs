namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Text Box Form Field Properties.
/// </summary>
public static class TextInputConverter
{
  /// <summary>
  /// Text Box Form Field Type.
  /// </summary>
  private static DMW.TextBoxFormFieldKind? GetTextBoxFormFieldType(DXW.TextInput openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TextBoxFormFieldType>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TextBoxFormFieldValues, DMW.TextBoxFormFieldKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetTextBoxFormFieldType(DXW.TextInput openXmlElement, DMW.TextBoxFormFieldKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TextBoxFormFieldType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.TextBoxFormFieldType, DocumentFormat.OpenXml.Wordprocessing.TextBoxFormFieldValues, DMW.TextBoxFormFieldKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Default Text Box Form Field String.
  /// </summary>
  private static String? GetDefaultTextBoxFormFieldString(DXW.TextInput openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.DefaultTextBoxFormFieldString>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetDefaultTextBoxFormFieldString(DXW.TextInput openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DefaultTextBoxFormFieldString>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.DefaultTextBoxFormFieldString { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Text Box Form Field Maximum Length.
  /// </summary>
  private static Int16? GetMaxLength(DXW.TextInput openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.MaxLength>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetMaxLength(DXW.TextInput openXmlElement, Int16? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MaxLength>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.MaxLength{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Text Box Form Field Formatting.
  /// </summary>
  private static String? GetFormat(DXW.TextInput openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.Format>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetFormat(DXW.TextInput openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Format>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.Format { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.TextInput? CreateModelElement(DXW.TextInput? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TextInput();
      value.TextBoxFormFieldType = GetTextBoxFormFieldType(openXmlElement);
      value.DefaultTextBoxFormFieldString = GetDefaultTextBoxFormFieldString(openXmlElement);
      value.MaxLength = GetMaxLength(openXmlElement);
      value.Format = GetFormat(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.TextInput? value)
    where OpenXmlElementType: DXW.TextInput, new()
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
