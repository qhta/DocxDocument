namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the DropDown Class.
/// </summary>
public static class DropDownConverter
{
  /// <summary>
  /// onAction
  /// </summary>
  private static String? GetOnAction(DXOCustUI.DropDown openXmlElement)
  {
    return openXmlElement?.OnAction?.Value;
  }
  
  private static void SetOnAction(DXOCustUI.DropDown openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.OnAction = new StringValue { Value = value };
    else
      openXmlElement.OnAction = null;
  }
  
  /// <summary>
  /// enabled
  /// </summary>
  private static Boolean? GetEnabled(DXOCustUI.DropDown openXmlElement)
  {
    return openXmlElement?.Enabled?.Value;
  }
  
  private static void SetEnabled(DXOCustUI.DropDown openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Enabled = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Enabled = null;
  }
  
  /// <summary>
  /// getEnabled
  /// </summary>
  private static String? GetGetEnabled(DXOCustUI.DropDown openXmlElement)
  {
    return openXmlElement?.GetEnabled?.Value;
  }
  
  private static void SetGetEnabled(DXOCustUI.DropDown openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetEnabled = new StringValue { Value = value };
    else
      openXmlElement.GetEnabled = null;
  }
  
  /// <summary>
  /// image
  /// </summary>
  private static String? GetImage(DXOCustUI.DropDown openXmlElement)
  {
    return openXmlElement?.Image?.Value;
  }
  
  private static void SetImage(DXOCustUI.DropDown openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Image = new StringValue { Value = value };
    else
      openXmlElement.Image = null;
  }
  
  /// <summary>
  /// imageMso
  /// </summary>
  private static String? GetImageMso(DXOCustUI.DropDown openXmlElement)
  {
    return openXmlElement?.ImageMso?.Value;
  }
  
  private static void SetImageMso(DXOCustUI.DropDown openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ImageMso = new StringValue { Value = value };
    else
      openXmlElement.ImageMso = null;
  }
  
  /// <summary>
  /// getImage
  /// </summary>
  private static String? GetGetImage(DXOCustUI.DropDown openXmlElement)
  {
    return openXmlElement?.GetImage?.Value;
  }
  
  private static void SetGetImage(DXOCustUI.DropDown openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetImage = new StringValue { Value = value };
    else
      openXmlElement.GetImage = null;
  }
  
  /// <summary>
  /// showItemImage
  /// </summary>
  private static Boolean? GetShowItemImage(DXOCustUI.DropDown openXmlElement)
  {
    return openXmlElement?.ShowItemImage?.Value;
  }
  
  private static void SetShowItemImage(DXOCustUI.DropDown openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowItemImage = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowItemImage = null;
  }
  
  /// <summary>
  /// getItemCount
  /// </summary>
  private static String? GetGetItemCount(DXOCustUI.DropDown openXmlElement)
  {
    return openXmlElement?.GetItemCount?.Value;
  }
  
  private static void SetGetItemCount(DXOCustUI.DropDown openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetItemCount = new StringValue { Value = value };
    else
      openXmlElement.GetItemCount = null;
  }
  
  /// <summary>
  /// getItemLabel
  /// </summary>
  private static String? GetGetItemLabel(DXOCustUI.DropDown openXmlElement)
  {
    return openXmlElement?.GetItemLabel?.Value;
  }
  
  private static void SetGetItemLabel(DXOCustUI.DropDown openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetItemLabel = new StringValue { Value = value };
    else
      openXmlElement.GetItemLabel = null;
  }
  
  /// <summary>
  /// getItemScreentip
  /// </summary>
  private static String? GetGetItemScreentip(DXOCustUI.DropDown openXmlElement)
  {
    return openXmlElement?.GetItemScreentip?.Value;
  }
  
  private static void SetGetItemScreentip(DXOCustUI.DropDown openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetItemScreentip = new StringValue { Value = value };
    else
      openXmlElement.GetItemScreentip = null;
  }
  
  /// <summary>
  /// getItemSupertip
  /// </summary>
  private static String? GetGetItemSupertip(DXOCustUI.DropDown openXmlElement)
  {
    return openXmlElement?.GetItemSupertip?.Value;
  }
  
  private static void SetGetItemSupertip(DXOCustUI.DropDown openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetItemSupertip = new StringValue { Value = value };
    else
      openXmlElement.GetItemSupertip = null;
  }
  
  /// <summary>
  /// getItemImage
  /// </summary>
  private static String? GetGetItemImage(DXOCustUI.DropDown openXmlElement)
  {
    return openXmlElement?.GetItemImage?.Value;
  }
  
  private static void SetGetItemImage(DXOCustUI.DropDown openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetItemImage = new StringValue { Value = value };
    else
      openXmlElement.GetItemImage = null;
  }
  
  /// <summary>
  /// getItemID
  /// </summary>
  private static String? GetGetItemID(DXOCustUI.DropDown openXmlElement)
  {
    return openXmlElement?.GetItemID?.Value;
  }
  
  private static void SetGetItemID(DXOCustUI.DropDown openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetItemID = new StringValue { Value = value };
    else
      openXmlElement.GetItemID = null;
  }
  
  /// <summary>
  /// sizeString
  /// </summary>
  private static String? GetSizeString(DXOCustUI.DropDown openXmlElement)
  {
    return openXmlElement?.SizeString?.Value;
  }
  
  private static void SetSizeString(DXOCustUI.DropDown openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.SizeString = new StringValue { Value = value };
    else
      openXmlElement.SizeString = null;
  }
  
  /// <summary>
  /// getSelectedItemID
  /// </summary>
  private static String? GetGetSelectedItemID(DXOCustUI.DropDown openXmlElement)
  {
    return openXmlElement?.GetSelectedItemID?.Value;
  }
  
  private static void SetGetSelectedItemID(DXOCustUI.DropDown openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetSelectedItemID = new StringValue { Value = value };
    else
      openXmlElement.GetSelectedItemID = null;
  }
  
  /// <summary>
  /// getSelectedItemIndex
  /// </summary>
  private static String? GetGetSelectedItemIndex(DXOCustUI.DropDown openXmlElement)
  {
    return openXmlElement?.GetSelectedItemIndex?.Value;
  }
  
  private static void SetGetSelectedItemIndex(DXOCustUI.DropDown openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetSelectedItemIndex = new StringValue { Value = value };
    else
      openXmlElement.GetSelectedItemIndex = null;
  }
  
  /// <summary>
  /// showItemLabel
  /// </summary>
  private static Boolean? GetShowItemLabel(DXOCustUI.DropDown openXmlElement)
  {
    return openXmlElement?.ShowItemLabel?.Value;
  }
  
  private static void SetShowItemLabel(DXOCustUI.DropDown openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowItemLabel = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowItemLabel = null;
  }
  
  /// <summary>
  /// id
  /// </summary>
  private static String? GetId(DXOCustUI.DropDown openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXOCustUI.DropDown openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// idQ
  /// </summary>
  private static String? GetIdQ(DXOCustUI.DropDown openXmlElement)
  {
    return openXmlElement?.IdQ?.Value;
  }
  
  private static void SetIdQ(DXOCustUI.DropDown openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.IdQ = new StringValue { Value = value };
    else
      openXmlElement.IdQ = null;
  }
  
  /// <summary>
  /// idMso
  /// </summary>
  private static String? GetIdMso(DXOCustUI.DropDown openXmlElement)
  {
    return openXmlElement?.IdMso?.Value;
  }
  
  private static void SetIdMso(DXOCustUI.DropDown openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.IdMso = new StringValue { Value = value };
    else
      openXmlElement.IdMso = null;
  }
  
  /// <summary>
  /// tag
  /// </summary>
  private static String? GetTag(DXOCustUI.DropDown openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }
  
  private static void SetTag(DXOCustUI.DropDown openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Tag = new StringValue { Value = value };
    else
      openXmlElement.Tag = null;
  }
  
  /// <summary>
  /// screentip
  /// </summary>
  private static String? GetScreentip(DXOCustUI.DropDown openXmlElement)
  {
    return openXmlElement?.Screentip?.Value;
  }
  
  private static void SetScreentip(DXOCustUI.DropDown openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Screentip = new StringValue { Value = value };
    else
      openXmlElement.Screentip = null;
  }
  
  /// <summary>
  /// getScreentip
  /// </summary>
  private static String? GetGetScreentip(DXOCustUI.DropDown openXmlElement)
  {
    return openXmlElement?.GetScreentip?.Value;
  }
  
  private static void SetGetScreentip(DXOCustUI.DropDown openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetScreentip = new StringValue { Value = value };
    else
      openXmlElement.GetScreentip = null;
  }
  
  /// <summary>
  /// supertip
  /// </summary>
  private static String? GetSupertip(DXOCustUI.DropDown openXmlElement)
  {
    return openXmlElement?.Supertip?.Value;
  }
  
  private static void SetSupertip(DXOCustUI.DropDown openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Supertip = new StringValue { Value = value };
    else
      openXmlElement.Supertip = null;
  }
  
  /// <summary>
  /// getSupertip
  /// </summary>
  private static String? GetGetSupertip(DXOCustUI.DropDown openXmlElement)
  {
    return openXmlElement?.GetSupertip?.Value;
  }
  
  private static void SetGetSupertip(DXOCustUI.DropDown openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetSupertip = new StringValue { Value = value };
    else
      openXmlElement.GetSupertip = null;
  }
  
  /// <summary>
  /// label
  /// </summary>
  private static String? GetLabel(DXOCustUI.DropDown openXmlElement)
  {
    return openXmlElement?.Label?.Value;
  }
  
  private static void SetLabel(DXOCustUI.DropDown openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Label = new StringValue { Value = value };
    else
      openXmlElement.Label = null;
  }
  
  /// <summary>
  /// getLabel
  /// </summary>
  private static String? GetGetLabel(DXOCustUI.DropDown openXmlElement)
  {
    return openXmlElement?.GetLabel?.Value;
  }
  
  private static void SetGetLabel(DXOCustUI.DropDown openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetLabel = new StringValue { Value = value };
    else
      openXmlElement.GetLabel = null;
  }
  
  /// <summary>
  /// insertAfterMso
  /// </summary>
  private static String? GetInsertAfterMso(DXOCustUI.DropDown openXmlElement)
  {
    return openXmlElement?.InsertAfterMso?.Value;
  }
  
  private static void SetInsertAfterMso(DXOCustUI.DropDown openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterMso = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterMso = null;
  }
  
  /// <summary>
  /// insertBeforeMso
  /// </summary>
  private static String? GetInsertBeforeMso(DXOCustUI.DropDown openXmlElement)
  {
    return openXmlElement?.InsertBeforeMso?.Value;
  }
  
  private static void SetInsertBeforeMso(DXOCustUI.DropDown openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeMso = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeMso = null;
  }
  
  /// <summary>
  /// insertAfterQ
  /// </summary>
  private static String? GetInsertAfterQ(DXOCustUI.DropDown openXmlElement)
  {
    return openXmlElement?.InsertAfterQ?.Value;
  }
  
  private static void SetInsertAfterQ(DXOCustUI.DropDown openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterQ = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterQ = null;
  }
  
  /// <summary>
  /// insertBeforeQ
  /// </summary>
  private static String? GetInsertBeforeQ(DXOCustUI.DropDown openXmlElement)
  {
    return openXmlElement?.InsertBeforeQ?.Value;
  }
  
  private static void SetInsertBeforeQ(DXOCustUI.DropDown openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeQ = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeQ = null;
  }
  
  /// <summary>
  /// visible
  /// </summary>
  private static Boolean? GetVisible(DXOCustUI.DropDown openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static void SetVisible(DXOCustUI.DropDown openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible
  /// </summary>
  private static String? GetGetVisible(DXOCustUI.DropDown openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }
  
  private static void SetGetVisible(DXOCustUI.DropDown openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetVisible = new StringValue { Value = value };
    else
      openXmlElement.GetVisible = null;
  }
  
  /// <summary>
  /// keytip
  /// </summary>
  private static String? GetKeytip(DXOCustUI.DropDown openXmlElement)
  {
    return openXmlElement?.Keytip?.Value;
  }
  
  private static void SetKeytip(DXOCustUI.DropDown openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Keytip = new StringValue { Value = value };
    else
      openXmlElement.Keytip = null;
  }
  
  /// <summary>
  /// getKeytip
  /// </summary>
  private static String? GetGetKeytip(DXOCustUI.DropDown openXmlElement)
  {
    return openXmlElement?.GetKeytip?.Value;
  }
  
  private static void SetGetKeytip(DXOCustUI.DropDown openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetKeytip = new StringValue { Value = value };
    else
      openXmlElement.GetKeytip = null;
  }
  
  /// <summary>
  /// showLabel
  /// </summary>
  private static Boolean? GetShowLabel(DXOCustUI.DropDown openXmlElement)
  {
    return openXmlElement?.ShowLabel?.Value;
  }
  
  private static void SetShowLabel(DXOCustUI.DropDown openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowLabel = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowLabel = null;
  }
  
  /// <summary>
  /// getShowLabel
  /// </summary>
  private static String? GetGetShowLabel(DXOCustUI.DropDown openXmlElement)
  {
    return openXmlElement?.GetShowLabel?.Value;
  }
  
  private static void SetGetShowLabel(DXOCustUI.DropDown openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetShowLabel = new StringValue { Value = value };
    else
      openXmlElement.GetShowLabel = null;
  }
  
  /// <summary>
  /// showImage
  /// </summary>
  private static Boolean? GetShowImage(DXOCustUI.DropDown openXmlElement)
  {
    return openXmlElement?.ShowImage?.Value;
  }
  
  private static void SetShowImage(DXOCustUI.DropDown openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowImage = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowImage = null;
  }
  
  /// <summary>
  /// getShowImage
  /// </summary>
  private static String? GetGetShowImage(DXOCustUI.DropDown openXmlElement)
  {
    return openXmlElement?.GetShowImage?.Value;
  }
  
  private static void SetGetShowImage(DXOCustUI.DropDown openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetShowImage = new StringValue { Value = value };
    else
      openXmlElement.GetShowImage = null;
  }
  
  private static Collection<DMUI.Item> GetItems(DXOCustUI.DropDown openXmlElement)
  {
    var collection = new Collection<DMUI.Item>();
    foreach (var item in openXmlElement.Elements<DXOCustUI.Item>())
    {
      var newItem = DMXUI.ItemConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetItems(DXOCustUI.DropDown openXmlElement, Collection<DMUI.Item>? value)
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
  
  private static Collection<DMUI.UnsizedButton> GetUnsizedButtons(DXOCustUI.DropDown openXmlElement)
  {
    var collection = new Collection<DMUI.UnsizedButton>();
    foreach (var item in openXmlElement.Elements<DXOCustUI.UnsizedButton>())
    {
      var newItem = DMXUI.UnsizedButtonConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetUnsizedButtons(DXOCustUI.DropDown openXmlElement, Collection<DMUI.UnsizedButton>? value)
  {
    openXmlElement.RemoveAllChildren<DXOCustUI.UnsizedButton>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXUI.UnsizedButtonConverter.CreateOpenXmlElement<DXOCustUI.UnsizedButton>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMUI.DropDown? CreateModelElement(DXOCustUI.DropDown? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMUI.DropDown();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMUI.DropDown? value)
    where OpenXmlElementType: DXOCustUI.DropDown, new()
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
