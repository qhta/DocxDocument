namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the UnsizedGallery Class.
/// </summary>
public static class UnsizedGalleryConverter
{
  /// <summary>
  /// description
  /// </summary>
  private static String? GetDescription(DXOCUI.UnsizedGallery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Description);
  }
  
  private static bool CmpDescription(DXOCUI.UnsizedGallery openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Description, value, diffs, objName, "Description");
  }
  
  private static void SetDescription(DXOCUI.UnsizedGallery openXmlElement, String? value)
  {
    openXmlElement.Description = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getDescription
  /// </summary>
  private static String? GetGetDescription(DXOCUI.UnsizedGallery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetDescription);
  }
  
  private static bool CmpGetDescription(DXOCUI.UnsizedGallery openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetDescription, value, diffs, objName, "GetDescription");
  }
  
  private static void SetGetDescription(DXOCUI.UnsizedGallery openXmlElement, String? value)
  {
    openXmlElement.GetDescription = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// invalidateContentOnDrop
  /// </summary>
  private static Boolean? GetInvalidateContentOnDrop(DXOCUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.InvalidateContentOnDrop?.Value;
  }
  
  private static bool CmpInvalidateContentOnDrop(DXOCUI.UnsizedGallery openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.InvalidateContentOnDrop?.Value == value) return true;
    diffs?.Add(objName, "InvalidateContentOnDrop", openXmlElement?.InvalidateContentOnDrop?.Value, value);
    return false;
  }
  
  private static void SetInvalidateContentOnDrop(DXOCUI.UnsizedGallery openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.InvalidateContentOnDrop = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.InvalidateContentOnDrop = null;
  }
  
  /// <summary>
  /// columns
  /// </summary>
  private static Int64? GetColumns(DXOCUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.Columns?.Value;
  }
  
  private static bool CmpColumns(DXOCUI.UnsizedGallery openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Columns?.Value == value) return true;
    diffs?.Add(objName, "Columns", openXmlElement?.Columns?.Value, value);
    return false;
  }
  
  private static void SetColumns(DXOCUI.UnsizedGallery openXmlElement, Int64? value)
  {
    openXmlElement.Columns = value;
  }
  
  /// <summary>
  /// rows
  /// </summary>
  private static Int64? GetRows(DXOCUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.Rows?.Value;
  }
  
  private static bool CmpRows(DXOCUI.UnsizedGallery openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Rows?.Value == value) return true;
    diffs?.Add(objName, "Rows", openXmlElement?.Rows?.Value, value);
    return false;
  }
  
  private static void SetRows(DXOCUI.UnsizedGallery openXmlElement, Int64? value)
  {
    openXmlElement.Rows = value;
  }
  
  /// <summary>
  /// itemWidth
  /// </summary>
  private static Int64? GetItemWidth(DXOCUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.ItemWidth?.Value;
  }
  
  private static bool CmpItemWidth(DXOCUI.UnsizedGallery openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ItemWidth?.Value == value) return true;
    diffs?.Add(objName, "ItemWidth", openXmlElement?.ItemWidth?.Value, value);
    return false;
  }
  
  private static void SetItemWidth(DXOCUI.UnsizedGallery openXmlElement, Int64? value)
  {
    openXmlElement.ItemWidth = value;
  }
  
  /// <summary>
  /// itemHeight
  /// </summary>
  private static Int64? GetItemHeight(DXOCUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.ItemHeight?.Value;
  }
  
  private static bool CmpItemHeight(DXOCUI.UnsizedGallery openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ItemHeight?.Value == value) return true;
    diffs?.Add(objName, "ItemHeight", openXmlElement?.ItemHeight?.Value, value);
    return false;
  }
  
  private static void SetItemHeight(DXOCUI.UnsizedGallery openXmlElement, Int64? value)
  {
    openXmlElement.ItemHeight = value;
  }
  
  /// <summary>
  /// getItemWidth
  /// </summary>
  private static String? GetGetItemWidth(DXOCUI.UnsizedGallery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetItemWidth);
  }
  
  private static bool CmpGetItemWidth(DXOCUI.UnsizedGallery openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetItemWidth, value, diffs, objName, "GetItemWidth");
  }
  
  private static void SetGetItemWidth(DXOCUI.UnsizedGallery openXmlElement, String? value)
  {
    openXmlElement.GetItemWidth = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getItemHeight
  /// </summary>
  private static String? GetGetItemHeight(DXOCUI.UnsizedGallery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetItemHeight);
  }
  
  private static bool CmpGetItemHeight(DXOCUI.UnsizedGallery openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetItemHeight, value, diffs, objName, "GetItemHeight");
  }
  
  private static void SetGetItemHeight(DXOCUI.UnsizedGallery openXmlElement, String? value)
  {
    openXmlElement.GetItemHeight = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// showItemLabel
  /// </summary>
  private static Boolean? GetShowItemLabel(DXOCUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.ShowItemLabel?.Value;
  }
  
  private static bool CmpShowItemLabel(DXOCUI.UnsizedGallery openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ShowItemLabel?.Value == value) return true;
    diffs?.Add(objName, "ShowItemLabel", openXmlElement?.ShowItemLabel?.Value, value);
    return false;
  }
  
  private static void SetShowItemLabel(DXOCUI.UnsizedGallery openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowItemLabel = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowItemLabel = null;
  }
  
  /// <summary>
  /// onAction
  /// </summary>
  private static String? GetOnAction(DXOCUI.UnsizedGallery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.OnAction);
  }
  
  private static bool CmpOnAction(DXOCUI.UnsizedGallery openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.OnAction, value, diffs, objName, "OnAction");
  }
  
  private static void SetOnAction(DXOCUI.UnsizedGallery openXmlElement, String? value)
  {
    openXmlElement.OnAction = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// enabled
  /// </summary>
  private static Boolean? GetEnabled(DXOCUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.Enabled?.Value;
  }
  
  private static bool CmpEnabled(DXOCUI.UnsizedGallery openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Enabled?.Value == value) return true;
    diffs?.Add(objName, "Enabled", openXmlElement?.Enabled?.Value, value);
    return false;
  }
  
  private static void SetEnabled(DXOCUI.UnsizedGallery openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Enabled = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Enabled = null;
  }
  
  /// <summary>
  /// getEnabled
  /// </summary>
  private static String? GetGetEnabled(DXOCUI.UnsizedGallery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetEnabled);
  }
  
  private static bool CmpGetEnabled(DXOCUI.UnsizedGallery openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetEnabled, value, diffs, objName, "GetEnabled");
  }
  
  private static void SetGetEnabled(DXOCUI.UnsizedGallery openXmlElement, String? value)
  {
    openXmlElement.GetEnabled = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// image
  /// </summary>
  private static String? GetImage(DXOCUI.UnsizedGallery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Image);
  }
  
  private static bool CmpImage(DXOCUI.UnsizedGallery openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Image, value, diffs, objName, "Image");
  }
  
  private static void SetImage(DXOCUI.UnsizedGallery openXmlElement, String? value)
  {
    openXmlElement.Image = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// imageMso
  /// </summary>
  private static String? GetImageMso(DXOCUI.UnsizedGallery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ImageMso);
  }
  
  private static bool CmpImageMso(DXOCUI.UnsizedGallery openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ImageMso, value, diffs, objName, "ImageMso");
  }
  
  private static void SetImageMso(DXOCUI.UnsizedGallery openXmlElement, String? value)
  {
    openXmlElement.ImageMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getImage
  /// </summary>
  private static String? GetGetImage(DXOCUI.UnsizedGallery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetImage);
  }
  
  private static bool CmpGetImage(DXOCUI.UnsizedGallery openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetImage, value, diffs, objName, "GetImage");
  }
  
  private static void SetGetImage(DXOCUI.UnsizedGallery openXmlElement, String? value)
  {
    openXmlElement.GetImage = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// showItemImage
  /// </summary>
  private static Boolean? GetShowItemImage(DXOCUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.ShowItemImage?.Value;
  }
  
  private static bool CmpShowItemImage(DXOCUI.UnsizedGallery openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ShowItemImage?.Value == value) return true;
    diffs?.Add(objName, "ShowItemImage", openXmlElement?.ShowItemImage?.Value, value);
    return false;
  }
  
  private static void SetShowItemImage(DXOCUI.UnsizedGallery openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowItemImage = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowItemImage = null;
  }
  
  /// <summary>
  /// getItemCount
  /// </summary>
  private static String? GetGetItemCount(DXOCUI.UnsizedGallery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetItemCount);
  }
  
  private static bool CmpGetItemCount(DXOCUI.UnsizedGallery openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetItemCount, value, diffs, objName, "GetItemCount");
  }
  
  private static void SetGetItemCount(DXOCUI.UnsizedGallery openXmlElement, String? value)
  {
    openXmlElement.GetItemCount = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getItemLabel
  /// </summary>
  private static String? GetGetItemLabel(DXOCUI.UnsizedGallery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetItemLabel);
  }
  
  private static bool CmpGetItemLabel(DXOCUI.UnsizedGallery openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetItemLabel, value, diffs, objName, "GetItemLabel");
  }
  
  private static void SetGetItemLabel(DXOCUI.UnsizedGallery openXmlElement, String? value)
  {
    openXmlElement.GetItemLabel = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getItemScreentip
  /// </summary>
  private static String? GetGetItemScreentip(DXOCUI.UnsizedGallery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetItemScreentip);
  }
  
  private static bool CmpGetItemScreentip(DXOCUI.UnsizedGallery openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetItemScreentip, value, diffs, objName, "GetItemScreentip");
  }
  
  private static void SetGetItemScreentip(DXOCUI.UnsizedGallery openXmlElement, String? value)
  {
    openXmlElement.GetItemScreentip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getItemSupertip
  /// </summary>
  private static String? GetGetItemSupertip(DXOCUI.UnsizedGallery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetItemSupertip);
  }
  
  private static bool CmpGetItemSupertip(DXOCUI.UnsizedGallery openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetItemSupertip, value, diffs, objName, "GetItemSupertip");
  }
  
  private static void SetGetItemSupertip(DXOCUI.UnsizedGallery openXmlElement, String? value)
  {
    openXmlElement.GetItemSupertip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getItemImage
  /// </summary>
  private static String? GetGetItemImage(DXOCUI.UnsizedGallery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetItemImage);
  }
  
  private static bool CmpGetItemImage(DXOCUI.UnsizedGallery openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetItemImage, value, diffs, objName, "GetItemImage");
  }
  
  private static void SetGetItemImage(DXOCUI.UnsizedGallery openXmlElement, String? value)
  {
    openXmlElement.GetItemImage = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getItemID
  /// </summary>
  private static String? GetGetItemID(DXOCUI.UnsizedGallery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetItemID);
  }
  
  private static bool CmpGetItemID(DXOCUI.UnsizedGallery openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetItemID, value, diffs, objName, "GetItemID");
  }
  
  private static void SetGetItemID(DXOCUI.UnsizedGallery openXmlElement, String? value)
  {
    openXmlElement.GetItemID = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// sizeString
  /// </summary>
  private static String? GetSizeString(DXOCUI.UnsizedGallery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.SizeString);
  }
  
  private static bool CmpSizeString(DXOCUI.UnsizedGallery openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.SizeString, value, diffs, objName, "SizeString");
  }
  
  private static void SetSizeString(DXOCUI.UnsizedGallery openXmlElement, String? value)
  {
    openXmlElement.SizeString = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getSelectedItemID
  /// </summary>
  private static String? GetGetSelectedItemID(DXOCUI.UnsizedGallery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetSelectedItemID);
  }
  
  private static bool CmpGetSelectedItemID(DXOCUI.UnsizedGallery openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetSelectedItemID, value, diffs, objName, "GetSelectedItemID");
  }
  
  private static void SetGetSelectedItemID(DXOCUI.UnsizedGallery openXmlElement, String? value)
  {
    openXmlElement.GetSelectedItemID = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getSelectedItemIndex
  /// </summary>
  private static String? GetGetSelectedItemIndex(DXOCUI.UnsizedGallery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetSelectedItemIndex);
  }
  
  private static bool CmpGetSelectedItemIndex(DXOCUI.UnsizedGallery openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetSelectedItemIndex, value, diffs, objName, "GetSelectedItemIndex");
  }
  
  private static void SetGetSelectedItemIndex(DXOCUI.UnsizedGallery openXmlElement, String? value)
  {
    openXmlElement.GetSelectedItemIndex = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// id
  /// </summary>
  private static String? GetId(DXOCUI.UnsizedGallery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXOCUI.UnsizedGallery openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXOCUI.UnsizedGallery openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// idQ
  /// </summary>
  private static String? GetIdQ(DXOCUI.UnsizedGallery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.IdQ);
  }
  
  private static bool CmpIdQ(DXOCUI.UnsizedGallery openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.IdQ, value, diffs, objName, "IdQ");
  }
  
  private static void SetIdQ(DXOCUI.UnsizedGallery openXmlElement, String? value)
  {
    openXmlElement.IdQ = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// idMso
  /// </summary>
  private static String? GetIdMso(DXOCUI.UnsizedGallery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.IdMso);
  }
  
  private static bool CmpIdMso(DXOCUI.UnsizedGallery openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.IdMso, value, diffs, objName, "IdMso");
  }
  
  private static void SetIdMso(DXOCUI.UnsizedGallery openXmlElement, String? value)
  {
    openXmlElement.IdMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// tag
  /// </summary>
  private static String? GetTag(DXOCUI.UnsizedGallery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Tag);
  }
  
  private static bool CmpTag(DXOCUI.UnsizedGallery openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Tag, value, diffs, objName, "Tag");
  }
  
  private static void SetTag(DXOCUI.UnsizedGallery openXmlElement, String? value)
  {
    openXmlElement.Tag = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// screentip
  /// </summary>
  private static String? GetScreentip(DXOCUI.UnsizedGallery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Screentip);
  }
  
  private static bool CmpScreentip(DXOCUI.UnsizedGallery openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Screentip, value, diffs, objName, "Screentip");
  }
  
  private static void SetScreentip(DXOCUI.UnsizedGallery openXmlElement, String? value)
  {
    openXmlElement.Screentip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getScreentip
  /// </summary>
  private static String? GetGetScreentip(DXOCUI.UnsizedGallery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetScreentip);
  }
  
  private static bool CmpGetScreentip(DXOCUI.UnsizedGallery openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetScreentip, value, diffs, objName, "GetScreentip");
  }
  
  private static void SetGetScreentip(DXOCUI.UnsizedGallery openXmlElement, String? value)
  {
    openXmlElement.GetScreentip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// supertip
  /// </summary>
  private static String? GetSupertip(DXOCUI.UnsizedGallery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Supertip);
  }
  
  private static bool CmpSupertip(DXOCUI.UnsizedGallery openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Supertip, value, diffs, objName, "Supertip");
  }
  
  private static void SetSupertip(DXOCUI.UnsizedGallery openXmlElement, String? value)
  {
    openXmlElement.Supertip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getSupertip
  /// </summary>
  private static String? GetGetSupertip(DXOCUI.UnsizedGallery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetSupertip);
  }
  
  private static bool CmpGetSupertip(DXOCUI.UnsizedGallery openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetSupertip, value, diffs, objName, "GetSupertip");
  }
  
  private static void SetGetSupertip(DXOCUI.UnsizedGallery openXmlElement, String? value)
  {
    openXmlElement.GetSupertip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// label
  /// </summary>
  private static String? GetLabel(DXOCUI.UnsizedGallery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Label);
  }
  
  private static bool CmpLabel(DXOCUI.UnsizedGallery openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Label, value, diffs, objName, "Label");
  }
  
  private static void SetLabel(DXOCUI.UnsizedGallery openXmlElement, String? value)
  {
    openXmlElement.Label = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getLabel
  /// </summary>
  private static String? GetGetLabel(DXOCUI.UnsizedGallery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetLabel);
  }
  
  private static bool CmpGetLabel(DXOCUI.UnsizedGallery openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetLabel, value, diffs, objName, "GetLabel");
  }
  
  private static void SetGetLabel(DXOCUI.UnsizedGallery openXmlElement, String? value)
  {
    openXmlElement.GetLabel = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertAfterMso
  /// </summary>
  private static String? GetInsertAfterMso(DXOCUI.UnsizedGallery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertAfterMso);
  }
  
  private static bool CmpInsertAfterMso(DXOCUI.UnsizedGallery openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertAfterMso, value, diffs, objName, "InsertAfterMso");
  }
  
  private static void SetInsertAfterMso(DXOCUI.UnsizedGallery openXmlElement, String? value)
  {
    openXmlElement.InsertAfterMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertBeforeMso
  /// </summary>
  private static String? GetInsertBeforeMso(DXOCUI.UnsizedGallery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertBeforeMso);
  }
  
  private static bool CmpInsertBeforeMso(DXOCUI.UnsizedGallery openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertBeforeMso, value, diffs, objName, "InsertBeforeMso");
  }
  
  private static void SetInsertBeforeMso(DXOCUI.UnsizedGallery openXmlElement, String? value)
  {
    openXmlElement.InsertBeforeMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertAfterQ
  /// </summary>
  private static String? GetInsertAfterQ(DXOCUI.UnsizedGallery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertAfterQ);
  }
  
  private static bool CmpInsertAfterQ(DXOCUI.UnsizedGallery openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertAfterQ, value, diffs, objName, "InsertAfterQ");
  }
  
  private static void SetInsertAfterQ(DXOCUI.UnsizedGallery openXmlElement, String? value)
  {
    openXmlElement.InsertAfterQ = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertBeforeQ
  /// </summary>
  private static String? GetInsertBeforeQ(DXOCUI.UnsizedGallery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertBeforeQ);
  }
  
  private static bool CmpInsertBeforeQ(DXOCUI.UnsizedGallery openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertBeforeQ, value, diffs, objName, "InsertBeforeQ");
  }
  
  private static void SetInsertBeforeQ(DXOCUI.UnsizedGallery openXmlElement, String? value)
  {
    openXmlElement.InsertBeforeQ = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// visible
  /// </summary>
  private static Boolean? GetVisible(DXOCUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static bool CmpVisible(DXOCUI.UnsizedGallery openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Visible?.Value == value) return true;
    diffs?.Add(objName, "Visible", openXmlElement?.Visible?.Value, value);
    return false;
  }
  
  private static void SetVisible(DXOCUI.UnsizedGallery openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible
  /// </summary>
  private static String? GetGetVisible(DXOCUI.UnsizedGallery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetVisible);
  }
  
  private static bool CmpGetVisible(DXOCUI.UnsizedGallery openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetVisible, value, diffs, objName, "GetVisible");
  }
  
  private static void SetGetVisible(DXOCUI.UnsizedGallery openXmlElement, String? value)
  {
    openXmlElement.GetVisible = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// keytip
  /// </summary>
  private static String? GetKeytip(DXOCUI.UnsizedGallery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Keytip);
  }
  
  private static bool CmpKeytip(DXOCUI.UnsizedGallery openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Keytip, value, diffs, objName, "Keytip");
  }
  
  private static void SetKeytip(DXOCUI.UnsizedGallery openXmlElement, String? value)
  {
    openXmlElement.Keytip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getKeytip
  /// </summary>
  private static String? GetGetKeytip(DXOCUI.UnsizedGallery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetKeytip);
  }
  
  private static bool CmpGetKeytip(DXOCUI.UnsizedGallery openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetKeytip, value, diffs, objName, "GetKeytip");
  }
  
  private static void SetGetKeytip(DXOCUI.UnsizedGallery openXmlElement, String? value)
  {
    openXmlElement.GetKeytip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// showLabel
  /// </summary>
  private static Boolean? GetShowLabel(DXOCUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.ShowLabel?.Value;
  }
  
  private static bool CmpShowLabel(DXOCUI.UnsizedGallery openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ShowLabel?.Value == value) return true;
    diffs?.Add(objName, "ShowLabel", openXmlElement?.ShowLabel?.Value, value);
    return false;
  }
  
  private static void SetShowLabel(DXOCUI.UnsizedGallery openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowLabel = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowLabel = null;
  }
  
  /// <summary>
  /// getShowLabel
  /// </summary>
  private static String? GetGetShowLabel(DXOCUI.UnsizedGallery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetShowLabel);
  }
  
  private static bool CmpGetShowLabel(DXOCUI.UnsizedGallery openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetShowLabel, value, diffs, objName, "GetShowLabel");
  }
  
  private static void SetGetShowLabel(DXOCUI.UnsizedGallery openXmlElement, String? value)
  {
    openXmlElement.GetShowLabel = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// showImage
  /// </summary>
  private static Boolean? GetShowImage(DXOCUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.ShowImage?.Value;
  }
  
  private static bool CmpShowImage(DXOCUI.UnsizedGallery openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ShowImage?.Value == value) return true;
    diffs?.Add(objName, "ShowImage", openXmlElement?.ShowImage?.Value, value);
    return false;
  }
  
  private static void SetShowImage(DXOCUI.UnsizedGallery openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowImage = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowImage = null;
  }
  
  /// <summary>
  /// getShowImage
  /// </summary>
  private static String? GetGetShowImage(DXOCUI.UnsizedGallery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetShowImage);
  }
  
  private static bool CmpGetShowImage(DXOCUI.UnsizedGallery openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetShowImage, value, diffs, objName, "GetShowImage");
  }
  
  private static void SetGetShowImage(DXOCUI.UnsizedGallery openXmlElement, String? value)
  {
    openXmlElement.GetShowImage = StringValueConverter.CreateStringValue(value);
  }
  
  private static Collection<DMUI.Item>? GetItems(DXOCUI.UnsizedGallery openXmlElement)
  {
    var collection = new Collection<DMUI.Item>();
    foreach (var item in openXmlElement.Elements<DXOCUI.Item>())
    {
      var newItem = DMXUI.ItemConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpItems(DXOCUI.UnsizedGallery openXmlElement, Collection<DMUI.Item>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXOCUI.Item>();
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
  
  private static void SetItems(DXOCUI.UnsizedGallery openXmlElement, Collection<DMUI.Item>? value)
  {
    openXmlElement.RemoveAllChildren<DXOCUI.Item>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXUI.ItemConverter.CreateOpenXmlElement<DXOCUI.Item>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static Collection<DMUI.UnsizedButton>? GetUnsizedButtons(DXOCUI.UnsizedGallery openXmlElement)
  {
    var collection = new Collection<DMUI.UnsizedButton>();
    foreach (var item in openXmlElement.Elements<DXOCUI.UnsizedButton>())
    {
      var newItem = DMXUI.UnsizedButtonConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpUnsizedButtons(DXOCUI.UnsizedGallery openXmlElement, Collection<DMUI.UnsizedButton>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXOCUI.UnsizedButton>();
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
        if (!DMXUI.UnsizedButtonConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetUnsizedButtons(DXOCUI.UnsizedGallery openXmlElement, Collection<DMUI.UnsizedButton>? value)
  {
    openXmlElement.RemoveAllChildren<DXOCUI.UnsizedButton>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXUI.UnsizedButtonConverter.CreateOpenXmlElement<DXOCUI.UnsizedButton>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.UI.UnsizedGallery? CreateModelElement(DXOCUI.UnsizedGallery? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.UI.UnsizedGallery();
      value.Description = GetDescription(openXmlElement);
      value.GetDescription = GetGetDescription(openXmlElement);
      value.InvalidateContentOnDrop = GetInvalidateContentOnDrop(openXmlElement);
      value.Columns = GetColumns(openXmlElement);
      value.Rows = GetRows(openXmlElement);
      value.ItemWidth = GetItemWidth(openXmlElement);
      value.ItemHeight = GetItemHeight(openXmlElement);
      value.GetItemWidth = GetGetItemWidth(openXmlElement);
      value.GetItemHeight = GetGetItemHeight(openXmlElement);
      value.ShowItemLabel = GetShowItemLabel(openXmlElement);
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
      value.UnsizedButtons = GetUnsizedButtons(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOCUI.UnsizedGallery? openXmlElement, DMUI.UnsizedGallery? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDescription(openXmlElement, value.Description, diffs, objName))
        ok = false;
      if (!CmpGetDescription(openXmlElement, value.GetDescription, diffs, objName))
        ok = false;
      if (!CmpInvalidateContentOnDrop(openXmlElement, value.InvalidateContentOnDrop, diffs, objName))
        ok = false;
      if (!CmpColumns(openXmlElement, value.Columns, diffs, objName))
        ok = false;
      if (!CmpRows(openXmlElement, value.Rows, diffs, objName))
        ok = false;
      if (!CmpItemWidth(openXmlElement, value.ItemWidth, diffs, objName))
        ok = false;
      if (!CmpItemHeight(openXmlElement, value.ItemHeight, diffs, objName))
        ok = false;
      if (!CmpGetItemWidth(openXmlElement, value.GetItemWidth, diffs, objName))
        ok = false;
      if (!CmpGetItemHeight(openXmlElement, value.GetItemHeight, diffs, objName))
        ok = false;
      if (!CmpShowItemLabel(openXmlElement, value.ShowItemLabel, diffs, objName))
        ok = false;
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
      if (!CmpUnsizedButtons(openXmlElement, value.UnsizedButtons, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMUI.UnsizedGallery value)
    where OpenXmlElementType: DXOCUI.UnsizedGallery, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOCUI.UnsizedGallery openXmlElement, DMUI.UnsizedGallery value)
  {
    SetDescription(openXmlElement, value?.Description);
    SetGetDescription(openXmlElement, value?.GetDescription);
    SetInvalidateContentOnDrop(openXmlElement, value?.InvalidateContentOnDrop);
    SetColumns(openXmlElement, value?.Columns);
    SetRows(openXmlElement, value?.Rows);
    SetItemWidth(openXmlElement, value?.ItemWidth);
    SetItemHeight(openXmlElement, value?.ItemHeight);
    SetGetItemWidth(openXmlElement, value?.GetItemWidth);
    SetGetItemHeight(openXmlElement, value?.GetItemHeight);
    SetShowItemLabel(openXmlElement, value?.ShowItemLabel);
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
    SetUnsizedButtons(openXmlElement, value?.UnsizedButtons);
  }
}
