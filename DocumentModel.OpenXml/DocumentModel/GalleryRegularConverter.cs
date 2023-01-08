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
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetDescription(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getDescription, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetDescription(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetDescription(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// invalidateContentOnDrop, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetInvalidateContentOnDrop(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetInvalidateContentOnDrop(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// columns, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetColumns(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetColumns(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// rows, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetRows(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRows(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// itemWidth, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetItemWidth(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetItemWidth(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// itemHeight, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetItemHeight(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetItemHeight(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getItemWidth, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetItemWidth(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetItemWidth(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getItemHeight, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetItemHeight(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetItemHeight(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// showItemLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetShowItemLabel(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShowItemLabel(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
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
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetOnAction(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// enabled, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getEnabled, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// image, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetImage(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetImage(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// imageMso, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetImageMso(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetImageMso(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getImage, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetImage(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetImage(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// showItemImage, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetShowItemImage(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShowItemImage(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getItemCount, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetItemCount(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetItemCount(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getItemLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetItemLabel(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetItemLabel(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getItemScreentip, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetItemScreentip(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetItemScreentip(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getItemSupertip, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetItemSupertip(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetItemSupertip(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getItemImage, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetItemImage(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetItemImage(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getItemID, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetItemID(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetItemID(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// sizeString, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetSizeString(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetSizeString(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getSelectedItemID, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetSelectedItemID(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetSelectedItemID(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getSelectedItemIndex, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetSelectedItemIndex(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetSelectedItemIndex(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetId(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetTag(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetTag(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// idMso, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetIdMso(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetIdMso(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// screentip, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetScreentip(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetScreentip(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getScreentip, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetScreentip(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetScreentip(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// supertip, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetSupertip(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetSupertip(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getSupertip, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetSupertip(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetSupertip(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetInsertAfterMso(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetInsertAfterMso(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// insertBeforeMso, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetInsertBeforeMso(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetInsertBeforeMso(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// insertAfterQ, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetInsertAfterQulifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetInsertAfterQulifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// insertBeforeQ, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetInsertBeforeQulifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetInsertBeforeQulifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// keytip, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getKeytip, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// showLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetShowLabel(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShowLabel(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getShowLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetShowLabel(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetShowLabel(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// showImage, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetShowImage(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShowImage(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getShowImage, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetShowImage(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetShowImage(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Item>? GetItems(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetItems(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Item>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.ButtonRegular>? GetButtonRegulars(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetButtonRegulars(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.ButtonRegular>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
