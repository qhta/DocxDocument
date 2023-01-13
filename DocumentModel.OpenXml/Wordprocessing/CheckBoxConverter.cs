namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Checkbox Form Field Properties.
/// </summary>
public static class CheckBoxConverter
{
  public static String? GetFormFieldSize(DocumentFormat.OpenXml.Wordprocessing.CheckBox? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FormFieldSize>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetFormFieldSize(DocumentFormat.OpenXml.Wordprocessing.CheckBox? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FormFieldSize>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Wordprocessing.FormFieldSize { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetAutomaticallySizeFormField(DocumentFormat.OpenXml.Wordprocessing.CheckBox? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AutomaticallySizeFormField>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetAutomaticallySizeFormField(DocumentFormat.OpenXml.Wordprocessing.CheckBox? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AutomaticallySizeFormField>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.AutomaticallySizeFormField();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetDefaultCheckBoxFormFieldState(DocumentFormat.OpenXml.Wordprocessing.CheckBox? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DefaultCheckBoxFormFieldState>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetDefaultCheckBoxFormFieldState(DocumentFormat.OpenXml.Wordprocessing.CheckBox? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DefaultCheckBoxFormFieldState>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.DefaultCheckBoxFormFieldState();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetChecked(DocumentFormat.OpenXml.Wordprocessing.CheckBox? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Checked>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetChecked(DocumentFormat.OpenXml.Wordprocessing.CheckBox? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Checked>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Wordprocessing.Checked();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.CheckBox? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.CheckBox? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.CheckBox? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.CheckBox, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
