namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the UnsizedMenu Class.
/// </summary>
public static class UnsizedMenuConverter
{
  /// <summary>
  /// itemSize
  /// </summary>
  public static DocumentModel.UI.ItemSizeKind? GetItemSize(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues, DocumentModel.UI.ItemSizeKind>(openXmlElement?.ItemSize?.Value);
  }
  
  public static void SetItemSize(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement, DocumentModel.UI.ItemSizeKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.ItemSize = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues, DocumentModel.UI.ItemSizeKind>(value);
  }
  
  /// <summary>
  /// description
  /// </summary>
  public static String? GetDescription(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.Description?.Value;
  }
  
  public static void SetDescription(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Description = new StringValue { Value = value };
      else
        openXmlElement.Description = null;
  }
  
  /// <summary>
  /// getDescription
  /// </summary>
  public static String? GetGetDescription(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.GetDescription?.Value;
  }
  
  public static void SetGetDescription(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetDescription = new StringValue { Value = value };
      else
        openXmlElement.GetDescription = null;
  }
  
  /// <summary>
  /// id
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  /// <summary>
  /// idQ
  /// </summary>
  public static String? GetIdQ(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.IdQ?.Value;
  }
  
  public static void SetIdQ(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.IdQ = new StringValue { Value = value };
      else
        openXmlElement.IdQ = null;
  }
  
  /// <summary>
  /// idMso
  /// </summary>
  public static String? GetIdMso(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.IdMso?.Value;
  }
  
  public static void SetIdMso(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.IdMso = new StringValue { Value = value };
      else
        openXmlElement.IdMso = null;
  }
  
  /// <summary>
  /// tag
  /// </summary>
  public static String? GetTag(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }
  
  public static void SetTag(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Tag = new StringValue { Value = value };
      else
        openXmlElement.Tag = null;
  }
  
  /// <summary>
  /// image
  /// </summary>
  public static String? GetImage(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.Image?.Value;
  }
  
  public static void SetImage(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Image = new StringValue { Value = value };
      else
        openXmlElement.Image = null;
  }
  
  /// <summary>
  /// imageMso
  /// </summary>
  public static String? GetImageMso(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.ImageMso?.Value;
  }
  
  public static void SetImageMso(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ImageMso = new StringValue { Value = value };
      else
        openXmlElement.ImageMso = null;
  }
  
  /// <summary>
  /// getImage
  /// </summary>
  public static String? GetGetImage(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.GetImage?.Value;
  }
  
  public static void SetGetImage(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetImage = new StringValue { Value = value };
      else
        openXmlElement.GetImage = null;
  }
  
  /// <summary>
  /// screentip
  /// </summary>
  public static String? GetScreentip(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.Screentip?.Value;
  }
  
  public static void SetScreentip(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Screentip = new StringValue { Value = value };
      else
        openXmlElement.Screentip = null;
  }
  
  /// <summary>
  /// getScreentip
  /// </summary>
  public static String? GetGetScreentip(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.GetScreentip?.Value;
  }
  
  public static void SetGetScreentip(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetScreentip = new StringValue { Value = value };
      else
        openXmlElement.GetScreentip = null;
  }
  
  /// <summary>
  /// supertip
  /// </summary>
  public static String? GetSupertip(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.Supertip?.Value;
  }
  
  public static void SetSupertip(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Supertip = new StringValue { Value = value };
      else
        openXmlElement.Supertip = null;
  }
  
  /// <summary>
  /// getSupertip
  /// </summary>
  public static String? GetGetSupertip(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.GetSupertip?.Value;
  }
  
  public static void SetGetSupertip(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetSupertip = new StringValue { Value = value };
      else
        openXmlElement.GetSupertip = null;
  }
  
  /// <summary>
  /// enabled
  /// </summary>
  public static Boolean? GetEnabled(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.Enabled?.Value;
  }
  
  public static void SetEnabled(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Enabled = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Enabled = null;
  }
  
  /// <summary>
  /// getEnabled
  /// </summary>
  public static String? GetGetEnabled(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.GetEnabled?.Value;
  }
  
  public static void SetGetEnabled(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetEnabled = new StringValue { Value = value };
      else
        openXmlElement.GetEnabled = null;
  }
  
  /// <summary>
  /// label
  /// </summary>
  public static String? GetLabel(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.Label?.Value;
  }
  
  public static void SetLabel(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Label = new StringValue { Value = value };
      else
        openXmlElement.Label = null;
  }
  
  /// <summary>
  /// getLabel
  /// </summary>
  public static String? GetGetLabel(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.GetLabel?.Value;
  }
  
  public static void SetGetLabel(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetLabel = new StringValue { Value = value };
      else
        openXmlElement.GetLabel = null;
  }
  
  /// <summary>
  /// insertAfterMso
  /// </summary>
  public static String? GetInsertAfterMso(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.InsertAfterMso?.Value;
  }
  
  public static void SetInsertAfterMso(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsertAfterMso = new StringValue { Value = value };
      else
        openXmlElement.InsertAfterMso = null;
  }
  
  /// <summary>
  /// insertBeforeMso
  /// </summary>
  public static String? GetInsertBeforeMso(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.InsertBeforeMso?.Value;
  }
  
  public static void SetInsertBeforeMso(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsertBeforeMso = new StringValue { Value = value };
      else
        openXmlElement.InsertBeforeMso = null;
  }
  
  /// <summary>
  /// insertAfterQ
  /// </summary>
  public static String? GetInsertAfterQ(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.InsertAfterQ?.Value;
  }
  
  public static void SetInsertAfterQ(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsertAfterQ = new StringValue { Value = value };
      else
        openXmlElement.InsertAfterQ = null;
  }
  
  /// <summary>
  /// insertBeforeQ
  /// </summary>
  public static String? GetInsertBeforeQ(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.InsertBeforeQ?.Value;
  }
  
  public static void SetInsertBeforeQ(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsertBeforeQ = new StringValue { Value = value };
      else
        openXmlElement.InsertBeforeQ = null;
  }
  
  /// <summary>
  /// visible
  /// </summary>
  public static Boolean? GetVisible(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  public static void SetVisible(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible
  /// </summary>
  public static String? GetGetVisible(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }
  
  public static void SetGetVisible(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetVisible = new StringValue { Value = value };
      else
        openXmlElement.GetVisible = null;
  }
  
  /// <summary>
  /// keytip
  /// </summary>
  public static String? GetKeytip(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.Keytip?.Value;
  }
  
  public static void SetKeytip(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Keytip = new StringValue { Value = value };
      else
        openXmlElement.Keytip = null;
  }
  
  /// <summary>
  /// getKeytip
  /// </summary>
  public static String? GetGetKeytip(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.GetKeytip?.Value;
  }
  
  public static void SetGetKeytip(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetKeytip = new StringValue { Value = value };
      else
        openXmlElement.GetKeytip = null;
  }
  
  /// <summary>
  /// showLabel
  /// </summary>
  public static Boolean? GetShowLabel(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.ShowLabel?.Value;
  }
  
  public static void SetShowLabel(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ShowLabel = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.ShowLabel = null;
  }
  
  /// <summary>
  /// getShowLabel
  /// </summary>
  public static String? GetGetShowLabel(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.GetShowLabel?.Value;
  }
  
  public static void SetGetShowLabel(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetShowLabel = new StringValue { Value = value };
      else
        openXmlElement.GetShowLabel = null;
  }
  
  /// <summary>
  /// showImage
  /// </summary>
  public static Boolean? GetShowImage(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.ShowImage?.Value;
  }
  
  public static void SetShowImage(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ShowImage = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.ShowImage = null;
  }
  
  /// <summary>
  /// getShowImage
  /// </summary>
  public static String? GetGetShowImage(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.GetShowImage?.Value;
  }
  
  public static void SetGetShowImage(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetShowImage = new StringValue { Value = value };
      else
        openXmlElement.GetShowImage = null;
  }
  
  public static DocumentModel.UI.UnsizedControlClone? GetUnsizedControlClone(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedControlClone>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.UnsizedControlCloneConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetUnsizedControlClone(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement, DocumentModel.UI.UnsizedControlClone? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedControlClone>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.UI.UnsizedControlCloneConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.UnsizedControlClone>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.UI.UnsizedButton? GetUnsizedButton(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.UnsizedButtonConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetUnsizedButton(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement, DocumentModel.UI.UnsizedButton? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.UI.UnsizedButtonConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.UI.CheckBox? GetCheckBox(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.CheckBox>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.CheckBoxConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCheckBox(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement, DocumentModel.UI.CheckBox? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.CheckBox>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.UI.CheckBoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.CheckBox>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.UI.UnsizedGallery? GetUnsizedGallery(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.UnsizedGalleryConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetUnsizedGallery(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement, DocumentModel.UI.UnsizedGallery? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.UI.UnsizedGalleryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.UI.UnsizedToggleButton? GetUnsizedToggleButton(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedToggleButton>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.UnsizedToggleButtonConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetUnsizedToggleButton(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement, DocumentModel.UI.UnsizedToggleButton? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedToggleButton>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.UI.UnsizedToggleButtonConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.UnsizedToggleButton>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.UI.MenuSeparator? GetMenuSeparator(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.MenuSeparatorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMenuSeparator(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement, DocumentModel.UI.MenuSeparator? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.UI.MenuSeparatorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.UI.UnsizedSplitButton? GetUnsizedSplitButton(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.UnsizedSplitButtonConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetUnsizedSplitButton(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement, DocumentModel.UI.UnsizedSplitButton? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.UI.UnsizedSplitButtonConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.UI.UnsizedMenu? GetChildUnsizedMenu(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.UnsizedMenuConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetChildUnsizedMenu(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement, DocumentModel.UI.UnsizedMenu? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.UI.UnsizedMenuConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.UI.UnsizedDynamicMenu? GetUnsizedDynamicMenu(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedDynamicMenu>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.UnsizedDynamicMenuConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetUnsizedDynamicMenu(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement, DocumentModel.UI.UnsizedDynamicMenu? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedDynamicMenu>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.UI.UnsizedDynamicMenuConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.UnsizedDynamicMenu>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.UI.UnsizedMenu? CreateModelElement(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.UI.UnsizedMenu();
      value.ItemSize = GetItemSize(openXmlElement);
      value.Description = GetDescription(openXmlElement);
      value.GetDescription = GetGetDescription(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.IdQ = GetIdQ(openXmlElement);
      value.IdMso = GetIdMso(openXmlElement);
      value.Tag = GetTag(openXmlElement);
      value.Image = GetImage(openXmlElement);
      value.ImageMso = GetImageMso(openXmlElement);
      value.GetImage = GetGetImage(openXmlElement);
      value.Screentip = GetScreentip(openXmlElement);
      value.GetScreentip = GetGetScreentip(openXmlElement);
      value.Supertip = GetSupertip(openXmlElement);
      value.GetSupertip = GetGetSupertip(openXmlElement);
      value.Enabled = GetEnabled(openXmlElement);
      value.GetEnabled = GetGetEnabled(openXmlElement);
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
      value.UnsizedControlClone = GetUnsizedControlClone(openXmlElement);
      value.UnsizedButton = GetUnsizedButton(openXmlElement);
      value.CheckBox = GetCheckBox(openXmlElement);
      value.UnsizedGallery = GetUnsizedGallery(openXmlElement);
      value.UnsizedToggleButton = GetUnsizedToggleButton(openXmlElement);
      value.MenuSeparator = GetMenuSeparator(openXmlElement);
      value.UnsizedSplitButton = GetUnsizedSplitButton(openXmlElement);
      value.ChildUnsizedMenu = GetChildUnsizedMenu(openXmlElement);
      value.UnsizedDynamicMenu = GetUnsizedDynamicMenu(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.UI.UnsizedMenu? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetItemSize(openXmlElement, value?.ItemSize);
      SetDescription(openXmlElement, value?.Description);
      SetGetDescription(openXmlElement, value?.GetDescription);
      SetId(openXmlElement, value?.Id);
      SetIdQ(openXmlElement, value?.IdQ);
      SetIdMso(openXmlElement, value?.IdMso);
      SetTag(openXmlElement, value?.Tag);
      SetImage(openXmlElement, value?.Image);
      SetImageMso(openXmlElement, value?.ImageMso);
      SetGetImage(openXmlElement, value?.GetImage);
      SetScreentip(openXmlElement, value?.Screentip);
      SetGetScreentip(openXmlElement, value?.GetScreentip);
      SetSupertip(openXmlElement, value?.Supertip);
      SetGetSupertip(openXmlElement, value?.GetSupertip);
      SetEnabled(openXmlElement, value?.Enabled);
      SetGetEnabled(openXmlElement, value?.GetEnabled);
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
      return openXmlElement;
    }
    return default;
  }
}
