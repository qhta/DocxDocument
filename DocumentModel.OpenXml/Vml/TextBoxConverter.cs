namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Defines the TextBox Class.
/// </summary>
public static class TextBoxConverter
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  private static String? GetId(DXVml.TextBox openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXVml.TextBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Id?.Value == value) return true;
    diffs?.Add(objName, "Id", openXmlElement?.Id?.Value, value);
    return false;
  }
  
  private static void SetId(DXVml.TextBox openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Shape Styling Properties
  /// </summary>
  private static String? GetStyle(DXVml.TextBox openXmlElement)
  {
    return openXmlElement?.Style?.Value;
  }
  
  private static bool CmpStyle(DXVml.TextBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Style?.Value == value) return true;
    diffs?.Add(objName, "Style", openXmlElement?.Style?.Value, value);
    return false;
  }
  
  private static void SetStyle(DXVml.TextBox openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Style = new StringValue { Value = value };
    else
      openXmlElement.Style = null;
  }
  
  /// <summary>
  /// Text Box Inset
  /// </summary>
  private static String? GetInset(DXVml.TextBox openXmlElement)
  {
    return openXmlElement?.Inset?.Value;
  }
  
  private static bool CmpInset(DXVml.TextBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Inset?.Value == value) return true;
    diffs?.Add(objName, "Inset", openXmlElement?.Inset?.Value, value);
    return false;
  }
  
  private static void SetInset(DXVml.TextBox openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Inset = new StringValue { Value = value };
    else
      openXmlElement.Inset = null;
  }
  
  /// <summary>
  /// Text Box Single-Click Selection Toggle
  /// </summary>
  private static Boolean? GetSingleClick(DXVml.TextBox openXmlElement)
  {
    return openXmlElement?.SingleClick?.Value;
  }
  
  private static bool CmpSingleClick(DXVml.TextBox openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.SingleClick?.Value == value) return true;
    diffs?.Add(objName, "SingleClick", openXmlElement?.SingleClick?.Value, value);
    return false;
  }
  
  private static void SetSingleClick(DXVml.TextBox openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.SingleClick = value;
    else
      openXmlElement.SingleClick = null;
  }
  
  private static DMW.TextBoxContent? GetTextBoxContent(DXVml.TextBox openXmlElement)
  {
    return DMXW.TextBoxContentConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.TextBoxContent>());
  }
  
  private static bool CmpTextBoxContent(DXVml.TextBox openXmlElement, DMW.TextBoxContent? value, DiffList? diffs, string? objName)
  {
    return DMXW.TextBoxContentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TextBoxContent>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTextBoxContent(DXVml.TextBox openXmlElement, DMW.TextBoxContent? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TextBoxContent>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TextBoxContentConverter.CreateOpenXmlElement<DXW.TextBoxContent>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMVml.TextBox? CreateModelElement(DXVml.TextBox? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMVml.TextBox();
      value.Id = GetId(openXmlElement);
      value.Style = GetStyle(openXmlElement);
      value.Inset = GetInset(openXmlElement);
      value.SingleClick = GetSingleClick(openXmlElement);
      value.TextBoxContent = GetTextBoxContent(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXVml.TextBox? openXmlElement, DMVml.TextBox? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMVml.TextBox? value)
    where OpenXmlElementType: DXVml.TextBox, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetStyle(openXmlElement, value?.Style);
      SetInset(openXmlElement, value?.Inset);
      SetSingleClick(openXmlElement, value?.SingleClick);
      SetTextBoxContent(openXmlElement, value?.TextBoxContent);
      return openXmlElement;
    }
    return default;
  }
}
