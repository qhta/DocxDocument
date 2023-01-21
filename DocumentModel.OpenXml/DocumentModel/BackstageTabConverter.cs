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
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXO2010CustUI.BackstageTab openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetQualifiedId(DXO2010CustUI.BackstageTab openXmlElement)
  {
    return openXmlElement?.QualifiedId?.Value;
  }
  
  private static void SetQualifiedId(DXO2010CustUI.BackstageTab openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.QualifiedId = new StringValue { Value = value };
    else
      openXmlElement.QualifiedId = null;
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetTag(DXO2010CustUI.BackstageTab openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }
  
  private static void SetTag(DXO2010CustUI.BackstageTab openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Tag = new StringValue { Value = value };
    else
      openXmlElement.Tag = null;
  }
  
  /// <summary>
  /// idMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetIdMso(DXO2010CustUI.BackstageTab openXmlElement)
  {
    return openXmlElement?.IdMso?.Value;
  }
  
  private static void SetIdMso(DXO2010CustUI.BackstageTab openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.IdMso = new StringValue { Value = value };
    else
      openXmlElement.IdMso = null;
  }
  
  /// <summary>
  /// insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertAfterMso(DXO2010CustUI.BackstageTab openXmlElement)
  {
    return openXmlElement?.InsertAfterMso?.Value;
  }
  
  private static void SetInsertAfterMso(DXO2010CustUI.BackstageTab openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterMso = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterMso = null;
  }
  
  /// <summary>
  /// insertBeforeMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertBeforeMso(DXO2010CustUI.BackstageTab openXmlElement)
  {
    return openXmlElement?.InsertBeforeMso?.Value;
  }
  
  private static void SetInsertBeforeMso(DXO2010CustUI.BackstageTab openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeMso = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeMso = null;
  }
  
  /// <summary>
  /// insertAfterQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertAfterQulifiedId(DXO2010CustUI.BackstageTab openXmlElement)
  {
    return openXmlElement?.InsertAfterQulifiedId?.Value;
  }
  
  private static void SetInsertAfterQulifiedId(DXO2010CustUI.BackstageTab openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterQulifiedId = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterQulifiedId = null;
  }
  
  /// <summary>
  /// insertBeforeQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertBeforeQulifiedId(DXO2010CustUI.BackstageTab openXmlElement)
  {
    return openXmlElement?.InsertBeforeQulifiedId?.Value;
  }
  
  private static void SetInsertBeforeQulifiedId(DXO2010CustUI.BackstageTab openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeQulifiedId = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeQulifiedId = null;
  }
  
  /// <summary>
  /// enabled, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetEnabled(DXO2010CustUI.BackstageTab openXmlElement)
  {
    return openXmlElement?.Enabled?.Value;
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
    return openXmlElement?.GetEnabled?.Value;
  }
  
  private static void SetGetEnabled(DXO2010CustUI.BackstageTab openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetEnabled = new StringValue { Value = value };
    else
      openXmlElement.GetEnabled = null;
  }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetLabel(DXO2010CustUI.BackstageTab openXmlElement)
  {
    return openXmlElement?.Label?.Value;
  }
  
  private static void SetLabel(DXO2010CustUI.BackstageTab openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Label = new StringValue { Value = value };
    else
      openXmlElement.Label = null;
  }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetLabel(DXO2010CustUI.BackstageTab openXmlElement)
  {
    return openXmlElement?.GetLabel?.Value;
  }
  
  private static void SetGetLabel(DXO2010CustUI.BackstageTab openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetLabel = new StringValue { Value = value };
    else
      openXmlElement.GetLabel = null;
  }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetVisible(DXO2010CustUI.BackstageTab openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
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
    return openXmlElement?.GetVisible?.Value;
  }
  
  private static void SetGetVisible(DXO2010CustUI.BackstageTab openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetVisible = new StringValue { Value = value };
    else
      openXmlElement.GetVisible = null;
  }
  
  /// <summary>
  /// keytip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetKeytip(DXO2010CustUI.BackstageTab openXmlElement)
  {
    return openXmlElement?.Keytip?.Value;
  }
  
  private static void SetKeytip(DXO2010CustUI.BackstageTab openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Keytip = new StringValue { Value = value };
    else
      openXmlElement.Keytip = null;
  }
  
  /// <summary>
  /// getKeytip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetKeytip(DXO2010CustUI.BackstageTab openXmlElement)
  {
    return openXmlElement?.GetKeytip?.Value;
  }
  
  private static void SetGetKeytip(DXO2010CustUI.BackstageTab openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetKeytip = new StringValue { Value = value };
    else
      openXmlElement.GetKeytip = null;
  }
  
  /// <summary>
  /// title, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetTitle(DXO2010CustUI.BackstageTab openXmlElement)
  {
    return openXmlElement?.Title?.Value;
  }
  
  private static void SetTitle(DXO2010CustUI.BackstageTab openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Title = new StringValue { Value = value };
    else
      openXmlElement.Title = null;
  }
  
  /// <summary>
  /// getTitle, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetTitle(DXO2010CustUI.BackstageTab openXmlElement)
  {
    return openXmlElement?.GetTitle?.Value;
  }
  
  private static void SetGetTitle(DXO2010CustUI.BackstageTab openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetTitle = new StringValue { Value = value };
    else
      openXmlElement.GetTitle = null;
  }
  
  /// <summary>
  /// columnWidthPercent, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int64? GetColumnWidthPercent(DXO2010CustUI.BackstageTab openXmlElement)
  {
    return openXmlElement.ColumnWidthPercent?.Value;
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
    return openXmlElement.FirstColumnMinWidth?.Value;
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
    return openXmlElement.FirstColumnMaxWidth?.Value;
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
    return openXmlElement.SecondColumnMinWidth?.Value;
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
    return openXmlElement.SecondColumnMaxWidth?.Value;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageGroups>();
    if (itemElement != null)
      return DMX.BackstageGroupsConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.SimpleGroups>();
    if (itemElement != null)
      return DMX.SimpleGroupsConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DM.BackstageTab? CreateModelElement(DXO2010CustUI.BackstageTab? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.BackstageTab();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.BackstageTab? value)
    where OpenXmlElementType: DXO2010CustUI.BackstageTab, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      return openXmlElement;
    }
    return default;
  }
}
