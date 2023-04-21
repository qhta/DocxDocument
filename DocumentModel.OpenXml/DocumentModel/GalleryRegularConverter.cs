namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the GalleryRegular Class.
/// </summary>
public static class GalleryRegularConverter
{
  /// <summary>
  /// description, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetDescription(DXO10CUI.GalleryRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Description);
  }
  
  private static bool CmpDescription(DXO10CUI.GalleryRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Description, value, diffs, objName, "Description");
  }
  
  private static void SetDescription(DXO10CUI.GalleryRegular openXmlElement, String? value)
  {
    openXmlElement.Description = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getDescription, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetDescription(DXO10CUI.GalleryRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetDescription);
  }
  
  private static bool CmpGetDescription(DXO10CUI.GalleryRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetDescription, value, diffs, objName, "GetDescription");
  }
  
  private static void SetGetDescription(DXO10CUI.GalleryRegular openXmlElement, String? value)
  {
    openXmlElement.GetDescription = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// invalidateContentOnDrop, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetInvalidateContentOnDrop(DXO10CUI.GalleryRegular openXmlElement)
  {
    return openXmlElement?.InvalidateContentOnDrop?.Value;
  }
  
  private static bool CmpInvalidateContentOnDrop(DXO10CUI.GalleryRegular openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.InvalidateContentOnDrop?.Value == value) return true;
    diffs?.Add(objName, "InvalidateContentOnDrop", openXmlElement?.InvalidateContentOnDrop?.Value, value);
    return false;
  }
  
  private static void SetInvalidateContentOnDrop(DXO10CUI.GalleryRegular openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.InvalidateContentOnDrop = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.InvalidateContentOnDrop = null;
  }
  
  /// <summary>
  /// columns, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int64? GetColumns(DXO10CUI.GalleryRegular openXmlElement)
  {
    return openXmlElement?.Columns?.Value;
  }
  
  private static bool CmpColumns(DXO10CUI.GalleryRegular openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Columns?.Value == value) return true;
    diffs?.Add(objName, "Columns", openXmlElement?.Columns?.Value, value);
    return false;
  }
  
  private static void SetColumns(DXO10CUI.GalleryRegular openXmlElement, Int64? value)
  {
    openXmlElement.Columns = value;
  }
  
  /// <summary>
  /// rows, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int64? GetRows(DXO10CUI.GalleryRegular openXmlElement)
  {
    return openXmlElement?.Rows?.Value;
  }
  
  private static bool CmpRows(DXO10CUI.GalleryRegular openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Rows?.Value == value) return true;
    diffs?.Add(objName, "Rows", openXmlElement?.Rows?.Value, value);
    return false;
  }
  
  private static void SetRows(DXO10CUI.GalleryRegular openXmlElement, Int64? value)
  {
    openXmlElement.Rows = value;
  }
  
  /// <summary>
  /// itemWidth, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int64? GetItemWidth(DXO10CUI.GalleryRegular openXmlElement)
  {
    return openXmlElement?.ItemWidth?.Value;
  }
  
  private static bool CmpItemWidth(DXO10CUI.GalleryRegular openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ItemWidth?.Value == value) return true;
    diffs?.Add(objName, "ItemWidth", openXmlElement?.ItemWidth?.Value, value);
    return false;
  }
  
  private static void SetItemWidth(DXO10CUI.GalleryRegular openXmlElement, Int64? value)
  {
    openXmlElement.ItemWidth = value;
  }
  
  /// <summary>
  /// itemHeight, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int64? GetItemHeight(DXO10CUI.GalleryRegular openXmlElement)
  {
    return openXmlElement?.ItemHeight?.Value;
  }
  
  private static bool CmpItemHeight(DXO10CUI.GalleryRegular openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ItemHeight?.Value == value) return true;
    diffs?.Add(objName, "ItemHeight", openXmlElement?.ItemHeight?.Value, value);
    return false;
  }
  
  private static void SetItemHeight(DXO10CUI.GalleryRegular openXmlElement, Int64? value)
  {
    openXmlElement.ItemHeight = value;
  }
  
  /// <summary>
  /// getItemWidth, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetItemWidth(DXO10CUI.GalleryRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetItemWidth);
  }
  
  private static bool CmpGetItemWidth(DXO10CUI.GalleryRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetItemWidth, value, diffs, objName, "GetItemWidth");
  }
  
  private static void SetGetItemWidth(DXO10CUI.GalleryRegular openXmlElement, String? value)
  {
    openXmlElement.GetItemWidth = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getItemHeight, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetItemHeight(DXO10CUI.GalleryRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetItemHeight);
  }
  
  private static bool CmpGetItemHeight(DXO10CUI.GalleryRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetItemHeight, value, diffs, objName, "GetItemHeight");
  }
  
  private static void SetGetItemHeight(DXO10CUI.GalleryRegular openXmlElement, String? value)
  {
    openXmlElement.GetItemHeight = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// showItemLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetShowItemLabel(DXO10CUI.GalleryRegular openXmlElement)
  {
    return openXmlElement?.ShowItemLabel?.Value;
  }
  
  private static bool CmpShowItemLabel(DXO10CUI.GalleryRegular openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ShowItemLabel?.Value == value) return true;
    diffs?.Add(objName, "ShowItemLabel", openXmlElement?.ShowItemLabel?.Value, value);
    return false;
  }
  
  private static void SetShowItemLabel(DXO10CUI.GalleryRegular openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowItemLabel = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowItemLabel = null;
  }
  
  /// <summary>
  /// showInRibbon, this property is only available in Office 2010 and later.
  /// </summary>
  private static DM.GalleryShowInRibbonKind? GetShowInRibbon(DXO10CUI.GalleryRegular openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.CustomUI.GalleryShowInRibbonValues, DM.GalleryShowInRibbonKind>(openXmlElement?.ShowInRibbon?.Value);
  }
  
  private static bool CmpShowInRibbon(DXO10CUI.GalleryRegular openXmlElement, DM.GalleryShowInRibbonKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.CustomUI.GalleryShowInRibbonValues, DM.GalleryShowInRibbonKind>(openXmlElement?.ShowInRibbon?.Value, value, diffs, objName);
  }
  
  private static void SetShowInRibbon(DXO10CUI.GalleryRegular openXmlElement, DM.GalleryShowInRibbonKind? value)
  {
    openXmlElement.ShowInRibbon = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.GalleryShowInRibbonValues, DM.GalleryShowInRibbonKind>(value);
  }
  
  /// <summary>
  /// onAction, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetOnAction(DXO10CUI.GalleryRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.OnAction);
  }
  
  private static bool CmpOnAction(DXO10CUI.GalleryRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.OnAction, value, diffs, objName, "OnAction");
  }
  
  private static void SetOnAction(DXO10CUI.GalleryRegular openXmlElement, String? value)
  {
    openXmlElement.OnAction = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// enabled, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetEnabled(DXO10CUI.GalleryRegular openXmlElement)
  {
    return openXmlElement?.Enabled?.Value;
  }
  
  private static bool CmpEnabled(DXO10CUI.GalleryRegular openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Enabled?.Value == value) return true;
    diffs?.Add(objName, "Enabled", openXmlElement?.Enabled?.Value, value);
    return false;
  }
  
  private static void SetEnabled(DXO10CUI.GalleryRegular openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Enabled = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Enabled = null;
  }
  
  /// <summary>
  /// getEnabled, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetEnabled(DXO10CUI.GalleryRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetEnabled);
  }
  
  private static bool CmpGetEnabled(DXO10CUI.GalleryRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetEnabled, value, diffs, objName, "GetEnabled");
  }
  
  private static void SetGetEnabled(DXO10CUI.GalleryRegular openXmlElement, String? value)
  {
    openXmlElement.GetEnabled = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// image, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetImage(DXO10CUI.GalleryRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Image);
  }
  
  private static bool CmpImage(DXO10CUI.GalleryRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Image, value, diffs, objName, "Image");
  }
  
  private static void SetImage(DXO10CUI.GalleryRegular openXmlElement, String? value)
  {
    openXmlElement.Image = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// imageMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetImageMso(DXO10CUI.GalleryRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ImageMso);
  }
  
  private static bool CmpImageMso(DXO10CUI.GalleryRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ImageMso, value, diffs, objName, "ImageMso");
  }
  
  private static void SetImageMso(DXO10CUI.GalleryRegular openXmlElement, String? value)
  {
    openXmlElement.ImageMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getImage, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetImage(DXO10CUI.GalleryRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetImage);
  }
  
  private static bool CmpGetImage(DXO10CUI.GalleryRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetImage, value, diffs, objName, "GetImage");
  }
  
  private static void SetGetImage(DXO10CUI.GalleryRegular openXmlElement, String? value)
  {
    openXmlElement.GetImage = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// showItemImage, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetShowItemImage(DXO10CUI.GalleryRegular openXmlElement)
  {
    return openXmlElement?.ShowItemImage?.Value;
  }
  
  private static bool CmpShowItemImage(DXO10CUI.GalleryRegular openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ShowItemImage?.Value == value) return true;
    diffs?.Add(objName, "ShowItemImage", openXmlElement?.ShowItemImage?.Value, value);
    return false;
  }
  
  private static void SetShowItemImage(DXO10CUI.GalleryRegular openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowItemImage = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowItemImage = null;
  }
  
  /// <summary>
  /// getItemCount, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetItemCount(DXO10CUI.GalleryRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetItemCount);
  }
  
  private static bool CmpGetItemCount(DXO10CUI.GalleryRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetItemCount, value, diffs, objName, "GetItemCount");
  }
  
  private static void SetGetItemCount(DXO10CUI.GalleryRegular openXmlElement, String? value)
  {
    openXmlElement.GetItemCount = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getItemLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetItemLabel(DXO10CUI.GalleryRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetItemLabel);
  }
  
  private static bool CmpGetItemLabel(DXO10CUI.GalleryRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetItemLabel, value, diffs, objName, "GetItemLabel");
  }
  
  private static void SetGetItemLabel(DXO10CUI.GalleryRegular openXmlElement, String? value)
  {
    openXmlElement.GetItemLabel = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getItemScreentip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetItemScreentip(DXO10CUI.GalleryRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetItemScreentip);
  }
  
  private static bool CmpGetItemScreentip(DXO10CUI.GalleryRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetItemScreentip, value, diffs, objName, "GetItemScreentip");
  }
  
  private static void SetGetItemScreentip(DXO10CUI.GalleryRegular openXmlElement, String? value)
  {
    openXmlElement.GetItemScreentip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getItemSupertip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetItemSupertip(DXO10CUI.GalleryRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetItemSupertip);
  }
  
  private static bool CmpGetItemSupertip(DXO10CUI.GalleryRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetItemSupertip, value, diffs, objName, "GetItemSupertip");
  }
  
  private static void SetGetItemSupertip(DXO10CUI.GalleryRegular openXmlElement, String? value)
  {
    openXmlElement.GetItemSupertip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getItemImage, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetItemImage(DXO10CUI.GalleryRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetItemImage);
  }
  
  private static bool CmpGetItemImage(DXO10CUI.GalleryRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetItemImage, value, diffs, objName, "GetItemImage");
  }
  
  private static void SetGetItemImage(DXO10CUI.GalleryRegular openXmlElement, String? value)
  {
    openXmlElement.GetItemImage = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getItemID, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetItemID(DXO10CUI.GalleryRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetItemID);
  }
  
  private static bool CmpGetItemID(DXO10CUI.GalleryRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetItemID, value, diffs, objName, "GetItemID");
  }
  
  private static void SetGetItemID(DXO10CUI.GalleryRegular openXmlElement, String? value)
  {
    openXmlElement.GetItemID = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// sizeString, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetSizeString(DXO10CUI.GalleryRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.SizeString);
  }
  
  private static bool CmpSizeString(DXO10CUI.GalleryRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.SizeString, value, diffs, objName, "SizeString");
  }
  
  private static void SetSizeString(DXO10CUI.GalleryRegular openXmlElement, String? value)
  {
    openXmlElement.SizeString = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getSelectedItemID, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetSelectedItemID(DXO10CUI.GalleryRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetSelectedItemID);
  }
  
  private static bool CmpGetSelectedItemID(DXO10CUI.GalleryRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetSelectedItemID, value, diffs, objName, "GetSelectedItemID");
  }
  
  private static void SetGetSelectedItemID(DXO10CUI.GalleryRegular openXmlElement, String? value)
  {
    openXmlElement.GetSelectedItemID = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getSelectedItemIndex, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetSelectedItemIndex(DXO10CUI.GalleryRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetSelectedItemIndex);
  }
  
  private static bool CmpGetSelectedItemIndex(DXO10CUI.GalleryRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetSelectedItemIndex, value, diffs, objName, "GetSelectedItemIndex");
  }
  
  private static void SetGetSelectedItemIndex(DXO10CUI.GalleryRegular openXmlElement, String? value)
  {
    openXmlElement.GetSelectedItemIndex = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetId(DXO10CUI.GalleryRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXO10CUI.GalleryRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXO10CUI.GalleryRegular openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetQualifiedId(DXO10CUI.GalleryRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.QualifiedId);
  }
  
  private static bool CmpQualifiedId(DXO10CUI.GalleryRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.QualifiedId, value, diffs, objName, "QualifiedId");
  }
  
  private static void SetQualifiedId(DXO10CUI.GalleryRegular openXmlElement, String? value)
  {
    openXmlElement.QualifiedId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetTag(DXO10CUI.GalleryRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Tag);
  }
  
  private static bool CmpTag(DXO10CUI.GalleryRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Tag, value, diffs, objName, "Tag");
  }
  
  private static void SetTag(DXO10CUI.GalleryRegular openXmlElement, String? value)
  {
    openXmlElement.Tag = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// idMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetIdMso(DXO10CUI.GalleryRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.IdMso);
  }
  
  private static bool CmpIdMso(DXO10CUI.GalleryRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.IdMso, value, diffs, objName, "IdMso");
  }
  
  private static void SetIdMso(DXO10CUI.GalleryRegular openXmlElement, String? value)
  {
    openXmlElement.IdMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// screentip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetScreentip(DXO10CUI.GalleryRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Screentip);
  }
  
  private static bool CmpScreentip(DXO10CUI.GalleryRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Screentip, value, diffs, objName, "Screentip");
  }
  
  private static void SetScreentip(DXO10CUI.GalleryRegular openXmlElement, String? value)
  {
    openXmlElement.Screentip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getScreentip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetScreentip(DXO10CUI.GalleryRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetScreentip);
  }
  
  private static bool CmpGetScreentip(DXO10CUI.GalleryRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetScreentip, value, diffs, objName, "GetScreentip");
  }
  
  private static void SetGetScreentip(DXO10CUI.GalleryRegular openXmlElement, String? value)
  {
    openXmlElement.GetScreentip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// supertip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetSupertip(DXO10CUI.GalleryRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Supertip);
  }
  
  private static bool CmpSupertip(DXO10CUI.GalleryRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Supertip, value, diffs, objName, "Supertip");
  }
  
  private static void SetSupertip(DXO10CUI.GalleryRegular openXmlElement, String? value)
  {
    openXmlElement.Supertip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getSupertip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetSupertip(DXO10CUI.GalleryRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetSupertip);
  }
  
  private static bool CmpGetSupertip(DXO10CUI.GalleryRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetSupertip, value, diffs, objName, "GetSupertip");
  }
  
  private static void SetGetSupertip(DXO10CUI.GalleryRegular openXmlElement, String? value)
  {
    openXmlElement.GetSupertip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetLabel(DXO10CUI.GalleryRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Label);
  }
  
  private static bool CmpLabel(DXO10CUI.GalleryRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Label, value, diffs, objName, "Label");
  }
  
  private static void SetLabel(DXO10CUI.GalleryRegular openXmlElement, String? value)
  {
    openXmlElement.Label = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetLabel(DXO10CUI.GalleryRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetLabel);
  }
  
  private static bool CmpGetLabel(DXO10CUI.GalleryRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetLabel, value, diffs, objName, "GetLabel");
  }
  
  private static void SetGetLabel(DXO10CUI.GalleryRegular openXmlElement, String? value)
  {
    openXmlElement.GetLabel = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertAfterMso(DXO10CUI.GalleryRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertAfterMso);
  }
  
  private static bool CmpInsertAfterMso(DXO10CUI.GalleryRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertAfterMso, value, diffs, objName, "InsertAfterMso");
  }
  
  private static void SetInsertAfterMso(DXO10CUI.GalleryRegular openXmlElement, String? value)
  {
    openXmlElement.InsertAfterMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertBeforeMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertBeforeMso(DXO10CUI.GalleryRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertBeforeMso);
  }
  
  private static bool CmpInsertBeforeMso(DXO10CUI.GalleryRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertBeforeMso, value, diffs, objName, "InsertBeforeMso");
  }
  
  private static void SetInsertBeforeMso(DXO10CUI.GalleryRegular openXmlElement, String? value)
  {
    openXmlElement.InsertBeforeMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertAfterQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertAfterQulifiedId(DXO10CUI.GalleryRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertAfterQulifiedId);
  }
  
  private static bool CmpInsertAfterQulifiedId(DXO10CUI.GalleryRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertAfterQulifiedId, value, diffs, objName, "InsertAfterQulifiedId");
  }
  
  private static void SetInsertAfterQulifiedId(DXO10CUI.GalleryRegular openXmlElement, String? value)
  {
    openXmlElement.InsertAfterQulifiedId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertBeforeQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertBeforeQulifiedId(DXO10CUI.GalleryRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertBeforeQulifiedId);
  }
  
  private static bool CmpInsertBeforeQulifiedId(DXO10CUI.GalleryRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertBeforeQulifiedId, value, diffs, objName, "InsertBeforeQulifiedId");
  }
  
  private static void SetInsertBeforeQulifiedId(DXO10CUI.GalleryRegular openXmlElement, String? value)
  {
    openXmlElement.InsertBeforeQulifiedId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetVisible(DXO10CUI.GalleryRegular openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static bool CmpVisible(DXO10CUI.GalleryRegular openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Visible?.Value == value) return true;
    diffs?.Add(objName, "Visible", openXmlElement?.Visible?.Value, value);
    return false;
  }
  
  private static void SetVisible(DXO10CUI.GalleryRegular openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetVisible(DXO10CUI.GalleryRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetVisible);
  }
  
  private static bool CmpGetVisible(DXO10CUI.GalleryRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetVisible, value, diffs, objName, "GetVisible");
  }
  
  private static void SetGetVisible(DXO10CUI.GalleryRegular openXmlElement, String? value)
  {
    openXmlElement.GetVisible = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// keytip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetKeytip(DXO10CUI.GalleryRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Keytip);
  }
  
  private static bool CmpKeytip(DXO10CUI.GalleryRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Keytip, value, diffs, objName, "Keytip");
  }
  
  private static void SetKeytip(DXO10CUI.GalleryRegular openXmlElement, String? value)
  {
    openXmlElement.Keytip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getKeytip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetKeytip(DXO10CUI.GalleryRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetKeytip);
  }
  
  private static bool CmpGetKeytip(DXO10CUI.GalleryRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetKeytip, value, diffs, objName, "GetKeytip");
  }
  
  private static void SetGetKeytip(DXO10CUI.GalleryRegular openXmlElement, String? value)
  {
    openXmlElement.GetKeytip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// showLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetShowLabel(DXO10CUI.GalleryRegular openXmlElement)
  {
    return openXmlElement?.ShowLabel?.Value;
  }
  
  private static bool CmpShowLabel(DXO10CUI.GalleryRegular openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ShowLabel?.Value == value) return true;
    diffs?.Add(objName, "ShowLabel", openXmlElement?.ShowLabel?.Value, value);
    return false;
  }
  
  private static void SetShowLabel(DXO10CUI.GalleryRegular openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowLabel = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowLabel = null;
  }
  
  /// <summary>
  /// getShowLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetShowLabel(DXO10CUI.GalleryRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetShowLabel);
  }
  
  private static bool CmpGetShowLabel(DXO10CUI.GalleryRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetShowLabel, value, diffs, objName, "GetShowLabel");
  }
  
  private static void SetGetShowLabel(DXO10CUI.GalleryRegular openXmlElement, String? value)
  {
    openXmlElement.GetShowLabel = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// showImage, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetShowImage(DXO10CUI.GalleryRegular openXmlElement)
  {
    return openXmlElement?.ShowImage?.Value;
  }
  
  private static bool CmpShowImage(DXO10CUI.GalleryRegular openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ShowImage?.Value == value) return true;
    diffs?.Add(objName, "ShowImage", openXmlElement?.ShowImage?.Value, value);
    return false;
  }
  
  private static void SetShowImage(DXO10CUI.GalleryRegular openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowImage = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowImage = null;
  }
  
  /// <summary>
  /// getShowImage, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetShowImage(DXO10CUI.GalleryRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetShowImage);
  }
  
  private static bool CmpGetShowImage(DXO10CUI.GalleryRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetShowImage, value, diffs, objName, "GetShowImage");
  }
  
  private static void SetGetShowImage(DXO10CUI.GalleryRegular openXmlElement, String? value)
  {
    openXmlElement.GetShowImage = StringValueConverter.CreateStringValue(value);
  }
  
  private static Collection<DM.Item>? GetItems(DXO10CUI.GalleryRegular openXmlElement)
  {
    var collection = new Collection<DM.Item>();
    foreach (var item in openXmlElement.Elements<DXO10CUI.Item>())
    {
      var newItem = DMX.ItemConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpItems(DXO10CUI.GalleryRegular openXmlElement, Collection<DM.Item>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXO10CUI.Item>();
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
        if (!DMX.ItemConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXO10CUI.GalleryRegular openXmlElement, Collection<DM.Item>? value)
  {
    openXmlElement.RemoveAllChildren<DXO10CUI.Item>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMX.ItemConverter.CreateOpenXmlElement<DXO10CUI.Item>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static Collection<DM.ButtonRegular>? GetButtonRegulars(DXO10CUI.GalleryRegular openXmlElement)
  {
    var collection = new Collection<DM.ButtonRegular>();
    foreach (var item in openXmlElement.Elements<DXO10CUI.ButtonRegular>())
    {
      var newItem = DMX.ButtonRegularConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpButtonRegulars(DXO10CUI.GalleryRegular openXmlElement, Collection<DM.ButtonRegular>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXO10CUI.ButtonRegular>();
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
        if (!DMX.ButtonRegularConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetButtonRegulars(DXO10CUI.GalleryRegular openXmlElement, Collection<DM.ButtonRegular>? value)
  {
    openXmlElement.RemoveAllChildren<DXO10CUI.ButtonRegular>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMX.ButtonRegularConverter.CreateOpenXmlElement<DXO10CUI.ButtonRegular>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.GalleryRegular? CreateModelElement(DXO10CUI.GalleryRegular? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.GalleryRegular();
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
      value.ShowInRibbon = GetShowInRibbon(openXmlElement);
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
  
  public static bool CompareModelElement(DXO10CUI.GalleryRegular? openXmlElement, DM.GalleryRegular? value, DiffList? diffs, string? objName)
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
      if (!CmpShowInRibbon(openXmlElement, value.ShowInRibbon, diffs, objName))
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.GalleryRegular value)
    where OpenXmlElementType: DXO10CUI.GalleryRegular, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10CUI.GalleryRegular openXmlElement, DM.GalleryRegular value)
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
    SetShowInRibbon(openXmlElement, value?.ShowInRibbon);
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
  }
}
