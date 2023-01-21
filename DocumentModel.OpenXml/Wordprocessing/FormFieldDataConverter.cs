namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Form Field Properties.
/// </summary>
public static class FormFieldDataConverter
{
  private static String? GetFormFieldName(DocumentFormat.OpenXml.Wordprocessing.FormFieldData openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FormFieldName>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetFormFieldName(DocumentFormat.OpenXml.Wordprocessing.FormFieldData openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FormFieldName>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.FormFieldName { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetEnabled(DocumentFormat.OpenXml.Wordprocessing.FormFieldData openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Enabled>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetEnabled(DocumentFormat.OpenXml.Wordprocessing.FormFieldData openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Enabled>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.Enabled();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetCalculateOnExit(DocumentFormat.OpenXml.Wordprocessing.FormFieldData openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CalculateOnExit>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetCalculateOnExit(DocumentFormat.OpenXml.Wordprocessing.FormFieldData openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CalculateOnExit>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.CalculateOnExit();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static String? GetEntryMacro(DocumentFormat.OpenXml.Wordprocessing.FormFieldData openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EntryMacro>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetEntryMacro(DocumentFormat.OpenXml.Wordprocessing.FormFieldData openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EntryMacro>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.EntryMacro { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static String? GetExitMacro(DocumentFormat.OpenXml.Wordprocessing.FormFieldData openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ExitMacro>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetExitMacro(DocumentFormat.OpenXml.Wordprocessing.FormFieldData openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ExitMacro>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.ExitMacro { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.HelpText? GetHelpText(DocumentFormat.OpenXml.Wordprocessing.FormFieldData openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.HelpText>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.HelpTextConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetHelpText(DocumentFormat.OpenXml.Wordprocessing.FormFieldData openXmlElement, DocumentModel.Wordprocessing.HelpText? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.HelpText>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.HelpTextConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.HelpText>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.StatusText? GetStatusText(DocumentFormat.OpenXml.Wordprocessing.FormFieldData openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StatusText>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.StatusTextConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetStatusText(DocumentFormat.OpenXml.Wordprocessing.FormFieldData openXmlElement, DocumentModel.Wordprocessing.StatusText? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StatusText>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.StatusTextConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.StatusText>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.CheckBox? GetCheckBox(DocumentFormat.OpenXml.Wordprocessing.FormFieldData openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CheckBox>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.CheckBoxConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCheckBox(DocumentFormat.OpenXml.Wordprocessing.FormFieldData openXmlElement, DocumentModel.Wordprocessing.CheckBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CheckBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.CheckBoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.CheckBox>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.DropDownListFormField? GetDropDownListFormField(DocumentFormat.OpenXml.Wordprocessing.FormFieldData openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DropDownListFormField>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.DropDownListFormFieldConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDropDownListFormField(DocumentFormat.OpenXml.Wordprocessing.FormFieldData openXmlElement, DocumentModel.Wordprocessing.DropDownListFormField? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DropDownListFormField>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.DropDownListFormFieldConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DropDownListFormField>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.TextInput? GetTextInput(DocumentFormat.OpenXml.Wordprocessing.FormFieldData openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TextInput>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TextInputConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTextInput(DocumentFormat.OpenXml.Wordprocessing.FormFieldData openXmlElement, DocumentModel.Wordprocessing.TextInput? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TextInput>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.TextInputConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TextInput>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.FormFieldData? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.FormFieldData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.FormFieldData();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.FormFieldData? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.FormFieldData, new()
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
