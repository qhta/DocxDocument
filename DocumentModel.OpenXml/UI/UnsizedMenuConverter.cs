using DocumentFormat.OpenXml.Office.CustomUI;
using UnsizedButton = DocumentModel.UI.UnsizedButton;
using UnsizedControlClone = DocumentModel.UI.UnsizedControlClone;
using UnsizedDynamicMenu = DocumentModel.UI.UnsizedDynamicMenu;
using UnsizedGallery = DocumentModel.UI.UnsizedGallery;
using UnsizedSplitButton = DocumentModel.UI.UnsizedSplitButton;
using UnsizedToggleButton = DocumentModel.UI.UnsizedToggleButton;

namespace DocumentModel.OpenXml.UI;

/// <summary>
///   Defines the UnsizedMenu Class.
/// </summary>
public static class UnsizedMenuConverter
{
  /// <summary>
  ///   itemSize
  /// </summary>
  public static DocumentModel.UI.ItemSizeKind? GetItemSize(UnsizedMenu? openXmlElement)
  {
    return EnumValueConverter.GetValue<ItemSizeValues, DocumentModel.UI.ItemSizeKind>(openXmlElement?.ItemSize?.Value);
  }

  public static void SetItemSize(UnsizedMenu? openXmlElement, DocumentModel.UI.ItemSizeKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.ItemSize = EnumValueConverter.CreateEnumValue<ItemSizeValues, DocumentModel.UI.ItemSizeKind>(value);
  }

  /// <summary>
  ///   description
  /// </summary>
  public static String? GetDescription(UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.Description?.Value;
  }

  public static void SetDescription(UnsizedMenu? openXmlElement, String? value)
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
  public static String? GetGetDescription(UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.GetDescription?.Value;
  }

  public static void SetGetDescription(UnsizedMenu? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetDescription = new StringValue { Value = value };
      else
        openXmlElement.GetDescription = null;
  }

  /// <summary>
  ///   id
  /// </summary>
  public static String? GetId(UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(UnsizedMenu? openXmlElement, String? value)
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
  public static String? GetIdQ(UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.IdQ?.Value;
  }

  public static void SetIdQ(UnsizedMenu? openXmlElement, String? value)
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
  public static String? GetIdMso(UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.IdMso?.Value;
  }

  public static void SetIdMso(UnsizedMenu? openXmlElement, String? value)
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
  public static String? GetTag(UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }

  public static void SetTag(UnsizedMenu? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Tag = new StringValue { Value = value };
      else
        openXmlElement.Tag = null;
  }

  /// <summary>
  ///   image
  /// </summary>
  public static String? GetImage(UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.Image?.Value;
  }

  public static void SetImage(UnsizedMenu? openXmlElement, String? value)
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
  public static String? GetImageMso(UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.ImageMso?.Value;
  }

  public static void SetImageMso(UnsizedMenu? openXmlElement, String? value)
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
  public static String? GetGetImage(UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.GetImage?.Value;
  }

  public static void SetGetImage(UnsizedMenu? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetImage = new StringValue { Value = value };
      else
        openXmlElement.GetImage = null;
  }

  /// <summary>
  ///   screentip
  /// </summary>
  public static String? GetScreentip(UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.Screentip?.Value;
  }

  public static void SetScreentip(UnsizedMenu? openXmlElement, String? value)
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
  public static String? GetGetScreentip(UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.GetScreentip?.Value;
  }

  public static void SetGetScreentip(UnsizedMenu? openXmlElement, String? value)
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
  public static String? GetSupertip(UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.Supertip?.Value;
  }

  public static void SetSupertip(UnsizedMenu? openXmlElement, String? value)
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
  public static String? GetGetSupertip(UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.GetSupertip?.Value;
  }

  public static void SetGetSupertip(UnsizedMenu? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetSupertip = new StringValue { Value = value };
      else
        openXmlElement.GetSupertip = null;
  }

  /// <summary>
  ///   enabled
  /// </summary>
  public static Boolean? GetEnabled(UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.Enabled?.Value;
  }

  public static void SetEnabled(UnsizedMenu? openXmlElement, Boolean? value)
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
  public static String? GetGetEnabled(UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.GetEnabled?.Value;
  }

  public static void SetGetEnabled(UnsizedMenu? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetEnabled = new StringValue { Value = value };
      else
        openXmlElement.GetEnabled = null;
  }

  /// <summary>
  ///   label
  /// </summary>
  public static String? GetLabel(UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.Label?.Value;
  }

  public static void SetLabel(UnsizedMenu? openXmlElement, String? value)
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
  public static String? GetGetLabel(UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.GetLabel?.Value;
  }

  public static void SetGetLabel(UnsizedMenu? openXmlElement, String? value)
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
  public static String? GetInsertAfterMso(UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.InsertAfterMso?.Value;
  }

  public static void SetInsertAfterMso(UnsizedMenu? openXmlElement, String? value)
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
  public static String? GetInsertBeforeMso(UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.InsertBeforeMso?.Value;
  }

  public static void SetInsertBeforeMso(UnsizedMenu? openXmlElement, String? value)
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
  public static String? GetInsertAfterQ(UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.InsertAfterQ?.Value;
  }

  public static void SetInsertAfterQ(UnsizedMenu? openXmlElement, String? value)
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
  public static String? GetInsertBeforeQ(UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.InsertBeforeQ?.Value;
  }

  public static void SetInsertBeforeQ(UnsizedMenu? openXmlElement, String? value)
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
  public static Boolean? GetVisible(UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }

  public static void SetVisible(UnsizedMenu? openXmlElement, Boolean? value)
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
  public static String? GetGetVisible(UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }

  public static void SetGetVisible(UnsizedMenu? openXmlElement, String? value)
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
  public static String? GetKeytip(UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.Keytip?.Value;
  }

  public static void SetKeytip(UnsizedMenu? openXmlElement, String? value)
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
  public static String? GetGetKeytip(UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.GetKeytip?.Value;
  }

  public static void SetGetKeytip(UnsizedMenu? openXmlElement, String? value)
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
  public static Boolean? GetShowLabel(UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.ShowLabel?.Value;
  }

  public static void SetShowLabel(UnsizedMenu? openXmlElement, Boolean? value)
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
  public static String? GetGetShowLabel(UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.GetShowLabel?.Value;
  }

  public static void SetGetShowLabel(UnsizedMenu? openXmlElement, String? value)
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
  public static Boolean? GetShowImage(UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.ShowImage?.Value;
  }

  public static void SetShowImage(UnsizedMenu? openXmlElement, Boolean? value)
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
  public static String? GetGetShowImage(UnsizedMenu? openXmlElement)
  {
    return openXmlElement?.GetShowImage?.Value;
  }

  public static void SetGetShowImage(UnsizedMenu? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetShowImage = new StringValue { Value = value };
      else
        openXmlElement.GetShowImage = null;
  }

  public static UnsizedControlClone? GetUnsizedControlClone(UnsizedMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedControlClone>();
    if (itemElement != null)
      return UnsizedControlCloneConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetUnsizedControlClone(UnsizedMenu? openXmlElement, UnsizedControlClone? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedControlClone>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = UnsizedControlCloneConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.UnsizedControlClone>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static UnsizedButton? GetUnsizedButton(UnsizedMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton>();
    if (itemElement != null)
      return UnsizedButtonConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetUnsizedButton(UnsizedMenu? openXmlElement, UnsizedButton? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = UnsizedButtonConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.UI.CheckBox? GetCheckBox(UnsizedMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.CheckBox>();
    if (itemElement != null)
      return CheckBoxConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCheckBox(UnsizedMenu? openXmlElement, DocumentModel.UI.CheckBox? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.CheckBox>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CheckBoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.CheckBox>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static UnsizedGallery? GetUnsizedGallery(UnsizedMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery>();
    if (itemElement != null)
      return UnsizedGalleryConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetUnsizedGallery(UnsizedMenu? openXmlElement, UnsizedGallery? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = UnsizedGalleryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static UnsizedToggleButton? GetUnsizedToggleButton(UnsizedMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedToggleButton>();
    if (itemElement != null)
      return UnsizedToggleButtonConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetUnsizedToggleButton(UnsizedMenu? openXmlElement, UnsizedToggleButton? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedToggleButton>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = UnsizedToggleButtonConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.UnsizedToggleButton>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.UI.MenuSeparator? GetMenuSeparator(UnsizedMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator>();
    if (itemElement != null)
      return MenuSeparatorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMenuSeparator(UnsizedMenu? openXmlElement, DocumentModel.UI.MenuSeparator? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MenuSeparatorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static UnsizedSplitButton? GetUnsizedSplitButton(UnsizedMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton>();
    if (itemElement != null)
      return UnsizedSplitButtonConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetUnsizedSplitButton(UnsizedMenu? openXmlElement, UnsizedSplitButton? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = UnsizedSplitButtonConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.UI.UnsizedMenu? GetChildUnsizedMenu(UnsizedMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<UnsizedMenu>();
    if (itemElement != null)
      return CreateModelElement(itemElement);
    return null;
  }

  public static void SetChildUnsizedMenu(UnsizedMenu? openXmlElement, DocumentModel.UI.UnsizedMenu? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<UnsizedMenu>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CreateOpenXmlElement<UnsizedMenu>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static UnsizedDynamicMenu? GetUnsizedDynamicMenu(UnsizedMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedDynamicMenu>();
    if (itemElement != null)
      return UnsizedDynamicMenuConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetUnsizedDynamicMenu(UnsizedMenu? openXmlElement, UnsizedDynamicMenu? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedDynamicMenu>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = UnsizedDynamicMenuConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.UnsizedDynamicMenu>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.UI.UnsizedMenu? CreateModelElement(UnsizedMenu? openXmlElement)
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
    where OpenXmlElementType : UnsizedMenu, new()
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
      SetUnsizedControlClone(openXmlElement, value?.UnsizedControlClone);
      SetUnsizedButton(openXmlElement, value?.UnsizedButton);
      SetCheckBox(openXmlElement, value?.CheckBox);
      SetUnsizedGallery(openXmlElement, value?.UnsizedGallery);
      SetUnsizedToggleButton(openXmlElement, value?.UnsizedToggleButton);
      SetMenuSeparator(openXmlElement, value?.MenuSeparator);
      SetUnsizedSplitButton(openXmlElement, value?.UnsizedSplitButton);
      SetChildUnsizedMenu(openXmlElement, value?.ChildUnsizedMenu);
      SetUnsizedDynamicMenu(openXmlElement, value?.UnsizedDynamicMenu);
      return openXmlElement;
    }
    return default;
  }
}