namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the MenuRegular Class.
/// </summary>
public static class MenuRegularConverter
{
  /// <summary>
  /// itemSize, this property is only available in Office 2010 and later.
  /// </summary>
  private static DM.ItemSizeKind? GetItemSize(DXO10CUI.MenuRegular openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues, DM.ItemSizeKind>(openXmlElement?.ItemSize?.Value);
  }
  
  private static bool CmpItemSize(DXO10CUI.MenuRegular openXmlElement, DM.ItemSizeKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues, DM.ItemSizeKind>(openXmlElement?.ItemSize?.Value, value, diffs, objName);
  }
  
  private static void SetItemSize(DXO10CUI.MenuRegular openXmlElement, DM.ItemSizeKind? value)
  {
    openXmlElement.ItemSize = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues, DM.ItemSizeKind>(value);
  }
  
  /// <summary>
  /// description, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetDescription(DXO10CUI.MenuRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Description);
  }
  
  private static bool CmpDescription(DXO10CUI.MenuRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Description, value, diffs, objName, "Description");
  }
  
  private static void SetDescription(DXO10CUI.MenuRegular openXmlElement, String? value)
  {
    openXmlElement.Description = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getDescription, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetDescription(DXO10CUI.MenuRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetDescription);
  }
  
  private static bool CmpGetDescription(DXO10CUI.MenuRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetDescription, value, diffs, objName, "GetDescription");
  }
  
  private static void SetGetDescription(DXO10CUI.MenuRegular openXmlElement, String? value)
  {
    openXmlElement.GetDescription = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetId(DXO10CUI.MenuRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXO10CUI.MenuRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXO10CUI.MenuRegular openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetQualifiedId(DXO10CUI.MenuRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.QualifiedId);
  }
  
  private static bool CmpQualifiedId(DXO10CUI.MenuRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.QualifiedId, value, diffs, objName, "QualifiedId");
  }
  
  private static void SetQualifiedId(DXO10CUI.MenuRegular openXmlElement, String? value)
  {
    openXmlElement.QualifiedId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetTag(DXO10CUI.MenuRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Tag);
  }
  
  private static bool CmpTag(DXO10CUI.MenuRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Tag, value, diffs, objName, "Tag");
  }
  
  private static void SetTag(DXO10CUI.MenuRegular openXmlElement, String? value)
  {
    openXmlElement.Tag = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// idMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetIdMso(DXO10CUI.MenuRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.IdMso);
  }
  
  private static bool CmpIdMso(DXO10CUI.MenuRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.IdMso, value, diffs, objName, "IdMso");
  }
  
  private static void SetIdMso(DXO10CUI.MenuRegular openXmlElement, String? value)
  {
    openXmlElement.IdMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// image, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetImage(DXO10CUI.MenuRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Image);
  }
  
  private static bool CmpImage(DXO10CUI.MenuRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Image, value, diffs, objName, "Image");
  }
  
  private static void SetImage(DXO10CUI.MenuRegular openXmlElement, String? value)
  {
    openXmlElement.Image = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// imageMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetImageMso(DXO10CUI.MenuRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ImageMso);
  }
  
  private static bool CmpImageMso(DXO10CUI.MenuRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ImageMso, value, diffs, objName, "ImageMso");
  }
  
  private static void SetImageMso(DXO10CUI.MenuRegular openXmlElement, String? value)
  {
    openXmlElement.ImageMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getImage, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetImage(DXO10CUI.MenuRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetImage);
  }
  
  private static bool CmpGetImage(DXO10CUI.MenuRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetImage, value, diffs, objName, "GetImage");
  }
  
  private static void SetGetImage(DXO10CUI.MenuRegular openXmlElement, String? value)
  {
    openXmlElement.GetImage = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// screentip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetScreentip(DXO10CUI.MenuRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Screentip);
  }
  
  private static bool CmpScreentip(DXO10CUI.MenuRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Screentip, value, diffs, objName, "Screentip");
  }
  
  private static void SetScreentip(DXO10CUI.MenuRegular openXmlElement, String? value)
  {
    openXmlElement.Screentip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getScreentip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetScreentip(DXO10CUI.MenuRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetScreentip);
  }
  
  private static bool CmpGetScreentip(DXO10CUI.MenuRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetScreentip, value, diffs, objName, "GetScreentip");
  }
  
  private static void SetGetScreentip(DXO10CUI.MenuRegular openXmlElement, String? value)
  {
    openXmlElement.GetScreentip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// supertip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetSupertip(DXO10CUI.MenuRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Supertip);
  }
  
  private static bool CmpSupertip(DXO10CUI.MenuRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Supertip, value, diffs, objName, "Supertip");
  }
  
  private static void SetSupertip(DXO10CUI.MenuRegular openXmlElement, String? value)
  {
    openXmlElement.Supertip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getSupertip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetSupertip(DXO10CUI.MenuRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetSupertip);
  }
  
  private static bool CmpGetSupertip(DXO10CUI.MenuRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetSupertip, value, diffs, objName, "GetSupertip");
  }
  
  private static void SetGetSupertip(DXO10CUI.MenuRegular openXmlElement, String? value)
  {
    openXmlElement.GetSupertip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// enabled, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetEnabled(DXO10CUI.MenuRegular openXmlElement)
  {
    return openXmlElement?.Enabled?.Value;
  }
  
  private static bool CmpEnabled(DXO10CUI.MenuRegular openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Enabled?.Value == value) return true;
    diffs?.Add(objName, "Enabled", openXmlElement?.Enabled?.Value, value);
    return false;
  }
  
  private static void SetEnabled(DXO10CUI.MenuRegular openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Enabled = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Enabled = null;
  }
  
  /// <summary>
  /// getEnabled, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetEnabled(DXO10CUI.MenuRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetEnabled);
  }
  
  private static bool CmpGetEnabled(DXO10CUI.MenuRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetEnabled, value, diffs, objName, "GetEnabled");
  }
  
  private static void SetGetEnabled(DXO10CUI.MenuRegular openXmlElement, String? value)
  {
    openXmlElement.GetEnabled = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetLabel(DXO10CUI.MenuRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Label);
  }
  
  private static bool CmpLabel(DXO10CUI.MenuRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Label, value, diffs, objName, "Label");
  }
  
  private static void SetLabel(DXO10CUI.MenuRegular openXmlElement, String? value)
  {
    openXmlElement.Label = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetLabel(DXO10CUI.MenuRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetLabel);
  }
  
  private static bool CmpGetLabel(DXO10CUI.MenuRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetLabel, value, diffs, objName, "GetLabel");
  }
  
  private static void SetGetLabel(DXO10CUI.MenuRegular openXmlElement, String? value)
  {
    openXmlElement.GetLabel = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertAfterMso(DXO10CUI.MenuRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertAfterMso);
  }
  
  private static bool CmpInsertAfterMso(DXO10CUI.MenuRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertAfterMso, value, diffs, objName, "InsertAfterMso");
  }
  
  private static void SetInsertAfterMso(DXO10CUI.MenuRegular openXmlElement, String? value)
  {
    openXmlElement.InsertAfterMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertBeforeMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertBeforeMso(DXO10CUI.MenuRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertBeforeMso);
  }
  
  private static bool CmpInsertBeforeMso(DXO10CUI.MenuRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertBeforeMso, value, diffs, objName, "InsertBeforeMso");
  }
  
  private static void SetInsertBeforeMso(DXO10CUI.MenuRegular openXmlElement, String? value)
  {
    openXmlElement.InsertBeforeMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertAfterQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertAfterQulifiedId(DXO10CUI.MenuRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertAfterQulifiedId);
  }
  
  private static bool CmpInsertAfterQulifiedId(DXO10CUI.MenuRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertAfterQulifiedId, value, diffs, objName, "InsertAfterQulifiedId");
  }
  
  private static void SetInsertAfterQulifiedId(DXO10CUI.MenuRegular openXmlElement, String? value)
  {
    openXmlElement.InsertAfterQulifiedId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertBeforeQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertBeforeQulifiedId(DXO10CUI.MenuRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertBeforeQulifiedId);
  }
  
  private static bool CmpInsertBeforeQulifiedId(DXO10CUI.MenuRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertBeforeQulifiedId, value, diffs, objName, "InsertBeforeQulifiedId");
  }
  
  private static void SetInsertBeforeQulifiedId(DXO10CUI.MenuRegular openXmlElement, String? value)
  {
    openXmlElement.InsertBeforeQulifiedId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetVisible(DXO10CUI.MenuRegular openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static bool CmpVisible(DXO10CUI.MenuRegular openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Visible?.Value == value) return true;
    diffs?.Add(objName, "Visible", openXmlElement?.Visible?.Value, value);
    return false;
  }
  
  private static void SetVisible(DXO10CUI.MenuRegular openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetVisible(DXO10CUI.MenuRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetVisible);
  }
  
  private static bool CmpGetVisible(DXO10CUI.MenuRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetVisible, value, diffs, objName, "GetVisible");
  }
  
  private static void SetGetVisible(DXO10CUI.MenuRegular openXmlElement, String? value)
  {
    openXmlElement.GetVisible = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// keytip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetKeytip(DXO10CUI.MenuRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Keytip);
  }
  
  private static bool CmpKeytip(DXO10CUI.MenuRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Keytip, value, diffs, objName, "Keytip");
  }
  
  private static void SetKeytip(DXO10CUI.MenuRegular openXmlElement, String? value)
  {
    openXmlElement.Keytip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getKeytip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetKeytip(DXO10CUI.MenuRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetKeytip);
  }
  
  private static bool CmpGetKeytip(DXO10CUI.MenuRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetKeytip, value, diffs, objName, "GetKeytip");
  }
  
  private static void SetGetKeytip(DXO10CUI.MenuRegular openXmlElement, String? value)
  {
    openXmlElement.GetKeytip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// showLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetShowLabel(DXO10CUI.MenuRegular openXmlElement)
  {
    return openXmlElement?.ShowLabel?.Value;
  }
  
  private static bool CmpShowLabel(DXO10CUI.MenuRegular openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ShowLabel?.Value == value) return true;
    diffs?.Add(objName, "ShowLabel", openXmlElement?.ShowLabel?.Value, value);
    return false;
  }
  
  private static void SetShowLabel(DXO10CUI.MenuRegular openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowLabel = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowLabel = null;
  }
  
  /// <summary>
  /// getShowLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetShowLabel(DXO10CUI.MenuRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetShowLabel);
  }
  
  private static bool CmpGetShowLabel(DXO10CUI.MenuRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetShowLabel, value, diffs, objName, "GetShowLabel");
  }
  
  private static void SetGetShowLabel(DXO10CUI.MenuRegular openXmlElement, String? value)
  {
    openXmlElement.GetShowLabel = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// showImage, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetShowImage(DXO10CUI.MenuRegular openXmlElement)
  {
    return openXmlElement?.ShowImage?.Value;
  }
  
  private static bool CmpShowImage(DXO10CUI.MenuRegular openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ShowImage?.Value == value) return true;
    diffs?.Add(objName, "ShowImage", openXmlElement?.ShowImage?.Value, value);
    return false;
  }
  
  private static void SetShowImage(DXO10CUI.MenuRegular openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowImage = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowImage = null;
  }
  
  /// <summary>
  /// getShowImage, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetShowImage(DXO10CUI.MenuRegular openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetShowImage);
  }
  
  private static bool CmpGetShowImage(DXO10CUI.MenuRegular openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetShowImage, value, diffs, objName, "GetShowImage");
  }
  
  private static void SetGetShowImage(DXO10CUI.MenuRegular openXmlElement, String? value)
  {
    openXmlElement.GetShowImage = StringValueConverter.CreateStringValue(value);
  }
  
  private static DM.ControlCloneRegular? GetControlCloneRegular(DXO10CUI.MenuRegular openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.ControlCloneRegular>();
    if (element != null)
      return DMX.ControlCloneRegularConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpControlCloneRegular(DXO10CUI.MenuRegular openXmlElement, DM.ControlCloneRegular? value, DiffList? diffs, string? objName)
  {
    return DMX.ControlCloneRegularConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.ControlCloneRegular>(), value, diffs, objName);
  }
  
  private static void SetControlCloneRegular(DXO10CUI.MenuRegular openXmlElement, DM.ControlCloneRegular? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.ControlCloneRegular>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.ControlCloneRegularConverter.CreateOpenXmlElement<DXO10CUI.ControlCloneRegular>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.ButtonRegular? GetButtonRegular(DXO10CUI.MenuRegular openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.ButtonRegular>();
    if (element != null)
      return DMX.ButtonRegularConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpButtonRegular(DXO10CUI.MenuRegular openXmlElement, DM.ButtonRegular? value, DiffList? diffs, string? objName)
  {
    return DMX.ButtonRegularConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.ButtonRegular>(), value, diffs, objName);
  }
  
  private static void SetButtonRegular(DXO10CUI.MenuRegular openXmlElement, DM.ButtonRegular? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.ButtonRegular>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.ButtonRegularConverter.CreateOpenXmlElement<DXO10CUI.ButtonRegular>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.CheckBox? GetCheckBox(DXO10CUI.MenuRegular openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.CheckBox>();
    if (element != null)
      return DMX.CheckBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCheckBox(DXO10CUI.MenuRegular openXmlElement, DM.CheckBox? value, DiffList? diffs, string? objName)
  {
    return DMX.CheckBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.CheckBox>(), value, diffs, objName);
  }
  
  private static void SetCheckBox(DXO10CUI.MenuRegular openXmlElement, DM.CheckBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.CheckBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.CheckBoxConverter.CreateOpenXmlElement<DXO10CUI.CheckBox>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.GalleryRegular? GetGalleryRegular(DXO10CUI.MenuRegular openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.GalleryRegular>();
    if (element != null)
      return DMX.GalleryRegularConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGalleryRegular(DXO10CUI.MenuRegular openXmlElement, DM.GalleryRegular? value, DiffList? diffs, string? objName)
  {
    return DMX.GalleryRegularConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.GalleryRegular>(), value, diffs, objName);
  }
  
  private static void SetGalleryRegular(DXO10CUI.MenuRegular openXmlElement, DM.GalleryRegular? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.GalleryRegular>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.GalleryRegularConverter.CreateOpenXmlElement<DXO10CUI.GalleryRegular>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.ToggleButtonRegular? GetToggleButtonRegular(DXO10CUI.MenuRegular openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.ToggleButtonRegular>();
    if (element != null)
      return DMX.ToggleButtonRegularConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpToggleButtonRegular(DXO10CUI.MenuRegular openXmlElement, DM.ToggleButtonRegular? value, DiffList? diffs, string? objName)
  {
    return DMX.ToggleButtonRegularConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.ToggleButtonRegular>(), value, diffs, objName);
  }
  
  private static void SetToggleButtonRegular(DXO10CUI.MenuRegular openXmlElement, DM.ToggleButtonRegular? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.ToggleButtonRegular>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.ToggleButtonRegularConverter.CreateOpenXmlElement<DXO10CUI.ToggleButtonRegular>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.MenuSeparator? GetMenuSeparator(DXO10CUI.MenuRegular openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.MenuSeparator>();
    if (element != null)
      return DMX.MenuSeparatorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMenuSeparator(DXO10CUI.MenuRegular openXmlElement, DM.MenuSeparator? value, DiffList? diffs, string? objName)
  {
    return DMX.MenuSeparatorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.MenuSeparator>(), value, diffs, objName);
  }
  
  private static void SetMenuSeparator(DXO10CUI.MenuRegular openXmlElement, DM.MenuSeparator? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.MenuSeparator>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.MenuSeparatorConverter.CreateOpenXmlElement<DXO10CUI.MenuSeparator>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.SplitButtonRegular? GetSplitButtonRegular(DXO10CUI.MenuRegular openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.SplitButtonRegular>();
    if (element != null)
      return DMX.SplitButtonRegularConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSplitButtonRegular(DXO10CUI.MenuRegular openXmlElement, DM.SplitButtonRegular? value, DiffList? diffs, string? objName)
  {
    return DMX.SplitButtonRegularConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.SplitButtonRegular>(), value, diffs, objName);
  }
  
  private static void SetSplitButtonRegular(DXO10CUI.MenuRegular openXmlElement, DM.SplitButtonRegular? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.SplitButtonRegular>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.SplitButtonRegularConverter.CreateOpenXmlElement<DXO10CUI.SplitButtonRegular>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.MenuRegular? GetChildMenuRegular(DXO10CUI.MenuRegular openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.MenuRegular>();
    if (element != null)
      return DMX.MenuRegularConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChildMenuRegular(DXO10CUI.MenuRegular openXmlElement, DM.MenuRegular? value, DiffList? diffs, string? objName)
  {
    return DMX.MenuRegularConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.MenuRegular>(), value, diffs, objName);
  }
  
  private static void SetChildMenuRegular(DXO10CUI.MenuRegular openXmlElement, DM.MenuRegular? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.MenuRegular>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.MenuRegularConverter.CreateOpenXmlElement<DXO10CUI.MenuRegular>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.DynamicMenuRegular? GetDynamicMenuRegular(DXO10CUI.MenuRegular openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.DynamicMenuRegular>();
    if (element != null)
      return DMX.DynamicMenuRegularConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDynamicMenuRegular(DXO10CUI.MenuRegular openXmlElement, DM.DynamicMenuRegular? value, DiffList? diffs, string? objName)
  {
    return DMX.DynamicMenuRegularConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.DynamicMenuRegular>(), value, diffs, objName);
  }
  
  private static void SetDynamicMenuRegular(DXO10CUI.MenuRegular openXmlElement, DM.DynamicMenuRegular? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.DynamicMenuRegular>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.DynamicMenuRegularConverter.CreateOpenXmlElement<DXO10CUI.DynamicMenuRegular>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.MenuRegular? CreateModelElement(DXO10CUI.MenuRegular? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.MenuRegular();
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
      value.ChildMenuRegular = GetChildMenuRegular(openXmlElement);
      value.DynamicMenuRegular = GetDynamicMenuRegular(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10CUI.MenuRegular? openXmlElement, DM.MenuRegular? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpItemSize(openXmlElement, value.ItemSize, diffs, objName))
        ok = false;
      if (!CmpDescription(openXmlElement, value.Description, diffs, objName))
        ok = false;
      if (!CmpGetDescription(openXmlElement, value.GetDescription, diffs, objName))
        ok = false;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpQualifiedId(openXmlElement, value.QualifiedId, diffs, objName))
        ok = false;
      if (!CmpTag(openXmlElement, value.Tag, diffs, objName))
        ok = false;
      if (!CmpIdMso(openXmlElement, value.IdMso, diffs, objName))
        ok = false;
      if (!CmpImage(openXmlElement, value.Image, diffs, objName))
        ok = false;
      if (!CmpImageMso(openXmlElement, value.ImageMso, diffs, objName))
        ok = false;
      if (!CmpGetImage(openXmlElement, value.GetImage, diffs, objName))
        ok = false;
      if (!CmpScreentip(openXmlElement, value.Screentip, diffs, objName))
        ok = false;
      if (!CmpGetScreentip(openXmlElement, value.GetScreentip, diffs, objName))
        ok = false;
      if (!CmpSupertip(openXmlElement, value.Supertip, diffs, objName))
        ok = false;
      if (!CmpGetSupertip(openXmlElement, value.GetSupertip, diffs, objName))
        ok = false;
      if (!CmpEnabled(openXmlElement, value.Enabled, diffs, objName))
        ok = false;
      if (!CmpGetEnabled(openXmlElement, value.GetEnabled, diffs, objName))
        ok = false;
      if (!CmpLabel(openXmlElement, value.Label, diffs, objName))
        ok = false;
      if (!CmpGetLabel(openXmlElement, value.GetLabel, diffs, objName))
        ok = false;
      if (!CmpInsertAfterMso(openXmlElement, value.InsertAfterMso, diffs, objName))
        ok = false;
      if (!CmpInsertBeforeMso(openXmlElement, value.InsertBeforeMso, diffs, objName))
        ok = false;
      if (!CmpInsertAfterQulifiedId(openXmlElement, value.InsertAfterQulifiedId, diffs, objName))
        ok = false;
      if (!CmpInsertBeforeQulifiedId(openXmlElement, value.InsertBeforeQulifiedId, diffs, objName))
        ok = false;
      if (!CmpVisible(openXmlElement, value.Visible, diffs, objName))
        ok = false;
      if (!CmpGetVisible(openXmlElement, value.GetVisible, diffs, objName))
        ok = false;
      if (!CmpKeytip(openXmlElement, value.Keytip, diffs, objName))
        ok = false;
      if (!CmpGetKeytip(openXmlElement, value.GetKeytip, diffs, objName))
        ok = false;
      if (!CmpShowLabel(openXmlElement, value.ShowLabel, diffs, objName))
        ok = false;
      if (!CmpGetShowLabel(openXmlElement, value.GetShowLabel, diffs, objName))
        ok = false;
      if (!CmpShowImage(openXmlElement, value.ShowImage, diffs, objName))
        ok = false;
      if (!CmpGetShowImage(openXmlElement, value.GetShowImage, diffs, objName))
        ok = false;
      if (!CmpControlCloneRegular(openXmlElement, value.ControlCloneRegular, diffs, objName))
        ok = false;
      if (!CmpButtonRegular(openXmlElement, value.ButtonRegular, diffs, objName))
        ok = false;
      if (!CmpCheckBox(openXmlElement, value.CheckBox, diffs, objName))
        ok = false;
      if (!CmpGalleryRegular(openXmlElement, value.GalleryRegular, diffs, objName))
        ok = false;
      if (!CmpToggleButtonRegular(openXmlElement, value.ToggleButtonRegular, diffs, objName))
        ok = false;
      if (!CmpMenuSeparator(openXmlElement, value.MenuSeparator, diffs, objName))
        ok = false;
      if (!CmpSplitButtonRegular(openXmlElement, value.SplitButtonRegular, diffs, objName))
        ok = false;
      if (!CmpChildMenuRegular(openXmlElement, value.ChildMenuRegular, diffs, objName))
        ok = false;
      if (!CmpDynamicMenuRegular(openXmlElement, value.DynamicMenuRegular, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.MenuRegular value)
    where OpenXmlElementType: DXO10CUI.MenuRegular, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10CUI.MenuRegular openXmlElement, DM.MenuRegular value)
  {
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
    SetChildMenuRegular(openXmlElement, value?.ChildMenuRegular);
    SetDynamicMenuRegular(openXmlElement, value?.DynamicMenuRegular);
  }
}
