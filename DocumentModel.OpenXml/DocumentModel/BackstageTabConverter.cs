namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the BackstageTab Class.
/// </summary>
public static class BackstageTabConverter
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetId(DXO2010CustUI.BackstageTab openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXO2010CustUI.BackstageTab openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "Id");
  }
  
  private static void SetId(DXO2010CustUI.BackstageTab openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetQualifiedId(DXO2010CustUI.BackstageTab openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.QualifiedId);
  }
  
  private static bool CmpQualifiedId(DXO2010CustUI.BackstageTab openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.QualifiedId, value, diffs, objName, "QualifiedId");
  }
  
  private static void SetQualifiedId(DXO2010CustUI.BackstageTab openXmlElement, String? value)
  {
    openXmlElement.QualifiedId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetTag(DXO2010CustUI.BackstageTab openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Tag);
  }
  
  private static bool CmpTag(DXO2010CustUI.BackstageTab openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Tag, value, diffs, objName, "Tag");
  }
  
  private static void SetTag(DXO2010CustUI.BackstageTab openXmlElement, String? value)
  {
    openXmlElement.Tag = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// idMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetIdMso(DXO2010CustUI.BackstageTab openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.IdMso);
  }
  
  private static bool CmpIdMso(DXO2010CustUI.BackstageTab openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.IdMso, value, diffs, objName, "IdMso");
  }
  
  private static void SetIdMso(DXO2010CustUI.BackstageTab openXmlElement, String? value)
  {
    openXmlElement.IdMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertAfterMso(DXO2010CustUI.BackstageTab openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertAfterMso);
  }
  
  private static bool CmpInsertAfterMso(DXO2010CustUI.BackstageTab openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertAfterMso, value, diffs, objName, "InsertAfterMso");
  }
  
  private static void SetInsertAfterMso(DXO2010CustUI.BackstageTab openXmlElement, String? value)
  {
    openXmlElement.InsertAfterMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertBeforeMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertBeforeMso(DXO2010CustUI.BackstageTab openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertBeforeMso);
  }
  
  private static bool CmpInsertBeforeMso(DXO2010CustUI.BackstageTab openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertBeforeMso, value, diffs, objName, "InsertBeforeMso");
  }
  
  private static void SetInsertBeforeMso(DXO2010CustUI.BackstageTab openXmlElement, String? value)
  {
    openXmlElement.InsertBeforeMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertAfterQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertAfterQulifiedId(DXO2010CustUI.BackstageTab openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertAfterQulifiedId);
  }
  
  private static bool CmpInsertAfterQulifiedId(DXO2010CustUI.BackstageTab openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertAfterQulifiedId, value, diffs, objName, "InsertAfterQulifiedId");
  }
  
  private static void SetInsertAfterQulifiedId(DXO2010CustUI.BackstageTab openXmlElement, String? value)
  {
    openXmlElement.InsertAfterQulifiedId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertBeforeQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertBeforeQulifiedId(DXO2010CustUI.BackstageTab openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertBeforeQulifiedId);
  }
  
  private static bool CmpInsertBeforeQulifiedId(DXO2010CustUI.BackstageTab openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertBeforeQulifiedId, value, diffs, objName, "InsertBeforeQulifiedId");
  }
  
  private static void SetInsertBeforeQulifiedId(DXO2010CustUI.BackstageTab openXmlElement, String? value)
  {
    openXmlElement.InsertBeforeQulifiedId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// enabled, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetEnabled(DXO2010CustUI.BackstageTab openXmlElement)
  {
    return openXmlElement?.Enabled?.Value;
  }
  
  private static bool CmpEnabled(DXO2010CustUI.BackstageTab openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Enabled?.Value == value) return true;
    diffs?.Add(objName, "Enabled", openXmlElement?.Enabled?.Value, value);
    return false;
  }
  
  private static void SetEnabled(DXO2010CustUI.BackstageTab openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Enabled = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Enabled = null;
  }
  
  /// <summary>
  /// getEnabled, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetEnabled(DXO2010CustUI.BackstageTab openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetEnabled);
  }
  
  private static bool CmpGetEnabled(DXO2010CustUI.BackstageTab openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetEnabled, value, diffs, objName, "GetEnabled");
  }
  
  private static void SetGetEnabled(DXO2010CustUI.BackstageTab openXmlElement, String? value)
  {
    openXmlElement.GetEnabled = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetLabel(DXO2010CustUI.BackstageTab openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Label);
  }
  
  private static bool CmpLabel(DXO2010CustUI.BackstageTab openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Label, value, diffs, objName, "Label");
  }
  
  private static void SetLabel(DXO2010CustUI.BackstageTab openXmlElement, String? value)
  {
    openXmlElement.Label = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetLabel(DXO2010CustUI.BackstageTab openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetLabel);
  }
  
  private static bool CmpGetLabel(DXO2010CustUI.BackstageTab openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetLabel, value, diffs, objName, "GetLabel");
  }
  
  private static void SetGetLabel(DXO2010CustUI.BackstageTab openXmlElement, String? value)
  {
    openXmlElement.GetLabel = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetVisible(DXO2010CustUI.BackstageTab openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static bool CmpVisible(DXO2010CustUI.BackstageTab openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Visible?.Value == value) return true;
    diffs?.Add(objName, "Visible", openXmlElement?.Visible?.Value, value);
    return false;
  }
  
  private static void SetVisible(DXO2010CustUI.BackstageTab openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetVisible(DXO2010CustUI.BackstageTab openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetVisible);
  }
  
  private static bool CmpGetVisible(DXO2010CustUI.BackstageTab openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetVisible, value, diffs, objName, "GetVisible");
  }
  
  private static void SetGetVisible(DXO2010CustUI.BackstageTab openXmlElement, String? value)
  {
    openXmlElement.GetVisible = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// keytip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetKeytip(DXO2010CustUI.BackstageTab openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Keytip);
  }
  
  private static bool CmpKeytip(DXO2010CustUI.BackstageTab openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Keytip, value, diffs, objName, "Keytip");
  }
  
  private static void SetKeytip(DXO2010CustUI.BackstageTab openXmlElement, String? value)
  {
    openXmlElement.Keytip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getKeytip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetKeytip(DXO2010CustUI.BackstageTab openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetKeytip);
  }
  
  private static bool CmpGetKeytip(DXO2010CustUI.BackstageTab openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetKeytip, value, diffs, objName, "GetKeytip");
  }
  
  private static void SetGetKeytip(DXO2010CustUI.BackstageTab openXmlElement, String? value)
  {
    openXmlElement.GetKeytip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// title, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetTitle(DXO2010CustUI.BackstageTab openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Title);
  }
  
  private static bool CmpTitle(DXO2010CustUI.BackstageTab openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Title, value, diffs, objName, "Title");
  }
  
  private static void SetTitle(DXO2010CustUI.BackstageTab openXmlElement, String? value)
  {
    openXmlElement.Title = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getTitle, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetTitle(DXO2010CustUI.BackstageTab openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetTitle);
  }
  
  private static bool CmpGetTitle(DXO2010CustUI.BackstageTab openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetTitle, value, diffs, objName, "GetTitle");
  }
  
  private static void SetGetTitle(DXO2010CustUI.BackstageTab openXmlElement, String? value)
  {
    openXmlElement.GetTitle = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// columnWidthPercent, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int64? GetColumnWidthPercent(DXO2010CustUI.BackstageTab openXmlElement)
  {
    return openXmlElement?.ColumnWidthPercent?.Value;
  }
  
  private static bool CmpColumnWidthPercent(DXO2010CustUI.BackstageTab openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ColumnWidthPercent?.Value == value) return true;
    diffs?.Add(objName, "ColumnWidthPercent", openXmlElement?.ColumnWidthPercent?.Value, value);
    return false;
  }
  
  private static void SetColumnWidthPercent(DXO2010CustUI.BackstageTab openXmlElement, Int64? value)
  {
    openXmlElement.ColumnWidthPercent = value;
  }
  
  /// <summary>
  /// firstColumnMinWidth, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int64? GetFirstColumnMinWidth(DXO2010CustUI.BackstageTab openXmlElement)
  {
    return openXmlElement?.FirstColumnMinWidth?.Value;
  }
  
  private static bool CmpFirstColumnMinWidth(DXO2010CustUI.BackstageTab openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.FirstColumnMinWidth?.Value == value) return true;
    diffs?.Add(objName, "FirstColumnMinWidth", openXmlElement?.FirstColumnMinWidth?.Value, value);
    return false;
  }
  
  private static void SetFirstColumnMinWidth(DXO2010CustUI.BackstageTab openXmlElement, Int64? value)
  {
    openXmlElement.FirstColumnMinWidth = value;
  }
  
  /// <summary>
  /// firstColumnMaxWidth, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int64? GetFirstColumnMaxWidth(DXO2010CustUI.BackstageTab openXmlElement)
  {
    return openXmlElement?.FirstColumnMaxWidth?.Value;
  }
  
  private static bool CmpFirstColumnMaxWidth(DXO2010CustUI.BackstageTab openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.FirstColumnMaxWidth?.Value == value) return true;
    diffs?.Add(objName, "FirstColumnMaxWidth", openXmlElement?.FirstColumnMaxWidth?.Value, value);
    return false;
  }
  
  private static void SetFirstColumnMaxWidth(DXO2010CustUI.BackstageTab openXmlElement, Int64? value)
  {
    openXmlElement.FirstColumnMaxWidth = value;
  }
  
  /// <summary>
  /// secondColumnMinWidth, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int64? GetSecondColumnMinWidth(DXO2010CustUI.BackstageTab openXmlElement)
  {
    return openXmlElement?.SecondColumnMinWidth?.Value;
  }
  
  private static bool CmpSecondColumnMinWidth(DXO2010CustUI.BackstageTab openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.SecondColumnMinWidth?.Value == value) return true;
    diffs?.Add(objName, "SecondColumnMinWidth", openXmlElement?.SecondColumnMinWidth?.Value, value);
    return false;
  }
  
  private static void SetSecondColumnMinWidth(DXO2010CustUI.BackstageTab openXmlElement, Int64? value)
  {
    openXmlElement.SecondColumnMinWidth = value;
  }
  
  /// <summary>
  /// secondColumnMaxWidth, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int64? GetSecondColumnMaxWidth(DXO2010CustUI.BackstageTab openXmlElement)
  {
    return openXmlElement?.SecondColumnMaxWidth?.Value;
  }
  
  private static bool CmpSecondColumnMaxWidth(DXO2010CustUI.BackstageTab openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.SecondColumnMaxWidth?.Value == value) return true;
    diffs?.Add(objName, "SecondColumnMaxWidth", openXmlElement?.SecondColumnMaxWidth?.Value, value);
    return false;
  }
  
  private static void SetSecondColumnMaxWidth(DXO2010CustUI.BackstageTab openXmlElement, Int64? value)
  {
    openXmlElement.SecondColumnMaxWidth = value;
  }
  
  /// <summary>
  /// BackstageGroups.
  /// </summary>
  private static DM.BackstageGroups? GetBackstageGroups(DXO2010CustUI.BackstageTab openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageGroups>();
    if (element != null)
      return DMX.BackstageGroupsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackstageGroups(DXO2010CustUI.BackstageTab openXmlElement, DM.BackstageGroups? value, DiffList? diffs, string? objName)
  {
    return DMX.BackstageGroupsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.BackstageGroups>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBackstageGroups(DXO2010CustUI.BackstageTab openXmlElement, DM.BackstageGroups? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.BackstageGroups>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.BackstageGroupsConverter.CreateOpenXmlElement<DXO2010CustUI.BackstageGroups>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// SimpleGroups.
  /// </summary>
  private static DM.SimpleGroups? GetSimpleGroups(DXO2010CustUI.BackstageTab openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.SimpleGroups>();
    if (element != null)
      return DMX.SimpleGroupsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSimpleGroups(DXO2010CustUI.BackstageTab openXmlElement, DM.SimpleGroups? value, DiffList? diffs, string? objName)
  {
    return DMX.SimpleGroupsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.SimpleGroups>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSimpleGroups(DXO2010CustUI.BackstageTab openXmlElement, DM.SimpleGroups? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.SimpleGroups>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.SimpleGroupsConverter.CreateOpenXmlElement<DXO2010CustUI.SimpleGroups>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.BackstageTab? CreateModelElement(DXO2010CustUI.BackstageTab? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.BackstageTab();
      value.Id = GetId(openXmlElement);
      value.QualifiedId = GetQualifiedId(openXmlElement);
      value.Tag = GetTag(openXmlElement);
      value.IdMso = GetIdMso(openXmlElement);
      value.InsertAfterMso = GetInsertAfterMso(openXmlElement);
      value.InsertBeforeMso = GetInsertBeforeMso(openXmlElement);
      value.InsertAfterQulifiedId = GetInsertAfterQulifiedId(openXmlElement);
      value.InsertBeforeQulifiedId = GetInsertBeforeQulifiedId(openXmlElement);
      value.Enabled = GetEnabled(openXmlElement);
      value.GetEnabled = GetGetEnabled(openXmlElement);
      value.Label = GetLabel(openXmlElement);
      value.GetLabel = GetGetLabel(openXmlElement);
      value.Visible = GetVisible(openXmlElement);
      value.GetVisible = GetGetVisible(openXmlElement);
      value.Keytip = GetKeytip(openXmlElement);
      value.GetKeytip = GetGetKeytip(openXmlElement);
      value.Title = GetTitle(openXmlElement);
      value.GetTitle = GetGetTitle(openXmlElement);
      value.ColumnWidthPercent = GetColumnWidthPercent(openXmlElement);
      value.FirstColumnMinWidth = GetFirstColumnMinWidth(openXmlElement);
      value.FirstColumnMaxWidth = GetFirstColumnMaxWidth(openXmlElement);
      value.SecondColumnMinWidth = GetSecondColumnMinWidth(openXmlElement);
      value.SecondColumnMaxWidth = GetSecondColumnMaxWidth(openXmlElement);
      value.BackstageGroups = GetBackstageGroups(openXmlElement);
      value.SimpleGroups = GetSimpleGroups(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010CustUI.BackstageTab? openXmlElement, DM.BackstageTab? value, DiffList? diffs, string? objName)
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
      if (!CmpIdMso(openXmlElement, value.IdMso, diffs, objName))
        ok = false;
      if (!CmpInsertAfterMso(openXmlElement, value.InsertAfterMso, diffs, objName))
        ok = false;
      if (!CmpInsertBeforeMso(openXmlElement, value.InsertBeforeMso, diffs, objName))
        ok = false;
      if (!CmpInsertAfterQulifiedId(openXmlElement, value.InsertAfterQulifiedId, diffs, objName))
        ok = false;
      if (!CmpInsertBeforeQulifiedId(openXmlElement, value.InsertBeforeQulifiedId, diffs, objName))
        ok = false;
      if (!CmpEnabled(openXmlElement, value.Enabled, diffs, objName))
        ok = false;
      if (!CmpGetEnabled(openXmlElement, value.GetEnabled, diffs, objName))
        ok = false;
      if (!CmpLabel(openXmlElement, value.Label, diffs, objName))
        ok = false;
      if (!CmpGetLabel(openXmlElement, value.GetLabel, diffs, objName))
        ok = false;
      if (!CmpVisible(openXmlElement, value.Visible, diffs, objName))
        ok = false;
      if (!CmpGetVisible(openXmlElement, value.GetVisible, diffs, objName))
        ok = false;
      if (!CmpKeytip(openXmlElement, value.Keytip, diffs, objName))
        ok = false;
      if (!CmpGetKeytip(openXmlElement, value.GetKeytip, diffs, objName))
        ok = false;
      if (!CmpTitle(openXmlElement, value.Title, diffs, objName))
        ok = false;
      if (!CmpGetTitle(openXmlElement, value.GetTitle, diffs, objName))
        ok = false;
      if (!CmpColumnWidthPercent(openXmlElement, value.ColumnWidthPercent, diffs, objName))
        ok = false;
      if (!CmpFirstColumnMinWidth(openXmlElement, value.FirstColumnMinWidth, diffs, objName))
        ok = false;
      if (!CmpFirstColumnMaxWidth(openXmlElement, value.FirstColumnMaxWidth, diffs, objName))
        ok = false;
      if (!CmpSecondColumnMinWidth(openXmlElement, value.SecondColumnMinWidth, diffs, objName))
        ok = false;
      if (!CmpSecondColumnMaxWidth(openXmlElement, value.SecondColumnMaxWidth, diffs, objName))
        ok = false;
      if (!CmpBackstageGroups(openXmlElement, value.BackstageGroups, diffs, objName))
        ok = false;
      if (!CmpSimpleGroups(openXmlElement, value.SimpleGroups, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.BackstageTab value)
    where OpenXmlElementType: DXO2010CustUI.BackstageTab, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010CustUI.BackstageTab openXmlElement, DM.BackstageTab value)
  {
    SetId(openXmlElement, value?.Id);
    SetQualifiedId(openXmlElement, value?.QualifiedId);
    SetTag(openXmlElement, value?.Tag);
    SetIdMso(openXmlElement, value?.IdMso);
    SetInsertAfterMso(openXmlElement, value?.InsertAfterMso);
    SetInsertBeforeMso(openXmlElement, value?.InsertBeforeMso);
    SetInsertAfterQulifiedId(openXmlElement, value?.InsertAfterQulifiedId);
    SetInsertBeforeQulifiedId(openXmlElement, value?.InsertBeforeQulifiedId);
    SetEnabled(openXmlElement, value?.Enabled);
    SetGetEnabled(openXmlElement, value?.GetEnabled);
    SetLabel(openXmlElement, value?.Label);
    SetGetLabel(openXmlElement, value?.GetLabel);
    SetVisible(openXmlElement, value?.Visible);
    SetGetVisible(openXmlElement, value?.GetVisible);
    SetKeytip(openXmlElement, value?.Keytip);
    SetGetKeytip(openXmlElement, value?.GetKeytip);
    SetTitle(openXmlElement, value?.Title);
    SetGetTitle(openXmlElement, value?.GetTitle);
    SetColumnWidthPercent(openXmlElement, value?.ColumnWidthPercent);
    SetFirstColumnMinWidth(openXmlElement, value?.FirstColumnMinWidth);
    SetFirstColumnMaxWidth(openXmlElement, value?.FirstColumnMaxWidth);
    SetSecondColumnMinWidth(openXmlElement, value?.SecondColumnMinWidth);
    SetSecondColumnMaxWidth(openXmlElement, value?.SecondColumnMaxWidth);
    SetBackstageGroups(openXmlElement, value?.BackstageGroups);
    SetSimpleGroups(openXmlElement, value?.SimpleGroups);
    }
  }
