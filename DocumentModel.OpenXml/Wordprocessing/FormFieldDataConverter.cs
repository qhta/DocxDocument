namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Form Field Properties converter from/to OpenXml.
///</summary>
public static class FormFieldDataConverter
{
  private static String? GetFormFieldName(DXW.FormFieldData openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.FormFieldName>()?.Val);
  }
  
  private static bool CmpFormFieldName(DXW.FormFieldData openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.FormFieldName>()?.Val, value, diffs, objName, "FormFieldName");
  }
  
  private static void SetFormFieldName(DXW.FormFieldData openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.FormFieldName>(openXmlElement, value);
  }
  
  private static Boolean? GetEnabled(DXW.FormFieldData openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.Enabled>());
  }
  
  private static bool CmpEnabled(DXW.FormFieldData openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.Enabled>(), value, diffs, objName);
  }
  
  private static void SetEnabled(DXW.FormFieldData openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.Enabled>(openXmlElement, value);
  }
  
  private static Boolean? GetCalculateOnExit(DXW.FormFieldData openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.CalculateOnExit>());
  }
  
  private static bool CmpCalculateOnExit(DXW.FormFieldData openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.CalculateOnExit>(), value, diffs, objName);
  }
  
  private static void SetCalculateOnExit(DXW.FormFieldData openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.CalculateOnExit>(openXmlElement, value);
  }
  
  private static String? GetEntryMacro(DXW.FormFieldData openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.EntryMacro>()?.Val);
  }
  
  private static bool CmpEntryMacro(DXW.FormFieldData openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.EntryMacro>()?.Val, value, diffs, objName, "EntryMacro");
  }
  
  private static void SetEntryMacro(DXW.FormFieldData openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.EntryMacro>(openXmlElement, value);
  }
  
  private static String? GetExitMacro(DXW.FormFieldData openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.ExitMacro>()?.Val);
  }
  
  private static bool CmpExitMacro(DXW.FormFieldData openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.ExitMacro>()?.Val, value, diffs, objName, "ExitMacro");
  }
  
  private static void SetExitMacro(DXW.FormFieldData openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.ExitMacro>(openXmlElement, value);
  }
  
  private static DMW.HelpText? GetHelpText(DXW.FormFieldData openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.HelpText>();
    if (element != null)
      return DMXW.HelpTextConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHelpText(DXW.FormFieldData openXmlElement, DMW.HelpText? value, DiffList? diffs, string? objName)
  {
    return DMXW.HelpTextConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.HelpText>(), value, diffs, objName);
  }
  
  private static void SetHelpText(DXW.FormFieldData openXmlElement, DMW.HelpText? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.HelpText>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.HelpTextConverter.CreateOpenXmlElement<DXW.HelpText>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.StatusText? GetStatusText(DXW.FormFieldData openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.StatusText>();
    if (element != null)
      return DMXW.StatusTextConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStatusText(DXW.FormFieldData openXmlElement, DMW.StatusText? value, DiffList? diffs, string? objName)
  {
    return DMXW.StatusTextConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.StatusText>(), value, diffs, objName);
  }
  
  private static void SetStatusText(DXW.FormFieldData openXmlElement, DMW.StatusText? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.StatusText>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.StatusTextConverter.CreateOpenXmlElement<DXW.StatusText>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.CheckBox? GetCheckBox(DXW.FormFieldData openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CheckBox>();
    if (element != null)
      return DMXW.CheckBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCheckBox(DXW.FormFieldData openXmlElement, DMW.CheckBox? value, DiffList? diffs, string? objName)
  {
    return DMXW.CheckBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CheckBox>(), value, diffs, objName);
  }
  
  private static void SetCheckBox(DXW.FormFieldData openXmlElement, DMW.CheckBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CheckBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.CheckBoxConverter.CreateOpenXmlElement<DXW.CheckBox>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.DropDownListFormField? GetDropDownListFormField(DXW.FormFieldData openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.DropDownListFormField>();
    if (element != null)
      return DMXW.DropDownListFormFieldConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDropDownListFormField(DXW.FormFieldData openXmlElement, DMW.DropDownListFormField? value, DiffList? diffs, string? objName)
  {
    return DMXW.DropDownListFormFieldConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.DropDownListFormField>(), value, diffs, objName);
  }
  
  private static void SetDropDownListFormField(DXW.FormFieldData openXmlElement, DMW.DropDownListFormField? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DropDownListFormField>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.DropDownListFormFieldConverter.CreateOpenXmlElement<DXW.DropDownListFormField>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.TextInput? GetTextInput(DXW.FormFieldData openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TextInput>();
    if (element != null)
      return DMXW.TextInputConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextInput(DXW.FormFieldData openXmlElement, DMW.TextInput? value, DiffList? diffs, string? objName)
  {
    return DMXW.TextInputConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TextInput>(), value, diffs, objName);
  }
  
  private static void SetTextInput(DXW.FormFieldData openXmlElement, DMW.TextInput? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TextInput>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TextInputConverter.CreateOpenXmlElement<DXW.TextInput>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.FormFieldData? CreateModelElement(DXW.FormFieldData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.FormFieldData();
      value.FormFieldName = GetFormFieldName(openXmlElement);
      value.Enabled = GetEnabled(openXmlElement);
      value.CalculateOnExit = GetCalculateOnExit(openXmlElement);
      value.EntryMacro = GetEntryMacro(openXmlElement);
      value.ExitMacro = GetExitMacro(openXmlElement);
      value.HelpText = GetHelpText(openXmlElement);
      value.StatusText = GetStatusText(openXmlElement);
      value.CheckBox = GetCheckBox(openXmlElement);
      value.DropDownListFormField = GetDropDownListFormField(openXmlElement);
      value.TextInput = GetTextInput(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.FormFieldData? openXmlElement, DMW.FormFieldData? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpFormFieldName(openXmlElement, value.FormFieldName, diffs, objName))
        ok = false;
      if (!CmpEnabled(openXmlElement, value.Enabled, diffs, objName))
        ok = false;
      if (!CmpCalculateOnExit(openXmlElement, value.CalculateOnExit, diffs, objName))
        ok = false;
      if (!CmpEntryMacro(openXmlElement, value.EntryMacro, diffs, objName))
        ok = false;
      if (!CmpExitMacro(openXmlElement, value.ExitMacro, diffs, objName))
        ok = false;
      if (!CmpHelpText(openXmlElement, value.HelpText, diffs, objName))
        ok = false;
      if (!CmpStatusText(openXmlElement, value.StatusText, diffs, objName))
        ok = false;
      if (!CmpCheckBox(openXmlElement, value.CheckBox, diffs, objName))
        ok = false;
      if (!CmpDropDownListFormField(openXmlElement, value.DropDownListFormField, diffs, objName))
        ok = false;
      if (!CmpTextInput(openXmlElement, value.TextInput, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.FormFieldData value)
    where OpenXmlElementType: DXW.FormFieldData, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.FormFieldData openXmlElement, DMW.FormFieldData value)
  {
    SetFormFieldName(openXmlElement, value?.FormFieldName);
    SetEnabled(openXmlElement, value?.Enabled);
    SetCalculateOnExit(openXmlElement, value?.CalculateOnExit);
    SetEntryMacro(openXmlElement, value?.EntryMacro);
    SetExitMacro(openXmlElement, value?.ExitMacro);
    SetHelpText(openXmlElement, value?.HelpText);
    SetStatusText(openXmlElement, value?.StatusText);
    SetCheckBox(openXmlElement, value?.CheckBox);
    SetDropDownListFormField(openXmlElement, value?.DropDownListFormField);
    SetTextInput(openXmlElement, value?.TextInput);
  }
}
