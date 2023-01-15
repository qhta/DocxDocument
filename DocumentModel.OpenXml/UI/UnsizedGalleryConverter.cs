using DocumentFormat.OpenXml.Office.CustomUI;
using UnsizedButton = DocumentModel.UI.UnsizedButton;

namespace DocumentModel.OpenXml.UI;

/// <summary>
///   Defines the UnsizedGallery Class.
/// </summary>
public static class UnsizedGalleryConverter
{
  /// <summary>
  ///   description
  /// </summary>
  public static String? GetDescription(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.Description?.Value;
  }

  public static void SetDescription(UnsizedGallery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Description = new StringValue { Value = value };
      else
        openXmlElement.Description = null;
  }

  /// <summary>
  ///   getDescription
  /// </summary>
  public static String? GetGetDescription(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.GetDescription?.Value;
  }

  public static void SetGetDescription(UnsizedGallery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetDescription = new StringValue { Value = value };
      else
        openXmlElement.GetDescription = null;
  }

  /// <summary>
  ///   invalidateContentOnDrop
  /// </summary>
  public static Boolean? GetInvalidateContentOnDrop(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.InvalidateContentOnDrop?.Value;
  }

  public static void SetInvalidateContentOnDrop(UnsizedGallery? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InvalidateContentOnDrop = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.InvalidateContentOnDrop = null;
  }

  /// <summary>
  ///   columns
  /// </summary>
  public static Int64? GetColumns(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.Columns?.Value;
  }

  public static void SetColumns(UnsizedGallery? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Columns = value;
  }

  /// <summary>
  ///   rows
  /// </summary>
  public static Int64? GetRows(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.Rows?.Value;
  }

  public static void SetRows(UnsizedGallery? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Rows = value;
  }

  /// <summary>
  ///   itemWidth
  /// </summary>
  public static Int64? GetItemWidth(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.ItemWidth?.Value;
  }

  public static void SetItemWidth(UnsizedGallery? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.ItemWidth = value;
  }

  /// <summary>
  ///   itemHeight
  /// </summary>
  public static Int64? GetItemHeight(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.ItemHeight?.Value;
  }

  public static void SetItemHeight(UnsizedGallery? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.ItemHeight = value;
  }

  /// <summary>
  ///   getItemWidth
  /// </summary>
  public static String? GetGetItemWidth(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.GetItemWidth?.Value;
  }

  public static void SetGetItemWidth(UnsizedGallery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetItemWidth = new StringValue { Value = value };
      else
        openXmlElement.GetItemWidth = null;
  }

  /// <summary>
  ///   getItemHeight
  /// </summary>
  public static String? GetGetItemHeight(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.GetItemHeight?.Value;
  }

  public static void SetGetItemHeight(UnsizedGallery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetItemHeight = new StringValue { Value = value };
      else
        openXmlElement.GetItemHeight = null;
  }

  /// <summary>
  ///   showItemLabel
  /// </summary>
  public static Boolean? GetShowItemLabel(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.ShowItemLabel?.Value;
  }

  public static void SetShowItemLabel(UnsizedGallery? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ShowItemLabel = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.ShowItemLabel = null;
  }

  /// <summary>
  ///   onAction
  /// </summary>
  public static String? GetOnAction(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.OnAction?.Value;
  }

  public static void SetOnAction(UnsizedGallery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.OnAction = new StringValue { Value = value };
      else
        openXmlElement.OnAction = null;
  }

  /// <summary>
  ///   enabled
  /// </summary>
  public static Boolean? GetEnabled(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.Enabled?.Value;
  }

  public static void SetEnabled(UnsizedGallery? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Enabled = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Enabled = null;
  }

  /// <summary>
  ///   getEnabled
  /// </summary>
  public static String? GetGetEnabled(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.GetEnabled?.Value;
  }

  public static void SetGetEnabled(UnsizedGallery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetEnabled = new StringValue { Value = value };
      else
        openXmlElement.GetEnabled = null;
  }

  /// <summary>
  ///   image
  /// </summary>
  public static String? GetImage(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.Image?.Value;
  }

  public static void SetImage(UnsizedGallery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Image = new StringValue { Value = value };
      else
        openXmlElement.Image = null;
  }

  /// <summary>
  ///   imageMso
  /// </summary>
  public static String? GetImageMso(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.ImageMso?.Value;
  }

  public static void SetImageMso(UnsizedGallery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ImageMso = new StringValue { Value = value };
      else
        openXmlElement.ImageMso = null;
  }

  /// <summary>
  ///   getImage
  /// </summary>
  public static String? GetGetImage(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.GetImage?.Value;
  }

  public static void SetGetImage(UnsizedGallery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetImage = new StringValue { Value = value };
      else
        openXmlElement.GetImage = null;
  }

  /// <summary>
  ///   showItemImage
  /// </summary>
  public static Boolean? GetShowItemImage(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.ShowItemImage?.Value;
  }

  public static void SetShowItemImage(UnsizedGallery? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ShowItemImage = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.ShowItemImage = null;
  }

  /// <summary>
  ///   getItemCount
  /// </summary>
  public static String? GetGetItemCount(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.GetItemCount?.Value;
  }

  public static void SetGetItemCount(UnsizedGallery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetItemCount = new StringValue { Value = value };
      else
        openXmlElement.GetItemCount = null;
  }

  /// <summary>
  ///   getItemLabel
  /// </summary>
  public static String? GetGetItemLabel(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.GetItemLabel?.Value;
  }

  public static void SetGetItemLabel(UnsizedGallery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetItemLabel = new StringValue { Value = value };
      else
        openXmlElement.GetItemLabel = null;
  }

  /// <summary>
  ///   getItemScreentip
  /// </summary>
  public static String? GetGetItemScreentip(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.GetItemScreentip?.Value;
  }

  public static void SetGetItemScreentip(UnsizedGallery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetItemScreentip = new StringValue { Value = value };
      else
        openXmlElement.GetItemScreentip = null;
  }

  /// <summary>
  ///   getItemSupertip
  /// </summary>
  public static String? GetGetItemSupertip(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.GetItemSupertip?.Value;
  }

  public static void SetGetItemSupertip(UnsizedGallery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetItemSupertip = new StringValue { Value = value };
      else
        openXmlElement.GetItemSupertip = null;
  }

  /// <summary>
  ///   getItemImage
  /// </summary>
  public static String? GetGetItemImage(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.GetItemImage?.Value;
  }

  public static void SetGetItemImage(UnsizedGallery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetItemImage = new StringValue { Value = value };
      else
        openXmlElement.GetItemImage = null;
  }

  /// <summary>
  ///   getItemID
  /// </summary>
  public static String? GetGetItemID(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.GetItemID?.Value;
  }

  public static void SetGetItemID(UnsizedGallery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetItemID = new StringValue { Value = value };
      else
        openXmlElement.GetItemID = null;
  }

  /// <summary>
  ///   sizeString
  /// </summary>
  public static String? GetSizeString(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.SizeString?.Value;
  }

  public static void SetSizeString(UnsizedGallery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.SizeString = new StringValue { Value = value };
      else
        openXmlElement.SizeString = null;
  }

  /// <summary>
  ///   getSelectedItemID
  /// </summary>
  public static String? GetGetSelectedItemID(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.GetSelectedItemID?.Value;
  }

  public static void SetGetSelectedItemID(UnsizedGallery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetSelectedItemID = new StringValue { Value = value };
      else
        openXmlElement.GetSelectedItemID = null;
  }

  /// <summary>
  ///   getSelectedItemIndex
  /// </summary>
  public static String? GetGetSelectedItemIndex(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.GetSelectedItemIndex?.Value;
  }

  public static void SetGetSelectedItemIndex(UnsizedGallery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetSelectedItemIndex = new StringValue { Value = value };
      else
        openXmlElement.GetSelectedItemIndex = null;
  }

  /// <summary>
  ///   id
  /// </summary>
  public static String? GetId(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(UnsizedGallery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  /// <summary>
  ///   idQ
  /// </summary>
  public static String? GetIdQ(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.IdQ?.Value;
  }

  public static void SetIdQ(UnsizedGallery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.IdQ = new StringValue { Value = value };
      else
        openXmlElement.IdQ = null;
  }

  /// <summary>
  ///   idMso
  /// </summary>
  public static String? GetIdMso(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.IdMso?.Value;
  }

  public static void SetIdMso(UnsizedGallery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.IdMso = new StringValue { Value = value };
      else
        openXmlElement.IdMso = null;
  }

  /// <summary>
  ///   tag
  /// </summary>
  public static String? GetTag(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }

  public static void SetTag(UnsizedGallery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Tag = new StringValue { Value = value };
      else
        openXmlElement.Tag = null;
  }

  /// <summary>
  ///   screentip
  /// </summary>
  public static String? GetScreentip(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.Screentip?.Value;
  }

  public static void SetScreentip(UnsizedGallery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Screentip = new StringValue { Value = value };
      else
        openXmlElement.Screentip = null;
  }

  /// <summary>
  ///   getScreentip
  /// </summary>
  public static String? GetGetScreentip(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.GetScreentip?.Value;
  }

  public static void SetGetScreentip(UnsizedGallery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetScreentip = new StringValue { Value = value };
      else
        openXmlElement.GetScreentip = null;
  }

  /// <summary>
  ///   supertip
  /// </summary>
  public static String? GetSupertip(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.Supertip?.Value;
  }

  public static void SetSupertip(UnsizedGallery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Supertip = new StringValue { Value = value };
      else
        openXmlElement.Supertip = null;
  }

  /// <summary>
  ///   getSupertip
  /// </summary>
  public static String? GetGetSupertip(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.GetSupertip?.Value;
  }

  public static void SetGetSupertip(UnsizedGallery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetSupertip = new StringValue { Value = value };
      else
        openXmlElement.GetSupertip = null;
  }

  /// <summary>
  ///   label
  /// </summary>
  public static String? GetLabel(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.Label?.Value;
  }

  public static void SetLabel(UnsizedGallery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Label = new StringValue { Value = value };
      else
        openXmlElement.Label = null;
  }

  /// <summary>
  ///   getLabel
  /// </summary>
  public static String? GetGetLabel(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.GetLabel?.Value;
  }

  public static void SetGetLabel(UnsizedGallery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetLabel = new StringValue { Value = value };
      else
        openXmlElement.GetLabel = null;
  }

  /// <summary>
  ///   insertAfterMso
  /// </summary>
  public static String? GetInsertAfterMso(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.InsertAfterMso?.Value;
  }

  public static void SetInsertAfterMso(UnsizedGallery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsertAfterMso = new StringValue { Value = value };
      else
        openXmlElement.InsertAfterMso = null;
  }

  /// <summary>
  ///   insertBeforeMso
  /// </summary>
  public static String? GetInsertBeforeMso(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.InsertBeforeMso?.Value;
  }

  public static void SetInsertBeforeMso(UnsizedGallery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsertBeforeMso = new StringValue { Value = value };
      else
        openXmlElement.InsertBeforeMso = null;
  }

  /// <summary>
  ///   insertAfterQ
  /// </summary>
  public static String? GetInsertAfterQ(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.InsertAfterQ?.Value;
  }

  public static void SetInsertAfterQ(UnsizedGallery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsertAfterQ = new StringValue { Value = value };
      else
        openXmlElement.InsertAfterQ = null;
  }

  /// <summary>
  ///   insertBeforeQ
  /// </summary>
  public static String? GetInsertBeforeQ(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.InsertBeforeQ?.Value;
  }

  public static void SetInsertBeforeQ(UnsizedGallery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsertBeforeQ = new StringValue { Value = value };
      else
        openXmlElement.InsertBeforeQ = null;
  }

  /// <summary>
  ///   visible
  /// </summary>
  public static Boolean? GetVisible(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }

  public static void SetVisible(UnsizedGallery? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Visible = null;
  }

  /// <summary>
  ///   getVisible
  /// </summary>
  public static String? GetGetVisible(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }

  public static void SetGetVisible(UnsizedGallery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetVisible = new StringValue { Value = value };
      else
        openXmlElement.GetVisible = null;
  }

  /// <summary>
  ///   keytip
  /// </summary>
  public static String? GetKeytip(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.Keytip?.Value;
  }

  public static void SetKeytip(UnsizedGallery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Keytip = new StringValue { Value = value };
      else
        openXmlElement.Keytip = null;
  }

  /// <summary>
  ///   getKeytip
  /// </summary>
  public static String? GetGetKeytip(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.GetKeytip?.Value;
  }

  public static void SetGetKeytip(UnsizedGallery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetKeytip = new StringValue { Value = value };
      else
        openXmlElement.GetKeytip = null;
  }

  /// <summary>
  ///   showLabel
  /// </summary>
  public static Boolean? GetShowLabel(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.ShowLabel?.Value;
  }

  public static void SetShowLabel(UnsizedGallery? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ShowLabel = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.ShowLabel = null;
  }

  /// <summary>
  ///   getShowLabel
  /// </summary>
  public static String? GetGetShowLabel(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.GetShowLabel?.Value;
  }

  public static void SetGetShowLabel(UnsizedGallery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetShowLabel = new StringValue { Value = value };
      else
        openXmlElement.GetShowLabel = null;
  }

  /// <summary>
  ///   showImage
  /// </summary>
  public static Boolean? GetShowImage(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.ShowImage?.Value;
  }

  public static void SetShowImage(UnsizedGallery? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ShowImage = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.ShowImage = null;
  }

  /// <summary>
  ///   getShowImage
  /// </summary>
  public static String? GetGetShowImage(UnsizedGallery? openXmlElement)
  {
    return openXmlElement?.GetShowImage?.Value;
  }

  public static void SetGetShowImage(UnsizedGallery? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetShowImage = new StringValue { Value = value };
      else
        openXmlElement.GetShowImage = null;
  }

  public static Collection<DocumentModel.UI.Item>? GetItems(UnsizedGallery? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<DocumentModel.UI.Item>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office.CustomUI.Item>())
      {
        var newItem = ItemConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetItems(UnsizedGallery? openXmlElement, Collection<DocumentModel.UI.Item>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.CustomUI.Item>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = ItemConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.Item>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static Collection<UnsizedButton>? GetUnsizedButtons(UnsizedGallery? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<UnsizedButton>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton>())
      {
        var newItem = UnsizedButtonConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetUnsizedButtons(UnsizedGallery? openXmlElement, Collection<UnsizedButton>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = UnsizedButtonConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.UI.UnsizedGallery? CreateModelElement(UnsizedGallery? openXmlElement)
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
    where OpenXmlElementType : UnsizedGallery, new()
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