namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the DropDownRegular Class.
/// </summary>
public static class DropDownRegularConverter
{
  /// <summary>
  /// onAction, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetOnAction(DXO2010CustUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.OnAction?.Value;
  }
  
  private static bool CmpOnAction(DXO2010CustUI.DropDownRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.OnAction?.Value == value;
  }
  
  private static void SetOnAction(DXO2010CustUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.OnAction = new StringValue { Value = value };
    else
      openXmlElement.OnAction = null;
  }
  
  /// <summary>
  /// enabled, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetEnabled(DXO2010CustUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.Enabled?.Value;
  }
  
  private static bool CmpEnabled(DXO2010CustUI.DropDownRegular openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Enabled?.Value == value;
  }
  
  private static void SetEnabled(DXO2010CustUI.DropDownRegular openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Enabled = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Enabled = null;
  }
  
  /// <summary>
  /// getEnabled, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetEnabled(DXO2010CustUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.GetEnabled?.Value;
  }
  
  private static bool CmpGetEnabled(DXO2010CustUI.DropDownRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetEnabled?.Value == value;
  }
  
  private static void SetGetEnabled(DXO2010CustUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetEnabled = new StringValue { Value = value };
    else
      openXmlElement.GetEnabled = null;
  }
  
  /// <summary>
  /// image, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetImage(DXO2010CustUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.Image?.Value;
  }
  
  private static bool CmpImage(DXO2010CustUI.DropDownRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Image?.Value == value;
  }
  
  private static void SetImage(DXO2010CustUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Image = new StringValue { Value = value };
    else
      openXmlElement.Image = null;
  }
  
  /// <summary>
  /// imageMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetImageMso(DXO2010CustUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.ImageMso?.Value;
  }
  
  private static bool CmpImageMso(DXO2010CustUI.DropDownRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ImageMso?.Value == value;
  }
  
  private static void SetImageMso(DXO2010CustUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ImageMso = new StringValue { Value = value };
    else
      openXmlElement.ImageMso = null;
  }
  
  /// <summary>
  /// getImage, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetImage(DXO2010CustUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.GetImage?.Value;
  }
  
  private static bool CmpGetImage(DXO2010CustUI.DropDownRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetImage?.Value == value;
  }
  
  private static void SetGetImage(DXO2010CustUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetImage = new StringValue { Value = value };
    else
      openXmlElement.GetImage = null;
  }
  
  /// <summary>
  /// showItemImage, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetShowItemImage(DXO2010CustUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.ShowItemImage?.Value;
  }
  
  private static bool CmpShowItemImage(DXO2010CustUI.DropDownRegular openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ShowItemImage?.Value == value;
  }
  
  private static void SetShowItemImage(DXO2010CustUI.DropDownRegular openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowItemImage = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowItemImage = null;
  }
  
  /// <summary>
  /// getItemCount, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetItemCount(DXO2010CustUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.GetItemCount?.Value;
  }
  
  private static bool CmpGetItemCount(DXO2010CustUI.DropDownRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetItemCount?.Value == value;
  }
  
  private static void SetGetItemCount(DXO2010CustUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetItemCount = new StringValue { Value = value };
    else
      openXmlElement.GetItemCount = null;
  }
  
  /// <summary>
  /// getItemLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetItemLabel(DXO2010CustUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.GetItemLabel?.Value;
  }
  
  private static bool CmpGetItemLabel(DXO2010CustUI.DropDownRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetItemLabel?.Value == value;
  }
  
  private static void SetGetItemLabel(DXO2010CustUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetItemLabel = new StringValue { Value = value };
    else
      openXmlElement.GetItemLabel = null;
  }
  
  /// <summary>
  /// getItemScreentip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetItemScreentip(DXO2010CustUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.GetItemScreentip?.Value;
  }
  
  private static bool CmpGetItemScreentip(DXO2010CustUI.DropDownRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetItemScreentip?.Value == value;
  }
  
  private static void SetGetItemScreentip(DXO2010CustUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetItemScreentip = new StringValue { Value = value };
    else
      openXmlElement.GetItemScreentip = null;
  }
  
  /// <summary>
  /// getItemSupertip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetItemSupertip(DXO2010CustUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.GetItemSupertip?.Value;
  }
  
  private static bool CmpGetItemSupertip(DXO2010CustUI.DropDownRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetItemSupertip?.Value == value;
  }
  
  private static void SetGetItemSupertip(DXO2010CustUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetItemSupertip = new StringValue { Value = value };
    else
      openXmlElement.GetItemSupertip = null;
  }
  
  /// <summary>
  /// getItemImage, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetItemImage(DXO2010CustUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.GetItemImage?.Value;
  }
  
  private static bool CmpGetItemImage(DXO2010CustUI.DropDownRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetItemImage?.Value == value;
  }
  
  private static void SetGetItemImage(DXO2010CustUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetItemImage = new StringValue { Value = value };
    else
      openXmlElement.GetItemImage = null;
  }
  
  /// <summary>
  /// getItemID, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetItemID(DXO2010CustUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.GetItemID?.Value;
  }
  
  private static bool CmpGetItemID(DXO2010CustUI.DropDownRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetItemID?.Value == value;
  }
  
  private static void SetGetItemID(DXO2010CustUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetItemID = new StringValue { Value = value };
    else
      openXmlElement.GetItemID = null;
  }
  
  /// <summary>
  /// sizeString, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetSizeString(DXO2010CustUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.SizeString?.Value;
  }
  
  private static bool CmpSizeString(DXO2010CustUI.DropDownRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.SizeString?.Value == value;
  }
  
  private static void SetSizeString(DXO2010CustUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.SizeString = new StringValue { Value = value };
    else
      openXmlElement.SizeString = null;
  }
  
  /// <summary>
  /// getSelectedItemID, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetSelectedItemID(DXO2010CustUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.GetSelectedItemID?.Value;
  }
  
  private static bool CmpGetSelectedItemID(DXO2010CustUI.DropDownRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetSelectedItemID?.Value == value;
  }
  
  private static void SetGetSelectedItemID(DXO2010CustUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetSelectedItemID = new StringValue { Value = value };
    else
      openXmlElement.GetSelectedItemID = null;
  }
  
  /// <summary>
  /// getSelectedItemIndex, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetSelectedItemIndex(DXO2010CustUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.GetSelectedItemIndex?.Value;
  }
  
  private static bool CmpGetSelectedItemIndex(DXO2010CustUI.DropDownRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetSelectedItemIndex?.Value == value;
  }
  
  private static void SetGetSelectedItemIndex(DXO2010CustUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetSelectedItemIndex = new StringValue { Value = value };
    else
      openXmlElement.GetSelectedItemIndex = null;
  }
  
  /// <summary>
  /// showItemLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetShowItemLabel(DXO2010CustUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.ShowItemLabel?.Value;
  }
  
  private static bool CmpShowItemLabel(DXO2010CustUI.DropDownRegular openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ShowItemLabel?.Value == value;
  }
  
  private static void SetShowItemLabel(DXO2010CustUI.DropDownRegular openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowItemLabel = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowItemLabel = null;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetId(DXO2010CustUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXO2010CustUI.DropDownRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Id?.Value == value;
  }
  
  private static void SetId(DXO2010CustUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetQualifiedId(DXO2010CustUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.QualifiedId?.Value;
  }
  
  private static bool CmpQualifiedId(DXO2010CustUI.DropDownRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.QualifiedId?.Value == value;
  }
  
  private static void SetQualifiedId(DXO2010CustUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.QualifiedId = new StringValue { Value = value };
    else
      openXmlElement.QualifiedId = null;
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetTag(DXO2010CustUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }
  
  private static bool CmpTag(DXO2010CustUI.DropDownRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Tag?.Value == value;
  }
  
  private static void SetTag(DXO2010CustUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Tag = new StringValue { Value = value };
    else
      openXmlElement.Tag = null;
  }
  
  /// <summary>
  /// idMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetIdMso(DXO2010CustUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.IdMso?.Value;
  }
  
  private static bool CmpIdMso(DXO2010CustUI.DropDownRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.IdMso?.Value == value;
  }
  
  private static void SetIdMso(DXO2010CustUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.IdMso = new StringValue { Value = value };
    else
      openXmlElement.IdMso = null;
  }
  
  /// <summary>
  /// screentip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetScreentip(DXO2010CustUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.Screentip?.Value;
  }
  
  private static bool CmpScreentip(DXO2010CustUI.DropDownRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Screentip?.Value == value;
  }
  
  private static void SetScreentip(DXO2010CustUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Screentip = new StringValue { Value = value };
    else
      openXmlElement.Screentip = null;
  }
  
  /// <summary>
  /// getScreentip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetScreentip(DXO2010CustUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.GetScreentip?.Value;
  }
  
  private static bool CmpGetScreentip(DXO2010CustUI.DropDownRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetScreentip?.Value == value;
  }
  
  private static void SetGetScreentip(DXO2010CustUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetScreentip = new StringValue { Value = value };
    else
      openXmlElement.GetScreentip = null;
  }
  
  /// <summary>
  /// supertip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetSupertip(DXO2010CustUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.Supertip?.Value;
  }
  
  private static bool CmpSupertip(DXO2010CustUI.DropDownRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Supertip?.Value == value;
  }
  
  private static void SetSupertip(DXO2010CustUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Supertip = new StringValue { Value = value };
    else
      openXmlElement.Supertip = null;
  }
  
  /// <summary>
  /// getSupertip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetSupertip(DXO2010CustUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.GetSupertip?.Value;
  }
  
  private static bool CmpGetSupertip(DXO2010CustUI.DropDownRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetSupertip?.Value == value;
  }
  
  private static void SetGetSupertip(DXO2010CustUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetSupertip = new StringValue { Value = value };
    else
      openXmlElement.GetSupertip = null;
  }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetLabel(DXO2010CustUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.Label?.Value;
  }
  
  private static bool CmpLabel(DXO2010CustUI.DropDownRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Label?.Value == value;
  }
  
  private static void SetLabel(DXO2010CustUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Label = new StringValue { Value = value };
    else
      openXmlElement.Label = null;
  }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetLabel(DXO2010CustUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.GetLabel?.Value;
  }
  
  private static bool CmpGetLabel(DXO2010CustUI.DropDownRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetLabel?.Value == value;
  }
  
  private static void SetGetLabel(DXO2010CustUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetLabel = new StringValue { Value = value };
    else
      openXmlElement.GetLabel = null;
  }
  
  /// <summary>
  /// insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertAfterMso(DXO2010CustUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.InsertAfterMso?.Value;
  }
  
  private static bool CmpInsertAfterMso(DXO2010CustUI.DropDownRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.InsertAfterMso?.Value == value;
  }
  
  private static void SetInsertAfterMso(DXO2010CustUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterMso = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterMso = null;
  }
  
  /// <summary>
  /// insertBeforeMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertBeforeMso(DXO2010CustUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.InsertBeforeMso?.Value;
  }
  
  private static bool CmpInsertBeforeMso(DXO2010CustUI.DropDownRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.InsertBeforeMso?.Value == value;
  }
  
  private static void SetInsertBeforeMso(DXO2010CustUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeMso = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeMso = null;
  }
  
  /// <summary>
  /// insertAfterQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertAfterQulifiedId(DXO2010CustUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.InsertAfterQulifiedId?.Value;
  }
  
  private static bool CmpInsertAfterQulifiedId(DXO2010CustUI.DropDownRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.InsertAfterQulifiedId?.Value == value;
  }
  
  private static void SetInsertAfterQulifiedId(DXO2010CustUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterQulifiedId = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterQulifiedId = null;
  }
  
  /// <summary>
  /// insertBeforeQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertBeforeQulifiedId(DXO2010CustUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.InsertBeforeQulifiedId?.Value;
  }
  
  private static bool CmpInsertBeforeQulifiedId(DXO2010CustUI.DropDownRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.InsertBeforeQulifiedId?.Value == value;
  }
  
  private static void SetInsertBeforeQulifiedId(DXO2010CustUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeQulifiedId = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeQulifiedId = null;
  }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetVisible(DXO2010CustUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static bool CmpVisible(DXO2010CustUI.DropDownRegular openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Visible?.Value == value;
  }
  
  private static void SetVisible(DXO2010CustUI.DropDownRegular openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetVisible(DXO2010CustUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }
  
  private static bool CmpGetVisible(DXO2010CustUI.DropDownRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetVisible?.Value == value;
  }
  
  private static void SetGetVisible(DXO2010CustUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetVisible = new StringValue { Value = value };
    else
      openXmlElement.GetVisible = null;
  }
  
  /// <summary>
  /// keytip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetKeytip(DXO2010CustUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.Keytip?.Value;
  }
  
  private static bool CmpKeytip(DXO2010CustUI.DropDownRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Keytip?.Value == value;
  }
  
  private static void SetKeytip(DXO2010CustUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Keytip = new StringValue { Value = value };
    else
      openXmlElement.Keytip = null;
  }
  
  /// <summary>
  /// getKeytip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetKeytip(DXO2010CustUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.GetKeytip?.Value;
  }
  
  private static bool CmpGetKeytip(DXO2010CustUI.DropDownRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetKeytip?.Value == value;
  }
  
  private static void SetGetKeytip(DXO2010CustUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetKeytip = new StringValue { Value = value };
    else
      openXmlElement.GetKeytip = null;
  }
  
  /// <summary>
  /// showLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetShowLabel(DXO2010CustUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.ShowLabel?.Value;
  }
  
  private static bool CmpShowLabel(DXO2010CustUI.DropDownRegular openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ShowLabel?.Value == value;
  }
  
  private static void SetShowLabel(DXO2010CustUI.DropDownRegular openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowLabel = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowLabel = null;
  }
  
  /// <summary>
  /// getShowLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetShowLabel(DXO2010CustUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.GetShowLabel?.Value;
  }
  
  private static bool CmpGetShowLabel(DXO2010CustUI.DropDownRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetShowLabel?.Value == value;
  }
  
  private static void SetGetShowLabel(DXO2010CustUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetShowLabel = new StringValue { Value = value };
    else
      openXmlElement.GetShowLabel = null;
  }
  
  /// <summary>
  /// showImage, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetShowImage(DXO2010CustUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.ShowImage?.Value;
  }
  
  private static bool CmpShowImage(DXO2010CustUI.DropDownRegular openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ShowImage?.Value == value;
  }
  
  private static void SetShowImage(DXO2010CustUI.DropDownRegular openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowImage = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowImage = null;
  }
  
  /// <summary>
  /// getShowImage, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetShowImage(DXO2010CustUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.GetShowImage?.Value;
  }
  
  private static bool CmpGetShowImage(DXO2010CustUI.DropDownRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetShowImage?.Value == value;
  }
  
  private static void SetGetShowImage(DXO2010CustUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetShowImage = new StringValue { Value = value };
    else
      openXmlElement.GetShowImage = null;
  }
  
  private static Collection<DM.Item> GetItems(DXO2010CustUI.DropDownRegular openXmlElement)
  {
    var collection = new Collection<DM.Item>();
    foreach (var item in openXmlElement.Elements<DXO2010CustUI.Item>())
    {
      var newItem = DMX.ItemConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpItems(DXO2010CustUI.DropDownRegular openXmlElement, Collection<DM.Item>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetItems(DXO2010CustUI.DropDownRegular openXmlElement, Collection<DM.Item>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2010CustUI.Item>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMX.ItemConverter.CreateOpenXmlElement<DXO2010CustUI.Item>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static Collection<DM.ButtonRegular> GetButtonRegulars(DXO2010CustUI.DropDownRegular openXmlElement)
  {
    var collection = new Collection<DM.ButtonRegular>();
    foreach (var item in openXmlElement.Elements<DXO2010CustUI.ButtonRegular>())
    {
      var newItem = DMX.ButtonRegularConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpButtonRegulars(DXO2010CustUI.DropDownRegular openXmlElement, Collection<DM.ButtonRegular>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetButtonRegulars(DXO2010CustUI.DropDownRegular openXmlElement, Collection<DM.ButtonRegular>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2010CustUI.ButtonRegular>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMX.ButtonRegularConverter.CreateOpenXmlElement<DXO2010CustUI.ButtonRegular>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DM.DropDownRegular? CreateModelElement(DXO2010CustUI.DropDownRegular? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.DropDownRegular();
      value.OnAction = GetOnAction(openXmlElement);
      value.Enabled = GetEnabled(openXmlElement);
      value.GetEnabled = GetGetEnabled(openXmlElement);
      value.Image = GetImage(openXmlElement);
      value.ImageMso = GetImageMso(openXmlElement);
      value.GetImage = GetGetImage(openXmlElement);
      value.ShowItemImage = GetShowItemImage(openXmlElement);
      value.GetItemCount = GetGetItemCount(openXmlElement);
      value.GetItemLabel = GetGetItemLabel(openXmlElement);
      value.GetItemScreentip = GetGetItemScreentip(openXmlElement);
      value.GetItemSupertip = GetGetItemSupertip(openXmlElement);
      value.GetItemImage = GetGetItemImage(openXmlElement);
      value.GetItemID = GetGetItemID(openXmlElement);
      value.SizeString = GetSizeString(openXmlElement);
      value.GetSelectedItemID = GetGetSelectedItemID(openXmlElement);
      value.GetSelectedItemIndex = GetGetSelectedItemIndex(openXmlElement);
      value.ShowItemLabel = GetShowItemLabel(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.QualifiedId = GetQualifiedId(openXmlElement);
      value.Tag = GetTag(openXmlElement);
      value.IdMso = GetIdMso(openXmlElement);
      value.Screentip = GetScreentip(openXmlElement);
      value.GetScreentip = GetGetScreentip(openXmlElement);
      value.Supertip = GetSupertip(openXmlElement);
      value.GetSupertip = GetGetSupertip(openXmlElement);
      value.Label = GetLabel(openXmlElement);
      value.GetLabel = GetGetLabel(openXmlElement);
      value.InsertAfterMso = GetInsertAfterMso(openXmlElement);
      value.InsertBeforeMso = GetInsertBeforeMso(openXmlElement);
      value.InsertAfterQulifiedId = GetInsertAfterQulifiedId(openXmlElement);
      value.InsertBeforeQulifiedId = GetInsertBeforeQulifiedId(openXmlElement);
      value.Visible = GetVisible(openXmlElement);
      value.GetVisible = GetGetVisible(openXmlElement);
      value.Keytip = GetKeytip(openXmlElement);
      value.GetKeytip = GetGetKeytip(openXmlElement);
      value.ShowLabel = GetShowLabel(openXmlElement);
      value.GetShowLabel = GetGetShowLabel(openXmlElement);
      value.ShowImage = GetShowImage(openXmlElement);
      value.GetShowImage = GetGetShowImage(openXmlElement);
      value.Items = GetItems(openXmlElement);
      value.ButtonRegulars = GetButtonRegulars(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010CustUI.DropDownRegular? openXmlElement, DM.DropDownRegular? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpOnAction(openXmlElement, value.OnAction, diffs, objName))
        ok = false;
      if (!CmpEnabled(openXmlElement, value.Enabled, diffs, objName))
        ok = false;
      if (!CmpGetEnabled(openXmlElement, value.GetEnabled, diffs, objName))
        ok = false;
      if (!CmpImage(openXmlElement, value.Image, diffs, objName))
        ok = false;
      if (!CmpImageMso(openXmlElement, value.ImageMso, diffs, objName))
        ok = false;
      if (!CmpGetImage(openXmlElement, value.GetImage, diffs, objName))
        ok = false;
      if (!CmpShowItemImage(openXmlElement, value.ShowItemImage, diffs, objName))
        ok = false;
      if (!CmpGetItemCount(openXmlElement, value.GetItemCount, diffs, objName))
        ok = false;
      if (!CmpGetItemLabel(openXmlElement, value.GetItemLabel, diffs, objName))
        ok = false;
      if (!CmpGetItemScreentip(openXmlElement, value.GetItemScreentip, diffs, objName))
        ok = false;
      if (!CmpGetItemSupertip(openXmlElement, value.GetItemSupertip, diffs, objName))
        ok = false;
      if (!CmpGetItemImage(openXmlElement, value.GetItemImage, diffs, objName))
        ok = false;
      if (!CmpGetItemID(openXmlElement, value.GetItemID, diffs, objName))
        ok = false;
      if (!CmpSizeString(openXmlElement, value.SizeString, diffs, objName))
        ok = false;
      if (!CmpGetSelectedItemID(openXmlElement, value.GetSelectedItemID, diffs, objName))
        ok = false;
      if (!CmpGetSelectedItemIndex(openXmlElement, value.GetSelectedItemIndex, diffs, objName))
        ok = false;
      if (!CmpShowItemLabel(openXmlElement, value.ShowItemLabel, diffs, objName))
        ok = false;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpQualifiedId(openXmlElement, value.QualifiedId, diffs, objName))
        ok = false;
      if (!CmpTag(openXmlElement, value.Tag, diffs, objName))
        ok = false;
      if (!CmpIdMso(openXmlElement, value.IdMso, diffs, objName))
        ok = false;
      if (!CmpScreentip(openXmlElement, value.Screentip, diffs, objName))
        ok = false;
      if (!CmpGetScreentip(openXmlElement, value.GetScreentip, diffs, objName))
        ok = false;
      if (!CmpSupertip(openXmlElement, value.Supertip, diffs, objName))
        ok = false;
      if (!CmpGetSupertip(openXmlElement, value.GetSupertip, diffs, objName))
        ok = false;
      if (!CmpLabel(openXmlElement, value.Label, diffs, objName))
        ok = false;
      if (!CmpGetLabel(openXmlElement, value.GetLabel, diffs, objName))
        ok = false;
      if (!CmpInsertAfterMso(openXmlElement, value.InsertAfterMso, diffs, objName))
        ok = false;
      if (!CmpInsertBeforeMso(openXmlElement, value.InsertBeforeMso, diffs, objName))
        ok = false;
      if (!CmpInsertAfterQulifiedId(openXmlElement, value.InsertAfterQulifiedId, diffs, objName))
        ok = false;
      if (!CmpInsertBeforeQulifiedId(openXmlElement, value.InsertBeforeQulifiedId, diffs, objName))
        ok = false;
      if (!CmpVisible(openXmlElement, value.Visible, diffs, objName))
        ok = false;
      if (!CmpGetVisible(openXmlElement, value.GetVisible, diffs, objName))
        ok = false;
      if (!CmpKeytip(openXmlElement, value.Keytip, diffs, objName))
        ok = false;
      if (!CmpGetKeytip(openXmlElement, value.GetKeytip, diffs, objName))
        ok = false;
      if (!CmpShowLabel(openXmlElement, value.ShowLabel, diffs, objName))
        ok = false;
      if (!CmpGetShowLabel(openXmlElement, value.GetShowLabel, diffs, objName))
        ok = false;
      if (!CmpShowImage(openXmlElement, value.ShowImage, diffs, objName))
        ok = false;
      if (!CmpGetShowImage(openXmlElement, value.GetShowImage, diffs, objName))
        ok = false;
      if (!CmpItems(openXmlElement, value.Items, diffs, objName))
        ok = false;
      if (!CmpButtonRegulars(openXmlElement, value.ButtonRegulars, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.DropDownRegular? value)
    where OpenXmlElementType: DXO2010CustUI.DropDownRegular, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetOnAction(openXmlElement, value?.OnAction);
      SetEnabled(openXmlElement, value?.Enabled);
      SetGetEnabled(openXmlElement, value?.GetEnabled);
      SetImage(openXmlElement, value?.Image);
      SetImageMso(openXmlElement, value?.ImageMso);
      SetGetImage(openXmlElement, value?.GetImage);
      SetShowItemImage(openXmlElement, value?.ShowItemImage);
      SetGetItemCount(openXmlElement, value?.GetItemCount);
      SetGetItemLabel(openXmlElement, value?.GetItemLabel);
      SetGetItemScreentip(openXmlElement, value?.GetItemScreentip);
      SetGetItemSupertip(openXmlElement, value?.GetItemSupertip);
      SetGetItemImage(openXmlElement, value?.GetItemImage);
      SetGetItemID(openXmlElement, value?.GetItemID);
      SetSizeString(openXmlElement, value?.SizeString);
      SetGetSelectedItemID(openXmlElement, value?.GetSelectedItemID);
      SetGetSelectedItemIndex(openXmlElement, value?.GetSelectedItemIndex);
      SetShowItemLabel(openXmlElement, value?.ShowItemLabel);
      SetId(openXmlElement, value?.Id);
      SetQualifiedId(openXmlElement, value?.QualifiedId);
      SetTag(openXmlElement, value?.Tag);
      SetIdMso(openXmlElement, value?.IdMso);
      SetScreentip(openXmlElement, value?.Screentip);
      SetGetScreentip(openXmlElement, value?.GetScreentip);
      SetSupertip(openXmlElement, value?.Supertip);
      SetGetSupertip(openXmlElement, value?.GetSupertip);
      SetLabel(openXmlElement, value?.Label);
      SetGetLabel(openXmlElement, value?.GetLabel);
      SetInsertAfterMso(openXmlElement, value?.InsertAfterMso);
      SetInsertBeforeMso(openXmlElement, value?.InsertBeforeMso);
      SetInsertAfterQulifiedId(openXmlElement, value?.InsertAfterQulifiedId);
      SetInsertBeforeQulifiedId(openXmlElement, value?.InsertBeforeQulifiedId);
      SetVisible(openXmlElement, value?.Visible);
      SetGetVisible(openXmlElement, value?.GetVisible);
      SetKeytip(openXmlElement, value?.Keytip);
      SetGetKeytip(openXmlElement, value?.GetKeytip);
      SetShowLabel(openXmlElement, value?.ShowLabel);
      SetGetShowLabel(openXmlElement, value?.GetShowLabel);
      SetShowImage(openXmlElement, value?.ShowImage);
      SetGetShowImage(openXmlElement, value?.GetShowImage);
      SetItems(openXmlElement, value?.Items);
      SetButtonRegulars(openXmlElement, value?.ButtonRegulars);
      return openXmlElement;
    }
    return default;
  }
}
