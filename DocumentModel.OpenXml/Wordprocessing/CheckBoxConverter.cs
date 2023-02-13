namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Checkbox Form Field Properties.
/// </summary>
public static class CheckBoxConverter
{
  private static String? GetFormFieldSize(DXW.CheckBox openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXW.FormFieldSize>()?.Val?.Value;
  }
  
  private static bool CmpFormFieldSize(DXW.CheckBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXW.FormFieldSize>()?.Val?.Value == value;
  }
  
  private static void SetFormFieldSize(DXW.CheckBox openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FormFieldSize>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.FormFieldSize { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetAutomaticallySizeFormField(DXW.CheckBox openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.AutomaticallySizeFormField>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpAutomaticallySizeFormField(DXW.CheckBox openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetAutomaticallySizeFormField(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.AutomaticallySizeFormField", val, value);
    return false;
  }
  
  private static void SetAutomaticallySizeFormField(DXW.CheckBox openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.AutomaticallySizeFormField>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.AutomaticallySizeFormField();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetDefaultCheckBoxFormFieldState(DXW.CheckBox openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.DefaultCheckBoxFormFieldState>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpDefaultCheckBoxFormFieldState(DXW.CheckBox openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetDefaultCheckBoxFormFieldState(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.DefaultCheckBoxFormFieldState", val, value);
    return false;
  }
  
  private static void SetDefaultCheckBoxFormFieldState(DXW.CheckBox openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.DefaultCheckBoxFormFieldState>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.DefaultCheckBoxFormFieldState();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetChecked(DXW.CheckBox openXmlElement)
  {
    var element = openXmlElement.GetFirstChild<DXW.Checked>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpChecked(DXW.CheckBox openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetChecked(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.Checked", val, value);
    return false;
  }
  
  private static void SetChecked(DXW.CheckBox openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.Checked>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.Checked();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.CheckBox? CreateModelElement(DXW.CheckBox? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.CheckBox();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.CheckBox? value)
    where OpenXmlElementType: DXW.CheckBox, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFormFieldSize(openXmlElement, value?.FormFieldSize);
      SetAutomaticallySizeFormField(openXmlElement, value?.AutomaticallySizeFormField);
      SetDefaultCheckBoxFormFieldState(openXmlElement, value?.DefaultCheckBoxFormFieldState);
      SetChecked(openXmlElement, value?.Checked);
      return openXmlElement;
    }
    return default;
  }
}
