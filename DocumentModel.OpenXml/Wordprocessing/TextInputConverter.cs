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
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TextBoxFormFieldValues, DMW.TextBoxFormFieldKind>(openXmlElement.GetFirstChild<DXW.TextBoxFormFieldType>()?.Val?.Value);
  }
  
  private static bool CmpTextBoxFormFieldType(DXW.TextInput openXmlElement, DMW.TextBoxFormFieldKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.TextBoxFormFieldValues, DMW.TextBoxFormFieldKind>(openXmlElement.GetFirstChild<DXW.TextBoxFormFieldType>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
      return openXmlElement?.GetFirstChild<DXW.DefaultTextBoxFormFieldString>()?.Val?.Value;
  }
  
  private static bool CmpDefaultTextBoxFormFieldString(DXW.TextInput openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXW.DefaultTextBoxFormFieldString>()?.Val?.Value == value;
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
    return openXmlElement?.GetFirstChild<DXW.MaxLength>()?.Val?.Value;
  }
  
  private static bool CmpMaxLength(DXW.TextInput openXmlElement, Int16? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.MaxLength>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXW.MaxLength", itemElement?.Val?.Value, value);
    return false;
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
      return openXmlElement?.GetFirstChild<DXW.Format>()?.Val?.Value;
  }
  
  private static bool CmpFormat(DXW.TextInput openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXW.Format>()?.Val?.Value == value;
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
  
  public static DocumentModel.Wordprocessing.TextInput? CreateModelElement(DXW.TextInput? openXmlElement)
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
  
  public static bool CompareModelElement(DXW.TextInput? openXmlElement, DMW.TextInput? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTextBoxFormFieldType(openXmlElement, value.TextBoxFormFieldType, diffs, objName))
        ok = false;
      if (!CmpDefaultTextBoxFormFieldString(openXmlElement, value.DefaultTextBoxFormFieldString, diffs, objName))
        ok = false;
      if (!CmpMaxLength(openXmlElement, value.MaxLength, diffs, objName))
        ok = false;
      if (!CmpFormat(openXmlElement, value.Format, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
