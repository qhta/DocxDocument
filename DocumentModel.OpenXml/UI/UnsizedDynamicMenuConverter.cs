namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the UnsizedDynamicMenu Class.
/// </summary>
public static class UnsizedDynamicMenuConverter
{
  /// <summary>
  /// description
  /// </summary>
  private static String? GetDescription(DXOCustUI.UnsizedDynamicMenu openXmlElement)
  {
    return openXmlElement?.Description?.Value;
  }
  
  private static bool CmpDescription(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Description?.Value == value;
  }
  
  private static void SetDescription(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Description = new StringValue { Value = value };
    else
      openXmlElement.Description = null;
  }
  
  /// <summary>
  /// getDescription
  /// </summary>
  private static String? GetGetDescription(DXOCustUI.UnsizedDynamicMenu openXmlElement)
  {
    return openXmlElement?.GetDescription?.Value;
  }
  
  private static bool CmpGetDescription(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetDescription?.Value == value;
  }
  
  private static void SetGetDescription(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetDescription = new StringValue { Value = value };
    else
      openXmlElement.GetDescription = null;
  }
  
  /// <summary>
  /// id
  /// </summary>
  private static String? GetId(DXOCustUI.UnsizedDynamicMenu openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Id?.Value == value;
  }
  
  private static void SetId(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// idQ
  /// </summary>
  private static String? GetIdQ(DXOCustUI.UnsizedDynamicMenu openXmlElement)
  {
    return openXmlElement?.IdQ?.Value;
  }
  
  private static bool CmpIdQ(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.IdQ?.Value == value;
  }
  
  private static void SetIdQ(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.IdQ = new StringValue { Value = value };
    else
      openXmlElement.IdQ = null;
  }
  
  /// <summary>
  /// idMso
  /// </summary>
  private static String? GetIdMso(DXOCustUI.UnsizedDynamicMenu openXmlElement)
  {
    return openXmlElement?.IdMso?.Value;
  }
  
  private static bool CmpIdMso(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.IdMso?.Value == value;
  }
  
  private static void SetIdMso(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.IdMso = new StringValue { Value = value };
    else
      openXmlElement.IdMso = null;
  }
  
  /// <summary>
  /// tag
  /// </summary>
  private static String? GetTag(DXOCustUI.UnsizedDynamicMenu openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }
  
  private static bool CmpTag(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Tag?.Value == value;
  }
  
  private static void SetTag(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Tag = new StringValue { Value = value };
    else
      openXmlElement.Tag = null;
  }
  
  /// <summary>
  /// getContent
  /// </summary>
  private static String? GetGetContent(DXOCustUI.UnsizedDynamicMenu openXmlElement)
  {
    return openXmlElement?.GetContent?.Value;
  }
  
  private static bool CmpGetContent(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetContent?.Value == value;
  }
  
  private static void SetGetContent(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetContent = new StringValue { Value = value };
    else
      openXmlElement.GetContent = null;
  }
  
  /// <summary>
  /// invalidateContentOnDrop
  /// </summary>
  private static Boolean? GetInvalidateContentOnDrop(DXOCustUI.UnsizedDynamicMenu openXmlElement)
  {
    return openXmlElement?.InvalidateContentOnDrop?.Value;
  }
  
  private static bool CmpInvalidateContentOnDrop(DXOCustUI.UnsizedDynamicMenu openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.InvalidateContentOnDrop?.Value == value;
  }
  
  private static void SetInvalidateContentOnDrop(DXOCustUI.UnsizedDynamicMenu openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.InvalidateContentOnDrop = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.InvalidateContentOnDrop = null;
  }
  
  /// <summary>
  /// image
  /// </summary>
  private static String? GetImage(DXOCustUI.UnsizedDynamicMenu openXmlElement)
  {
    return openXmlElement?.Image?.Value;
  }
  
  private static bool CmpImage(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Image?.Value == value;
  }
  
  private static void SetImage(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Image = new StringValue { Value = value };
    else
      openXmlElement.Image = null;
  }
  
  /// <summary>
  /// imageMso
  /// </summary>
  private static String? GetImageMso(DXOCustUI.UnsizedDynamicMenu openXmlElement)
  {
    return openXmlElement?.ImageMso?.Value;
  }
  
  private static bool CmpImageMso(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ImageMso?.Value == value;
  }
  
  private static void SetImageMso(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ImageMso = new StringValue { Value = value };
    else
      openXmlElement.ImageMso = null;
  }
  
  /// <summary>
  /// getImage
  /// </summary>
  private static String? GetGetImage(DXOCustUI.UnsizedDynamicMenu openXmlElement)
  {
    return openXmlElement?.GetImage?.Value;
  }
  
  private static bool CmpGetImage(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetImage?.Value == value;
  }
  
  private static void SetGetImage(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetImage = new StringValue { Value = value };
    else
      openXmlElement.GetImage = null;
  }
  
  /// <summary>
  /// screentip
  /// </summary>
  private static String? GetScreentip(DXOCustUI.UnsizedDynamicMenu openXmlElement)
  {
    return openXmlElement?.Screentip?.Value;
  }
  
  private static bool CmpScreentip(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Screentip?.Value == value;
  }
  
  private static void SetScreentip(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Screentip = new StringValue { Value = value };
    else
      openXmlElement.Screentip = null;
  }
  
  /// <summary>
  /// getScreentip
  /// </summary>
  private static String? GetGetScreentip(DXOCustUI.UnsizedDynamicMenu openXmlElement)
  {
    return openXmlElement?.GetScreentip?.Value;
  }
  
  private static bool CmpGetScreentip(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetScreentip?.Value == value;
  }
  
  private static void SetGetScreentip(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetScreentip = new StringValue { Value = value };
    else
      openXmlElement.GetScreentip = null;
  }
  
  /// <summary>
  /// supertip
  /// </summary>
  private static String? GetSupertip(DXOCustUI.UnsizedDynamicMenu openXmlElement)
  {
    return openXmlElement?.Supertip?.Value;
  }
  
  private static bool CmpSupertip(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Supertip?.Value == value;
  }
  
  private static void SetSupertip(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Supertip = new StringValue { Value = value };
    else
      openXmlElement.Supertip = null;
  }
  
  /// <summary>
  /// getSupertip
  /// </summary>
  private static String? GetGetSupertip(DXOCustUI.UnsizedDynamicMenu openXmlElement)
  {
    return openXmlElement?.GetSupertip?.Value;
  }
  
  private static bool CmpGetSupertip(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetSupertip?.Value == value;
  }
  
  private static void SetGetSupertip(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetSupertip = new StringValue { Value = value };
    else
      openXmlElement.GetSupertip = null;
  }
  
  /// <summary>
  /// enabled
  /// </summary>
  private static Boolean? GetEnabled(DXOCustUI.UnsizedDynamicMenu openXmlElement)
  {
    return openXmlElement?.Enabled?.Value;
  }
  
  private static bool CmpEnabled(DXOCustUI.UnsizedDynamicMenu openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Enabled?.Value == value;
  }
  
  private static void SetEnabled(DXOCustUI.UnsizedDynamicMenu openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Enabled = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Enabled = null;
  }
  
  /// <summary>
  /// getEnabled
  /// </summary>
  private static String? GetGetEnabled(DXOCustUI.UnsizedDynamicMenu openXmlElement)
  {
    return openXmlElement?.GetEnabled?.Value;
  }
  
  private static bool CmpGetEnabled(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetEnabled?.Value == value;
  }
  
  private static void SetGetEnabled(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetEnabled = new StringValue { Value = value };
    else
      openXmlElement.GetEnabled = null;
  }
  
  /// <summary>
  /// label
  /// </summary>
  private static String? GetLabel(DXOCustUI.UnsizedDynamicMenu openXmlElement)
  {
    return openXmlElement?.Label?.Value;
  }
  
  private static bool CmpLabel(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Label?.Value == value;
  }
  
  private static void SetLabel(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Label = new StringValue { Value = value };
    else
      openXmlElement.Label = null;
  }
  
  /// <summary>
  /// getLabel
  /// </summary>
  private static String? GetGetLabel(DXOCustUI.UnsizedDynamicMenu openXmlElement)
  {
    return openXmlElement?.GetLabel?.Value;
  }
  
  private static bool CmpGetLabel(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetLabel?.Value == value;
  }
  
  private static void SetGetLabel(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetLabel = new StringValue { Value = value };
    else
      openXmlElement.GetLabel = null;
  }
  
  /// <summary>
  /// insertAfterMso
  /// </summary>
  private static String? GetInsertAfterMso(DXOCustUI.UnsizedDynamicMenu openXmlElement)
  {
    return openXmlElement?.InsertAfterMso?.Value;
  }
  
  private static bool CmpInsertAfterMso(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.InsertAfterMso?.Value == value;
  }
  
  private static void SetInsertAfterMso(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterMso = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterMso = null;
  }
  
  /// <summary>
  /// insertBeforeMso
  /// </summary>
  private static String? GetInsertBeforeMso(DXOCustUI.UnsizedDynamicMenu openXmlElement)
  {
    return openXmlElement?.InsertBeforeMso?.Value;
  }
  
  private static bool CmpInsertBeforeMso(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.InsertBeforeMso?.Value == value;
  }
  
  private static void SetInsertBeforeMso(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeMso = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeMso = null;
  }
  
  /// <summary>
  /// insertAfterQ
  /// </summary>
  private static String? GetInsertAfterQ(DXOCustUI.UnsizedDynamicMenu openXmlElement)
  {
    return openXmlElement?.InsertAfterQ?.Value;
  }
  
  private static bool CmpInsertAfterQ(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.InsertAfterQ?.Value == value;
  }
  
  private static void SetInsertAfterQ(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterQ = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterQ = null;
  }
  
  /// <summary>
  /// insertBeforeQ
  /// </summary>
  private static String? GetInsertBeforeQ(DXOCustUI.UnsizedDynamicMenu openXmlElement)
  {
    return openXmlElement?.InsertBeforeQ?.Value;
  }
  
  private static bool CmpInsertBeforeQ(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.InsertBeforeQ?.Value == value;
  }
  
  private static void SetInsertBeforeQ(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeQ = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeQ = null;
  }
  
  /// <summary>
  /// visible
  /// </summary>
  private static Boolean? GetVisible(DXOCustUI.UnsizedDynamicMenu openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static bool CmpVisible(DXOCustUI.UnsizedDynamicMenu openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Visible?.Value == value;
  }
  
  private static void SetVisible(DXOCustUI.UnsizedDynamicMenu openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible
  /// </summary>
  private static String? GetGetVisible(DXOCustUI.UnsizedDynamicMenu openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }
  
  private static bool CmpGetVisible(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetVisible?.Value == value;
  }
  
  private static void SetGetVisible(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetVisible = new StringValue { Value = value };
    else
      openXmlElement.GetVisible = null;
  }
  
  /// <summary>
  /// keytip
  /// </summary>
  private static String? GetKeytip(DXOCustUI.UnsizedDynamicMenu openXmlElement)
  {
    return openXmlElement?.Keytip?.Value;
  }
  
  private static bool CmpKeytip(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Keytip?.Value == value;
  }
  
  private static void SetKeytip(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Keytip = new StringValue { Value = value };
    else
      openXmlElement.Keytip = null;
  }
  
  /// <summary>
  /// getKeytip
  /// </summary>
  private static String? GetGetKeytip(DXOCustUI.UnsizedDynamicMenu openXmlElement)
  {
    return openXmlElement?.GetKeytip?.Value;
  }
  
  private static bool CmpGetKeytip(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetKeytip?.Value == value;
  }
  
  private static void SetGetKeytip(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetKeytip = new StringValue { Value = value };
    else
      openXmlElement.GetKeytip = null;
  }
  
  /// <summary>
  /// showLabel
  /// </summary>
  private static Boolean? GetShowLabel(DXOCustUI.UnsizedDynamicMenu openXmlElement)
  {
    return openXmlElement?.ShowLabel?.Value;
  }
  
  private static bool CmpShowLabel(DXOCustUI.UnsizedDynamicMenu openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ShowLabel?.Value == value;
  }
  
  private static void SetShowLabel(DXOCustUI.UnsizedDynamicMenu openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowLabel = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowLabel = null;
  }
  
  /// <summary>
  /// getShowLabel
  /// </summary>
  private static String? GetGetShowLabel(DXOCustUI.UnsizedDynamicMenu openXmlElement)
  {
    return openXmlElement?.GetShowLabel?.Value;
  }
  
  private static bool CmpGetShowLabel(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetShowLabel?.Value == value;
  }
  
  private static void SetGetShowLabel(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetShowLabel = new StringValue { Value = value };
    else
      openXmlElement.GetShowLabel = null;
  }
  
  /// <summary>
  /// showImage
  /// </summary>
  private static Boolean? GetShowImage(DXOCustUI.UnsizedDynamicMenu openXmlElement)
  {
    return openXmlElement?.ShowImage?.Value;
  }
  
  private static bool CmpShowImage(DXOCustUI.UnsizedDynamicMenu openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ShowImage?.Value == value;
  }
  
  private static void SetShowImage(DXOCustUI.UnsizedDynamicMenu openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowImage = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowImage = null;
  }
  
  /// <summary>
  /// getShowImage
  /// </summary>
  private static String? GetGetShowImage(DXOCustUI.UnsizedDynamicMenu openXmlElement)
  {
    return openXmlElement?.GetShowImage?.Value;
  }
  
  private static bool CmpGetShowImage(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetShowImage?.Value == value;
  }
  
  private static void SetGetShowImage(DXOCustUI.UnsizedDynamicMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetShowImage = new StringValue { Value = value };
    else
      openXmlElement.GetShowImage = null;
  }
  
  public static DMUI.UnsizedDynamicMenu? CreateModelElement(DXOCustUI.UnsizedDynamicMenu? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMUI.UnsizedDynamicMenu();
      value.Description = GetDescription(openXmlElement);
      value.GetDescription = GetGetDescription(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.IdQ = GetIdQ(openXmlElement);
      value.IdMso = GetIdMso(openXmlElement);
      value.Tag = GetTag(openXmlElement);
      value.GetContent = GetGetContent(openXmlElement);
      value.InvalidateContentOnDrop = GetInvalidateContentOnDrop(openXmlElement);
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
  
  public static bool CompareModelElement(DXOCustUI.UnsizedDynamicMenu? openXmlElement, DMUI.UnsizedDynamicMenu? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDescription(openXmlElement, value.Description, diffs, objName))
        ok = false;
      if (!CmpGetDescription(openXmlElement, value.GetDescription, diffs, objName))
        ok = false;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpIdQ(openXmlElement, value.IdQ, diffs, objName))
        ok = false;
      if (!CmpIdMso(openXmlElement, value.IdMso, diffs, objName))
        ok = false;
      if (!CmpTag(openXmlElement, value.Tag, diffs, objName))
        ok = false;
      if (!CmpGetContent(openXmlElement, value.GetContent, diffs, objName))
        ok = false;
      if (!CmpInvalidateContentOnDrop(openXmlElement, value.InvalidateContentOnDrop, diffs, objName))
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMUI.UnsizedDynamicMenu? value)
    where OpenXmlElementType: DXOCustUI.UnsizedDynamicMenu, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDescription(openXmlElement, value?.Description);
      SetGetDescription(openXmlElement, value?.GetDescription);
      SetId(openXmlElement, value?.Id);
      SetIdQ(openXmlElement, value?.IdQ);
      SetIdMso(openXmlElement, value?.IdMso);
      SetTag(openXmlElement, value?.Tag);
      SetGetContent(openXmlElement, value?.GetContent);
      SetInvalidateContentOnDrop(openXmlElement, value?.InvalidateContentOnDrop);
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
