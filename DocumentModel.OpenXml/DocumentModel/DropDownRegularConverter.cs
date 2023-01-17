namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the DropDownRegular Class.
/// </summary>
public static class DropDownRegularConverter
{
  /// <summary>
  /// onAction, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetOnAction(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.OnAction?.Value;
  }
  
  private static void SetOnAction(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.OnAction = new StringValue { Value = value };
    else
      openXmlElement.OnAction = null;
  }
  
  /// <summary>
  /// enabled, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.Enabled?.Value;
  }
  
  private static void SetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Enabled = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Enabled = null;
  }
  
  /// <summary>
  /// getEnabled, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.GetEnabled?.Value;
  }
  
  private static void SetGetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetEnabled = new StringValue { Value = value };
    else
      openXmlElement.GetEnabled = null;
  }
  
  /// <summary>
  /// image, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetImage(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.Image?.Value;
  }
  
  private static void SetImage(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Image = new StringValue { Value = value };
    else
      openXmlElement.Image = null;
  }
  
  /// <summary>
  /// imageMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetImageMso(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.ImageMso?.Value;
  }
  
  private static void SetImageMso(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ImageMso = new StringValue { Value = value };
    else
      openXmlElement.ImageMso = null;
  }
  
  /// <summary>
  /// getImage, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetImage(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.GetImage?.Value;
  }
  
  private static void SetGetImage(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetImage = new StringValue { Value = value };
    else
      openXmlElement.GetImage = null;
  }
  
  /// <summary>
  /// showItemImage, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetShowItemImage(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.ShowItemImage?.Value;
  }
  
  private static void SetShowItemImage(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowItemImage = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowItemImage = null;
  }
  
  /// <summary>
  /// getItemCount, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetItemCount(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.GetItemCount?.Value;
  }
  
  private static void SetGetItemCount(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetItemCount = new StringValue { Value = value };
    else
      openXmlElement.GetItemCount = null;
  }
  
  /// <summary>
  /// getItemLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetItemLabel(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.GetItemLabel?.Value;
  }
  
  private static void SetGetItemLabel(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetItemLabel = new StringValue { Value = value };
    else
      openXmlElement.GetItemLabel = null;
  }
  
  /// <summary>
  /// getItemScreentip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetItemScreentip(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.GetItemScreentip?.Value;
  }
  
  private static void SetGetItemScreentip(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetItemScreentip = new StringValue { Value = value };
    else
      openXmlElement.GetItemScreentip = null;
  }
  
  /// <summary>
  /// getItemSupertip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetItemSupertip(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.GetItemSupertip?.Value;
  }
  
  private static void SetGetItemSupertip(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetItemSupertip = new StringValue { Value = value };
    else
      openXmlElement.GetItemSupertip = null;
  }
  
  /// <summary>
  /// getItemImage, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetItemImage(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.GetItemImage?.Value;
  }
  
  private static void SetGetItemImage(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetItemImage = new StringValue { Value = value };
    else
      openXmlElement.GetItemImage = null;
  }
  
  /// <summary>
  /// getItemID, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetItemID(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.GetItemID?.Value;
  }
  
  private static void SetGetItemID(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetItemID = new StringValue { Value = value };
    else
      openXmlElement.GetItemID = null;
  }
  
  /// <summary>
  /// sizeString, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetSizeString(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.SizeString?.Value;
  }
  
  private static void SetSizeString(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.SizeString = new StringValue { Value = value };
    else
      openXmlElement.SizeString = null;
  }
  
  /// <summary>
  /// getSelectedItemID, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetSelectedItemID(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.GetSelectedItemID?.Value;
  }
  
  private static void SetGetSelectedItemID(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetSelectedItemID = new StringValue { Value = value };
    else
      openXmlElement.GetSelectedItemID = null;
  }
  
  /// <summary>
  /// getSelectedItemIndex, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetSelectedItemIndex(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.GetSelectedItemIndex?.Value;
  }
  
  private static void SetGetSelectedItemIndex(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetSelectedItemIndex = new StringValue { Value = value };
    else
      openXmlElement.GetSelectedItemIndex = null;
  }
  
  /// <summary>
  /// showItemLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetShowItemLabel(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.ShowItemLabel?.Value;
  }
  
  private static void SetShowItemLabel(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowItemLabel = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowItemLabel = null;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetId(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.QualifiedId?.Value;
  }
  
  private static void SetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.QualifiedId = new StringValue { Value = value };
    else
      openXmlElement.QualifiedId = null;
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetTag(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }
  
  private static void SetTag(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Tag = new StringValue { Value = value };
    else
      openXmlElement.Tag = null;
  }
  
  /// <summary>
  /// idMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetIdMso(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.IdMso?.Value;
  }
  
  private static void SetIdMso(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.IdMso = new StringValue { Value = value };
    else
      openXmlElement.IdMso = null;
  }
  
  /// <summary>
  /// screentip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetScreentip(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.Screentip?.Value;
  }
  
  private static void SetScreentip(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Screentip = new StringValue { Value = value };
    else
      openXmlElement.Screentip = null;
  }
  
  /// <summary>
  /// getScreentip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetScreentip(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.GetScreentip?.Value;
  }
  
  private static void SetGetScreentip(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetScreentip = new StringValue { Value = value };
    else
      openXmlElement.GetScreentip = null;
  }
  
  /// <summary>
  /// supertip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetSupertip(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.Supertip?.Value;
  }
  
  private static void SetSupertip(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Supertip = new StringValue { Value = value };
    else
      openXmlElement.Supertip = null;
  }
  
  /// <summary>
  /// getSupertip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetSupertip(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.GetSupertip?.Value;
  }
  
  private static void SetGetSupertip(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetSupertip = new StringValue { Value = value };
    else
      openXmlElement.GetSupertip = null;
  }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.Label?.Value;
  }
  
  private static void SetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Label = new StringValue { Value = value };
    else
      openXmlElement.Label = null;
  }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.GetLabel?.Value;
  }
  
  private static void SetGetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetLabel = new StringValue { Value = value };
    else
      openXmlElement.GetLabel = null;
  }
  
  /// <summary>
  /// insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertAfterMso(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.InsertAfterMso?.Value;
  }
  
  private static void SetInsertAfterMso(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterMso = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterMso = null;
  }
  
  /// <summary>
  /// insertBeforeMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertBeforeMso(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.InsertBeforeMso?.Value;
  }
  
  private static void SetInsertBeforeMso(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeMso = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeMso = null;
  }
  
  /// <summary>
  /// insertAfterQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertAfterQulifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.InsertAfterQulifiedId?.Value;
  }
  
  private static void SetInsertAfterQulifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterQulifiedId = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterQulifiedId = null;
  }
  
  /// <summary>
  /// insertBeforeQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertBeforeQulifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.InsertBeforeQulifiedId?.Value;
  }
  
  private static void SetInsertBeforeQulifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeQulifiedId = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeQulifiedId = null;
  }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static void SetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }
  
  private static void SetGetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetVisible = new StringValue { Value = value };
    else
      openXmlElement.GetVisible = null;
  }
  
  /// <summary>
  /// keytip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.Keytip?.Value;
  }
  
  private static void SetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Keytip = new StringValue { Value = value };
    else
      openXmlElement.Keytip = null;
  }
  
  /// <summary>
  /// getKeytip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.GetKeytip?.Value;
  }
  
  private static void SetGetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetKeytip = new StringValue { Value = value };
    else
      openXmlElement.GetKeytip = null;
  }
  
  /// <summary>
  /// showLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetShowLabel(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.ShowLabel?.Value;
  }
  
  private static void SetShowLabel(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowLabel = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowLabel = null;
  }
  
  /// <summary>
  /// getShowLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetShowLabel(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.GetShowLabel?.Value;
  }
  
  private static void SetGetShowLabel(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetShowLabel = new StringValue { Value = value };
    else
      openXmlElement.GetShowLabel = null;
  }
  
  /// <summary>
  /// showImage, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetShowImage(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.ShowImage?.Value;
  }
  
  private static void SetShowImage(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowImage = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowImage = null;
  }
  
  /// <summary>
  /// getShowImage, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetShowImage(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement)
  {
    return openXmlElement?.GetShowImage?.Value;
  }
  
  private static void SetGetShowImage(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetShowImage = new StringValue { Value = value };
    else
      openXmlElement.GetShowImage = null;
  }
  
  private static System.Collections.ObjectModel.Collection<DocumentModel.Item> GetItems(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement)
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
  
  private static void SetItems(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Item>? value)
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
  
  private static System.Collections.ObjectModel.Collection<DocumentModel.ButtonRegular> GetButtonRegulars(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement)
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
  
  private static void SetButtonRegulars(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.ButtonRegular>? value)
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
  
  public static DocumentModel.DropDownRegular? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.DropDownRegular();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.DropDownRegular? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular, new()
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
