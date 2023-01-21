namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the Menu Class.
/// </summary>
public static class MenuConverter
{
  /// <summary>
  /// size, this property is only available in Office 2010 and later.
  /// </summary>
  private static DM.SizeKind? GetSize(DXO2010CustUI.Menu openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues, DM.SizeKind>(openXmlElement?.Size?.Value);
  }
  
  private static void SetSize(DXO2010CustUI.Menu openXmlElement, DM.SizeKind? value)
  {
    openXmlElement.Size = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues, DM.SizeKind>(value);
  }
  
  /// <summary>
  /// getSize, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetSize(DXO2010CustUI.Menu openXmlElement)
  {
    return openXmlElement?.GetSize?.Value;
  }
  
  private static void SetGetSize(DXO2010CustUI.Menu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetSize = new StringValue { Value = value };
    else
      openXmlElement.GetSize = null;
  }
  
  /// <summary>
  /// itemSize, this property is only available in Office 2010 and later.
  /// </summary>
  private static DM.ItemSizeKind? GetItemSize(DXO2010CustUI.Menu openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues, DM.ItemSizeKind>(openXmlElement?.ItemSize?.Value);
  }
  
  private static void SetItemSize(DXO2010CustUI.Menu openXmlElement, DM.ItemSizeKind? value)
  {
    openXmlElement.ItemSize = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues, DM.ItemSizeKind>(value);
  }
  
  /// <summary>
  /// description, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetDescription(DXO2010CustUI.Menu openXmlElement)
  {
    return openXmlElement?.Description?.Value;
  }
  
  private static void SetDescription(DXO2010CustUI.Menu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Description = new StringValue { Value = value };
    else
      openXmlElement.Description = null;
  }
  
  /// <summary>
  /// getDescription, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetDescription(DXO2010CustUI.Menu openXmlElement)
  {
    return openXmlElement?.GetDescription?.Value;
  }
  
  private static void SetGetDescription(DXO2010CustUI.Menu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetDescription = new StringValue { Value = value };
    else
      openXmlElement.GetDescription = null;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetId(DXO2010CustUI.Menu openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXO2010CustUI.Menu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetQualifiedId(DXO2010CustUI.Menu openXmlElement)
  {
    return openXmlElement?.QualifiedId?.Value;
  }
  
  private static void SetQualifiedId(DXO2010CustUI.Menu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.QualifiedId = new StringValue { Value = value };
    else
      openXmlElement.QualifiedId = null;
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetTag(DXO2010CustUI.Menu openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }
  
  private static void SetTag(DXO2010CustUI.Menu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Tag = new StringValue { Value = value };
    else
      openXmlElement.Tag = null;
  }
  
  /// <summary>
  /// idMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetIdMso(DXO2010CustUI.Menu openXmlElement)
  {
    return openXmlElement?.IdMso?.Value;
  }
  
  private static void SetIdMso(DXO2010CustUI.Menu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.IdMso = new StringValue { Value = value };
    else
      openXmlElement.IdMso = null;
  }
  
  /// <summary>
  /// image, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetImage(DXO2010CustUI.Menu openXmlElement)
  {
    return openXmlElement?.Image?.Value;
  }
  
  private static void SetImage(DXO2010CustUI.Menu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Image = new StringValue { Value = value };
    else
      openXmlElement.Image = null;
  }
  
  /// <summary>
  /// imageMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetImageMso(DXO2010CustUI.Menu openXmlElement)
  {
    return openXmlElement?.ImageMso?.Value;
  }
  
  private static void SetImageMso(DXO2010CustUI.Menu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ImageMso = new StringValue { Value = value };
    else
      openXmlElement.ImageMso = null;
  }
  
  /// <summary>
  /// getImage, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetImage(DXO2010CustUI.Menu openXmlElement)
  {
    return openXmlElement?.GetImage?.Value;
  }
  
  private static void SetGetImage(DXO2010CustUI.Menu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetImage = new StringValue { Value = value };
    else
      openXmlElement.GetImage = null;
  }
  
  /// <summary>
  /// screentip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetScreentip(DXO2010CustUI.Menu openXmlElement)
  {
    return openXmlElement?.Screentip?.Value;
  }
  
  private static void SetScreentip(DXO2010CustUI.Menu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Screentip = new StringValue { Value = value };
    else
      openXmlElement.Screentip = null;
  }
  
  /// <summary>
  /// getScreentip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetScreentip(DXO2010CustUI.Menu openXmlElement)
  {
    return openXmlElement?.GetScreentip?.Value;
  }
  
  private static void SetGetScreentip(DXO2010CustUI.Menu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetScreentip = new StringValue { Value = value };
    else
      openXmlElement.GetScreentip = null;
  }
  
  /// <summary>
  /// supertip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetSupertip(DXO2010CustUI.Menu openXmlElement)
  {
    return openXmlElement?.Supertip?.Value;
  }
  
  private static void SetSupertip(DXO2010CustUI.Menu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Supertip = new StringValue { Value = value };
    else
      openXmlElement.Supertip = null;
  }
  
  /// <summary>
  /// getSupertip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetSupertip(DXO2010CustUI.Menu openXmlElement)
  {
    return openXmlElement?.GetSupertip?.Value;
  }
  
  private static void SetGetSupertip(DXO2010CustUI.Menu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetSupertip = new StringValue { Value = value };
    else
      openXmlElement.GetSupertip = null;
  }
  
  /// <summary>
  /// enabled, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetEnabled(DXO2010CustUI.Menu openXmlElement)
  {
    return openXmlElement?.Enabled?.Value;
  }
  
  private static void SetEnabled(DXO2010CustUI.Menu openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Enabled = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Enabled = null;
  }
  
  /// <summary>
  /// getEnabled, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetEnabled(DXO2010CustUI.Menu openXmlElement)
  {
    return openXmlElement?.GetEnabled?.Value;
  }
  
  private static void SetGetEnabled(DXO2010CustUI.Menu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetEnabled = new StringValue { Value = value };
    else
      openXmlElement.GetEnabled = null;
  }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetLabel(DXO2010CustUI.Menu openXmlElement)
  {
    return openXmlElement?.Label?.Value;
  }
  
  private static void SetLabel(DXO2010CustUI.Menu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Label = new StringValue { Value = value };
    else
      openXmlElement.Label = null;
  }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetLabel(DXO2010CustUI.Menu openXmlElement)
  {
    return openXmlElement?.GetLabel?.Value;
  }
  
  private static void SetGetLabel(DXO2010CustUI.Menu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetLabel = new StringValue { Value = value };
    else
      openXmlElement.GetLabel = null;
  }
  
  /// <summary>
  /// insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertAfterMso(DXO2010CustUI.Menu openXmlElement)
  {
    return openXmlElement?.InsertAfterMso?.Value;
  }
  
  private static void SetInsertAfterMso(DXO2010CustUI.Menu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterMso = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterMso = null;
  }
  
  /// <summary>
  /// insertBeforeMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertBeforeMso(DXO2010CustUI.Menu openXmlElement)
  {
    return openXmlElement?.InsertBeforeMso?.Value;
  }
  
  private static void SetInsertBeforeMso(DXO2010CustUI.Menu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeMso = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeMso = null;
  }
  
  /// <summary>
  /// insertAfterQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertAfterQulifiedId(DXO2010CustUI.Menu openXmlElement)
  {
    return openXmlElement?.InsertAfterQulifiedId?.Value;
  }
  
  private static void SetInsertAfterQulifiedId(DXO2010CustUI.Menu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterQulifiedId = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterQulifiedId = null;
  }
  
  /// <summary>
  /// insertBeforeQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertBeforeQulifiedId(DXO2010CustUI.Menu openXmlElement)
  {
    return openXmlElement?.InsertBeforeQulifiedId?.Value;
  }
  
  private static void SetInsertBeforeQulifiedId(DXO2010CustUI.Menu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeQulifiedId = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeQulifiedId = null;
  }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetVisible(DXO2010CustUI.Menu openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static void SetVisible(DXO2010CustUI.Menu openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetVisible(DXO2010CustUI.Menu openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }
  
  private static void SetGetVisible(DXO2010CustUI.Menu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetVisible = new StringValue { Value = value };
    else
      openXmlElement.GetVisible = null;
  }
  
  /// <summary>
  /// keytip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetKeytip(DXO2010CustUI.Menu openXmlElement)
  {
    return openXmlElement?.Keytip?.Value;
  }
  
  private static void SetKeytip(DXO2010CustUI.Menu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Keytip = new StringValue { Value = value };
    else
      openXmlElement.Keytip = null;
  }
  
  /// <summary>
  /// getKeytip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetKeytip(DXO2010CustUI.Menu openXmlElement)
  {
    return openXmlElement?.GetKeytip?.Value;
  }
  
  private static void SetGetKeytip(DXO2010CustUI.Menu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetKeytip = new StringValue { Value = value };
    else
      openXmlElement.GetKeytip = null;
  }
  
  /// <summary>
  /// showLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetShowLabel(DXO2010CustUI.Menu openXmlElement)
  {
    return openXmlElement?.ShowLabel?.Value;
  }
  
  private static void SetShowLabel(DXO2010CustUI.Menu openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowLabel = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowLabel = null;
  }
  
  /// <summary>
  /// getShowLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetShowLabel(DXO2010CustUI.Menu openXmlElement)
  {
    return openXmlElement?.GetShowLabel?.Value;
  }
  
  private static void SetGetShowLabel(DXO2010CustUI.Menu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetShowLabel = new StringValue { Value = value };
    else
      openXmlElement.GetShowLabel = null;
  }
  
  /// <summary>
  /// showImage, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetShowImage(DXO2010CustUI.Menu openXmlElement)
  {
    return openXmlElement?.ShowImage?.Value;
  }
  
  private static void SetShowImage(DXO2010CustUI.Menu openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowImage = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowImage = null;
  }
  
  /// <summary>
  /// getShowImage, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetShowImage(DXO2010CustUI.Menu openXmlElement)
  {
    return openXmlElement?.GetShowImage?.Value;
  }
  
  private static void SetGetShowImage(DXO2010CustUI.Menu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetShowImage = new StringValue { Value = value };
    else
      openXmlElement.GetShowImage = null;
  }
  
  private static DM.ControlCloneRegular? GetControlCloneRegular(DXO2010CustUI.Menu openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.ControlCloneRegular>();
    if (itemElement != null)
      return DMX.ControlCloneRegularConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetControlCloneRegular(DXO2010CustUI.Menu openXmlElement, DM.ControlCloneRegular? value)
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
  
  private static DM.ButtonRegular? GetButtonRegular(DXO2010CustUI.Menu openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.ButtonRegular>();
    if (itemElement != null)
      return DMX.ButtonRegularConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetButtonRegular(DXO2010CustUI.Menu openXmlElement, DM.ButtonRegular? value)
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
  
  private static DM.CheckBox? GetCheckBox(DXO2010CustUI.Menu openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.CheckBox>();
    if (itemElement != null)
      return DMX.CheckBoxConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCheckBox(DXO2010CustUI.Menu openXmlElement, DM.CheckBox? value)
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
  
  private static DM.GalleryRegular? GetGalleryRegular(DXO2010CustUI.Menu openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.GalleryRegular>();
    if (itemElement != null)
      return DMX.GalleryRegularConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGalleryRegular(DXO2010CustUI.Menu openXmlElement, DM.GalleryRegular? value)
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
  
  private static DM.ToggleButtonRegular? GetToggleButtonRegular(DXO2010CustUI.Menu openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.ToggleButtonRegular>();
    if (itemElement != null)
      return DMX.ToggleButtonRegularConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetToggleButtonRegular(DXO2010CustUI.Menu openXmlElement, DM.ToggleButtonRegular? value)
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
  
  private static DM.MenuSeparator? GetMenuSeparator(DXO2010CustUI.Menu openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.MenuSeparator>();
    if (itemElement != null)
      return DMX.MenuSeparatorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMenuSeparator(DXO2010CustUI.Menu openXmlElement, DM.MenuSeparator? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.MenuSeparator>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.MenuSeparatorConverter.CreateOpenXmlElement<DXO2010CustUI.MenuSeparator>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.SplitButtonRegular? GetSplitButtonRegular(DXO2010CustUI.Menu openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.SplitButtonRegular>();
    if (itemElement != null)
      return DMX.SplitButtonRegularConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSplitButtonRegular(DXO2010CustUI.Menu openXmlElement, DM.SplitButtonRegular? value)
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
  
  private static DM.MenuRegular? GetMenuRegular(DXO2010CustUI.Menu openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.MenuRegular>();
    if (itemElement != null)
      return DMX.MenuRegularConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMenuRegular(DXO2010CustUI.Menu openXmlElement, DM.MenuRegular? value)
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
  
  private static DM.DynamicMenuRegular? GetDynamicMenuRegular(DXO2010CustUI.Menu openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.DynamicMenuRegular>();
    if (itemElement != null)
      return DMX.DynamicMenuRegularConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDynamicMenuRegular(DXO2010CustUI.Menu openXmlElement, DM.DynamicMenuRegular? value)
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
  
  public static DM.Menu? CreateModelElement(DXO2010CustUI.Menu? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.Menu();
      value.Size = GetSize(openXmlElement);
      value.GetSize = GetGetSize(openXmlElement);
      value.ItemSize = GetItemSize(openXmlElement);
      value.Description = GetDescription(openXmlElement);
      value.GetDescription = GetGetDescription(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.QualifiedId = GetQualifiedId(openXmlElement);
      value.Tag = GetTag(openXmlElement);
      value.IdMso = GetIdMso(openXmlElement);
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
      value.ControlCloneRegular = GetControlCloneRegular(openXmlElement);
      value.ButtonRegular = GetButtonRegular(openXmlElement);
      value.CheckBox = GetCheckBox(openXmlElement);
      value.GalleryRegular = GetGalleryRegular(openXmlElement);
      value.ToggleButtonRegular = GetToggleButtonRegular(openXmlElement);
      value.MenuSeparator = GetMenuSeparator(openXmlElement);
      value.SplitButtonRegular = GetSplitButtonRegular(openXmlElement);
      value.MenuRegular = GetMenuRegular(openXmlElement);
      value.DynamicMenuRegular = GetDynamicMenuRegular(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.Menu? value)
    where OpenXmlElementType: DXO2010CustUI.Menu, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSize(openXmlElement, value?.Size);
      SetGetSize(openXmlElement, value?.GetSize);
      SetItemSize(openXmlElement, value?.ItemSize);
      SetDescription(openXmlElement, value?.Description);
      SetGetDescription(openXmlElement, value?.GetDescription);
      SetId(openXmlElement, value?.Id);
      SetQualifiedId(openXmlElement, value?.QualifiedId);
      SetTag(openXmlElement, value?.Tag);
      SetIdMso(openXmlElement, value?.IdMso);
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
      SetControlCloneRegular(openXmlElement, value?.ControlCloneRegular);
      SetButtonRegular(openXmlElement, value?.ButtonRegular);
      SetCheckBox(openXmlElement, value?.CheckBox);
      SetGalleryRegular(openXmlElement, value?.GalleryRegular);
      SetToggleButtonRegular(openXmlElement, value?.ToggleButtonRegular);
      SetMenuSeparator(openXmlElement, value?.MenuSeparator);
      SetSplitButtonRegular(openXmlElement, value?.SplitButtonRegular);
      SetMenuRegular(openXmlElement, value?.MenuRegular);
      SetDynamicMenuRegular(openXmlElement, value?.DynamicMenuRegular);
      return openXmlElement;
    }
    return default;
  }
}
