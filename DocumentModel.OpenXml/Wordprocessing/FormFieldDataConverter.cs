namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Form Field Properties.
/// </summary>
public static class FormFieldDataConverter
{
  private static String? GetFormFieldName(DXW.FormFieldData openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.FormFieldName>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetFormFieldName(DXW.FormFieldData openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FormFieldName>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.FormFieldName { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetEnabled(DXW.FormFieldData openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Enabled>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetEnabled(DXW.FormFieldData openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.Enabled>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.Enabled();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetCalculateOnExit(DXW.FormFieldData openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CalculateOnExit>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetCalculateOnExit(DXW.FormFieldData openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.CalculateOnExit>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.CalculateOnExit();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static String? GetEntryMacro(DXW.FormFieldData openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.EntryMacro>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetEntryMacro(DXW.FormFieldData openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.EntryMacro>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.EntryMacro { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static String? GetExitMacro(DXW.FormFieldData openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.ExitMacro>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetExitMacro(DXW.FormFieldData openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ExitMacro>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.ExitMacro { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.HelpText? GetHelpText(DXW.FormFieldData openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.HelpText>();
    if (itemElement != null)
      return DMXW.HelpTextConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.StatusText>();
    if (itemElement != null)
      return DMXW.StatusTextConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.CheckBox>();
    if (itemElement != null)
      return DMXW.CheckBoxConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.DropDownListFormField>();
    if (itemElement != null)
      return DMXW.DropDownListFormFieldConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.TextInput>();
    if (itemElement != null)
      return DMXW.TextInputConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.FormFieldData? value)
    where OpenXmlElementType: DXW.FormFieldData, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      return openXmlElement;
    }
    return default;
  }
}
