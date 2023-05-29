namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the UnsizedControlClone Class.
/// </summary>
public static class UnsizedControlCloneConverter
{
  /// <summary>
  /// idQ
  /// </summary>
  private static String? GetIdQ(DXOCustUI.UnsizedControlClone openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.IdQ);
  }
  
  private static bool CmpIdQ(DXOCustUI.UnsizedControlClone openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.IdQ, value, diffs, objName, "IdQ");
  }
  
  private static void SetIdQ(DXOCustUI.UnsizedControlClone openXmlElement, String? value)
  {
    openXmlElement.IdQ = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// idMso
  /// </summary>
  private static String? GetIdMso(DXOCustUI.UnsizedControlClone openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.IdMso);
  }
  
  private static bool CmpIdMso(DXOCustUI.UnsizedControlClone openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.IdMso, value, diffs, objName, "IdMso");
  }
  
  private static void SetIdMso(DXOCustUI.UnsizedControlClone openXmlElement, String? value)
  {
    openXmlElement.IdMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// tag
  /// </summary>
  private static String? GetTag(DXOCustUI.UnsizedControlClone openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Tag);
  }
  
  private static bool CmpTag(DXOCustUI.UnsizedControlClone openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Tag, value, diffs, objName, "Tag");
  }
  
  private static void SetTag(DXOCustUI.UnsizedControlClone openXmlElement, String? value)
  {
    openXmlElement.Tag = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// image
  /// </summary>
  private static String? GetImage(DXOCustUI.UnsizedControlClone openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Image);
  }
  
  private static bool CmpImage(DXOCustUI.UnsizedControlClone openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Image, value, diffs, objName, "Image");
  }
  
  private static void SetImage(DXOCustUI.UnsizedControlClone openXmlElement, String? value)
  {
    openXmlElement.Image = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// imageMso
  /// </summary>
  private static String? GetImageMso(DXOCustUI.UnsizedControlClone openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ImageMso);
  }
  
  private static bool CmpImageMso(DXOCustUI.UnsizedControlClone openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ImageMso, value, diffs, objName, "ImageMso");
  }
  
  private static void SetImageMso(DXOCustUI.UnsizedControlClone openXmlElement, String? value)
  {
    openXmlElement.ImageMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getImage
  /// </summary>
  private static String? GetGetImage(DXOCustUI.UnsizedControlClone openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetImage);
  }
  
  private static bool CmpGetImage(DXOCustUI.UnsizedControlClone openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetImage, value, diffs, objName, "GetImage");
  }
  
  private static void SetGetImage(DXOCustUI.UnsizedControlClone openXmlElement, String? value)
  {
    openXmlElement.GetImage = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// screentip
  /// </summary>
  private static String? GetScreentip(DXOCustUI.UnsizedControlClone openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Screentip);
  }
  
  private static bool CmpScreentip(DXOCustUI.UnsizedControlClone openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Screentip, value, diffs, objName, "Screentip");
  }
  
  private static void SetScreentip(DXOCustUI.UnsizedControlClone openXmlElement, String? value)
  {
    openXmlElement.Screentip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getScreentip
  /// </summary>
  private static String? GetGetScreentip(DXOCustUI.UnsizedControlClone openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetScreentip);
  }
  
  private static bool CmpGetScreentip(DXOCustUI.UnsizedControlClone openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetScreentip, value, diffs, objName, "GetScreentip");
  }
  
  private static void SetGetScreentip(DXOCustUI.UnsizedControlClone openXmlElement, String? value)
  {
    openXmlElement.GetScreentip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// supertip
  /// </summary>
  private static String? GetSupertip(DXOCustUI.UnsizedControlClone openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Supertip);
  }
  
  private static bool CmpSupertip(DXOCustUI.UnsizedControlClone openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Supertip, value, diffs, objName, "Supertip");
  }
  
  private static void SetSupertip(DXOCustUI.UnsizedControlClone openXmlElement, String? value)
  {
    openXmlElement.Supertip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getSupertip
  /// </summary>
  private static String? GetGetSupertip(DXOCustUI.UnsizedControlClone openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetSupertip);
  }
  
  private static bool CmpGetSupertip(DXOCustUI.UnsizedControlClone openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetSupertip, value, diffs, objName, "GetSupertip");
  }
  
  private static void SetGetSupertip(DXOCustUI.UnsizedControlClone openXmlElement, String? value)
  {
    openXmlElement.GetSupertip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// enabled
  /// </summary>
  private static Boolean? GetEnabled(DXOCustUI.UnsizedControlClone openXmlElement)
  {
    return openXmlElement?.Enabled?.Value;
  }
  
  private static bool CmpEnabled(DXOCustUI.UnsizedControlClone openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Enabled?.Value == value) return true;
    diffs?.Add(objName, "Enabled", openXmlElement?.Enabled?.Value, value);
    return false;
  }
  
  private static void SetEnabled(DXOCustUI.UnsizedControlClone openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Enabled = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Enabled = null;
  }
  
  /// <summary>
  /// getEnabled
  /// </summary>
  private static String? GetGetEnabled(DXOCustUI.UnsizedControlClone openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetEnabled);
  }
  
  private static bool CmpGetEnabled(DXOCustUI.UnsizedControlClone openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetEnabled, value, diffs, objName, "GetEnabled");
  }
  
  private static void SetGetEnabled(DXOCustUI.UnsizedControlClone openXmlElement, String? value)
  {
    openXmlElement.GetEnabled = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// label
  /// </summary>
  private static String? GetLabel(DXOCustUI.UnsizedControlClone openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Label);
  }
  
  private static bool CmpLabel(DXOCustUI.UnsizedControlClone openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Label, value, diffs, objName, "Label");
  }
  
  private static void SetLabel(DXOCustUI.UnsizedControlClone openXmlElement, String? value)
  {
    openXmlElement.Label = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getLabel
  /// </summary>
  private static String? GetGetLabel(DXOCustUI.UnsizedControlClone openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetLabel);
  }
  
  private static bool CmpGetLabel(DXOCustUI.UnsizedControlClone openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetLabel, value, diffs, objName, "GetLabel");
  }
  
  private static void SetGetLabel(DXOCustUI.UnsizedControlClone openXmlElement, String? value)
  {
    openXmlElement.GetLabel = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertAfterMso
  /// </summary>
  private static String? GetInsertAfterMso(DXOCustUI.UnsizedControlClone openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertAfterMso);
  }
  
  private static bool CmpInsertAfterMso(DXOCustUI.UnsizedControlClone openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertAfterMso, value, diffs, objName, "InsertAfterMso");
  }
  
  private static void SetInsertAfterMso(DXOCustUI.UnsizedControlClone openXmlElement, String? value)
  {
    openXmlElement.InsertAfterMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertBeforeMso
  /// </summary>
  private static String? GetInsertBeforeMso(DXOCustUI.UnsizedControlClone openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertBeforeMso);
  }
  
  private static bool CmpInsertBeforeMso(DXOCustUI.UnsizedControlClone openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertBeforeMso, value, diffs, objName, "InsertBeforeMso");
  }
  
  private static void SetInsertBeforeMso(DXOCustUI.UnsizedControlClone openXmlElement, String? value)
  {
    openXmlElement.InsertBeforeMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertAfterQ
  /// </summary>
  private static String? GetInsertAfterQ(DXOCustUI.UnsizedControlClone openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertAfterQ);
  }
  
  private static bool CmpInsertAfterQ(DXOCustUI.UnsizedControlClone openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertAfterQ, value, diffs, objName, "InsertAfterQ");
  }
  
  private static void SetInsertAfterQ(DXOCustUI.UnsizedControlClone openXmlElement, String? value)
  {
    openXmlElement.InsertAfterQ = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertBeforeQ
  /// </summary>
  private static String? GetInsertBeforeQ(DXOCustUI.UnsizedControlClone openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertBeforeQ);
  }
  
  private static bool CmpInsertBeforeQ(DXOCustUI.UnsizedControlClone openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertBeforeQ, value, diffs, objName, "InsertBeforeQ");
  }
  
  private static void SetInsertBeforeQ(DXOCustUI.UnsizedControlClone openXmlElement, String? value)
  {
    openXmlElement.InsertBeforeQ = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// visible
  /// </summary>
  private static Boolean? GetVisible(DXOCustUI.UnsizedControlClone openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static bool CmpVisible(DXOCustUI.UnsizedControlClone openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Visible?.Value == value) return true;
    diffs?.Add(objName, "Visible", openXmlElement?.Visible?.Value, value);
    return false;
  }
  
  private static void SetVisible(DXOCustUI.UnsizedControlClone openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible
  /// </summary>
  private static String? GetGetVisible(DXOCustUI.UnsizedControlClone openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetVisible);
  }
  
  private static bool CmpGetVisible(DXOCustUI.UnsizedControlClone openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetVisible, value, diffs, objName, "GetVisible");
  }
  
  private static void SetGetVisible(DXOCustUI.UnsizedControlClone openXmlElement, String? value)
  {
    openXmlElement.GetVisible = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// keytip
  /// </summary>
  private static String? GetKeytip(DXOCustUI.UnsizedControlClone openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Keytip);
  }
  
  private static bool CmpKeytip(DXOCustUI.UnsizedControlClone openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Keytip, value, diffs, objName, "Keytip");
  }
  
  private static void SetKeytip(DXOCustUI.UnsizedControlClone openXmlElement, String? value)
  {
    openXmlElement.Keytip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getKeytip
  /// </summary>
  private static String? GetGetKeytip(DXOCustUI.UnsizedControlClone openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetKeytip);
  }
  
  private static bool CmpGetKeytip(DXOCustUI.UnsizedControlClone openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetKeytip, value, diffs, objName, "GetKeytip");
  }
  
  private static void SetGetKeytip(DXOCustUI.UnsizedControlClone openXmlElement, String? value)
  {
    openXmlElement.GetKeytip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// showLabel
  /// </summary>
  private static Boolean? GetShowLabel(DXOCustUI.UnsizedControlClone openXmlElement)
  {
    return openXmlElement?.ShowLabel?.Value;
  }
  
  private static bool CmpShowLabel(DXOCustUI.UnsizedControlClone openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ShowLabel?.Value == value) return true;
    diffs?.Add(objName, "ShowLabel", openXmlElement?.ShowLabel?.Value, value);
    return false;
  }
  
  private static void SetShowLabel(DXOCustUI.UnsizedControlClone openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowLabel = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowLabel = null;
  }
  
  /// <summary>
  /// getShowLabel
  /// </summary>
  private static String? GetGetShowLabel(DXOCustUI.UnsizedControlClone openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetShowLabel);
  }
  
  private static bool CmpGetShowLabel(DXOCustUI.UnsizedControlClone openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetShowLabel, value, diffs, objName, "GetShowLabel");
  }
  
  private static void SetGetShowLabel(DXOCustUI.UnsizedControlClone openXmlElement, String? value)
  {
    openXmlElement.GetShowLabel = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// showImage
  /// </summary>
  private static Boolean? GetShowImage(DXOCustUI.UnsizedControlClone openXmlElement)
  {
    return openXmlElement?.ShowImage?.Value;
  }
  
  private static bool CmpShowImage(DXOCustUI.UnsizedControlClone openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ShowImage?.Value == value) return true;
    diffs?.Add(objName, "ShowImage", openXmlElement?.ShowImage?.Value, value);
    return false;
  }
  
  private static void SetShowImage(DXOCustUI.UnsizedControlClone openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowImage = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowImage = null;
  }
  
  /// <summary>
  /// getShowImage
  /// </summary>
  private static String? GetGetShowImage(DXOCustUI.UnsizedControlClone openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetShowImage);
  }
  
  private static bool CmpGetShowImage(DXOCustUI.UnsizedControlClone openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetShowImage, value, diffs, objName, "GetShowImage");
  }
  
  private static void SetGetShowImage(DXOCustUI.UnsizedControlClone openXmlElement, String? value)
  {
    openXmlElement.GetShowImage = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.UI.UnsizedControlClone? CreateModelElement(DXOCustUI.UnsizedControlClone? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.UI.UnsizedControlClone();
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
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOCustUI.UnsizedControlClone? openXmlElement, DMUI.UnsizedControlClone? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpIdQ(openXmlElement, value.IdQ, diffs, objName))
        ok = false;
      if (!CmpIdMso(openXmlElement, value.IdMso, diffs, objName))
        ok = false;
      if (!CmpTag(openXmlElement, value.Tag, diffs, objName))
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
      if (!CmpInsertAfterQ(openXmlElement, value.InsertAfterQ, diffs, objName))
        ok = false;
      if (!CmpInsertBeforeQ(openXmlElement, value.InsertBeforeQ, diffs, objName))
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
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMUI.UnsizedControlClone value)
    where OpenXmlElementType: DXOCustUI.UnsizedControlClone, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOCustUI.UnsizedControlClone openXmlElement, DMUI.UnsizedControlClone value)
  {
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
  }
}
