namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the ContextMenu Class.
/// </summary>
public static class ContextMenuConverter
{
  /// <summary>
  /// idMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetIdMso(DXO2010CustUI.ContextMenu openXmlElement)
  {
    return openXmlElement?.IdMso?.Value;
  }
  
  private static void SetIdMso(DXO2010CustUI.ContextMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.IdMso = new StringValue { Value = value };
    else
      openXmlElement.IdMso = null;
  }
  
  private static DM.ControlCloneRegular? GetControlCloneRegular(DXO2010CustUI.ContextMenu openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.ControlCloneRegular>();
    if (itemElement != null)
      return DMX.ControlCloneRegularConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetControlCloneRegular(DXO2010CustUI.ContextMenu openXmlElement, DM.ControlCloneRegular? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.ControlCloneRegular>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.ControlCloneRegularConverter.CreateOpenXmlElement<DXO2010CustUI.ControlCloneRegular>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.ButtonRegular? GetButtonRegular(DXO2010CustUI.ContextMenu openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.ButtonRegular>();
    if (itemElement != null)
      return DMX.ButtonRegularConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetButtonRegular(DXO2010CustUI.ContextMenu openXmlElement, DM.ButtonRegular? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.ButtonRegular>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.ButtonRegularConverter.CreateOpenXmlElement<DXO2010CustUI.ButtonRegular>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.CheckBox? GetCheckBox(DXO2010CustUI.ContextMenu openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.CheckBox>();
    if (itemElement != null)
      return DMX.CheckBoxConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCheckBox(DXO2010CustUI.ContextMenu openXmlElement, DM.CheckBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.CheckBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.CheckBoxConverter.CreateOpenXmlElement<DXO2010CustUI.CheckBox>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.GalleryRegular? GetGalleryRegular(DXO2010CustUI.ContextMenu openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.GalleryRegular>();
    if (itemElement != null)
      return DMX.GalleryRegularConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGalleryRegular(DXO2010CustUI.ContextMenu openXmlElement, DM.GalleryRegular? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.GalleryRegular>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.GalleryRegularConverter.CreateOpenXmlElement<DXO2010CustUI.GalleryRegular>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.ToggleButtonRegular? GetToggleButtonRegular(DXO2010CustUI.ContextMenu openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.ToggleButtonRegular>();
    if (itemElement != null)
      return DMX.ToggleButtonRegularConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetToggleButtonRegular(DXO2010CustUI.ContextMenu openXmlElement, DM.ToggleButtonRegular? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.ToggleButtonRegular>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.ToggleButtonRegularConverter.CreateOpenXmlElement<DXO2010CustUI.ToggleButtonRegular>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.SplitButtonRegular? GetSplitButtonRegular(DXO2010CustUI.ContextMenu openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.SplitButtonRegular>();
    if (itemElement != null)
      return DMX.SplitButtonRegularConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSplitButtonRegular(DXO2010CustUI.ContextMenu openXmlElement, DM.SplitButtonRegular? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.SplitButtonRegular>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.SplitButtonRegularConverter.CreateOpenXmlElement<DXO2010CustUI.SplitButtonRegular>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.MenuRegular? GetMenuRegular(DXO2010CustUI.ContextMenu openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.MenuRegular>();
    if (itemElement != null)
      return DMX.MenuRegularConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMenuRegular(DXO2010CustUI.ContextMenu openXmlElement, DM.MenuRegular? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.MenuRegular>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.MenuRegularConverter.CreateOpenXmlElement<DXO2010CustUI.MenuRegular>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.DynamicMenuRegular? GetDynamicMenuRegular(DXO2010CustUI.ContextMenu openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.DynamicMenuRegular>();
    if (itemElement != null)
      return DMX.DynamicMenuRegularConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDynamicMenuRegular(DXO2010CustUI.ContextMenu openXmlElement, DM.DynamicMenuRegular? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.DynamicMenuRegular>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.DynamicMenuRegularConverter.CreateOpenXmlElement<DXO2010CustUI.DynamicMenuRegular>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.MenuSeparatorNoTitle? GetMenuSeparatorNoTitle(DXO2010CustUI.ContextMenu openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.MenuSeparatorNoTitle>();
    if (itemElement != null)
      return DMX.MenuSeparatorNoTitleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMenuSeparatorNoTitle(DXO2010CustUI.ContextMenu openXmlElement, DM.MenuSeparatorNoTitle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.MenuSeparatorNoTitle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.MenuSeparatorNoTitleConverter.CreateOpenXmlElement<DXO2010CustUI.MenuSeparatorNoTitle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DM.ContextMenu? CreateModelElement(DXO2010CustUI.ContextMenu? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.ContextMenu();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.ContextMenu? value)
    where OpenXmlElementType: DXO2010CustUI.ContextMenu, new()
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
