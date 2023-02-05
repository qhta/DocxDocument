namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the UnsizedMenu Class.
/// </summary>
public static class UnsizedMenuConverter
{
  /// <summary>
  /// itemSize
  /// </summary>
  private static DMUI.ItemSizeKind? GetItemSize(DXOCustUI.UnsizedMenu openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues, DMUI.ItemSizeKind>(openXmlElement?.ItemSize?.Value);
  }
  
  private static bool CmpItemSize(DXOCustUI.UnsizedMenu openXmlElement, DMUI.ItemSizeKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues, DMUI.ItemSizeKind>(openXmlElement?.ItemSize?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetItemSize(DXOCustUI.UnsizedMenu openXmlElement, DMUI.ItemSizeKind? value)
  {
    openXmlElement.ItemSize = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues, DMUI.ItemSizeKind>(value);
  }
  
  /// <summary>
  /// description
  /// </summary>
  private static String? GetDescription(DXOCustUI.UnsizedMenu openXmlElement)
  {
    return openXmlElement?.Description?.Value;
  }
  
  private static bool CmpDescription(DXOCustUI.UnsizedMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Description?.Value == value) return true;
    diffs?.Add(objName, "Description", openXmlElement?.Description?.Value, value);
    return false;
  }
  
  private static void SetDescription(DXOCustUI.UnsizedMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Description = new StringValue { Value = value };
    else
      openXmlElement.Description = null;
  }
  
  /// <summary>
  /// getDescription
  /// </summary>
  private static String? GetGetDescription(DXOCustUI.UnsizedMenu openXmlElement)
  {
    return openXmlElement?.GetDescription?.Value;
  }
  
  private static bool CmpGetDescription(DXOCustUI.UnsizedMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetDescription?.Value == value) return true;
    diffs?.Add(objName, "GetDescription", openXmlElement?.GetDescription?.Value, value);
    return false;
  }
  
  private static void SetGetDescription(DXOCustUI.UnsizedMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetDescription = new StringValue { Value = value };
    else
      openXmlElement.GetDescription = null;
  }
  
  /// <summary>
  /// id
  /// </summary>
  private static String? GetId(DXOCustUI.UnsizedMenu openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXOCustUI.UnsizedMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Id?.Value == value) return true;
    diffs?.Add(objName, "Id", openXmlElement?.Id?.Value, value);
    return false;
  }
  
  private static void SetId(DXOCustUI.UnsizedMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// idQ
  /// </summary>
  private static String? GetIdQ(DXOCustUI.UnsizedMenu openXmlElement)
  {
    return openXmlElement?.IdQ?.Value;
  }
  
  private static bool CmpIdQ(DXOCustUI.UnsizedMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.IdQ?.Value == value) return true;
    diffs?.Add(objName, "IdQ", openXmlElement?.IdQ?.Value, value);
    return false;
  }
  
  private static void SetIdQ(DXOCustUI.UnsizedMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.IdQ = new StringValue { Value = value };
    else
      openXmlElement.IdQ = null;
  }
  
  /// <summary>
  /// idMso
  /// </summary>
  private static String? GetIdMso(DXOCustUI.UnsizedMenu openXmlElement)
  {
    return openXmlElement?.IdMso?.Value;
  }
  
  private static bool CmpIdMso(DXOCustUI.UnsizedMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.IdMso?.Value == value) return true;
    diffs?.Add(objName, "IdMso", openXmlElement?.IdMso?.Value, value);
    return false;
  }
  
  private static void SetIdMso(DXOCustUI.UnsizedMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.IdMso = new StringValue { Value = value };
    else
      openXmlElement.IdMso = null;
  }
  
  /// <summary>
  /// tag
  /// </summary>
  private static String? GetTag(DXOCustUI.UnsizedMenu openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }
  
  private static bool CmpTag(DXOCustUI.UnsizedMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Tag?.Value == value) return true;
    diffs?.Add(objName, "Tag", openXmlElement?.Tag?.Value, value);
    return false;
  }
  
  private static void SetTag(DXOCustUI.UnsizedMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Tag = new StringValue { Value = value };
    else
      openXmlElement.Tag = null;
  }
  
  /// <summary>
  /// image
  /// </summary>
  private static String? GetImage(DXOCustUI.UnsizedMenu openXmlElement)
  {
    return openXmlElement?.Image?.Value;
  }
  
  private static bool CmpImage(DXOCustUI.UnsizedMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Image?.Value == value) return true;
    diffs?.Add(objName, "Image", openXmlElement?.Image?.Value, value);
    return false;
  }
  
  private static void SetImage(DXOCustUI.UnsizedMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Image = new StringValue { Value = value };
    else
      openXmlElement.Image = null;
  }
  
  /// <summary>
  /// imageMso
  /// </summary>
  private static String? GetImageMso(DXOCustUI.UnsizedMenu openXmlElement)
  {
    return openXmlElement?.ImageMso?.Value;
  }
  
  private static bool CmpImageMso(DXOCustUI.UnsizedMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ImageMso?.Value == value) return true;
    diffs?.Add(objName, "ImageMso", openXmlElement?.ImageMso?.Value, value);
    return false;
  }
  
  private static void SetImageMso(DXOCustUI.UnsizedMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ImageMso = new StringValue { Value = value };
    else
      openXmlElement.ImageMso = null;
  }
  
  /// <summary>
  /// getImage
  /// </summary>
  private static String? GetGetImage(DXOCustUI.UnsizedMenu openXmlElement)
  {
    return openXmlElement?.GetImage?.Value;
  }
  
  private static bool CmpGetImage(DXOCustUI.UnsizedMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetImage?.Value == value) return true;
    diffs?.Add(objName, "GetImage", openXmlElement?.GetImage?.Value, value);
    return false;
  }
  
  private static void SetGetImage(DXOCustUI.UnsizedMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetImage = new StringValue { Value = value };
    else
      openXmlElement.GetImage = null;
  }
  
  /// <summary>
  /// screentip
  /// </summary>
  private static String? GetScreentip(DXOCustUI.UnsizedMenu openXmlElement)
  {
    return openXmlElement?.Screentip?.Value;
  }
  
  private static bool CmpScreentip(DXOCustUI.UnsizedMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Screentip?.Value == value) return true;
    diffs?.Add(objName, "Screentip", openXmlElement?.Screentip?.Value, value);
    return false;
  }
  
  private static void SetScreentip(DXOCustUI.UnsizedMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Screentip = new StringValue { Value = value };
    else
      openXmlElement.Screentip = null;
  }
  
  /// <summary>
  /// getScreentip
  /// </summary>
  private static String? GetGetScreentip(DXOCustUI.UnsizedMenu openXmlElement)
  {
    return openXmlElement?.GetScreentip?.Value;
  }
  
  private static bool CmpGetScreentip(DXOCustUI.UnsizedMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetScreentip?.Value == value) return true;
    diffs?.Add(objName, "GetScreentip", openXmlElement?.GetScreentip?.Value, value);
    return false;
  }
  
  private static void SetGetScreentip(DXOCustUI.UnsizedMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetScreentip = new StringValue { Value = value };
    else
      openXmlElement.GetScreentip = null;
  }
  
  /// <summary>
  /// supertip
  /// </summary>
  private static String? GetSupertip(DXOCustUI.UnsizedMenu openXmlElement)
  {
    return openXmlElement?.Supertip?.Value;
  }
  
  private static bool CmpSupertip(DXOCustUI.UnsizedMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Supertip?.Value == value) return true;
    diffs?.Add(objName, "Supertip", openXmlElement?.Supertip?.Value, value);
    return false;
  }
  
  private static void SetSupertip(DXOCustUI.UnsizedMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Supertip = new StringValue { Value = value };
    else
      openXmlElement.Supertip = null;
  }
  
  /// <summary>
  /// getSupertip
  /// </summary>
  private static String? GetGetSupertip(DXOCustUI.UnsizedMenu openXmlElement)
  {
    return openXmlElement?.GetSupertip?.Value;
  }
  
  private static bool CmpGetSupertip(DXOCustUI.UnsizedMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetSupertip?.Value == value) return true;
    diffs?.Add(objName, "GetSupertip", openXmlElement?.GetSupertip?.Value, value);
    return false;
  }
  
  private static void SetGetSupertip(DXOCustUI.UnsizedMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetSupertip = new StringValue { Value = value };
    else
      openXmlElement.GetSupertip = null;
  }
  
  /// <summary>
  /// enabled
  /// </summary>
  private static Boolean? GetEnabled(DXOCustUI.UnsizedMenu openXmlElement)
  {
    return openXmlElement?.Enabled?.Value;
  }
  
  private static bool CmpEnabled(DXOCustUI.UnsizedMenu openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Enabled?.Value == value) return true;
    diffs?.Add(objName, "Enabled", openXmlElement?.Enabled?.Value, value);
    return false;
  }
  
  private static void SetEnabled(DXOCustUI.UnsizedMenu openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Enabled = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Enabled = null;
  }
  
  /// <summary>
  /// getEnabled
  /// </summary>
  private static String? GetGetEnabled(DXOCustUI.UnsizedMenu openXmlElement)
  {
    return openXmlElement?.GetEnabled?.Value;
  }
  
  private static bool CmpGetEnabled(DXOCustUI.UnsizedMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetEnabled?.Value == value) return true;
    diffs?.Add(objName, "GetEnabled", openXmlElement?.GetEnabled?.Value, value);
    return false;
  }
  
  private static void SetGetEnabled(DXOCustUI.UnsizedMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetEnabled = new StringValue { Value = value };
    else
      openXmlElement.GetEnabled = null;
  }
  
  /// <summary>
  /// label
  /// </summary>
  private static String? GetLabel(DXOCustUI.UnsizedMenu openXmlElement)
  {
    return openXmlElement?.Label?.Value;
  }
  
  private static bool CmpLabel(DXOCustUI.UnsizedMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Label?.Value == value) return true;
    diffs?.Add(objName, "Label", openXmlElement?.Label?.Value, value);
    return false;
  }
  
  private static void SetLabel(DXOCustUI.UnsizedMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Label = new StringValue { Value = value };
    else
      openXmlElement.Label = null;
  }
  
  /// <summary>
  /// getLabel
  /// </summary>
  private static String? GetGetLabel(DXOCustUI.UnsizedMenu openXmlElement)
  {
    return openXmlElement?.GetLabel?.Value;
  }
  
  private static bool CmpGetLabel(DXOCustUI.UnsizedMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetLabel?.Value == value) return true;
    diffs?.Add(objName, "GetLabel", openXmlElement?.GetLabel?.Value, value);
    return false;
  }
  
  private static void SetGetLabel(DXOCustUI.UnsizedMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetLabel = new StringValue { Value = value };
    else
      openXmlElement.GetLabel = null;
  }
  
  /// <summary>
  /// insertAfterMso
  /// </summary>
  private static String? GetInsertAfterMso(DXOCustUI.UnsizedMenu openXmlElement)
  {
    return openXmlElement?.InsertAfterMso?.Value;
  }
  
  private static bool CmpInsertAfterMso(DXOCustUI.UnsizedMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.InsertAfterMso?.Value == value) return true;
    diffs?.Add(objName, "InsertAfterMso", openXmlElement?.InsertAfterMso?.Value, value);
    return false;
  }
  
  private static void SetInsertAfterMso(DXOCustUI.UnsizedMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterMso = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterMso = null;
  }
  
  /// <summary>
  /// insertBeforeMso
  /// </summary>
  private static String? GetInsertBeforeMso(DXOCustUI.UnsizedMenu openXmlElement)
  {
    return openXmlElement?.InsertBeforeMso?.Value;
  }
  
  private static bool CmpInsertBeforeMso(DXOCustUI.UnsizedMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.InsertBeforeMso?.Value == value) return true;
    diffs?.Add(objName, "InsertBeforeMso", openXmlElement?.InsertBeforeMso?.Value, value);
    return false;
  }
  
  private static void SetInsertBeforeMso(DXOCustUI.UnsizedMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeMso = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeMso = null;
  }
  
  /// <summary>
  /// insertAfterQ
  /// </summary>
  private static String? GetInsertAfterQ(DXOCustUI.UnsizedMenu openXmlElement)
  {
    return openXmlElement?.InsertAfterQ?.Value;
  }
  
  private static bool CmpInsertAfterQ(DXOCustUI.UnsizedMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.InsertAfterQ?.Value == value) return true;
    diffs?.Add(objName, "InsertAfterQ", openXmlElement?.InsertAfterQ?.Value, value);
    return false;
  }
  
  private static void SetInsertAfterQ(DXOCustUI.UnsizedMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterQ = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterQ = null;
  }
  
  /// <summary>
  /// insertBeforeQ
  /// </summary>
  private static String? GetInsertBeforeQ(DXOCustUI.UnsizedMenu openXmlElement)
  {
    return openXmlElement?.InsertBeforeQ?.Value;
  }
  
  private static bool CmpInsertBeforeQ(DXOCustUI.UnsizedMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.InsertBeforeQ?.Value == value) return true;
    diffs?.Add(objName, "InsertBeforeQ", openXmlElement?.InsertBeforeQ?.Value, value);
    return false;
  }
  
  private static void SetInsertBeforeQ(DXOCustUI.UnsizedMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeQ = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeQ = null;
  }
  
  /// <summary>
  /// visible
  /// </summary>
  private static Boolean? GetVisible(DXOCustUI.UnsizedMenu openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static bool CmpVisible(DXOCustUI.UnsizedMenu openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Visible?.Value == value) return true;
    diffs?.Add(objName, "Visible", openXmlElement?.Visible?.Value, value);
    return false;
  }
  
  private static void SetVisible(DXOCustUI.UnsizedMenu openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible
  /// </summary>
  private static String? GetGetVisible(DXOCustUI.UnsizedMenu openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }
  
  private static bool CmpGetVisible(DXOCustUI.UnsizedMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetVisible?.Value == value) return true;
    diffs?.Add(objName, "GetVisible", openXmlElement?.GetVisible?.Value, value);
    return false;
  }
  
  private static void SetGetVisible(DXOCustUI.UnsizedMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetVisible = new StringValue { Value = value };
    else
      openXmlElement.GetVisible = null;
  }
  
  /// <summary>
  /// keytip
  /// </summary>
  private static String? GetKeytip(DXOCustUI.UnsizedMenu openXmlElement)
  {
    return openXmlElement?.Keytip?.Value;
  }
  
  private static bool CmpKeytip(DXOCustUI.UnsizedMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Keytip?.Value == value) return true;
    diffs?.Add(objName, "Keytip", openXmlElement?.Keytip?.Value, value);
    return false;
  }
  
  private static void SetKeytip(DXOCustUI.UnsizedMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Keytip = new StringValue { Value = value };
    else
      openXmlElement.Keytip = null;
  }
  
  /// <summary>
  /// getKeytip
  /// </summary>
  private static String? GetGetKeytip(DXOCustUI.UnsizedMenu openXmlElement)
  {
    return openXmlElement?.GetKeytip?.Value;
  }
  
  private static bool CmpGetKeytip(DXOCustUI.UnsizedMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetKeytip?.Value == value) return true;
    diffs?.Add(objName, "GetKeytip", openXmlElement?.GetKeytip?.Value, value);
    return false;
  }
  
  private static void SetGetKeytip(DXOCustUI.UnsizedMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetKeytip = new StringValue { Value = value };
    else
      openXmlElement.GetKeytip = null;
  }
  
  /// <summary>
  /// showLabel
  /// </summary>
  private static Boolean? GetShowLabel(DXOCustUI.UnsizedMenu openXmlElement)
  {
    return openXmlElement?.ShowLabel?.Value;
  }
  
  private static bool CmpShowLabel(DXOCustUI.UnsizedMenu openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ShowLabel?.Value == value) return true;
    diffs?.Add(objName, "ShowLabel", openXmlElement?.ShowLabel?.Value, value);
    return false;
  }
  
  private static void SetShowLabel(DXOCustUI.UnsizedMenu openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowLabel = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowLabel = null;
  }
  
  /// <summary>
  /// getShowLabel
  /// </summary>
  private static String? GetGetShowLabel(DXOCustUI.UnsizedMenu openXmlElement)
  {
    return openXmlElement?.GetShowLabel?.Value;
  }
  
  private static bool CmpGetShowLabel(DXOCustUI.UnsizedMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetShowLabel?.Value == value) return true;
    diffs?.Add(objName, "GetShowLabel", openXmlElement?.GetShowLabel?.Value, value);
    return false;
  }
  
  private static void SetGetShowLabel(DXOCustUI.UnsizedMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetShowLabel = new StringValue { Value = value };
    else
      openXmlElement.GetShowLabel = null;
  }
  
  /// <summary>
  /// showImage
  /// </summary>
  private static Boolean? GetShowImage(DXOCustUI.UnsizedMenu openXmlElement)
  {
    return openXmlElement?.ShowImage?.Value;
  }
  
  private static bool CmpShowImage(DXOCustUI.UnsizedMenu openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ShowImage?.Value == value) return true;
    diffs?.Add(objName, "ShowImage", openXmlElement?.ShowImage?.Value, value);
    return false;
  }
  
  private static void SetShowImage(DXOCustUI.UnsizedMenu openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowImage = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowImage = null;
  }
  
  /// <summary>
  /// getShowImage
  /// </summary>
  private static String? GetGetShowImage(DXOCustUI.UnsizedMenu openXmlElement)
  {
    return openXmlElement?.GetShowImage?.Value;
  }
  
  private static bool CmpGetShowImage(DXOCustUI.UnsizedMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetShowImage?.Value == value) return true;
    diffs?.Add(objName, "GetShowImage", openXmlElement?.GetShowImage?.Value, value);
    return false;
  }
  
  private static void SetGetShowImage(DXOCustUI.UnsizedMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetShowImage = new StringValue { Value = value };
    else
      openXmlElement.GetShowImage = null;
  }
  
  private static DMUI.UnsizedControlClone? GetUnsizedControlClone(DXOCustUI.UnsizedMenu openXmlElement)
  {
    return DMXUI.UnsizedControlCloneConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.UnsizedControlClone>());
  }
  
  private static bool CmpUnsizedControlClone(DXOCustUI.UnsizedMenu openXmlElement, DMUI.UnsizedControlClone? value, DiffList? diffs, string? objName)
  {
    return DMXUI.UnsizedControlCloneConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.UnsizedControlClone>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetUnsizedControlClone(DXOCustUI.UnsizedMenu openXmlElement, DMUI.UnsizedControlClone? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.UnsizedControlClone>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.UnsizedControlCloneConverter.CreateOpenXmlElement<DXOCustUI.UnsizedControlClone>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMUI.UnsizedButton? GetUnsizedButton(DXOCustUI.UnsizedMenu openXmlElement)
  {
    return DMXUI.UnsizedButtonConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.UnsizedButton>());
  }
  
  private static bool CmpUnsizedButton(DXOCustUI.UnsizedMenu openXmlElement, DMUI.UnsizedButton? value, DiffList? diffs, string? objName)
  {
    return DMXUI.UnsizedButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.UnsizedButton>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetUnsizedButton(DXOCustUI.UnsizedMenu openXmlElement, DMUI.UnsizedButton? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.UnsizedButton>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.UnsizedButtonConverter.CreateOpenXmlElement<DXOCustUI.UnsizedButton>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMUI.CheckBox? GetCheckBox(DXOCustUI.UnsizedMenu openXmlElement)
  {
    return DMXUI.CheckBoxConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.CheckBox>());
  }
  
  private static bool CmpCheckBox(DXOCustUI.UnsizedMenu openXmlElement, DMUI.CheckBox? value, DiffList? diffs, string? objName)
  {
    return DMXUI.CheckBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.CheckBox>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCheckBox(DXOCustUI.UnsizedMenu openXmlElement, DMUI.CheckBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.CheckBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.CheckBoxConverter.CreateOpenXmlElement<DXOCustUI.CheckBox>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMUI.UnsizedGallery? GetUnsizedGallery(DXOCustUI.UnsizedMenu openXmlElement)
  {
    return DMXUI.UnsizedGalleryConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.UnsizedGallery>());
  }
  
  private static bool CmpUnsizedGallery(DXOCustUI.UnsizedMenu openXmlElement, DMUI.UnsizedGallery? value, DiffList? diffs, string? objName)
  {
    return DMXUI.UnsizedGalleryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.UnsizedGallery>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetUnsizedGallery(DXOCustUI.UnsizedMenu openXmlElement, DMUI.UnsizedGallery? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.UnsizedGallery>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.UnsizedGalleryConverter.CreateOpenXmlElement<DXOCustUI.UnsizedGallery>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMUI.UnsizedToggleButton? GetUnsizedToggleButton(DXOCustUI.UnsizedMenu openXmlElement)
  {
    return DMXUI.UnsizedToggleButtonConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.UnsizedToggleButton>());
  }
  
  private static bool CmpUnsizedToggleButton(DXOCustUI.UnsizedMenu openXmlElement, DMUI.UnsizedToggleButton? value, DiffList? diffs, string? objName)
  {
    return DMXUI.UnsizedToggleButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.UnsizedToggleButton>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetUnsizedToggleButton(DXOCustUI.UnsizedMenu openXmlElement, DMUI.UnsizedToggleButton? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.UnsizedToggleButton>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.UnsizedToggleButtonConverter.CreateOpenXmlElement<DXOCustUI.UnsizedToggleButton>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMUI.MenuSeparator? GetMenuSeparator(DXOCustUI.UnsizedMenu openXmlElement)
  {
    return DMXUI.MenuSeparatorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.MenuSeparator>());
  }
  
  private static bool CmpMenuSeparator(DXOCustUI.UnsizedMenu openXmlElement, DMUI.MenuSeparator? value, DiffList? diffs, string? objName)
  {
    return DMXUI.MenuSeparatorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.MenuSeparator>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMenuSeparator(DXOCustUI.UnsizedMenu openXmlElement, DMUI.MenuSeparator? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.MenuSeparator>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.MenuSeparatorConverter.CreateOpenXmlElement<DXOCustUI.MenuSeparator>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMUI.UnsizedSplitButton? GetUnsizedSplitButton(DXOCustUI.UnsizedMenu openXmlElement)
  {
    return DMXUI.UnsizedSplitButtonConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.UnsizedSplitButton>());
  }
  
  private static bool CmpUnsizedSplitButton(DXOCustUI.UnsizedMenu openXmlElement, DMUI.UnsizedSplitButton? value, DiffList? diffs, string? objName)
  {
    return DMXUI.UnsizedSplitButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.UnsizedSplitButton>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetUnsizedSplitButton(DXOCustUI.UnsizedMenu openXmlElement, DMUI.UnsizedSplitButton? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.UnsizedSplitButton>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.UnsizedSplitButtonConverter.CreateOpenXmlElement<DXOCustUI.UnsizedSplitButton>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMUI.UnsizedMenu? GetChildUnsizedMenu(DXOCustUI.UnsizedMenu openXmlElement)
  {
    return DMXUI.UnsizedMenuConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.UnsizedMenu>());
  }
  
  private static bool CmpChildUnsizedMenu(DXOCustUI.UnsizedMenu openXmlElement, DMUI.UnsizedMenu? value, DiffList? diffs, string? objName)
  {
    return DMXUI.UnsizedMenuConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.UnsizedMenu>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetChildUnsizedMenu(DXOCustUI.UnsizedMenu openXmlElement, DMUI.UnsizedMenu? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.UnsizedMenu>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.UnsizedMenuConverter.CreateOpenXmlElement<DXOCustUI.UnsizedMenu>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMUI.UnsizedDynamicMenu? GetUnsizedDynamicMenu(DXOCustUI.UnsizedMenu openXmlElement)
  {
    return DMXUI.UnsizedDynamicMenuConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.UnsizedDynamicMenu>());
  }
  
  private static bool CmpUnsizedDynamicMenu(DXOCustUI.UnsizedMenu openXmlElement, DMUI.UnsizedDynamicMenu? value, DiffList? diffs, string? objName)
  {
    return DMXUI.UnsizedDynamicMenuConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.UnsizedDynamicMenu>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetUnsizedDynamicMenu(DXOCustUI.UnsizedMenu openXmlElement, DMUI.UnsizedDynamicMenu? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.UnsizedDynamicMenu>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.UnsizedDynamicMenuConverter.CreateOpenXmlElement<DXOCustUI.UnsizedDynamicMenu>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMUI.UnsizedMenu? CreateModelElement(DXOCustUI.UnsizedMenu? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMUI.UnsizedMenu();
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
  
  public static bool CompareModelElement(DXOCustUI.UnsizedMenu? openXmlElement, DMUI.UnsizedMenu? value, DiffList? diffs, string? objName)
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
      if (!CmpUnsizedControlClone(openXmlElement, value.UnsizedControlClone, diffs, objName))
        ok = false;
      if (!CmpUnsizedButton(openXmlElement, value.UnsizedButton, diffs, objName))
        ok = false;
      if (!CmpCheckBox(openXmlElement, value.CheckBox, diffs, objName))
        ok = false;
      if (!CmpUnsizedGallery(openXmlElement, value.UnsizedGallery, diffs, objName))
        ok = false;
      if (!CmpUnsizedToggleButton(openXmlElement, value.UnsizedToggleButton, diffs, objName))
        ok = false;
      if (!CmpMenuSeparator(openXmlElement, value.MenuSeparator, diffs, objName))
        ok = false;
      if (!CmpUnsizedSplitButton(openXmlElement, value.UnsizedSplitButton, diffs, objName))
        ok = false;
      if (!CmpChildUnsizedMenu(openXmlElement, value.ChildUnsizedMenu, diffs, objName))
        ok = false;
      if (!CmpUnsizedDynamicMenu(openXmlElement, value.UnsizedDynamicMenu, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMUI.UnsizedMenu? value)
    where OpenXmlElementType: DXOCustUI.UnsizedMenu, new()
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
