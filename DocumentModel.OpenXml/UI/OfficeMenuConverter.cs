using DocumentModel.UI;
using OfficeMenu = DocumentFormat.OpenXml.Office.CustomUI.OfficeMenu;

namespace DocumentModel.OpenXml.UI;

/// <summary>
///   Defines the OfficeMenu Class.
/// </summary>
public static class OfficeMenuConverter
{
  public static UnsizedControlClone? GetUnsizedControlClone(OfficeMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedControlClone>();
    if (itemElement != null)
      return UnsizedControlCloneConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetUnsizedControlClone(OfficeMenu? openXmlElement, UnsizedControlClone? value)
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

  public static UnsizedButton? GetUnsizedButton(OfficeMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton>();
    if (itemElement != null)
      return UnsizedButtonConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetUnsizedButton(OfficeMenu? openXmlElement, UnsizedButton? value)
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

  public static DocumentModel.UI.CheckBox? GetCheckBox(OfficeMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.CheckBox>();
    if (itemElement != null)
      return CheckBoxConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCheckBox(OfficeMenu? openXmlElement, DocumentModel.UI.CheckBox? value)
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

  public static UnsizedGallery? GetUnsizedGallery(OfficeMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery>();
    if (itemElement != null)
      return UnsizedGalleryConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetUnsizedGallery(OfficeMenu? openXmlElement, UnsizedGallery? value)
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

  public static UnsizedToggleButton? GetUnsizedToggleButton(OfficeMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedToggleButton>();
    if (itemElement != null)
      return UnsizedToggleButtonConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetUnsizedToggleButton(OfficeMenu? openXmlElement, UnsizedToggleButton? value)
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

  public static DocumentModel.UI.MenuSeparator? GetMenuSeparator(OfficeMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator>();
    if (itemElement != null)
      return MenuSeparatorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMenuSeparator(OfficeMenu? openXmlElement, DocumentModel.UI.MenuSeparator? value)
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

  public static SplitButtonWithTitle? GetSplitButtonWithTitle(OfficeMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.SplitButtonWithTitle>();
    if (itemElement != null)
      return SplitButtonWithTitleConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSplitButtonWithTitle(OfficeMenu? openXmlElement, SplitButtonWithTitle? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.SplitButtonWithTitle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SplitButtonWithTitleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.SplitButtonWithTitle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static MenuWithTitle? GetMenuWithTitle(OfficeMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.MenuWithTitle>();
    if (itemElement != null)
      return MenuWithTitleConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMenuWithTitle(OfficeMenu? openXmlElement, MenuWithTitle? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.MenuWithTitle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MenuWithTitleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.MenuWithTitle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static UnsizedDynamicMenu? GetUnsizedDynamicMenu(OfficeMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedDynamicMenu>();
    if (itemElement != null)
      return UnsizedDynamicMenuConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetUnsizedDynamicMenu(OfficeMenu? openXmlElement, UnsizedDynamicMenu? value)
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

  public static DocumentModel.UI.OfficeMenu? CreateModelElement(OfficeMenu? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.UI.OfficeMenu();
      value.UnsizedControlClone = GetUnsizedControlClone(openXmlElement);
      value.UnsizedButton = GetUnsizedButton(openXmlElement);
      value.CheckBox = GetCheckBox(openXmlElement);
      value.UnsizedGallery = GetUnsizedGallery(openXmlElement);
      value.UnsizedToggleButton = GetUnsizedToggleButton(openXmlElement);
      value.MenuSeparator = GetMenuSeparator(openXmlElement);
      value.SplitButtonWithTitle = GetSplitButtonWithTitle(openXmlElement);
      value.MenuWithTitle = GetMenuWithTitle(openXmlElement);
      value.UnsizedDynamicMenu = GetUnsizedDynamicMenu(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.UI.OfficeMenu? value)
    where OpenXmlElementType : OfficeMenu, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUnsizedControlClone(openXmlElement, value?.UnsizedControlClone);
      SetUnsizedButton(openXmlElement, value?.UnsizedButton);
      SetCheckBox(openXmlElement, value?.CheckBox);
      SetUnsizedGallery(openXmlElement, value?.UnsizedGallery);
      SetUnsizedToggleButton(openXmlElement, value?.UnsizedToggleButton);
      SetMenuSeparator(openXmlElement, value?.MenuSeparator);
      SetSplitButtonWithTitle(openXmlElement, value?.SplitButtonWithTitle);
      SetMenuWithTitle(openXmlElement, value?.MenuWithTitle);
      SetUnsizedDynamicMenu(openXmlElement, value?.UnsizedDynamicMenu);
      return openXmlElement;
    }
    return default;
  }
}