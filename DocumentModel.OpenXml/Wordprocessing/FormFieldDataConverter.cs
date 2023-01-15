using DocumentFormat.OpenXml.Wordprocessing;
using DropDownListFormField = DocumentModel.Wordprocessing.DropDownListFormField;
using HelpText = DocumentModel.Wordprocessing.HelpText;
using StatusText = DocumentModel.Wordprocessing.StatusText;
using TextInput = DocumentModel.Wordprocessing.TextInput;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Form Field Properties.
/// </summary>
public static class FormFieldDataConverter
{
  public static String? GetFormFieldName(FormFieldData? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<FormFieldName>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetFormFieldName(FormFieldData? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<FormFieldName>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new FormFieldName { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetEnabled(FormFieldData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Enabled>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetEnabled(FormFieldData? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<Enabled>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new Enabled();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetCalculateOnExit(FormFieldData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CalculateOnExit>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetCalculateOnExit(FormFieldData? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<CalculateOnExit>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new CalculateOnExit();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static String? GetEntryMacro(FormFieldData? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<EntryMacro>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetEntryMacro(FormFieldData? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<EntryMacro>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new EntryMacro { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static String? GetExitMacro(FormFieldData? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<ExitMacro>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetExitMacro(FormFieldData? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ExitMacro>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new ExitMacro { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static HelpText? GetHelpText(FormFieldData? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.HelpText>();
    if (itemElement != null)
      return HelpTextConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetHelpText(FormFieldData? openXmlElement, HelpText? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.HelpText>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HelpTextConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.HelpText>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static StatusText? GetStatusText(FormFieldData? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StatusText>();
    if (itemElement != null)
      return StatusTextConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetStatusText(FormFieldData? openXmlElement, StatusText? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StatusText>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StatusTextConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.StatusText>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.CheckBox? GetCheckBox(FormFieldData? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CheckBox>();
    if (itemElement != null)
      return CheckBoxConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCheckBox(FormFieldData? openXmlElement, DocumentModel.Wordprocessing.CheckBox? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CheckBox>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CheckBoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.CheckBox>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DropDownListFormField? GetDropDownListFormField(FormFieldData? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DropDownListFormField>();
    if (itemElement != null)
      return DropDownListFormFieldConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDropDownListFormField(FormFieldData? openXmlElement, DropDownListFormField? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DropDownListFormField>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DropDownListFormFieldConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DropDownListFormField>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TextInput? GetTextInput(FormFieldData? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TextInput>();
    if (itemElement != null)
      return TextInputConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTextInput(FormFieldData? openXmlElement, TextInput? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TextInput>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextInputConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TextInput>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.FormFieldData? CreateModelElement(FormFieldData? openXmlElement)
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
    where OpenXmlElementType : FormFieldData, new()
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