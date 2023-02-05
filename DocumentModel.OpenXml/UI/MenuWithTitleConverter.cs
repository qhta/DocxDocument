namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the MenuWithTitle Class.
/// </summary>
public static class MenuWithTitleConverter
{
  /// <summary>
  /// id
  /// </summary>
  private static String? GetId(DXOCustUI.MenuWithTitle openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXOCustUI.MenuWithTitle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Id?.Value == value) return true;
    diffs?.Add(objName, "Id", openXmlElement?.Id?.Value, value);
    return false;
  }
  
  private static void SetId(DXOCustUI.MenuWithTitle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// idQ
  /// </summary>
  private static String? GetIdQ(DXOCustUI.MenuWithTitle openXmlElement)
  {
    return openXmlElement?.IdQ?.Value;
  }
  
  private static bool CmpIdQ(DXOCustUI.MenuWithTitle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.IdQ?.Value == value) return true;
    diffs?.Add(objName, "IdQ", openXmlElement?.IdQ?.Value, value);
    return false;
  }
  
  private static void SetIdQ(DXOCustUI.MenuWithTitle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.IdQ = new StringValue { Value = value };
    else
      openXmlElement.IdQ = null;
  }
  
  /// <summary>
  /// idMso
  /// </summary>
  private static String? GetIdMso(DXOCustUI.MenuWithTitle openXmlElement)
  {
    return openXmlElement?.IdMso?.Value;
  }
  
  private static bool CmpIdMso(DXOCustUI.MenuWithTitle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.IdMso?.Value == value) return true;
    diffs?.Add(objName, "IdMso", openXmlElement?.IdMso?.Value, value);
    return false;
  }
  
  private static void SetIdMso(DXOCustUI.MenuWithTitle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.IdMso = new StringValue { Value = value };
    else
      openXmlElement.IdMso = null;
  }
  
  /// <summary>
  /// tag
  /// </summary>
  private static String? GetTag(DXOCustUI.MenuWithTitle openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }
  
  private static bool CmpTag(DXOCustUI.MenuWithTitle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Tag?.Value == value) return true;
    diffs?.Add(objName, "Tag", openXmlElement?.Tag?.Value, value);
    return false;
  }
  
  private static void SetTag(DXOCustUI.MenuWithTitle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Tag = new StringValue { Value = value };
    else
      openXmlElement.Tag = null;
  }
  
  /// <summary>
  /// itemSize
  /// </summary>
  private static DMUI.ItemSizeKind? GetItemSize(DXOCustUI.MenuWithTitle openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues, DMUI.ItemSizeKind>(openXmlElement?.ItemSize?.Value);
  }
  
  private static bool CmpItemSize(DXOCustUI.MenuWithTitle openXmlElement, DMUI.ItemSizeKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues, DMUI.ItemSizeKind>(openXmlElement?.ItemSize?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetItemSize(DXOCustUI.MenuWithTitle openXmlElement, DMUI.ItemSizeKind? value)
  {
    openXmlElement.ItemSize = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues, DMUI.ItemSizeKind>(value);
  }
  
  /// <summary>
  /// title
  /// </summary>
  private static String? GetTitle(DXOCustUI.MenuWithTitle openXmlElement)
  {
    return openXmlElement?.Title?.Value;
  }
  
  private static bool CmpTitle(DXOCustUI.MenuWithTitle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Title?.Value == value) return true;
    diffs?.Add(objName, "Title", openXmlElement?.Title?.Value, value);
    return false;
  }
  
  private static void SetTitle(DXOCustUI.MenuWithTitle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Title = new StringValue { Value = value };
    else
      openXmlElement.Title = null;
  }
  
  /// <summary>
  /// getTitle
  /// </summary>
  private static String? GetGetTitle(DXOCustUI.MenuWithTitle openXmlElement)
  {
    return openXmlElement?.GetTitle?.Value;
  }
  
  private static bool CmpGetTitle(DXOCustUI.MenuWithTitle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetTitle?.Value == value) return true;
    diffs?.Add(objName, "GetTitle", openXmlElement?.GetTitle?.Value, value);
    return false;
  }
  
  private static void SetGetTitle(DXOCustUI.MenuWithTitle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetTitle = new StringValue { Value = value };
    else
      openXmlElement.GetTitle = null;
  }
  
  /// <summary>
  /// image
  /// </summary>
  private static String? GetImage(DXOCustUI.MenuWithTitle openXmlElement)
  {
    return openXmlElement?.Image?.Value;
  }
  
  private static bool CmpImage(DXOCustUI.MenuWithTitle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Image?.Value == value) return true;
    diffs?.Add(objName, "Image", openXmlElement?.Image?.Value, value);
    return false;
  }
  
  private static void SetImage(DXOCustUI.MenuWithTitle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Image = new StringValue { Value = value };
    else
      openXmlElement.Image = null;
  }
  
  /// <summary>
  /// imageMso
  /// </summary>
  private static String? GetImageMso(DXOCustUI.MenuWithTitle openXmlElement)
  {
    return openXmlElement?.ImageMso?.Value;
  }
  
  private static bool CmpImageMso(DXOCustUI.MenuWithTitle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ImageMso?.Value == value) return true;
    diffs?.Add(objName, "ImageMso", openXmlElement?.ImageMso?.Value, value);
    return false;
  }
  
  private static void SetImageMso(DXOCustUI.MenuWithTitle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ImageMso = new StringValue { Value = value };
    else
      openXmlElement.ImageMso = null;
  }
  
  /// <summary>
  /// getImage
  /// </summary>
  private static String? GetGetImage(DXOCustUI.MenuWithTitle openXmlElement)
  {
    return openXmlElement?.GetImage?.Value;
  }
  
  private static bool CmpGetImage(DXOCustUI.MenuWithTitle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetImage?.Value == value) return true;
    diffs?.Add(objName, "GetImage", openXmlElement?.GetImage?.Value, value);
    return false;
  }
  
  private static void SetGetImage(DXOCustUI.MenuWithTitle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetImage = new StringValue { Value = value };
    else
      openXmlElement.GetImage = null;
  }
  
  /// <summary>
  /// screentip
  /// </summary>
  private static String? GetScreentip(DXOCustUI.MenuWithTitle openXmlElement)
  {
    return openXmlElement?.Screentip?.Value;
  }
  
  private static bool CmpScreentip(DXOCustUI.MenuWithTitle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Screentip?.Value == value) return true;
    diffs?.Add(objName, "Screentip", openXmlElement?.Screentip?.Value, value);
    return false;
  }
  
  private static void SetScreentip(DXOCustUI.MenuWithTitle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Screentip = new StringValue { Value = value };
    else
      openXmlElement.Screentip = null;
  }
  
  /// <summary>
  /// getScreentip
  /// </summary>
  private static String? GetGetScreentip(DXOCustUI.MenuWithTitle openXmlElement)
  {
    return openXmlElement?.GetScreentip?.Value;
  }
  
  private static bool CmpGetScreentip(DXOCustUI.MenuWithTitle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetScreentip?.Value == value) return true;
    diffs?.Add(objName, "GetScreentip", openXmlElement?.GetScreentip?.Value, value);
    return false;
  }
  
  private static void SetGetScreentip(DXOCustUI.MenuWithTitle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetScreentip = new StringValue { Value = value };
    else
      openXmlElement.GetScreentip = null;
  }
  
  /// <summary>
  /// supertip
  /// </summary>
  private static String? GetSupertip(DXOCustUI.MenuWithTitle openXmlElement)
  {
    return openXmlElement?.Supertip?.Value;
  }
  
  private static bool CmpSupertip(DXOCustUI.MenuWithTitle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Supertip?.Value == value) return true;
    diffs?.Add(objName, "Supertip", openXmlElement?.Supertip?.Value, value);
    return false;
  }
  
  private static void SetSupertip(DXOCustUI.MenuWithTitle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Supertip = new StringValue { Value = value };
    else
      openXmlElement.Supertip = null;
  }
  
  /// <summary>
  /// getSupertip
  /// </summary>
  private static String? GetGetSupertip(DXOCustUI.MenuWithTitle openXmlElement)
  {
    return openXmlElement?.GetSupertip?.Value;
  }
  
  private static bool CmpGetSupertip(DXOCustUI.MenuWithTitle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetSupertip?.Value == value) return true;
    diffs?.Add(objName, "GetSupertip", openXmlElement?.GetSupertip?.Value, value);
    return false;
  }
  
  private static void SetGetSupertip(DXOCustUI.MenuWithTitle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetSupertip = new StringValue { Value = value };
    else
      openXmlElement.GetSupertip = null;
  }
  
  /// <summary>
  /// enabled
  /// </summary>
  private static Boolean? GetEnabled(DXOCustUI.MenuWithTitle openXmlElement)
  {
    return openXmlElement?.Enabled?.Value;
  }
  
  private static bool CmpEnabled(DXOCustUI.MenuWithTitle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Enabled?.Value == value) return true;
    diffs?.Add(objName, "Enabled", openXmlElement?.Enabled?.Value, value);
    return false;
  }
  
  private static void SetEnabled(DXOCustUI.MenuWithTitle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Enabled = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Enabled = null;
  }
  
  /// <summary>
  /// getEnabled
  /// </summary>
  private static String? GetGetEnabled(DXOCustUI.MenuWithTitle openXmlElement)
  {
    return openXmlElement?.GetEnabled?.Value;
  }
  
  private static bool CmpGetEnabled(DXOCustUI.MenuWithTitle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetEnabled?.Value == value) return true;
    diffs?.Add(objName, "GetEnabled", openXmlElement?.GetEnabled?.Value, value);
    return false;
  }
  
  private static void SetGetEnabled(DXOCustUI.MenuWithTitle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetEnabled = new StringValue { Value = value };
    else
      openXmlElement.GetEnabled = null;
  }
  
  /// <summary>
  /// label
  /// </summary>
  private static String? GetLabel(DXOCustUI.MenuWithTitle openXmlElement)
  {
    return openXmlElement?.Label?.Value;
  }
  
  private static bool CmpLabel(DXOCustUI.MenuWithTitle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Label?.Value == value) return true;
    diffs?.Add(objName, "Label", openXmlElement?.Label?.Value, value);
    return false;
  }
  
  private static void SetLabel(DXOCustUI.MenuWithTitle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Label = new StringValue { Value = value };
    else
      openXmlElement.Label = null;
  }
  
  /// <summary>
  /// getLabel
  /// </summary>
  private static String? GetGetLabel(DXOCustUI.MenuWithTitle openXmlElement)
  {
    return openXmlElement?.GetLabel?.Value;
  }
  
  private static bool CmpGetLabel(DXOCustUI.MenuWithTitle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetLabel?.Value == value) return true;
    diffs?.Add(objName, "GetLabel", openXmlElement?.GetLabel?.Value, value);
    return false;
  }
  
  private static void SetGetLabel(DXOCustUI.MenuWithTitle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetLabel = new StringValue { Value = value };
    else
      openXmlElement.GetLabel = null;
  }
  
  /// <summary>
  /// insertAfterMso
  /// </summary>
  private static String? GetInsertAfterMso(DXOCustUI.MenuWithTitle openXmlElement)
  {
    return openXmlElement?.InsertAfterMso?.Value;
  }
  
  private static bool CmpInsertAfterMso(DXOCustUI.MenuWithTitle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.InsertAfterMso?.Value == value) return true;
    diffs?.Add(objName, "InsertAfterMso", openXmlElement?.InsertAfterMso?.Value, value);
    return false;
  }
  
  private static void SetInsertAfterMso(DXOCustUI.MenuWithTitle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterMso = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterMso = null;
  }
  
  /// <summary>
  /// insertBeforeMso
  /// </summary>
  private static String? GetInsertBeforeMso(DXOCustUI.MenuWithTitle openXmlElement)
  {
    return openXmlElement?.InsertBeforeMso?.Value;
  }
  
  private static bool CmpInsertBeforeMso(DXOCustUI.MenuWithTitle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.InsertBeforeMso?.Value == value) return true;
    diffs?.Add(objName, "InsertBeforeMso", openXmlElement?.InsertBeforeMso?.Value, value);
    return false;
  }
  
  private static void SetInsertBeforeMso(DXOCustUI.MenuWithTitle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeMso = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeMso = null;
  }
  
  /// <summary>
  /// insertAfterQ
  /// </summary>
  private static String? GetInsertAfterQ(DXOCustUI.MenuWithTitle openXmlElement)
  {
    return openXmlElement?.InsertAfterQ?.Value;
  }
  
  private static bool CmpInsertAfterQ(DXOCustUI.MenuWithTitle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.InsertAfterQ?.Value == value) return true;
    diffs?.Add(objName, "InsertAfterQ", openXmlElement?.InsertAfterQ?.Value, value);
    return false;
  }
  
  private static void SetInsertAfterQ(DXOCustUI.MenuWithTitle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterQ = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterQ = null;
  }
  
  /// <summary>
  /// insertBeforeQ
  /// </summary>
  private static String? GetInsertBeforeQ(DXOCustUI.MenuWithTitle openXmlElement)
  {
    return openXmlElement?.InsertBeforeQ?.Value;
  }
  
  private static bool CmpInsertBeforeQ(DXOCustUI.MenuWithTitle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.InsertBeforeQ?.Value == value) return true;
    diffs?.Add(objName, "InsertBeforeQ", openXmlElement?.InsertBeforeQ?.Value, value);
    return false;
  }
  
  private static void SetInsertBeforeQ(DXOCustUI.MenuWithTitle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeQ = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeQ = null;
  }
  
  /// <summary>
  /// visible
  /// </summary>
  private static Boolean? GetVisible(DXOCustUI.MenuWithTitle openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static bool CmpVisible(DXOCustUI.MenuWithTitle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Visible?.Value == value) return true;
    diffs?.Add(objName, "Visible", openXmlElement?.Visible?.Value, value);
    return false;
  }
  
  private static void SetVisible(DXOCustUI.MenuWithTitle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible
  /// </summary>
  private static String? GetGetVisible(DXOCustUI.MenuWithTitle openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }
  
  private static bool CmpGetVisible(DXOCustUI.MenuWithTitle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetVisible?.Value == value) return true;
    diffs?.Add(objName, "GetVisible", openXmlElement?.GetVisible?.Value, value);
    return false;
  }
  
  private static void SetGetVisible(DXOCustUI.MenuWithTitle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetVisible = new StringValue { Value = value };
    else
      openXmlElement.GetVisible = null;
  }
  
  /// <summary>
  /// keytip
  /// </summary>
  private static String? GetKeytip(DXOCustUI.MenuWithTitle openXmlElement)
  {
    return openXmlElement?.Keytip?.Value;
  }
  
  private static bool CmpKeytip(DXOCustUI.MenuWithTitle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Keytip?.Value == value) return true;
    diffs?.Add(objName, "Keytip", openXmlElement?.Keytip?.Value, value);
    return false;
  }
  
  private static void SetKeytip(DXOCustUI.MenuWithTitle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Keytip = new StringValue { Value = value };
    else
      openXmlElement.Keytip = null;
  }
  
  /// <summary>
  /// getKeytip
  /// </summary>
  private static String? GetGetKeytip(DXOCustUI.MenuWithTitle openXmlElement)
  {
    return openXmlElement?.GetKeytip?.Value;
  }
  
  private static bool CmpGetKeytip(DXOCustUI.MenuWithTitle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetKeytip?.Value == value) return true;
    diffs?.Add(objName, "GetKeytip", openXmlElement?.GetKeytip?.Value, value);
    return false;
  }
  
  private static void SetGetKeytip(DXOCustUI.MenuWithTitle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetKeytip = new StringValue { Value = value };
    else
      openXmlElement.GetKeytip = null;
  }
  
  /// <summary>
  /// showLabel
  /// </summary>
  private static Boolean? GetShowLabel(DXOCustUI.MenuWithTitle openXmlElement)
  {
    return openXmlElement?.ShowLabel?.Value;
  }
  
  private static bool CmpShowLabel(DXOCustUI.MenuWithTitle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ShowLabel?.Value == value) return true;
    diffs?.Add(objName, "ShowLabel", openXmlElement?.ShowLabel?.Value, value);
    return false;
  }
  
  private static void SetShowLabel(DXOCustUI.MenuWithTitle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowLabel = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowLabel = null;
  }
  
  /// <summary>
  /// getShowLabel
  /// </summary>
  private static String? GetGetShowLabel(DXOCustUI.MenuWithTitle openXmlElement)
  {
    return openXmlElement?.GetShowLabel?.Value;
  }
  
  private static bool CmpGetShowLabel(DXOCustUI.MenuWithTitle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetShowLabel?.Value == value) return true;
    diffs?.Add(objName, "GetShowLabel", openXmlElement?.GetShowLabel?.Value, value);
    return false;
  }
  
  private static void SetGetShowLabel(DXOCustUI.MenuWithTitle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetShowLabel = new StringValue { Value = value };
    else
      openXmlElement.GetShowLabel = null;
  }
  
  /// <summary>
  /// showImage
  /// </summary>
  private static Boolean? GetShowImage(DXOCustUI.MenuWithTitle openXmlElement)
  {
    return openXmlElement?.ShowImage?.Value;
  }
  
  private static bool CmpShowImage(DXOCustUI.MenuWithTitle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ShowImage?.Value == value) return true;
    diffs?.Add(objName, "ShowImage", openXmlElement?.ShowImage?.Value, value);
    return false;
  }
  
  private static void SetShowImage(DXOCustUI.MenuWithTitle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowImage = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowImage = null;
  }
  
  /// <summary>
  /// getShowImage
  /// </summary>
  private static String? GetGetShowImage(DXOCustUI.MenuWithTitle openXmlElement)
  {
    return openXmlElement?.GetShowImage?.Value;
  }
  
  private static bool CmpGetShowImage(DXOCustUI.MenuWithTitle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetShowImage?.Value == value) return true;
    diffs?.Add(objName, "GetShowImage", openXmlElement?.GetShowImage?.Value, value);
    return false;
  }
  
  private static void SetGetShowImage(DXOCustUI.MenuWithTitle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetShowImage = new StringValue { Value = value };
    else
      openXmlElement.GetShowImage = null;
  }
  
  private static DMUI.UnsizedControlClone? GetUnsizedControlClone(DXOCustUI.MenuWithTitle openXmlElement)
  {
    return DMXUI.UnsizedControlCloneConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.UnsizedControlClone>());
  }
  
  private static bool CmpUnsizedControlClone(DXOCustUI.MenuWithTitle openXmlElement, DMUI.UnsizedControlClone? value, DiffList? diffs, string? objName)
  {
    return DMXUI.UnsizedControlCloneConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.UnsizedControlClone>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetUnsizedControlClone(DXOCustUI.MenuWithTitle openXmlElement, DMUI.UnsizedControlClone? value)
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
  
  private static DMUI.UnsizedButton? GetUnsizedButton(DXOCustUI.MenuWithTitle openXmlElement)
  {
    return DMXUI.UnsizedButtonConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.UnsizedButton>());
  }
  
  private static bool CmpUnsizedButton(DXOCustUI.MenuWithTitle openXmlElement, DMUI.UnsizedButton? value, DiffList? diffs, string? objName)
  {
    return DMXUI.UnsizedButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.UnsizedButton>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetUnsizedButton(DXOCustUI.MenuWithTitle openXmlElement, DMUI.UnsizedButton? value)
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
  
  private static DMUI.CheckBox? GetCheckBox(DXOCustUI.MenuWithTitle openXmlElement)
  {
    return DMXUI.CheckBoxConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.CheckBox>());
  }
  
  private static bool CmpCheckBox(DXOCustUI.MenuWithTitle openXmlElement, DMUI.CheckBox? value, DiffList? diffs, string? objName)
  {
    return DMXUI.CheckBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.CheckBox>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCheckBox(DXOCustUI.MenuWithTitle openXmlElement, DMUI.CheckBox? value)
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
  
  private static DMUI.UnsizedGallery? GetUnsizedGallery(DXOCustUI.MenuWithTitle openXmlElement)
  {
    return DMXUI.UnsizedGalleryConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.UnsizedGallery>());
  }
  
  private static bool CmpUnsizedGallery(DXOCustUI.MenuWithTitle openXmlElement, DMUI.UnsizedGallery? value, DiffList? diffs, string? objName)
  {
    return DMXUI.UnsizedGalleryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.UnsizedGallery>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetUnsizedGallery(DXOCustUI.MenuWithTitle openXmlElement, DMUI.UnsizedGallery? value)
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
  
  private static DMUI.UnsizedToggleButton? GetUnsizedToggleButton(DXOCustUI.MenuWithTitle openXmlElement)
  {
    return DMXUI.UnsizedToggleButtonConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.UnsizedToggleButton>());
  }
  
  private static bool CmpUnsizedToggleButton(DXOCustUI.MenuWithTitle openXmlElement, DMUI.UnsizedToggleButton? value, DiffList? diffs, string? objName)
  {
    return DMXUI.UnsizedToggleButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.UnsizedToggleButton>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetUnsizedToggleButton(DXOCustUI.MenuWithTitle openXmlElement, DMUI.UnsizedToggleButton? value)
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
  
  private static DMUI.MenuSeparator? GetMenuSeparator(DXOCustUI.MenuWithTitle openXmlElement)
  {
    return DMXUI.MenuSeparatorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.MenuSeparator>());
  }
  
  private static bool CmpMenuSeparator(DXOCustUI.MenuWithTitle openXmlElement, DMUI.MenuSeparator? value, DiffList? diffs, string? objName)
  {
    return DMXUI.MenuSeparatorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.MenuSeparator>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMenuSeparator(DXOCustUI.MenuWithTitle openXmlElement, DMUI.MenuSeparator? value)
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
  
  private static DMUI.SplitButtonWithTitle? GetSplitButtonWithTitle(DXOCustUI.MenuWithTitle openXmlElement)
  {
    return DMXUI.SplitButtonWithTitleConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.SplitButtonWithTitle>());
  }
  
  private static bool CmpSplitButtonWithTitle(DXOCustUI.MenuWithTitle openXmlElement, DMUI.SplitButtonWithTitle? value, DiffList? diffs, string? objName)
  {
    return DMXUI.SplitButtonWithTitleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.SplitButtonWithTitle>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSplitButtonWithTitle(DXOCustUI.MenuWithTitle openXmlElement, DMUI.SplitButtonWithTitle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.SplitButtonWithTitle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.SplitButtonWithTitleConverter.CreateOpenXmlElement<DXOCustUI.SplitButtonWithTitle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMUI.MenuWithTitle? GetChildMenuWithTitle(DXOCustUI.MenuWithTitle openXmlElement)
  {
    return DMXUI.MenuWithTitleConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.MenuWithTitle>());
  }
  
  private static bool CmpChildMenuWithTitle(DXOCustUI.MenuWithTitle openXmlElement, DMUI.MenuWithTitle? value, DiffList? diffs, string? objName)
  {
    return DMXUI.MenuWithTitleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.MenuWithTitle>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetChildMenuWithTitle(DXOCustUI.MenuWithTitle openXmlElement, DMUI.MenuWithTitle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.MenuWithTitle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.MenuWithTitleConverter.CreateOpenXmlElement<DXOCustUI.MenuWithTitle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMUI.UnsizedDynamicMenu? GetUnsizedDynamicMenu(DXOCustUI.MenuWithTitle openXmlElement)
  {
    return DMXUI.UnsizedDynamicMenuConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.UnsizedDynamicMenu>());
  }
  
  private static bool CmpUnsizedDynamicMenu(DXOCustUI.MenuWithTitle openXmlElement, DMUI.UnsizedDynamicMenu? value, DiffList? diffs, string? objName)
  {
    return DMXUI.UnsizedDynamicMenuConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.UnsizedDynamicMenu>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetUnsizedDynamicMenu(DXOCustUI.MenuWithTitle openXmlElement, DMUI.UnsizedDynamicMenu? value)
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
  
  public static DMUI.MenuWithTitle? CreateModelElement(DXOCustUI.MenuWithTitle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMUI.MenuWithTitle();
      value.Id = GetId(openXmlElement);
      value.IdQ = GetIdQ(openXmlElement);
      value.IdMso = GetIdMso(openXmlElement);
      value.Tag = GetTag(openXmlElement);
      value.ItemSize = GetItemSize(openXmlElement);
      value.Title = GetTitle(openXmlElement);
      value.GetTitle = GetGetTitle(openXmlElement);
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
      value.SplitButtonWithTitle = GetSplitButtonWithTitle(openXmlElement);
      value.ChildMenuWithTitle = GetChildMenuWithTitle(openXmlElement);
      value.UnsizedDynamicMenu = GetUnsizedDynamicMenu(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOCustUI.MenuWithTitle? openXmlElement, DMUI.MenuWithTitle? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpIdQ(openXmlElement, value.IdQ, diffs, objName))
        ok = false;
      if (!CmpIdMso(openXmlElement, value.IdMso, diffs, objName))
        ok = false;
      if (!CmpTag(openXmlElement, value.Tag, diffs, objName))
        ok = false;
      if (!CmpItemSize(openXmlElement, value.ItemSize, diffs, objName))
        ok = false;
      if (!CmpTitle(openXmlElement, value.Title, diffs, objName))
        ok = false;
      if (!CmpGetTitle(openXmlElement, value.GetTitle, diffs, objName))
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
      if (!CmpSplitButtonWithTitle(openXmlElement, value.SplitButtonWithTitle, diffs, objName))
        ok = false;
      if (!CmpChildMenuWithTitle(openXmlElement, value.ChildMenuWithTitle, diffs, objName))
        ok = false;
      if (!CmpUnsizedDynamicMenu(openXmlElement, value.UnsizedDynamicMenu, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMUI.MenuWithTitle? value)
    where OpenXmlElementType: DXOCustUI.MenuWithTitle, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetIdQ(openXmlElement, value?.IdQ);
      SetIdMso(openXmlElement, value?.IdMso);
      SetTag(openXmlElement, value?.Tag);
      SetItemSize(openXmlElement, value?.ItemSize);
      SetTitle(openXmlElement, value?.Title);
      SetGetTitle(openXmlElement, value?.GetTitle);
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
      SetSplitButtonWithTitle(openXmlElement, value?.SplitButtonWithTitle);
      SetChildMenuWithTitle(openXmlElement, value?.ChildMenuWithTitle);
      SetUnsizedDynamicMenu(openXmlElement, value?.UnsizedDynamicMenu);
      return openXmlElement;
    }
    return default;
  }
}
