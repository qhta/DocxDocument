namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Checkbox Form Field Properties.
/// </summary>
public static class CheckBoxConverter
{
  private static String? GetFormFieldSize(DXW.CheckBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.FormFieldSize>()?.Val);
  }
  
  private static bool CmpFormFieldSize(DXW.CheckBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.FormFieldSize>()?.Val, value, diffs, objName, "FormFieldSize");
  }
  
  private static void SetFormFieldSize(DXW.CheckBox openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.FormFieldSize>(openXmlElement, value);
  }
  
  private static Boolean? GetAutomaticallySizeFormField(DXW.CheckBox openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.AutomaticallySizeFormField>());
  }
  
  private static bool CmpAutomaticallySizeFormField(DXW.CheckBox openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.AutomaticallySizeFormField>(), value, diffs, objName);
  }
  
  private static void SetAutomaticallySizeFormField(DXW.CheckBox openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.AutomaticallySizeFormField>(openXmlElement, value);
  }
  
  private static Boolean? GetDefaultCheckBoxFormFieldState(DXW.CheckBox openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.DefaultCheckBoxFormFieldState>());
  }
  
  private static bool CmpDefaultCheckBoxFormFieldState(DXW.CheckBox openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.DefaultCheckBoxFormFieldState>(), value, diffs, objName);
  }
  
  private static void SetDefaultCheckBoxFormFieldState(DXW.CheckBox openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.DefaultCheckBoxFormFieldState>(openXmlElement, value);
  }
  
  private static Boolean? GetChecked(DXW.CheckBox openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.Checked>());
  }
  
  private static bool CmpChecked(DXW.CheckBox openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.Checked>(), value, diffs, objName);
  }
  
  private static void SetChecked(DXW.CheckBox openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.Checked>(openXmlElement, value);
  }
  
  public static DocumentModel.Wordprocessing.CheckBox? CreateModelElement(DXW.CheckBox? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.CheckBox();
      value.FormFieldSize = GetFormFieldSize(openXmlElement);
      value.AutomaticallySizeFormField = GetAutomaticallySizeFormField(openXmlElement);
      value.DefaultCheckBoxFormFieldState = GetDefaultCheckBoxFormFieldState(openXmlElement);
      value.Checked = GetChecked(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.CheckBox? openXmlElement, DMW.CheckBox? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpFormFieldSize(openXmlElement, value.FormFieldSize, diffs, objName))
        ok = false;
      if (!CmpAutomaticallySizeFormField(openXmlElement, value.AutomaticallySizeFormField, diffs, objName))
        ok = false;
      if (!CmpDefaultCheckBoxFormFieldState(openXmlElement, value.DefaultCheckBoxFormFieldState, diffs, objName))
        ok = false;
      if (!CmpChecked(openXmlElement, value.Checked, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.CheckBox value)
    where OpenXmlElementType: DXW.CheckBox, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.CheckBox openXmlElement, DMW.CheckBox value)
  {
    SetFormFieldSize(openXmlElement, value?.FormFieldSize);
    SetAutomaticallySizeFormField(openXmlElement, value?.AutomaticallySizeFormField);
    SetDefaultCheckBoxFormFieldState(openXmlElement, value?.DefaultCheckBoxFormFieldState);
    SetChecked(openXmlElement, value?.Checked);
    }
  }
