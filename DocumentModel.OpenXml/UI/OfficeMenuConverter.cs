namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the OfficeMenu Class.
/// </summary>
public static class OfficeMenuConverter
{
  public static DocumentModel.UI.UnsizedControlClone? GetUnsizedControlClone(DocumentFormat.OpenXml.Office.CustomUI.OfficeMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedControlClone>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.UnsizedControlCloneConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetUnsizedControlClone(DocumentFormat.OpenXml.Office.CustomUI.OfficeMenu? openXmlElement, DocumentModel.UI.UnsizedControlClone? value)
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
  
  public static DocumentModel.UI.UnsizedButton? GetUnsizedButton(DocumentFormat.OpenXml.Office.CustomUI.OfficeMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.UnsizedButtonConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetUnsizedButton(DocumentFormat.OpenXml.Office.CustomUI.OfficeMenu? openXmlElement, DocumentModel.UI.UnsizedButton? value)
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
  
  public static DocumentModel.UI.CheckBox? GetCheckBox(DocumentFormat.OpenXml.Office.CustomUI.OfficeMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.CheckBox>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.CheckBoxConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCheckBox(DocumentFormat.OpenXml.Office.CustomUI.OfficeMenu? openXmlElement, DocumentModel.UI.CheckBox? value)
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
  
  public static DocumentModel.UI.UnsizedGallery? GetUnsizedGallery(DocumentFormat.OpenXml.Office.CustomUI.OfficeMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.UnsizedGalleryConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetUnsizedGallery(DocumentFormat.OpenXml.Office.CustomUI.OfficeMenu? openXmlElement, DocumentModel.UI.UnsizedGallery? value)
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
  
  public static DocumentModel.UI.UnsizedToggleButton? GetUnsizedToggleButton(DocumentFormat.OpenXml.Office.CustomUI.OfficeMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedToggleButton>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.UnsizedToggleButtonConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetUnsizedToggleButton(DocumentFormat.OpenXml.Office.CustomUI.OfficeMenu? openXmlElement, DocumentModel.UI.UnsizedToggleButton? value)
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
  
  public static DocumentModel.UI.MenuSeparator? GetMenuSeparator(DocumentFormat.OpenXml.Office.CustomUI.OfficeMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.MenuSeparatorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMenuSeparator(DocumentFormat.OpenXml.Office.CustomUI.OfficeMenu? openXmlElement, DocumentModel.UI.MenuSeparator? value)
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
  
  public static DocumentModel.UI.SplitButtonWithTitle? GetSplitButtonWithTitle(DocumentFormat.OpenXml.Office.CustomUI.OfficeMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.SplitButtonWithTitle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.SplitButtonWithTitleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSplitButtonWithTitle(DocumentFormat.OpenXml.Office.CustomUI.OfficeMenu? openXmlElement, DocumentModel.UI.SplitButtonWithTitle? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.SplitButtonWithTitle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.UI.SplitButtonWithTitleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.SplitButtonWithTitle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.UI.MenuWithTitle? GetMenuWithTitle(DocumentFormat.OpenXml.Office.CustomUI.OfficeMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.MenuWithTitle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.MenuWithTitleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMenuWithTitle(DocumentFormat.OpenXml.Office.CustomUI.OfficeMenu? openXmlElement, DocumentModel.UI.MenuWithTitle? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.MenuWithTitle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.UI.MenuWithTitleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.MenuWithTitle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.UI.UnsizedDynamicMenu? GetUnsizedDynamicMenu(DocumentFormat.OpenXml.Office.CustomUI.OfficeMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedDynamicMenu>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.UnsizedDynamicMenuConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetUnsizedDynamicMenu(DocumentFormat.OpenXml.Office.CustomUI.OfficeMenu? openXmlElement, DocumentModel.UI.UnsizedDynamicMenu? value)
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
  
  public static DocumentModel.UI.OfficeMenu? CreateModelElement(DocumentFormat.OpenXml.Office.CustomUI.OfficeMenu? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.CustomUI.OfficeMenu, new()
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
