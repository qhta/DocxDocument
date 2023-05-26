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
    return EnumValueConverter.GetValue<DXW.TextBoxFormFieldValues, DMW.TextBoxFormFieldKind>(openXmlElement.GetFirstChild<DXW.TextBoxFormFieldType>()?.Val?.Value);
  }
  
  private static bool CmpTextBoxFormFieldType(DXW.TextInput openXmlElement, DMW.TextBoxFormFieldKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.TextBoxFormFieldValues, DMW.TextBoxFormFieldKind>(openXmlElement.GetFirstChild<DXW.TextBoxFormFieldType>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetTextBoxFormFieldType(DXW.TextInput openXmlElement, DMW.TextBoxFormFieldKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TextBoxFormFieldType>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DXW.TextBoxFormFieldValues, DMW.TextBoxFormFieldKind>(itemElement, (DMW.TextBoxFormFieldKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXW.TextBoxFormFieldType, DXW.TextBoxFormFieldValues, DMW.TextBoxFormFieldKind>((DMW.TextBoxFormFieldKind)value));
  }
  
  /// <summary>
  /// Default Text Box Form Field String.
  /// </summary>
  private static String? GetDefaultTextBoxFormFieldString(DXW.TextInput openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.DefaultTextBoxFormFieldString>()?.Val);
  }
  
  private static bool CmpDefaultTextBoxFormFieldString(DXW.TextInput openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.DefaultTextBoxFormFieldString>()?.Val, value, diffs, objName, "DefaultTextBoxFormFieldString");
  }
  
  private static void SetDefaultTextBoxFormFieldString(DXW.TextInput openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.DefaultTextBoxFormFieldString>(openXmlElement, value);
  }
  
  /// <summary>
  /// Text Box Form Field Maximum Length.
  /// </summary>
  private static Int16? GetMaxLength(DXW.TextInput openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.MaxLength>()?.Val);
  }
  
  private static bool CmpMaxLength(DXW.TextInput openXmlElement, Int16? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.MaxLength>()?.Val, value, diffs, objName, "MaxLength");
  }
  
  private static void SetMaxLength(DXW.TextInput openXmlElement, Int16? value)
  {
    SimpleValueConverter.SetValue<DXW.MaxLength,System.Int16>(openXmlElement, value);
  }
  
  /// <summary>
  /// Text Box Form Field Formatting.
  /// </summary>
  private static String? GetFormat(DXW.TextInput openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.Format>()?.Val);
  }
  
  private static bool CmpFormat(DXW.TextInput openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.Format>()?.Val, value, diffs, objName, "Custom");
  }
  
  private static void SetFormat(DXW.TextInput openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.Format>(openXmlElement, value);
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
  
  public static bool CompareModelElement(DXW.TextInput? openXmlElement, DMW.TextInput? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTextBoxFormFieldType(openXmlElement, value.TextBoxFormFieldType, diffs, objName, propName))
        ok = false;
      if (!CmpDefaultTextBoxFormFieldString(openXmlElement, value.DefaultTextBoxFormFieldString, diffs, objName, propName))
        ok = false;
      if (!CmpMaxLength(openXmlElement, value.MaxLength, diffs, objName, propName))
        ok = false;
      if (!CmpFormat(openXmlElement, value.Format, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TextInput value)
    where OpenXmlElementType: DXW.TextInput, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TextInput openXmlElement, DMW.TextInput value)
  {
    SetTextBoxFormFieldType(openXmlElement, value?.TextBoxFormFieldType);
    SetDefaultTextBoxFormFieldString(openXmlElement, value?.DefaultTextBoxFormFieldString);
    SetMaxLength(openXmlElement, value?.MaxLength);
    SetFormat(openXmlElement, value?.Format);
  }
}
