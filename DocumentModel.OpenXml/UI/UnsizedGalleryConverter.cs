namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the UnsizedGallery Class.
/// </summary>
public static class UnsizedGalleryConverter
{
  /// <summary>
  /// description
  /// </summary>
  private static String? GetDescription(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.Description?.Value;
  }
  
  private static void SetDescription(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Description = new StringValue { Value = value };
    else
      openXmlElement.Description = null;
  }
  
  /// <summary>
  /// getDescription
  /// </summary>
  private static String? GetGetDescription(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.GetDescription?.Value;
  }
  
  private static void SetGetDescription(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetDescription = new StringValue { Value = value };
    else
      openXmlElement.GetDescription = null;
  }
  
  /// <summary>
  /// invalidateContentOnDrop
  /// </summary>
  private static Boolean? GetInvalidateContentOnDrop(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.InvalidateContentOnDrop?.Value;
  }
  
  private static void SetInvalidateContentOnDrop(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.InvalidateContentOnDrop = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.InvalidateContentOnDrop = null;
  }
  
  /// <summary>
  /// columns
  /// </summary>
  private static Int64? GetColumns(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement.Columns?.Value;
  }
  
  private static void SetColumns(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, Int64? value)
  {
    openXmlElement.Columns = value;
  }
  
  /// <summary>
  /// rows
  /// </summary>
  private static Int64? GetRows(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement.Rows?.Value;
  }
  
  private static void SetRows(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, Int64? value)
  {
    openXmlElement.Rows = value;
  }
  
  /// <summary>
  /// itemWidth
  /// </summary>
  private static Int64? GetItemWidth(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement.ItemWidth?.Value;
  }
  
  private static void SetItemWidth(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, Int64? value)
  {
    openXmlElement.ItemWidth = value;
  }
  
  /// <summary>
  /// itemHeight
  /// </summary>
  private static Int64? GetItemHeight(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement.ItemHeight?.Value;
  }
  
  private static void SetItemHeight(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, Int64? value)
  {
    openXmlElement.ItemHeight = value;
  }
  
  /// <summary>
  /// getItemWidth
  /// </summary>
  private static String? GetGetItemWidth(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.GetItemWidth?.Value;
  }
  
  private static void SetGetItemWidth(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetItemWidth = new StringValue { Value = value };
    else
      openXmlElement.GetItemWidth = null;
  }
  
  /// <summary>
  /// getItemHeight
  /// </summary>
  private static String? GetGetItemHeight(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.GetItemHeight?.Value;
  }
  
  private static void SetGetItemHeight(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetItemHeight = new StringValue { Value = value };
    else
      openXmlElement.GetItemHeight = null;
  }
  
  /// <summary>
  /// showItemLabel
  /// </summary>
  private static Boolean? GetShowItemLabel(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.ShowItemLabel?.Value;
  }
  
  private static void SetShowItemLabel(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowItemLabel = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowItemLabel = null;
  }
  
  /// <summary>
  /// onAction
  /// </summary>
  private static String? GetOnAction(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.OnAction?.Value;
  }
  
  private static void SetOnAction(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.OnAction = new StringValue { Value = value };
    else
      openXmlElement.OnAction = null;
  }
  
  /// <summary>
  /// enabled
  /// </summary>
  private static Boolean? GetEnabled(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.Enabled?.Value;
  }
  
  private static void SetEnabled(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Enabled = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Enabled = null;
  }
  
  /// <summary>
  /// getEnabled
  /// </summary>
  private static String? GetGetEnabled(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.GetEnabled?.Value;
  }
  
  private static void SetGetEnabled(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetEnabled = new StringValue { Value = value };
    else
      openXmlElement.GetEnabled = null;
  }
  
  /// <summary>
  /// image
  /// </summary>
  private static String? GetImage(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.Image?.Value;
  }
  
  private static void SetImage(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Image = new StringValue { Value = value };
    else
      openXmlElement.Image = null;
  }
  
  /// <summary>
  /// imageMso
  /// </summary>
  private static String? GetImageMso(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.ImageMso?.Value;
  }
  
  private static void SetImageMso(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ImageMso = new StringValue { Value = value };
    else
      openXmlElement.ImageMso = null;
  }
  
  /// <summary>
  /// getImage
  /// </summary>
  private static String? GetGetImage(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.GetImage?.Value;
  }
  
  private static void SetGetImage(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetImage = new StringValue { Value = value };
    else
      openXmlElement.GetImage = null;
  }
  
  /// <summary>
  /// showItemImage
  /// </summary>
  private static Boolean? GetShowItemImage(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.ShowItemImage?.Value;
  }
  
  private static void SetShowItemImage(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowItemImage = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowItemImage = null;
  }
  
  /// <summary>
  /// getItemCount
  /// </summary>
  private static String? GetGetItemCount(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.GetItemCount?.Value;
  }
  
  private static void SetGetItemCount(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetItemCount = new StringValue { Value = value };
    else
      openXmlElement.GetItemCount = null;
  }
  
  /// <summary>
  /// getItemLabel
  /// </summary>
  private static String? GetGetItemLabel(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.GetItemLabel?.Value;
  }
  
  private static void SetGetItemLabel(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetItemLabel = new StringValue { Value = value };
    else
      openXmlElement.GetItemLabel = null;
  }
  
  /// <summary>
  /// getItemScreentip
  /// </summary>
  private static String? GetGetItemScreentip(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.GetItemScreentip?.Value;
  }
  
  private static void SetGetItemScreentip(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetItemScreentip = new StringValue { Value = value };
    else
      openXmlElement.GetItemScreentip = null;
  }
  
  /// <summary>
  /// getItemSupertip
  /// </summary>
  private static String? GetGetItemSupertip(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.GetItemSupertip?.Value;
  }
  
  private static void SetGetItemSupertip(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetItemSupertip = new StringValue { Value = value };
    else
      openXmlElement.GetItemSupertip = null;
  }
  
  /// <summary>
  /// getItemImage
  /// </summary>
  private static String? GetGetItemImage(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.GetItemImage?.Value;
  }
  
  private static void SetGetItemImage(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetItemImage = new StringValue { Value = value };
    else
      openXmlElement.GetItemImage = null;
  }
  
  /// <summary>
  /// getItemID
  /// </summary>
  private static String? GetGetItemID(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.GetItemID?.Value;
  }
  
  private static void SetGetItemID(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetItemID = new StringValue { Value = value };
    else
      openXmlElement.GetItemID = null;
  }
  
  /// <summary>
  /// sizeString
  /// </summary>
  private static String? GetSizeString(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.SizeString?.Value;
  }
  
  private static void SetSizeString(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.SizeString = new StringValue { Value = value };
    else
      openXmlElement.SizeString = null;
  }
  
  /// <summary>
  /// getSelectedItemID
  /// </summary>
  private static String? GetGetSelectedItemID(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.GetSelectedItemID?.Value;
  }
  
  private static void SetGetSelectedItemID(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetSelectedItemID = new StringValue { Value = value };
    else
      openXmlElement.GetSelectedItemID = null;
  }
  
  /// <summary>
  /// getSelectedItemIndex
  /// </summary>
  private static String? GetGetSelectedItemIndex(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.GetSelectedItemIndex?.Value;
  }
  
  private static void SetGetSelectedItemIndex(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetSelectedItemIndex = new StringValue { Value = value };
    else
      openXmlElement.GetSelectedItemIndex = null;
  }
  
  /// <summary>
  /// id
  /// </summary>
  private static String? GetId(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// idQ
  /// </summary>
  private static String? GetIdQ(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.IdQ?.Value;
  }
  
  private static void SetIdQ(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.IdQ = new StringValue { Value = value };
    else
      openXmlElement.IdQ = null;
  }
  
  /// <summary>
  /// idMso
  /// </summary>
  private static String? GetIdMso(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.IdMso?.Value;
  }
  
  private static void SetIdMso(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.IdMso = new StringValue { Value = value };
    else
      openXmlElement.IdMso = null;
  }
  
  /// <summary>
  /// tag
  /// </summary>
  private static String? GetTag(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }
  
  private static void SetTag(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Tag = new StringValue { Value = value };
    else
      openXmlElement.Tag = null;
  }
  
  /// <summary>
  /// screentip
  /// </summary>
  private static String? GetScreentip(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.Screentip?.Value;
  }
  
  private static void SetScreentip(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Screentip = new StringValue { Value = value };
    else
      openXmlElement.Screentip = null;
  }
  
  /// <summary>
  /// getScreentip
  /// </summary>
  private static String? GetGetScreentip(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.GetScreentip?.Value;
  }
  
  private static void SetGetScreentip(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetScreentip = new StringValue { Value = value };
    else
      openXmlElement.GetScreentip = null;
  }
  
  /// <summary>
  /// supertip
  /// </summary>
  private static String? GetSupertip(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.Supertip?.Value;
  }
  
  private static void SetSupertip(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Supertip = new StringValue { Value = value };
    else
      openXmlElement.Supertip = null;
  }
  
  /// <summary>
  /// getSupertip
  /// </summary>
  private static String? GetGetSupertip(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.GetSupertip?.Value;
  }
  
  private static void SetGetSupertip(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetSupertip = new StringValue { Value = value };
    else
      openXmlElement.GetSupertip = null;
  }
  
  /// <summary>
  /// label
  /// </summary>
  private static String? GetLabel(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.Label?.Value;
  }
  
  private static void SetLabel(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Label = new StringValue { Value = value };
    else
      openXmlElement.Label = null;
  }
  
  /// <summary>
  /// getLabel
  /// </summary>
  private static String? GetGetLabel(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.GetLabel?.Value;
  }
  
  private static void SetGetLabel(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetLabel = new StringValue { Value = value };
    else
      openXmlElement.GetLabel = null;
  }
  
  /// <summary>
  /// insertAfterMso
  /// </summary>
  private static String? GetInsertAfterMso(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.InsertAfterMso?.Value;
  }
  
  private static void SetInsertAfterMso(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterMso = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterMso = null;
  }
  
  /// <summary>
  /// insertBeforeMso
  /// </summary>
  private static String? GetInsertBeforeMso(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.InsertBeforeMso?.Value;
  }
  
  private static void SetInsertBeforeMso(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeMso = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeMso = null;
  }
  
  /// <summary>
  /// insertAfterQ
  /// </summary>
  private static String? GetInsertAfterQ(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.InsertAfterQ?.Value;
  }
  
  private static void SetInsertAfterQ(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterQ = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterQ = null;
  }
  
  /// <summary>
  /// insertBeforeQ
  /// </summary>
  private static String? GetInsertBeforeQ(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.InsertBeforeQ?.Value;
  }
  
  private static void SetInsertBeforeQ(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeQ = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeQ = null;
  }
  
  /// <summary>
  /// visible
  /// </summary>
  private static Boolean? GetVisible(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static void SetVisible(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible
  /// </summary>
  private static String? GetGetVisible(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }
  
  private static void SetGetVisible(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetVisible = new StringValue { Value = value };
    else
      openXmlElement.GetVisible = null;
  }
  
  /// <summary>
  /// keytip
  /// </summary>
  private static String? GetKeytip(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.Keytip?.Value;
  }
  
  private static void SetKeytip(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Keytip = new StringValue { Value = value };
    else
      openXmlElement.Keytip = null;
  }
  
  /// <summary>
  /// getKeytip
  /// </summary>
  private static String? GetGetKeytip(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.GetKeytip?.Value;
  }
  
  private static void SetGetKeytip(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetKeytip = new StringValue { Value = value };
    else
      openXmlElement.GetKeytip = null;
  }
  
  /// <summary>
  /// showLabel
  /// </summary>
  private static Boolean? GetShowLabel(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.ShowLabel?.Value;
  }
  
  private static void SetShowLabel(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowLabel = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowLabel = null;
  }
  
  /// <summary>
  /// getShowLabel
  /// </summary>
  private static String? GetGetShowLabel(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.GetShowLabel?.Value;
  }
  
  private static void SetGetShowLabel(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetShowLabel = new StringValue { Value = value };
    else
      openXmlElement.GetShowLabel = null;
  }
  
  /// <summary>
  /// showImage
  /// </summary>
  private static Boolean? GetShowImage(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.ShowImage?.Value;
  }
  
  private static void SetShowImage(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowImage = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowImage = null;
  }
  
  /// <summary>
  /// getShowImage
  /// </summary>
  private static String? GetGetShowImage(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    return openXmlElement?.GetShowImage?.Value;
  }
  
  private static void SetGetShowImage(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetShowImage = new StringValue { Value = value };
    else
      openXmlElement.GetShowImage = null;
  }
  
  private static System.Collections.ObjectModel.Collection<DocumentModel.UI.Item> GetItems(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.UI.Item>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office.CustomUI.Item>())
    {
      var newItem = DocumentModel.OpenXml.UI.ItemConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetItems(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.UI.Item>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.CustomUI.Item>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.UI.ItemConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.Item>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static System.Collections.ObjectModel.Collection<DocumentModel.UI.UnsizedButton> GetUnsizedButtons(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.UI.UnsizedButton>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton>())
    {
      var newItem = DocumentModel.OpenXml.UI.UnsizedButtonConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetUnsizedButtons(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.UI.UnsizedButton>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.UI.UnsizedButtonConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.UI.UnsizedGallery? CreateModelElement(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.UI.UnsizedGallery? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      return openXmlElement;
    }
    return default;
  }
}
