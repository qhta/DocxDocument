namespace DocumentModel.OpenXml;

/// <summary>
///   Defines the ContextMenu Class.
/// </summary>
public static class ContextMenuConverter
{
  /// <summary>
  ///   idMso, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetIdMso(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu? openXmlElement)
  {
    return openXmlElement?.IdMso?.Value;
  }

  public static void SetIdMso(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.IdMso = new StringValue { Value = value };
      else
        openXmlElement.IdMso = null;
  }

  public static ControlCloneRegular? GetControlCloneRegular(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneRegular>();
    if (itemElement != null)
      return ControlCloneRegularConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetControlCloneRegular(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu? openXmlElement, ControlCloneRegular? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneRegular>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ControlCloneRegularConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneRegular>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ButtonRegular? GetButtonRegular(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular>();
    if (itemElement != null)
      return ButtonRegularConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetButtonRegular(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu? openXmlElement, ButtonRegular? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ButtonRegularConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static CheckBox? GetCheckBox(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.CheckBox>();
    if (itemElement != null)
      return CheckBoxConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCheckBox(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu? openXmlElement, CheckBox? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.CheckBox>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CheckBoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.CheckBox>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static GalleryRegular? GetGalleryRegular(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular>();
    if (itemElement != null)
      return GalleryRegularConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGalleryRegular(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu? openXmlElement, GalleryRegular? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GalleryRegularConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ToggleButtonRegular? GetToggleButtonRegular(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButtonRegular>();
    if (itemElement != null)
      return ToggleButtonRegularConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetToggleButtonRegular(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu? openXmlElement, ToggleButtonRegular? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButtonRegular>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ToggleButtonRegularConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButtonRegular>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static SplitButtonRegular? GetSplitButtonRegular(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular>();
    if (itemElement != null)
      return SplitButtonRegularConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSplitButtonRegular(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu? openXmlElement, SplitButtonRegular? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SplitButtonRegularConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static MenuRegular? GetMenuRegular(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular>();
    if (itemElement != null)
      return MenuRegularConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMenuRegular(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu? openXmlElement, MenuRegular? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MenuRegularConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DynamicMenuRegular? GetDynamicMenuRegular(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenuRegular>();
    if (itemElement != null)
      return DynamicMenuRegularConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDynamicMenuRegular(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu? openXmlElement, DynamicMenuRegular? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenuRegular>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DynamicMenuRegularConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenuRegular>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static MenuSeparatorNoTitle? GetMenuSeparatorNoTitle(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.MenuSeparatorNoTitle>();
    if (itemElement != null)
      return MenuSeparatorNoTitleConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMenuSeparatorNoTitle(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu? openXmlElement, MenuSeparatorNoTitle? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.MenuSeparatorNoTitle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MenuSeparatorNoTitleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.MenuSeparatorNoTitle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ContextMenu? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new ContextMenu();
      value.IdMso = GetIdMso(openXmlElement);
      value.ControlCloneRegular = GetControlCloneRegular(openXmlElement);
      value.ButtonRegular = GetButtonRegular(openXmlElement);
      value.CheckBox = GetCheckBox(openXmlElement);
      value.GalleryRegular = GetGalleryRegular(openXmlElement);
      value.ToggleButtonRegular = GetToggleButtonRegular(openXmlElement);
      value.SplitButtonRegular = GetSplitButtonRegular(openXmlElement);
      value.MenuRegular = GetMenuRegular(openXmlElement);
      value.DynamicMenuRegular = GetDynamicMenuRegular(openXmlElement);
      value.MenuSeparatorNoTitle = GetMenuSeparatorNoTitle(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(ContextMenu? value)
    where OpenXmlElementType : DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetIdMso(openXmlElement, value?.IdMso);
      SetControlCloneRegular(openXmlElement, value?.ControlCloneRegular);
      SetButtonRegular(openXmlElement, value?.ButtonRegular);
      SetCheckBox(openXmlElement, value?.CheckBox);
      SetGalleryRegular(openXmlElement, value?.GalleryRegular);
      SetToggleButtonRegular(openXmlElement, value?.ToggleButtonRegular);
      SetSplitButtonRegular(openXmlElement, value?.SplitButtonRegular);
      SetMenuRegular(openXmlElement, value?.MenuRegular);
      SetDynamicMenuRegular(openXmlElement, value?.DynamicMenuRegular);
      SetMenuSeparatorNoTitle(openXmlElement, value?.MenuSeparatorNoTitle);
      return openXmlElement;
    }
    return default;
  }
}