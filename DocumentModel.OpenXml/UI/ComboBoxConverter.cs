namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the ComboBox Class.
/// </summary>
public static class ComboBoxConverter
{
  /// <summary>
  /// showItemImage
  /// </summary>
  private static Boolean? GetShowItemImage(DXOCustUI.ComboBox openXmlElement)
  {
    return openXmlElement?.ShowItemImage?.Value;
  }
  
  private static bool CmpShowItemImage(DXOCustUI.ComboBox openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ShowItemImage?.Value == value) return true;
    diffs?.Add(objName, "ShowItemImage", openXmlElement?.ShowItemImage?.Value, value);
    return false;
  }
  
  private static void SetShowItemImage(DXOCustUI.ComboBox openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowItemImage = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowItemImage = null;
  }
  
  /// <summary>
  /// getItemCount
  /// </summary>
  private static String? GetGetItemCount(DXOCustUI.ComboBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetItemCount);
  }
  
  private static bool CmpGetItemCount(DXOCustUI.ComboBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetItemCount, value, diffs, objName, "GetItemCount");
  }
  
  private static void SetGetItemCount(DXOCustUI.ComboBox openXmlElement, String? value)
  {
    openXmlElement.GetItemCount = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getItemLabel
  /// </summary>
  private static String? GetGetItemLabel(DXOCustUI.ComboBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetItemLabel);
  }
  
  private static bool CmpGetItemLabel(DXOCustUI.ComboBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetItemLabel, value, diffs, objName, "GetItemLabel");
  }
  
  private static void SetGetItemLabel(DXOCustUI.ComboBox openXmlElement, String? value)
  {
    openXmlElement.GetItemLabel = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getItemScreentip
  /// </summary>
  private static String? GetGetItemScreentip(DXOCustUI.ComboBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetItemScreentip);
  }
  
  private static bool CmpGetItemScreentip(DXOCustUI.ComboBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetItemScreentip, value, diffs, objName, "GetItemScreentip");
  }
  
  private static void SetGetItemScreentip(DXOCustUI.ComboBox openXmlElement, String? value)
  {
    openXmlElement.GetItemScreentip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getItemSupertip
  /// </summary>
  private static String? GetGetItemSupertip(DXOCustUI.ComboBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetItemSupertip);
  }
  
  private static bool CmpGetItemSupertip(DXOCustUI.ComboBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetItemSupertip, value, diffs, objName, "GetItemSupertip");
  }
  
  private static void SetGetItemSupertip(DXOCustUI.ComboBox openXmlElement, String? value)
  {
    openXmlElement.GetItemSupertip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getItemImage
  /// </summary>
  private static String? GetGetItemImage(DXOCustUI.ComboBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetItemImage);
  }
  
  private static bool CmpGetItemImage(DXOCustUI.ComboBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetItemImage, value, diffs, objName, "GetItemImage");
  }
  
  private static void SetGetItemImage(DXOCustUI.ComboBox openXmlElement, String? value)
  {
    openXmlElement.GetItemImage = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getItemID
  /// </summary>
  private static String? GetGetItemID(DXOCustUI.ComboBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetItemID);
  }
  
  private static bool CmpGetItemID(DXOCustUI.ComboBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetItemID, value, diffs, objName, "GetItemID");
  }
  
  private static void SetGetItemID(DXOCustUI.ComboBox openXmlElement, String? value)
  {
    openXmlElement.GetItemID = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// sizeString
  /// </summary>
  private static String? GetSizeString(DXOCustUI.ComboBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.SizeString);
  }
  
  private static bool CmpSizeString(DXOCustUI.ComboBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.SizeString, value, diffs, objName, "SizeString");
  }
  
  private static void SetSizeString(DXOCustUI.ComboBox openXmlElement, String? value)
  {
    openXmlElement.SizeString = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// invalidateContentOnDrop
  /// </summary>
  private static Boolean? GetInvalidateContentOnDrop(DXOCustUI.ComboBox openXmlElement)
  {
    return openXmlElement?.InvalidateContentOnDrop?.Value;
  }
  
  private static bool CmpInvalidateContentOnDrop(DXOCustUI.ComboBox openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.InvalidateContentOnDrop?.Value == value) return true;
    diffs?.Add(objName, "InvalidateContentOnDrop", openXmlElement?.InvalidateContentOnDrop?.Value, value);
    return false;
  }
  
  private static void SetInvalidateContentOnDrop(DXOCustUI.ComboBox openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.InvalidateContentOnDrop = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.InvalidateContentOnDrop = null;
  }
  
  /// <summary>
  /// enabled
  /// </summary>
  private static Boolean? GetEnabled(DXOCustUI.ComboBox openXmlElement)
  {
    return openXmlElement?.Enabled?.Value;
  }
  
  private static bool CmpEnabled(DXOCustUI.ComboBox openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Enabled?.Value == value) return true;
    diffs?.Add(objName, "Enabled", openXmlElement?.Enabled?.Value, value);
    return false;
  }
  
  private static void SetEnabled(DXOCustUI.ComboBox openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Enabled = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Enabled = null;
  }
  
  /// <summary>
  /// getEnabled
  /// </summary>
  private static String? GetGetEnabled(DXOCustUI.ComboBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetEnabled);
  }
  
  private static bool CmpGetEnabled(DXOCustUI.ComboBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetEnabled, value, diffs, objName, "GetEnabled");
  }
  
  private static void SetGetEnabled(DXOCustUI.ComboBox openXmlElement, String? value)
  {
    openXmlElement.GetEnabled = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// image
  /// </summary>
  private static String? GetImage(DXOCustUI.ComboBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Image);
  }
  
  private static bool CmpImage(DXOCustUI.ComboBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Image, value, diffs, objName, "Image");
  }
  
  private static void SetImage(DXOCustUI.ComboBox openXmlElement, String? value)
  {
    openXmlElement.Image = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// imageMso
  /// </summary>
  private static String? GetImageMso(DXOCustUI.ComboBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ImageMso);
  }
  
  private static bool CmpImageMso(DXOCustUI.ComboBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ImageMso, value, diffs, objName, "ImageMso");
  }
  
  private static void SetImageMso(DXOCustUI.ComboBox openXmlElement, String? value)
  {
    openXmlElement.ImageMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getImage
  /// </summary>
  private static String? GetGetImage(DXOCustUI.ComboBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetImage);
  }
  
  private static bool CmpGetImage(DXOCustUI.ComboBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetImage, value, diffs, objName, "GetImage");
  }
  
  private static void SetGetImage(DXOCustUI.ComboBox openXmlElement, String? value)
  {
    openXmlElement.GetImage = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// maxLength
  /// </summary>
  private static Int64? GetMaxLength(DXOCustUI.ComboBox openXmlElement)
  {
    return openXmlElement?.MaxLength?.Value;
  }
  
  private static bool CmpMaxLength(DXOCustUI.ComboBox openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.MaxLength?.Value == value) return true;
    diffs?.Add(objName, "MaxLength", openXmlElement?.MaxLength?.Value, value);
    return false;
  }
  
  private static void SetMaxLength(DXOCustUI.ComboBox openXmlElement, Int64? value)
  {
    openXmlElement.MaxLength = value;
  }
  
  /// <summary>
  /// getText
  /// </summary>
  private static String? GetGetText(DXOCustUI.ComboBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetText);
  }
  
  private static bool CmpGetText(DXOCustUI.ComboBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetText, value, diffs, objName, "GetText");
  }
  
  private static void SetGetText(DXOCustUI.ComboBox openXmlElement, String? value)
  {
    openXmlElement.GetText = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// onChange
  /// </summary>
  private static String? GetOnChange(DXOCustUI.ComboBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.OnChange);
  }
  
  private static bool CmpOnChange(DXOCustUI.ComboBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.OnChange, value, diffs, objName, "OnChange");
  }
  
  private static void SetOnChange(DXOCustUI.ComboBox openXmlElement, String? value)
  {
    openXmlElement.OnChange = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// id
  /// </summary>
  private static String? GetId(DXOCustUI.ComboBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXOCustUI.ComboBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "Id");
  }
  
  private static void SetId(DXOCustUI.ComboBox openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// idQ
  /// </summary>
  private static String? GetIdQ(DXOCustUI.ComboBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.IdQ);
  }
  
  private static bool CmpIdQ(DXOCustUI.ComboBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.IdQ, value, diffs, objName, "IdQ");
  }
  
  private static void SetIdQ(DXOCustUI.ComboBox openXmlElement, String? value)
  {
    openXmlElement.IdQ = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// idMso
  /// </summary>
  private static String? GetIdMso(DXOCustUI.ComboBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.IdMso);
  }
  
  private static bool CmpIdMso(DXOCustUI.ComboBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.IdMso, value, diffs, objName, "IdMso");
  }
  
  private static void SetIdMso(DXOCustUI.ComboBox openXmlElement, String? value)
  {
    openXmlElement.IdMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// tag
  /// </summary>
  private static String? GetTag(DXOCustUI.ComboBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Tag);
  }
  
  private static bool CmpTag(DXOCustUI.ComboBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Tag, value, diffs, objName, "Tag");
  }
  
  private static void SetTag(DXOCustUI.ComboBox openXmlElement, String? value)
  {
    openXmlElement.Tag = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// screentip
  /// </summary>
  private static String? GetScreentip(DXOCustUI.ComboBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Screentip);
  }
  
  private static bool CmpScreentip(DXOCustUI.ComboBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Screentip, value, diffs, objName, "Screentip");
  }
  
  private static void SetScreentip(DXOCustUI.ComboBox openXmlElement, String? value)
  {
    openXmlElement.Screentip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getScreentip
  /// </summary>
  private static String? GetGetScreentip(DXOCustUI.ComboBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetScreentip);
  }
  
  private static bool CmpGetScreentip(DXOCustUI.ComboBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetScreentip, value, diffs, objName, "GetScreentip");
  }
  
  private static void SetGetScreentip(DXOCustUI.ComboBox openXmlElement, String? value)
  {
    openXmlElement.GetScreentip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// supertip
  /// </summary>
  private static String? GetSupertip(DXOCustUI.ComboBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Supertip);
  }
  
  private static bool CmpSupertip(DXOCustUI.ComboBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Supertip, value, diffs, objName, "Supertip");
  }
  
  private static void SetSupertip(DXOCustUI.ComboBox openXmlElement, String? value)
  {
    openXmlElement.Supertip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getSupertip
  /// </summary>
  private static String? GetGetSupertip(DXOCustUI.ComboBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetSupertip);
  }
  
  private static bool CmpGetSupertip(DXOCustUI.ComboBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetSupertip, value, diffs, objName, "GetSupertip");
  }
  
  private static void SetGetSupertip(DXOCustUI.ComboBox openXmlElement, String? value)
  {
    openXmlElement.GetSupertip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// label
  /// </summary>
  private static String? GetLabel(DXOCustUI.ComboBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Label);
  }
  
  private static bool CmpLabel(DXOCustUI.ComboBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Label, value, diffs, objName, "Label");
  }
  
  private static void SetLabel(DXOCustUI.ComboBox openXmlElement, String? value)
  {
    openXmlElement.Label = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getLabel
  /// </summary>
  private static String? GetGetLabel(DXOCustUI.ComboBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetLabel);
  }
  
  private static bool CmpGetLabel(DXOCustUI.ComboBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetLabel, value, diffs, objName, "GetLabel");
  }
  
  private static void SetGetLabel(DXOCustUI.ComboBox openXmlElement, String? value)
  {
    openXmlElement.GetLabel = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertAfterMso
  /// </summary>
  private static String? GetInsertAfterMso(DXOCustUI.ComboBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertAfterMso);
  }
  
  private static bool CmpInsertAfterMso(DXOCustUI.ComboBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertAfterMso, value, diffs, objName, "InsertAfterMso");
  }
  
  private static void SetInsertAfterMso(DXOCustUI.ComboBox openXmlElement, String? value)
  {
    openXmlElement.InsertAfterMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertBeforeMso
  /// </summary>
  private static String? GetInsertBeforeMso(DXOCustUI.ComboBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertBeforeMso);
  }
  
  private static bool CmpInsertBeforeMso(DXOCustUI.ComboBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertBeforeMso, value, diffs, objName, "InsertBeforeMso");
  }
  
  private static void SetInsertBeforeMso(DXOCustUI.ComboBox openXmlElement, String? value)
  {
    openXmlElement.InsertBeforeMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertAfterQ
  /// </summary>
  private static String? GetInsertAfterQ(DXOCustUI.ComboBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertAfterQ);
  }
  
  private static bool CmpInsertAfterQ(DXOCustUI.ComboBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertAfterQ, value, diffs, objName, "InsertAfterQ");
  }
  
  private static void SetInsertAfterQ(DXOCustUI.ComboBox openXmlElement, String? value)
  {
    openXmlElement.InsertAfterQ = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertBeforeQ
  /// </summary>
  private static String? GetInsertBeforeQ(DXOCustUI.ComboBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertBeforeQ);
  }
  
  private static bool CmpInsertBeforeQ(DXOCustUI.ComboBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertBeforeQ, value, diffs, objName, "InsertBeforeQ");
  }
  
  private static void SetInsertBeforeQ(DXOCustUI.ComboBox openXmlElement, String? value)
  {
    openXmlElement.InsertBeforeQ = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// visible
  /// </summary>
  private static Boolean? GetVisible(DXOCustUI.ComboBox openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static bool CmpVisible(DXOCustUI.ComboBox openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Visible?.Value == value) return true;
    diffs?.Add(objName, "Visible", openXmlElement?.Visible?.Value, value);
    return false;
  }
  
  private static void SetVisible(DXOCustUI.ComboBox openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible
  /// </summary>
  private static String? GetGetVisible(DXOCustUI.ComboBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetVisible);
  }
  
  private static bool CmpGetVisible(DXOCustUI.ComboBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetVisible, value, diffs, objName, "GetVisible");
  }
  
  private static void SetGetVisible(DXOCustUI.ComboBox openXmlElement, String? value)
  {
    openXmlElement.GetVisible = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// keytip
  /// </summary>
  private static String? GetKeytip(DXOCustUI.ComboBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Keytip);
  }
  
  private static bool CmpKeytip(DXOCustUI.ComboBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Keytip, value, diffs, objName, "Keytip");
  }
  
  private static void SetKeytip(DXOCustUI.ComboBox openXmlElement, String? value)
  {
    openXmlElement.Keytip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getKeytip
  /// </summary>
  private static String? GetGetKeytip(DXOCustUI.ComboBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetKeytip);
  }
  
  private static bool CmpGetKeytip(DXOCustUI.ComboBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetKeytip, value, diffs, objName, "GetKeytip");
  }
  
  private static void SetGetKeytip(DXOCustUI.ComboBox openXmlElement, String? value)
  {
    openXmlElement.GetKeytip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// showLabel
  /// </summary>
  private static Boolean? GetShowLabel(DXOCustUI.ComboBox openXmlElement)
  {
    return openXmlElement?.ShowLabel?.Value;
  }
  
  private static bool CmpShowLabel(DXOCustUI.ComboBox openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ShowLabel?.Value == value) return true;
    diffs?.Add(objName, "ShowLabel", openXmlElement?.ShowLabel?.Value, value);
    return false;
  }
  
  private static void SetShowLabel(DXOCustUI.ComboBox openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowLabel = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowLabel = null;
  }
  
  /// <summary>
  /// getShowLabel
  /// </summary>
  private static String? GetGetShowLabel(DXOCustUI.ComboBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetShowLabel);
  }
  
  private static bool CmpGetShowLabel(DXOCustUI.ComboBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetShowLabel, value, diffs, objName, "GetShowLabel");
  }
  
  private static void SetGetShowLabel(DXOCustUI.ComboBox openXmlElement, String? value)
  {
    openXmlElement.GetShowLabel = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// showImage
  /// </summary>
  private static Boolean? GetShowImage(DXOCustUI.ComboBox openXmlElement)
  {
    return openXmlElement?.ShowImage?.Value;
  }
  
  private static bool CmpShowImage(DXOCustUI.ComboBox openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ShowImage?.Value == value) return true;
    diffs?.Add(objName, "ShowImage", openXmlElement?.ShowImage?.Value, value);
    return false;
  }
  
  private static void SetShowImage(DXOCustUI.ComboBox openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowImage = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowImage = null;
  }
  
  /// <summary>
  /// getShowImage
  /// </summary>
  private static String? GetGetShowImage(DXOCustUI.ComboBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetShowImage);
  }
  
  private static bool CmpGetShowImage(DXOCustUI.ComboBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetShowImage, value, diffs, objName, "GetShowImage");
  }
  
  private static void SetGetShowImage(DXOCustUI.ComboBox openXmlElement, String? value)
  {
    openXmlElement.GetShowImage = StringValueConverter.CreateStringValue(value);
  }
  
  private static Collection<DMUI.Item>? GetItems(DXOCustUI.ComboBox openXmlElement)
  {
    var collection = new Collection<DMUI.Item>();
    foreach (var item in openXmlElement.Elements<DXOCustUI.Item>())
    {
      var newItem = DMXUI.ItemConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpItems(DXOCustUI.ComboBox openXmlElement, Collection<DMUI.Item>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXOCustUI.Item>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXUI.ItemConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXOCustUI.ComboBox openXmlElement, Collection<DMUI.Item>? value)
  {
    openXmlElement.RemoveAllChildren<DXOCustUI.Item>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXUI.ItemConverter.CreateOpenXmlElement<DXOCustUI.Item>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.UI.ComboBox? CreateModelElement(DXOCustUI.ComboBox? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.UI.ComboBox();
      value.ShowItemImage = GetShowItemImage(openXmlElement);
      value.GetItemCount = GetGetItemCount(openXmlElement);
      value.GetItemLabel = GetGetItemLabel(openXmlElement);
      value.GetItemScreentip = GetGetItemScreentip(openXmlElement);
      value.GetItemSupertip = GetGetItemSupertip(openXmlElement);
      value.GetItemImage = GetGetItemImage(openXmlElement);
      value.GetItemID = GetGetItemID(openXmlElement);
      value.SizeString = GetSizeString(openXmlElement);
      value.InvalidateContentOnDrop = GetInvalidateContentOnDrop(openXmlElement);
      value.Enabled = GetEnabled(openXmlElement);
      value.GetEnabled = GetGetEnabled(openXmlElement);
      value.Image = GetImage(openXmlElement);
      value.ImageMso = GetImageMso(openXmlElement);
      value.GetImage = GetGetImage(openXmlElement);
      value.MaxLength = GetMaxLength(openXmlElement);
      value.GetText = GetGetText(openXmlElement);
      value.OnChange = GetOnChange(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.IdQ = GetIdQ(openXmlElement);
      value.IdMso = GetIdMso(openXmlElement);
      value.Tag = GetTag(openXmlElement);
      value.Screentip = GetScreentip(openXmlElement);
      value.GetScreentip = GetGetScreentip(openXmlElement);
      value.Supertip = GetSupertip(openXmlElement);
      value.GetSupertip = GetGetSupertip(openXmlElement);
      value.Label = GetLabel(openXmlElement);
      value.GetLabel = GetGetLabel(openXmlElement);
      value.InsertAfterMso = GetInsertAfterMso(openXmlElement);
      value.InsertBeforeMso = GetInsertBeforeMso(openXmlElement);
      value.InsertAfterQ = GetInsertAfterQ(openXmlElement);
      value.InsertBeforeQ = GetInsertBeforeQ(openXmlElement);
      value.Visible = GetVisible(openXmlElement);
      value.GetVisible = GetGetVisible(openXmlElement);
      value.Keytip = GetKeytip(openXmlElement);
      value.GetKeytip = GetGetKeytip(openXmlElement);
      value.ShowLabel = GetShowLabel(openXmlElement);
      value.GetShowLabel = GetGetShowLabel(openXmlElement);
      value.ShowImage = GetShowImage(openXmlElement);
      value.GetShowImage = GetGetShowImage(openXmlElement);
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOCustUI.ComboBox? openXmlElement, DMUI.ComboBox? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
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
      if (!CmpInvalidateContentOnDrop(openXmlElement, value.InvalidateContentOnDrop, diffs, objName))
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
      if (!CmpMaxLength(openXmlElement, value.MaxLength, diffs, objName))
        ok = false;
      if (!CmpGetText(openXmlElement, value.GetText, diffs, objName))
        ok = false;
      if (!CmpOnChange(openXmlElement, value.OnChange, diffs, objName))
        ok = false;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpIdQ(openXmlElement, value.IdQ, diffs, objName))
        ok = false;
      if (!CmpIdMso(openXmlElement, value.IdMso, diffs, objName))
        ok = false;
      if (!CmpTag(openXmlElement, value.Tag, diffs, objName))
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
      if (!CmpInsertAfterQ(openXmlElement, value.InsertAfterQ, diffs, objName))
        ok = false;
      if (!CmpInsertBeforeQ(openXmlElement, value.InsertBeforeQ, diffs, objName))
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
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMUI.ComboBox value)
    where OpenXmlElementType: DXOCustUI.ComboBox, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOCustUI.ComboBox openXmlElement, DMUI.ComboBox value)
  {
    SetShowItemImage(openXmlElement, value?.ShowItemImage);
    SetGetItemCount(openXmlElement, value?.GetItemCount);
    SetGetItemLabel(openXmlElement, value?.GetItemLabel);
    SetGetItemScreentip(openXmlElement, value?.GetItemScreentip);
    SetGetItemSupertip(openXmlElement, value?.GetItemSupertip);
    SetGetItemImage(openXmlElement, value?.GetItemImage);
    SetGetItemID(openXmlElement, value?.GetItemID);
    SetSizeString(openXmlElement, value?.SizeString);
    SetInvalidateContentOnDrop(openXmlElement, value?.InvalidateContentOnDrop);
    SetEnabled(openXmlElement, value?.Enabled);
    SetGetEnabled(openXmlElement, value?.GetEnabled);
    SetImage(openXmlElement, value?.Image);
    SetImageMso(openXmlElement, value?.ImageMso);
    SetGetImage(openXmlElement, value?.GetImage);
    SetMaxLength(openXmlElement, value?.MaxLength);
    SetGetText(openXmlElement, value?.GetText);
    SetOnChange(openXmlElement, value?.OnChange);
    SetId(openXmlElement, value?.Id);
    SetIdQ(openXmlElement, value?.IdQ);
    SetIdMso(openXmlElement, value?.IdMso);
    SetTag(openXmlElement, value?.Tag);
    SetScreentip(openXmlElement, value?.Screentip);
    SetGetScreentip(openXmlElement, value?.GetScreentip);
    SetSupertip(openXmlElement, value?.Supertip);
    SetGetSupertip(openXmlElement, value?.GetSupertip);
    SetLabel(openXmlElement, value?.Label);
    SetGetLabel(openXmlElement, value?.GetLabel);
    SetInsertAfterMso(openXmlElement, value?.InsertAfterMso);
    SetInsertBeforeMso(openXmlElement, value?.InsertBeforeMso);
    SetInsertAfterQ(openXmlElement, value?.InsertAfterQ);
    SetInsertBeforeQ(openXmlElement, value?.InsertBeforeQ);
    SetVisible(openXmlElement, value?.Visible);
    SetGetVisible(openXmlElement, value?.GetVisible);
    SetKeytip(openXmlElement, value?.Keytip);
    SetGetKeytip(openXmlElement, value?.GetKeytip);
    SetShowLabel(openXmlElement, value?.ShowLabel);
    SetGetShowLabel(openXmlElement, value?.GetShowLabel);
    SetShowImage(openXmlElement, value?.ShowImage);
    SetGetShowImage(openXmlElement, value?.GetShowImage);
    SetItems(openXmlElement, value?.Items);
  }
}
