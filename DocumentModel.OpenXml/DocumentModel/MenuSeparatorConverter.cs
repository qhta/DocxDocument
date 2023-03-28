namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the MenuSeparator Class converter from/to OpenXml.
///</summary>
public static class MenuSeparatorConverter
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetId(DXO2010CustUI.MenuSeparator openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXO2010CustUI.MenuSeparator openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "Id");
  }
  
  private static void SetId(DXO2010CustUI.MenuSeparator openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetQualifiedId(DXO2010CustUI.MenuSeparator openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.QualifiedId);
  }
  
  private static bool CmpQualifiedId(DXO2010CustUI.MenuSeparator openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.QualifiedId, value, diffs, objName, "QualifiedId");
  }
  
  private static void SetQualifiedId(DXO2010CustUI.MenuSeparator openXmlElement, String? value)
  {
    openXmlElement.QualifiedId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetTag(DXO2010CustUI.MenuSeparator openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Tag);
  }
  
  private static bool CmpTag(DXO2010CustUI.MenuSeparator openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Tag, value, diffs, objName, "Tag");
  }
  
  private static void SetTag(DXO2010CustUI.MenuSeparator openXmlElement, String? value)
  {
    openXmlElement.Tag = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertAfterMso(DXO2010CustUI.MenuSeparator openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertAfterMso);
  }
  
  private static bool CmpInsertAfterMso(DXO2010CustUI.MenuSeparator openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertAfterMso, value, diffs, objName, "InsertAfterMso");
  }
  
  private static void SetInsertAfterMso(DXO2010CustUI.MenuSeparator openXmlElement, String? value)
  {
    openXmlElement.InsertAfterMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertBeforeMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertBeforeMso(DXO2010CustUI.MenuSeparator openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertBeforeMso);
  }
  
  private static bool CmpInsertBeforeMso(DXO2010CustUI.MenuSeparator openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertBeforeMso, value, diffs, objName, "InsertBeforeMso");
  }
  
  private static void SetInsertBeforeMso(DXO2010CustUI.MenuSeparator openXmlElement, String? value)
  {
    openXmlElement.InsertBeforeMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertAfterQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertAfterQulifiedId(DXO2010CustUI.MenuSeparator openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertAfterQulifiedId);
  }
  
  private static bool CmpInsertAfterQulifiedId(DXO2010CustUI.MenuSeparator openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertAfterQulifiedId, value, diffs, objName, "InsertAfterQulifiedId");
  }
  
  private static void SetInsertAfterQulifiedId(DXO2010CustUI.MenuSeparator openXmlElement, String? value)
  {
    openXmlElement.InsertAfterQulifiedId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertBeforeQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertBeforeQulifiedId(DXO2010CustUI.MenuSeparator openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertBeforeQulifiedId);
  }
  
  private static bool CmpInsertBeforeQulifiedId(DXO2010CustUI.MenuSeparator openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertBeforeQulifiedId, value, diffs, objName, "InsertBeforeQulifiedId");
  }
  
  private static void SetInsertBeforeQulifiedId(DXO2010CustUI.MenuSeparator openXmlElement, String? value)
  {
    openXmlElement.InsertBeforeQulifiedId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// title, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetTitle(DXO2010CustUI.MenuSeparator openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Title);
  }
  
  private static bool CmpTitle(DXO2010CustUI.MenuSeparator openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Title, value, diffs, objName, "Title");
  }
  
  private static void SetTitle(DXO2010CustUI.MenuSeparator openXmlElement, String? value)
  {
    openXmlElement.Title = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getTitle, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetTitle(DXO2010CustUI.MenuSeparator openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetTitle);
  }
  
  private static bool CmpGetTitle(DXO2010CustUI.MenuSeparator openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetTitle, value, diffs, objName, "GetTitle");
  }
  
  private static void SetGetTitle(DXO2010CustUI.MenuSeparator openXmlElement, String? value)
  {
    openXmlElement.GetTitle = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.MenuSeparator? CreateModelElement(DXO2010CustUI.MenuSeparator? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.MenuSeparator();
      value.Id = GetId(openXmlElement);
      value.QualifiedId = GetQualifiedId(openXmlElement);
      value.Tag = GetTag(openXmlElement);
      value.InsertAfterMso = GetInsertAfterMso(openXmlElement);
      value.InsertBeforeMso = GetInsertBeforeMso(openXmlElement);
      value.InsertAfterQulifiedId = GetInsertAfterQulifiedId(openXmlElement);
      value.InsertBeforeQulifiedId = GetInsertBeforeQulifiedId(openXmlElement);
      value.Title = GetTitle(openXmlElement);
      value.GetTitle = GetGetTitle(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010CustUI.MenuSeparator? openXmlElement, DM.MenuSeparator? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpQualifiedId(openXmlElement, value.QualifiedId, diffs, objName))
        ok = false;
      if (!CmpTag(openXmlElement, value.Tag, diffs, objName))
        ok = false;
      if (!CmpInsertAfterMso(openXmlElement, value.InsertAfterMso, diffs, objName))
        ok = false;
      if (!CmpInsertBeforeMso(openXmlElement, value.InsertBeforeMso, diffs, objName))
        ok = false;
      if (!CmpInsertAfterQulifiedId(openXmlElement, value.InsertAfterQulifiedId, diffs, objName))
        ok = false;
      if (!CmpInsertBeforeQulifiedId(openXmlElement, value.InsertBeforeQulifiedId, diffs, objName))
        ok = false;
      if (!CmpTitle(openXmlElement, value.Title, diffs, objName))
        ok = false;
      if (!CmpGetTitle(openXmlElement, value.GetTitle, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.MenuSeparator value)
    where OpenXmlElementType: DXO2010CustUI.MenuSeparator, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010CustUI.MenuSeparator openXmlElement, DM.MenuSeparator value)
  {
    SetId(openXmlElement, value?.Id);
    SetQualifiedId(openXmlElement, value?.QualifiedId);
    SetTag(openXmlElement, value?.Tag);
    SetInsertAfterMso(openXmlElement, value?.InsertAfterMso);
    SetInsertBeforeMso(openXmlElement, value?.InsertBeforeMso);
    SetInsertAfterQulifiedId(openXmlElement, value?.InsertAfterQulifiedId);
    SetInsertBeforeQulifiedId(openXmlElement, value?.InsertBeforeQulifiedId);
    SetTitle(openXmlElement, value?.Title);
    SetGetTitle(openXmlElement, value?.GetTitle);
  }
}
