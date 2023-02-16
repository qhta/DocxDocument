namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the EditBox Class.
/// </summary>
public static class EditBoxConverter
{
  /// <summary>
  /// enabled
  /// </summary>
  private static Boolean? GetEnabled(DXOCustUI.EditBox openXmlElement)
  {
    return openXmlElement?.Enabled?.Value;
  }
  
  private static bool CmpEnabled(DXOCustUI.EditBox openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Enabled?.Value == value) return true;
    diffs?.Add(objName, "Enabled", openXmlElement?.Enabled?.Value, value);
    return false;
  }
  
  private static void SetEnabled(DXOCustUI.EditBox openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Enabled = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Enabled = null;
  }
  
  /// <summary>
  /// getEnabled
  /// </summary>
  private static String? GetGetEnabled(DXOCustUI.EditBox openXmlElement)
  {
    return openXmlElement?.GetEnabled?.Value;
  }
  
  private static bool CmpGetEnabled(DXOCustUI.EditBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetEnabled?.Value == value) return true;
    diffs?.Add(objName, "GetEnabled", openXmlElement?.GetEnabled?.Value, value);
    return false;
  }
  
  private static void SetGetEnabled(DXOCustUI.EditBox openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetEnabled = new StringValue { Value = value };
    else
      openXmlElement.GetEnabled = null;
  }
  
  /// <summary>
  /// image
  /// </summary>
  private static String? GetImage(DXOCustUI.EditBox openXmlElement)
  {
    return openXmlElement?.Image?.Value;
  }
  
  private static bool CmpImage(DXOCustUI.EditBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Image?.Value == value) return true;
    diffs?.Add(objName, "Image", openXmlElement?.Image?.Value, value);
    return false;
  }
  
  private static void SetImage(DXOCustUI.EditBox openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Image = new StringValue { Value = value };
    else
      openXmlElement.Image = null;
  }
  
  /// <summary>
  /// imageMso
  /// </summary>
  private static String? GetImageMso(DXOCustUI.EditBox openXmlElement)
  {
    return openXmlElement?.ImageMso?.Value;
  }
  
  private static bool CmpImageMso(DXOCustUI.EditBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ImageMso?.Value == value) return true;
    diffs?.Add(objName, "ImageMso", openXmlElement?.ImageMso?.Value, value);
    return false;
  }
  
  private static void SetImageMso(DXOCustUI.EditBox openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ImageMso = new StringValue { Value = value };
    else
      openXmlElement.ImageMso = null;
  }
  
  /// <summary>
  /// getImage
  /// </summary>
  private static String? GetGetImage(DXOCustUI.EditBox openXmlElement)
  {
    return openXmlElement?.GetImage?.Value;
  }
  
  private static bool CmpGetImage(DXOCustUI.EditBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetImage?.Value == value) return true;
    diffs?.Add(objName, "GetImage", openXmlElement?.GetImage?.Value, value);
    return false;
  }
  
  private static void SetGetImage(DXOCustUI.EditBox openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetImage = new StringValue { Value = value };
    else
      openXmlElement.GetImage = null;
  }
  
  /// <summary>
  /// maxLength
  /// </summary>
  private static Int64? GetMaxLength(DXOCustUI.EditBox openXmlElement)
  {
    return openXmlElement?.MaxLength?.Value;
  }
  
  private static bool CmpMaxLength(DXOCustUI.EditBox openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.MaxLength?.Value == value) return true;
    diffs?.Add(objName, "MaxLength", openXmlElement?.MaxLength?.Value, value);
    return false;
  }
  
  private static void SetMaxLength(DXOCustUI.EditBox openXmlElement, Int64? value)
  {
    openXmlElement.MaxLength = value;
  }
  
  /// <summary>
  /// getText
  /// </summary>
  private static String? GetGetText(DXOCustUI.EditBox openXmlElement)
  {
    return openXmlElement?.GetText?.Value;
  }
  
  private static bool CmpGetText(DXOCustUI.EditBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetText?.Value == value) return true;
    diffs?.Add(objName, "GetText", openXmlElement?.GetText?.Value, value);
    return false;
  }
  
  private static void SetGetText(DXOCustUI.EditBox openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetText = new StringValue { Value = value };
    else
      openXmlElement.GetText = null;
  }
  
  /// <summary>
  /// onChange
  /// </summary>
  private static String? GetOnChange(DXOCustUI.EditBox openXmlElement)
  {
    return openXmlElement?.OnChange?.Value;
  }
  
  private static bool CmpOnChange(DXOCustUI.EditBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.OnChange?.Value == value) return true;
    diffs?.Add(objName, "OnChange", openXmlElement?.OnChange?.Value, value);
    return false;
  }
  
  private static void SetOnChange(DXOCustUI.EditBox openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.OnChange = new StringValue { Value = value };
    else
      openXmlElement.OnChange = null;
  }
  
  /// <summary>
  /// sizeString
  /// </summary>
  private static String? GetSizeString(DXOCustUI.EditBox openXmlElement)
  {
    return openXmlElement?.SizeString?.Value;
  }
  
  private static bool CmpSizeString(DXOCustUI.EditBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.SizeString?.Value == value) return true;
    diffs?.Add(objName, "SizeString", openXmlElement?.SizeString?.Value, value);
    return false;
  }
  
  private static void SetSizeString(DXOCustUI.EditBox openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.SizeString = new StringValue { Value = value };
    else
      openXmlElement.SizeString = null;
  }
  
  /// <summary>
  /// id
  /// </summary>
  private static String? GetId(DXOCustUI.EditBox openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXOCustUI.EditBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Id?.Value == value) return true;
    diffs?.Add(objName, "Id", openXmlElement?.Id?.Value, value);
    return false;
  }
  
  private static void SetId(DXOCustUI.EditBox openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// idQ
  /// </summary>
  private static String? GetIdQ(DXOCustUI.EditBox openXmlElement)
  {
    return openXmlElement?.IdQ?.Value;
  }
  
  private static bool CmpIdQ(DXOCustUI.EditBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.IdQ?.Value == value) return true;
    diffs?.Add(objName, "IdQ", openXmlElement?.IdQ?.Value, value);
    return false;
  }
  
  private static void SetIdQ(DXOCustUI.EditBox openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.IdQ = new StringValue { Value = value };
    else
      openXmlElement.IdQ = null;
  }
  
  /// <summary>
  /// idMso
  /// </summary>
  private static String? GetIdMso(DXOCustUI.EditBox openXmlElement)
  {
    return openXmlElement?.IdMso?.Value;
  }
  
  private static bool CmpIdMso(DXOCustUI.EditBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.IdMso?.Value == value) return true;
    diffs?.Add(objName, "IdMso", openXmlElement?.IdMso?.Value, value);
    return false;
  }
  
  private static void SetIdMso(DXOCustUI.EditBox openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.IdMso = new StringValue { Value = value };
    else
      openXmlElement.IdMso = null;
  }
  
  /// <summary>
  /// tag
  /// </summary>
  private static String? GetTag(DXOCustUI.EditBox openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }
  
  private static bool CmpTag(DXOCustUI.EditBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Tag?.Value == value) return true;
    diffs?.Add(objName, "Tag", openXmlElement?.Tag?.Value, value);
    return false;
  }
  
  private static void SetTag(DXOCustUI.EditBox openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Tag = new StringValue { Value = value };
    else
      openXmlElement.Tag = null;
  }
  
  /// <summary>
  /// screentip
  /// </summary>
  private static String? GetScreentip(DXOCustUI.EditBox openXmlElement)
  {
    return openXmlElement?.Screentip?.Value;
  }
  
  private static bool CmpScreentip(DXOCustUI.EditBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Screentip?.Value == value) return true;
    diffs?.Add(objName, "Screentip", openXmlElement?.Screentip?.Value, value);
    return false;
  }
  
  private static void SetScreentip(DXOCustUI.EditBox openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Screentip = new StringValue { Value = value };
    else
      openXmlElement.Screentip = null;
  }
  
  /// <summary>
  /// getScreentip
  /// </summary>
  private static String? GetGetScreentip(DXOCustUI.EditBox openXmlElement)
  {
    return openXmlElement?.GetScreentip?.Value;
  }
  
  private static bool CmpGetScreentip(DXOCustUI.EditBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetScreentip?.Value == value) return true;
    diffs?.Add(objName, "GetScreentip", openXmlElement?.GetScreentip?.Value, value);
    return false;
  }
  
  private static void SetGetScreentip(DXOCustUI.EditBox openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetScreentip = new StringValue { Value = value };
    else
      openXmlElement.GetScreentip = null;
  }
  
  /// <summary>
  /// supertip
  /// </summary>
  private static String? GetSupertip(DXOCustUI.EditBox openXmlElement)
  {
    return openXmlElement?.Supertip?.Value;
  }
  
  private static bool CmpSupertip(DXOCustUI.EditBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Supertip?.Value == value) return true;
    diffs?.Add(objName, "Supertip", openXmlElement?.Supertip?.Value, value);
    return false;
  }
  
  private static void SetSupertip(DXOCustUI.EditBox openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Supertip = new StringValue { Value = value };
    else
      openXmlElement.Supertip = null;
  }
  
  /// <summary>
  /// getSupertip
  /// </summary>
  private static String? GetGetSupertip(DXOCustUI.EditBox openXmlElement)
  {
    return openXmlElement?.GetSupertip?.Value;
  }
  
  private static bool CmpGetSupertip(DXOCustUI.EditBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetSupertip?.Value == value) return true;
    diffs?.Add(objName, "GetSupertip", openXmlElement?.GetSupertip?.Value, value);
    return false;
  }
  
  private static void SetGetSupertip(DXOCustUI.EditBox openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetSupertip = new StringValue { Value = value };
    else
      openXmlElement.GetSupertip = null;
  }
  
  /// <summary>
  /// label
  /// </summary>
  private static String? GetLabel(DXOCustUI.EditBox openXmlElement)
  {
    return openXmlElement?.Label?.Value;
  }
  
  private static bool CmpLabel(DXOCustUI.EditBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Label?.Value == value) return true;
    diffs?.Add(objName, "Label", openXmlElement?.Label?.Value, value);
    return false;
  }
  
  private static void SetLabel(DXOCustUI.EditBox openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Label = new StringValue { Value = value };
    else
      openXmlElement.Label = null;
  }
  
  /// <summary>
  /// getLabel
  /// </summary>
  private static String? GetGetLabel(DXOCustUI.EditBox openXmlElement)
  {
    return openXmlElement?.GetLabel?.Value;
  }
  
  private static bool CmpGetLabel(DXOCustUI.EditBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetLabel?.Value == value) return true;
    diffs?.Add(objName, "GetLabel", openXmlElement?.GetLabel?.Value, value);
    return false;
  }
  
  private static void SetGetLabel(DXOCustUI.EditBox openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetLabel = new StringValue { Value = value };
    else
      openXmlElement.GetLabel = null;
  }
  
  /// <summary>
  /// insertAfterMso
  /// </summary>
  private static String? GetInsertAfterMso(DXOCustUI.EditBox openXmlElement)
  {
    return openXmlElement?.InsertAfterMso?.Value;
  }
  
  private static bool CmpInsertAfterMso(DXOCustUI.EditBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.InsertAfterMso?.Value == value) return true;
    diffs?.Add(objName, "InsertAfterMso", openXmlElement?.InsertAfterMso?.Value, value);
    return false;
  }
  
  private static void SetInsertAfterMso(DXOCustUI.EditBox openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterMso = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterMso = null;
  }
  
  /// <summary>
  /// insertBeforeMso
  /// </summary>
  private static String? GetInsertBeforeMso(DXOCustUI.EditBox openXmlElement)
  {
    return openXmlElement?.InsertBeforeMso?.Value;
  }
  
  private static bool CmpInsertBeforeMso(DXOCustUI.EditBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.InsertBeforeMso?.Value == value) return true;
    diffs?.Add(objName, "InsertBeforeMso", openXmlElement?.InsertBeforeMso?.Value, value);
    return false;
  }
  
  private static void SetInsertBeforeMso(DXOCustUI.EditBox openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeMso = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeMso = null;
  }
  
  /// <summary>
  /// insertAfterQ
  /// </summary>
  private static String? GetInsertAfterQ(DXOCustUI.EditBox openXmlElement)
  {
    return openXmlElement?.InsertAfterQ?.Value;
  }
  
  private static bool CmpInsertAfterQ(DXOCustUI.EditBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.InsertAfterQ?.Value == value) return true;
    diffs?.Add(objName, "InsertAfterQ", openXmlElement?.InsertAfterQ?.Value, value);
    return false;
  }
  
  private static void SetInsertAfterQ(DXOCustUI.EditBox openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterQ = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterQ = null;
  }
  
  /// <summary>
  /// insertBeforeQ
  /// </summary>
  private static String? GetInsertBeforeQ(DXOCustUI.EditBox openXmlElement)
  {
    return openXmlElement?.InsertBeforeQ?.Value;
  }
  
  private static bool CmpInsertBeforeQ(DXOCustUI.EditBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.InsertBeforeQ?.Value == value) return true;
    diffs?.Add(objName, "InsertBeforeQ", openXmlElement?.InsertBeforeQ?.Value, value);
    return false;
  }
  
  private static void SetInsertBeforeQ(DXOCustUI.EditBox openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeQ = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeQ = null;
  }
  
  /// <summary>
  /// visible
  /// </summary>
  private static Boolean? GetVisible(DXOCustUI.EditBox openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static bool CmpVisible(DXOCustUI.EditBox openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Visible?.Value == value) return true;
    diffs?.Add(objName, "Visible", openXmlElement?.Visible?.Value, value);
    return false;
  }
  
  private static void SetVisible(DXOCustUI.EditBox openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible
  /// </summary>
  private static String? GetGetVisible(DXOCustUI.EditBox openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }
  
  private static bool CmpGetVisible(DXOCustUI.EditBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetVisible?.Value == value) return true;
    diffs?.Add(objName, "GetVisible", openXmlElement?.GetVisible?.Value, value);
    return false;
  }
  
  private static void SetGetVisible(DXOCustUI.EditBox openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetVisible = new StringValue { Value = value };
    else
      openXmlElement.GetVisible = null;
  }
  
  /// <summary>
  /// keytip
  /// </summary>
  private static String? GetKeytip(DXOCustUI.EditBox openXmlElement)
  {
    return openXmlElement?.Keytip?.Value;
  }
  
  private static bool CmpKeytip(DXOCustUI.EditBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Keytip?.Value == value) return true;
    diffs?.Add(objName, "Keytip", openXmlElement?.Keytip?.Value, value);
    return false;
  }
  
  private static void SetKeytip(DXOCustUI.EditBox openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Keytip = new StringValue { Value = value };
    else
      openXmlElement.Keytip = null;
  }
  
  /// <summary>
  /// getKeytip
  /// </summary>
  private static String? GetGetKeytip(DXOCustUI.EditBox openXmlElement)
  {
    return openXmlElement?.GetKeytip?.Value;
  }
  
  private static bool CmpGetKeytip(DXOCustUI.EditBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetKeytip?.Value == value) return true;
    diffs?.Add(objName, "GetKeytip", openXmlElement?.GetKeytip?.Value, value);
    return false;
  }
  
  private static void SetGetKeytip(DXOCustUI.EditBox openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetKeytip = new StringValue { Value = value };
    else
      openXmlElement.GetKeytip = null;
  }
  
  /// <summary>
  /// showLabel
  /// </summary>
  private static Boolean? GetShowLabel(DXOCustUI.EditBox openXmlElement)
  {
    return openXmlElement?.ShowLabel?.Value;
  }
  
  private static bool CmpShowLabel(DXOCustUI.EditBox openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ShowLabel?.Value == value) return true;
    diffs?.Add(objName, "ShowLabel", openXmlElement?.ShowLabel?.Value, value);
    return false;
  }
  
  private static void SetShowLabel(DXOCustUI.EditBox openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowLabel = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowLabel = null;
  }
  
  /// <summary>
  /// getShowLabel
  /// </summary>
  private static String? GetGetShowLabel(DXOCustUI.EditBox openXmlElement)
  {
    return openXmlElement?.GetShowLabel?.Value;
  }
  
  private static bool CmpGetShowLabel(DXOCustUI.EditBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetShowLabel?.Value == value) return true;
    diffs?.Add(objName, "GetShowLabel", openXmlElement?.GetShowLabel?.Value, value);
    return false;
  }
  
  private static void SetGetShowLabel(DXOCustUI.EditBox openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetShowLabel = new StringValue { Value = value };
    else
      openXmlElement.GetShowLabel = null;
  }
  
  /// <summary>
  /// showImage
  /// </summary>
  private static Boolean? GetShowImage(DXOCustUI.EditBox openXmlElement)
  {
    return openXmlElement?.ShowImage?.Value;
  }
  
  private static bool CmpShowImage(DXOCustUI.EditBox openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ShowImage?.Value == value) return true;
    diffs?.Add(objName, "ShowImage", openXmlElement?.ShowImage?.Value, value);
    return false;
  }
  
  private static void SetShowImage(DXOCustUI.EditBox openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowImage = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowImage = null;
  }
  
  /// <summary>
  /// getShowImage
  /// </summary>
  private static String? GetGetShowImage(DXOCustUI.EditBox openXmlElement)
  {
    return openXmlElement?.GetShowImage?.Value;
  }
  
  private static bool CmpGetShowImage(DXOCustUI.EditBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetShowImage?.Value == value) return true;
    diffs?.Add(objName, "GetShowImage", openXmlElement?.GetShowImage?.Value, value);
    return false;
  }
  
  private static void SetGetShowImage(DXOCustUI.EditBox openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetShowImage = new StringValue { Value = value };
    else
      openXmlElement.GetShowImage = null;
  }
  
  public static DocumentModel.UI.EditBox? CreateModelElement(DXOCustUI.EditBox? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.UI.EditBox();
      value.Enabled = GetEnabled(openXmlElement);
      value.GetEnabled = GetGetEnabled(openXmlElement);
      value.Image = GetImage(openXmlElement);
      value.ImageMso = GetImageMso(openXmlElement);
      value.GetImage = GetGetImage(openXmlElement);
      value.MaxLength = GetMaxLength(openXmlElement);
      value.GetText = GetGetText(openXmlElement);
      value.OnChange = GetOnChange(openXmlElement);
      value.SizeString = GetSizeString(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.IdQ = GetIdQ(openXmlElement);
      value.IdMso = GetIdMso(openXmlElement);
      value.Tag = GetTag(openXmlElement);
      value.Screentip = GetScreentip(openXmlElement);
      value.GetScreentip = GetGetScreentip(openXmlElement);
      value.Supertip = GetSupertip(openXmlElement);
      value.GetSupertip = GetGetSupertip(openXmlElement);
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
  
  public static bool CompareModelElement(DXOCustUI.EditBox? openXmlElement, DMUI.EditBox? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpEnabled(openXmlElement, value.Enabled, diffs, objName))
        ok = false;
      if (!CmpGetEnabled(openXmlElement, value.GetEnabled, diffs, objName))
        ok = false;
      if (!CmpImage(openXmlElement, value.Image, diffs, objName))
        ok = false;
      if (!CmpImageMso(openXmlElement, value.ImageMso, diffs, objName))
        ok = false;
      if (!CmpGetImage(openXmlElement, value.GetImage, diffs, objName))
        ok = false;
      if (!CmpMaxLength(openXmlElement, value.MaxLength, diffs, objName))
        ok = false;
      if (!CmpGetText(openXmlElement, value.GetText, diffs, objName))
        ok = false;
      if (!CmpOnChange(openXmlElement, value.OnChange, diffs, objName))
        ok = false;
      if (!CmpSizeString(openXmlElement, value.SizeString, diffs, objName))
        ok = false;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpIdQ(openXmlElement, value.IdQ, diffs, objName))
        ok = false;
      if (!CmpIdMso(openXmlElement, value.IdMso, diffs, objName))
        ok = false;
      if (!CmpTag(openXmlElement, value.Tag, diffs, objName))
        ok = false;
      if (!CmpScreentip(openXmlElement, value.Screentip, diffs, objName))
        ok = false;
      if (!CmpGetScreentip(openXmlElement, value.GetScreentip, diffs, objName))
        ok = false;
      if (!CmpSupertip(openXmlElement, value.Supertip, diffs, objName))
        ok = false;
      if (!CmpGetSupertip(openXmlElement, value.GetSupertip, diffs, objName))
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMUI.EditBox? value)
    where OpenXmlElementType: DXOCustUI.EditBox, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEnabled(openXmlElement, value?.Enabled);
      SetGetEnabled(openXmlElement, value?.GetEnabled);
      SetImage(openXmlElement, value?.Image);
      SetImageMso(openXmlElement, value?.ImageMso);
      SetGetImage(openXmlElement, value?.GetImage);
      SetMaxLength(openXmlElement, value?.MaxLength);
      SetGetText(openXmlElement, value?.GetText);
      SetOnChange(openXmlElement, value?.OnChange);
      SetSizeString(openXmlElement, value?.SizeString);
      SetId(openXmlElement, value?.Id);
      SetIdQ(openXmlElement, value?.IdQ);
      SetIdMso(openXmlElement, value?.IdMso);
      SetTag(openXmlElement, value?.Tag);
      SetScreentip(openXmlElement, value?.Screentip);
      SetGetScreentip(openXmlElement, value?.GetScreentip);
      SetSupertip(openXmlElement, value?.Supertip);
      SetGetSupertip(openXmlElement, value?.GetSupertip);
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
