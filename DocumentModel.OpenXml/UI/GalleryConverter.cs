namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the Gallery Class.
/// </summary>
public static class GalleryConverter
{
  /// <summary>
  /// size
  /// </summary>
  public static DocumentModel.UI.SizeKind? GetSize(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues, DocumentModel.UI.SizeKind>(openXmlElement?.Size?.Value);
  }
  
  public static void SetSize(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, DocumentModel.UI.SizeKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Size = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues, DocumentModel.UI.SizeKind>(value);
  }
  
  /// <summary>
  /// getSize
  /// </summary>
  public static String? GetGetSize(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetSize(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// description
  /// </summary>
  public static String? GetDescription(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetDescription(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getDescription
  /// </summary>
  public static String? GetGetDescription(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetDescription(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// invalidateContentOnDrop
  /// </summary>
  public static Boolean? GetInvalidateContentOnDrop(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetInvalidateContentOnDrop(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// columns
  /// </summary>
  public static Int32? GetColumns(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetColumns(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// rows
  /// </summary>
  public static Int32? GetRows(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRows(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// itemWidth
  /// </summary>
  public static Int32? GetItemWidth(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetItemWidth(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// itemHeight
  /// </summary>
  public static Int32? GetItemHeight(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetItemHeight(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getItemWidth
  /// </summary>
  public static String? GetGetItemWidth(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetItemWidth(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getItemHeight
  /// </summary>
  public static String? GetGetItemHeight(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetItemHeight(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// showItemLabel
  /// </summary>
  public static Boolean? GetShowItemLabel(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShowItemLabel(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// onAction
  /// </summary>
  public static String? GetOnAction(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetOnAction(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// enabled
  /// </summary>
  public static Boolean? GetEnabled(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetEnabled(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getEnabled
  /// </summary>
  public static String? GetGetEnabled(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetEnabled(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// image
  /// </summary>
  public static String? GetImage(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetImage(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// imageMso
  /// </summary>
  public static String? GetImageMso(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetImageMso(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getImage
  /// </summary>
  public static String? GetGetImage(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetImage(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// showItemImage
  /// </summary>
  public static Boolean? GetShowItemImage(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShowItemImage(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getItemCount
  /// </summary>
  public static String? GetGetItemCount(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetItemCount(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getItemLabel
  /// </summary>
  public static String? GetGetItemLabel(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetItemLabel(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getItemScreentip
  /// </summary>
  public static String? GetGetItemScreentip(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetItemScreentip(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getItemSupertip
  /// </summary>
  public static String? GetGetItemSupertip(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetItemSupertip(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getItemImage
  /// </summary>
  public static String? GetGetItemImage(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetItemImage(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getItemID
  /// </summary>
  public static String? GetGetItemID(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetItemID(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// sizeString
  /// </summary>
  public static String? GetSizeString(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetSizeString(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getSelectedItemID
  /// </summary>
  public static String? GetGetSelectedItemID(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetSelectedItemID(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getSelectedItemIndex
  /// </summary>
  public static String? GetGetSelectedItemIndex(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetSelectedItemIndex(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// id
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetId(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// idQ
  /// </summary>
  public static String? GetIdQ(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetIdQ(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// idMso
  /// </summary>
  public static String? GetIdMso(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetIdMso(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// tag
  /// </summary>
  public static String? GetTag(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetTag(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// screentip
  /// </summary>
  public static String? GetScreentip(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetScreentip(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getScreentip
  /// </summary>
  public static String? GetGetScreentip(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetScreentip(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// supertip
  /// </summary>
  public static String? GetSupertip(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetSupertip(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getSupertip
  /// </summary>
  public static String? GetGetSupertip(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetSupertip(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// label
  /// </summary>
  public static String? GetLabel(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetLabel(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getLabel
  /// </summary>
  public static String? GetGetLabel(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetLabel(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// insertAfterMso
  /// </summary>
  public static String? GetInsertAfterMso(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetInsertAfterMso(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// insertBeforeMso
  /// </summary>
  public static String? GetInsertBeforeMso(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetInsertBeforeMso(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// insertAfterQ
  /// </summary>
  public static String? GetInsertAfterQ(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetInsertAfterQ(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// insertBeforeQ
  /// </summary>
  public static String? GetInsertBeforeQ(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetInsertBeforeQ(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// visible
  /// </summary>
  public static Boolean? GetVisible(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetVisible(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getVisible
  /// </summary>
  public static String? GetGetVisible(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetVisible(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// keytip
  /// </summary>
  public static String? GetKeytip(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetKeytip(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getKeytip
  /// </summary>
  public static String? GetGetKeytip(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetKeytip(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// showLabel
  /// </summary>
  public static Boolean? GetShowLabel(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShowLabel(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getShowLabel
  /// </summary>
  public static String? GetGetShowLabel(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetShowLabel(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// showImage
  /// </summary>
  public static Boolean? GetShowImage(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShowImage(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getShowImage
  /// </summary>
  public static String? GetGetShowImage(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetShowImage(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.UI.Item>? GetItems(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetItems(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.UI.Item>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.UI.UnsizedButton>? GetUnsizedButtons(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetUnsizedButtons(DocumentFormat.OpenXml.Office.CustomUI.Gallery? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.UI.UnsizedButton>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
