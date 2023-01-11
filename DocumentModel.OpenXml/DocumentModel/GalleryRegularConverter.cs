namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the GalleryRegular Class.
/// </summary>
public static class GalleryRegularConverter
{
  /// <summary>
  /// description, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetDescription(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.Description?.Value;
  }
  
  public static void SetDescription(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Description = new StringValue { Value = value };
      else
        openXmlElement.Description = null;
  }
  
  /// <summary>
  /// getDescription, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetDescription(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.GetDescription?.Value;
  }
  
  public static void SetGetDescription(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetDescription = new StringValue { Value = value };
      else
        openXmlElement.GetDescription = null;
  }
  
  /// <summary>
  /// invalidateContentOnDrop, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetInvalidateContentOnDrop(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.InvalidateContentOnDrop?.Value;
  }
  
  public static void SetInvalidateContentOnDrop(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InvalidateContentOnDrop = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.InvalidateContentOnDrop = null;
  }
  
  /// <summary>
  /// columns, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int64? GetColumns(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.Columns?.Value;
  }
  
  public static void SetColumns(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Columns = value;
  }
  
  /// <summary>
  /// rows, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int64? GetRows(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.Rows?.Value;
  }
  
  public static void SetRows(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Rows = value;
  }
  
  /// <summary>
  /// itemWidth, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int64? GetItemWidth(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.ItemWidth?.Value;
  }
  
  public static void SetItemWidth(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.ItemWidth = value;
  }
  
  /// <summary>
  /// itemHeight, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int64? GetItemHeight(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.ItemHeight?.Value;
  }
  
  public static void SetItemHeight(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.ItemHeight = value;
  }
  
  /// <summary>
  /// getItemWidth, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetItemWidth(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.GetItemWidth?.Value;
  }
  
  public static void SetGetItemWidth(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetItemWidth = new StringValue { Value = value };
      else
        openXmlElement.GetItemWidth = null;
  }
  
  /// <summary>
  /// getItemHeight, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetItemHeight(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.GetItemHeight?.Value;
  }
  
  public static void SetGetItemHeight(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetItemHeight = new StringValue { Value = value };
      else
        openXmlElement.GetItemHeight = null;
  }
  
  /// <summary>
  /// showItemLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetShowItemLabel(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.ShowItemLabel?.Value;
  }
  
  public static void SetShowItemLabel(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ShowItemLabel = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.ShowItemLabel = null;
  }
  
  /// <summary>
  /// showInRibbon, this property is only available in Office 2010 and later.
  /// </summary>
  public static DocumentModel.GalleryShowInRibbonKind? GetShowInRibbon(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.CustomUI.GalleryShowInRibbonValues, DocumentModel.GalleryShowInRibbonKind>(openXmlElement?.ShowInRibbon?.Value);
  }
  
  public static void SetShowInRibbon(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, DocumentModel.GalleryShowInRibbonKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.ShowInRibbon = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.GalleryShowInRibbonValues, DocumentModel.GalleryShowInRibbonKind>(value);
  }
  
  /// <summary>
  /// onAction, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetOnAction(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.OnAction?.Value;
  }
  
  public static void SetOnAction(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.OnAction = new StringValue { Value = value };
      else
        openXmlElement.OnAction = null;
  }
  
  /// <summary>
  /// enabled, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.Enabled?.Value;
  }
  
  public static void SetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Enabled = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Enabled = null;
  }
  
  /// <summary>
  /// getEnabled, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.GetEnabled?.Value;
  }
  
  public static void SetGetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetEnabled = new StringValue { Value = value };
      else
        openXmlElement.GetEnabled = null;
  }
  
  /// <summary>
  /// image, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetImage(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.Image?.Value;
  }
  
  public static void SetImage(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Image = new StringValue { Value = value };
      else
        openXmlElement.Image = null;
  }
  
  /// <summary>
  /// imageMso, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetImageMso(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.ImageMso?.Value;
  }
  
  public static void SetImageMso(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ImageMso = new StringValue { Value = value };
      else
        openXmlElement.ImageMso = null;
  }
  
  /// <summary>
  /// getImage, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetImage(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.GetImage?.Value;
  }
  
  public static void SetGetImage(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetImage = new StringValue { Value = value };
      else
        openXmlElement.GetImage = null;
  }
  
  /// <summary>
  /// showItemImage, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetShowItemImage(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.ShowItemImage?.Value;
  }
  
  public static void SetShowItemImage(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ShowItemImage = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.ShowItemImage = null;
  }
  
  /// <summary>
  /// getItemCount, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetItemCount(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.GetItemCount?.Value;
  }
  
  public static void SetGetItemCount(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetItemCount = new StringValue { Value = value };
      else
        openXmlElement.GetItemCount = null;
  }
  
  /// <summary>
  /// getItemLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetItemLabel(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.GetItemLabel?.Value;
  }
  
  public static void SetGetItemLabel(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetItemLabel = new StringValue { Value = value };
      else
        openXmlElement.GetItemLabel = null;
  }
  
  /// <summary>
  /// getItemScreentip, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetItemScreentip(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.GetItemScreentip?.Value;
  }
  
  public static void SetGetItemScreentip(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetItemScreentip = new StringValue { Value = value };
      else
        openXmlElement.GetItemScreentip = null;
  }
  
  /// <summary>
  /// getItemSupertip, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetItemSupertip(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.GetItemSupertip?.Value;
  }
  
  public static void SetGetItemSupertip(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetItemSupertip = new StringValue { Value = value };
      else
        openXmlElement.GetItemSupertip = null;
  }
  
  /// <summary>
  /// getItemImage, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetItemImage(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.GetItemImage?.Value;
  }
  
  public static void SetGetItemImage(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetItemImage = new StringValue { Value = value };
      else
        openXmlElement.GetItemImage = null;
  }
  
  /// <summary>
  /// getItemID, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetItemID(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.GetItemID?.Value;
  }
  
  public static void SetGetItemID(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetItemID = new StringValue { Value = value };
      else
        openXmlElement.GetItemID = null;
  }
  
  /// <summary>
  /// sizeString, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetSizeString(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.SizeString?.Value;
  }
  
  public static void SetSizeString(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.SizeString = new StringValue { Value = value };
      else
        openXmlElement.SizeString = null;
  }
  
  /// <summary>
  /// getSelectedItemID, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetSelectedItemID(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.GetSelectedItemID?.Value;
  }
  
  public static void SetGetSelectedItemID(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetSelectedItemID = new StringValue { Value = value };
      else
        openXmlElement.GetSelectedItemID = null;
  }
  
  /// <summary>
  /// getSelectedItemIndex, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetSelectedItemIndex(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.GetSelectedItemIndex?.Value;
  }
  
  public static void SetGetSelectedItemIndex(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetSelectedItemIndex = new StringValue { Value = value };
      else
        openXmlElement.GetSelectedItemIndex = null;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.QualifiedId?.Value;
  }
  
  public static void SetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.QualifiedId = new StringValue { Value = value };
      else
        openXmlElement.QualifiedId = null;
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetTag(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }
  
  public static void SetTag(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Tag = new StringValue { Value = value };
      else
        openXmlElement.Tag = null;
  }
  
  /// <summary>
  /// idMso, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetIdMso(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.IdMso?.Value;
  }
  
  public static void SetIdMso(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.IdMso = new StringValue { Value = value };
      else
        openXmlElement.IdMso = null;
  }
  
  /// <summary>
  /// screentip, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetScreentip(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.Screentip?.Value;
  }
  
  public static void SetScreentip(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Screentip = new StringValue { Value = value };
      else
        openXmlElement.Screentip = null;
  }
  
  /// <summary>
  /// getScreentip, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetScreentip(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.GetScreentip?.Value;
  }
  
  public static void SetGetScreentip(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetScreentip = new StringValue { Value = value };
      else
        openXmlElement.GetScreentip = null;
  }
  
  /// <summary>
  /// supertip, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetSupertip(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.Supertip?.Value;
  }
  
  public static void SetSupertip(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Supertip = new StringValue { Value = value };
      else
        openXmlElement.Supertip = null;
  }
  
  /// <summary>
  /// getSupertip, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetSupertip(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.GetSupertip?.Value;
  }
  
  public static void SetGetSupertip(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetSupertip = new StringValue { Value = value };
      else
        openXmlElement.GetSupertip = null;
  }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.Label?.Value;
  }
  
  public static void SetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Label = new StringValue { Value = value };
      else
        openXmlElement.Label = null;
  }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.GetLabel?.Value;
  }
  
  public static void SetGetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetLabel = new StringValue { Value = value };
      else
        openXmlElement.GetLabel = null;
  }
  
  /// <summary>
  /// insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetInsertAfterMso(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.InsertAfterMso?.Value;
  }
  
  public static void SetInsertAfterMso(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsertAfterMso = new StringValue { Value = value };
      else
        openXmlElement.InsertAfterMso = null;
  }
  
  /// <summary>
  /// insertBeforeMso, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetInsertBeforeMso(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.InsertBeforeMso?.Value;
  }
  
  public static void SetInsertBeforeMso(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsertBeforeMso = new StringValue { Value = value };
      else
        openXmlElement.InsertBeforeMso = null;
  }
  
  /// <summary>
  /// insertAfterQ, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetInsertAfterQulifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.InsertAfterQulifiedId?.Value;
  }
  
  public static void SetInsertAfterQulifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsertAfterQulifiedId = new StringValue { Value = value };
      else
        openXmlElement.InsertAfterQulifiedId = null;
  }
  
  /// <summary>
  /// insertBeforeQ, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetInsertBeforeQulifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.InsertBeforeQulifiedId?.Value;
  }
  
  public static void SetInsertBeforeQulifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsertBeforeQulifiedId = new StringValue { Value = value };
      else
        openXmlElement.InsertBeforeQulifiedId = null;
  }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  public static void SetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }
  
  public static void SetGetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetVisible = new StringValue { Value = value };
      else
        openXmlElement.GetVisible = null;
  }
  
  /// <summary>
  /// keytip, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.Keytip?.Value;
  }
  
  public static void SetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Keytip = new StringValue { Value = value };
      else
        openXmlElement.Keytip = null;
  }
  
  /// <summary>
  /// getKeytip, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.GetKeytip?.Value;
  }
  
  public static void SetGetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetKeytip = new StringValue { Value = value };
      else
        openXmlElement.GetKeytip = null;
  }
  
  /// <summary>
  /// showLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetShowLabel(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.ShowLabel?.Value;
  }
  
  public static void SetShowLabel(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ShowLabel = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.ShowLabel = null;
  }
  
  /// <summary>
  /// getShowLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetShowLabel(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.GetShowLabel?.Value;
  }
  
  public static void SetGetShowLabel(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetShowLabel = new StringValue { Value = value };
      else
        openXmlElement.GetShowLabel = null;
  }
  
  /// <summary>
  /// showImage, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetShowImage(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.ShowImage?.Value;
  }
  
  public static void SetShowImage(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ShowImage = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.ShowImage = null;
  }
  
  /// <summary>
  /// getShowImage, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetShowImage(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    return openXmlElement?.GetShowImage?.Value;
  }
  
  public static void SetGetShowImage(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetShowImage = new StringValue { Value = value };
      else
        openXmlElement.GetShowImage = null;
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Item>? GetItems(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Item>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2010.CustomUI.Item>())
      {
        var newItem = DocumentModel.OpenXml.ItemConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetItems(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Item>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.CustomUI.Item>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.ItemConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.Item>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.ButtonRegular>? GetButtonRegulars(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.ButtonRegular>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular>())
      {
        var newItem = DocumentModel.OpenXml.ButtonRegularConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetButtonRegulars(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.ButtonRegular>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.ButtonRegularConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.GalleryRegular? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.GalleryRegular? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
