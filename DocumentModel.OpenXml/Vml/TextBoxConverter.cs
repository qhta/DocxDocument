namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Defines the TextBox Class.
/// </summary>
public static class TextBoxConverter
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  private static String? GetId(DXV.TextBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXV.TextBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXV.TextBox openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shape Styling Properties
  /// </summary>
  private static String? GetStyle(DXV.TextBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Style);
  }
  
  private static bool CmpStyle(DXV.TextBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Style, value, diffs, objName, "Style");
  }
  
  private static void SetStyle(DXV.TextBox openXmlElement, String? value)
  {
    openXmlElement.Style = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Text Box Inset
  /// </summary>
  private static String? GetInset(DXV.TextBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Inset);
  }
  
  private static bool CmpInset(DXV.TextBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Inset, value, diffs, objName, "Inset");
  }
  
  private static void SetInset(DXV.TextBox openXmlElement, String? value)
  {
    openXmlElement.Inset = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Text Box Single-Click Selection Toggle
  /// </summary>
  private static Boolean? GetSingleClick(DXV.TextBox openXmlElement)
  {
    return openXmlElement?.SingleClick?.Value;
  }
  
  private static bool CmpSingleClick(DXV.TextBox openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.SingleClick?.Value == value) return true;
    diffs?.Add(objName, "SingleClick", openXmlElement?.SingleClick?.Value, value);
    return false;
  }
  
  private static void SetSingleClick(DXV.TextBox openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.SingleClick = value;
    else
      openXmlElement.SingleClick = null;
  }
  
  private static DMW.TextBoxContent? GetTextBoxContent(DXV.TextBox openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TextBoxContent>();
    if (element != null)
      return DMXW.TextBoxContentConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextBoxContent(DXV.TextBox openXmlElement, DMW.TextBoxContent? value, DiffList? diffs, string? objName)
  {
    return DMXW.TextBoxContentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TextBoxContent>(), value, diffs, objName);
  }
  
  private static void SetTextBoxContent(DXV.TextBox openXmlElement, DMW.TextBoxContent? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TextBoxContent>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TextBoxContentConverter.CreateOpenXmlElement<DXW.TextBoxContent>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Vml.TextBox? CreateModelElement(DXV.TextBox? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.TextBox();
      value.Id = GetId(openXmlElement);
      value.Style = GetStyle(openXmlElement);
      value.Inset = GetInset(openXmlElement);
      value.SingleClick = GetSingleClick(openXmlElement);
      value.TextBoxContent = GetTextBoxContent(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXV.TextBox? openXmlElement, DMV.TextBox? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpStyle(openXmlElement, value.Style, diffs, objName))
        ok = false;
      if (!CmpInset(openXmlElement, value.Inset, diffs, objName))
        ok = false;
      if (!CmpSingleClick(openXmlElement, value.SingleClick, diffs, objName))
        ok = false;
      if (!CmpTextBoxContent(openXmlElement, value.TextBoxContent, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMV.TextBox value)
    where OpenXmlElementType: DXV.TextBox, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXV.TextBox openXmlElement, DMV.TextBox value)
  {
    SetId(openXmlElement, value?.Id);
    SetStyle(openXmlElement, value?.Style);
    SetInset(openXmlElement, value?.Inset);
    SetSingleClick(openXmlElement, value?.SingleClick);
    SetTextBoxContent(openXmlElement, value?.TextBoxContent);
  }
}
