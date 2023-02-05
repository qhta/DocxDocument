namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the Hyperlink Class.
/// </summary>
public static class HyperlinkConverter
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetId(DXO2010CustUI.Hyperlink openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXO2010CustUI.Hyperlink openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Id?.Value == value) return true;
    diffs?.Add(objName, "Id", openXmlElement?.Id?.Value, value);
    return false;
  }
  
  private static void SetId(DXO2010CustUI.Hyperlink openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetQualifiedId(DXO2010CustUI.Hyperlink openXmlElement)
  {
    return openXmlElement?.QualifiedId?.Value;
  }
  
  private static bool CmpQualifiedId(DXO2010CustUI.Hyperlink openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.QualifiedId?.Value == value) return true;
    diffs?.Add(objName, "QualifiedId", openXmlElement?.QualifiedId?.Value, value);
    return false;
  }
  
  private static void SetQualifiedId(DXO2010CustUI.Hyperlink openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.QualifiedId = new StringValue { Value = value };
    else
      openXmlElement.QualifiedId = null;
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetTag(DXO2010CustUI.Hyperlink openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }
  
  private static bool CmpTag(DXO2010CustUI.Hyperlink openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Tag?.Value == value) return true;
    diffs?.Add(objName, "Tag", openXmlElement?.Tag?.Value, value);
    return false;
  }
  
  private static void SetTag(DXO2010CustUI.Hyperlink openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Tag = new StringValue { Value = value };
    else
      openXmlElement.Tag = null;
  }
  
  /// <summary>
  /// alignLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static DM.ExpandKind? GetAlignLabel(DXO2010CustUI.Hyperlink openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DM.ExpandKind>(openXmlElement?.AlignLabel?.Value);
  }
  
  private static bool CmpAlignLabel(DXO2010CustUI.Hyperlink openXmlElement, DM.ExpandKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DM.ExpandKind>(openXmlElement?.AlignLabel?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetAlignLabel(DXO2010CustUI.Hyperlink openXmlElement, DM.ExpandKind? value)
  {
    openXmlElement.AlignLabel = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DM.ExpandKind>(value);
  }
  
  /// <summary>
  /// expand, this property is only available in Office 2010 and later.
  /// </summary>
  private static DM.ExpandKind? GetExpand(DXO2010CustUI.Hyperlink openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DM.ExpandKind>(openXmlElement?.Expand?.Value);
  }
  
  private static bool CmpExpand(DXO2010CustUI.Hyperlink openXmlElement, DM.ExpandKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DM.ExpandKind>(openXmlElement?.Expand?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExpand(DXO2010CustUI.Hyperlink openXmlElement, DM.ExpandKind? value)
  {
    openXmlElement.Expand = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DM.ExpandKind>(value);
  }
  
  /// <summary>
  /// enabled, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetEnabled(DXO2010CustUI.Hyperlink openXmlElement)
  {
    return openXmlElement?.Enabled?.Value;
  }
  
  private static bool CmpEnabled(DXO2010CustUI.Hyperlink openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Enabled?.Value == value) return true;
    diffs?.Add(objName, "Enabled", openXmlElement?.Enabled?.Value, value);
    return false;
  }
  
  private static void SetEnabled(DXO2010CustUI.Hyperlink openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Enabled = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Enabled = null;
  }
  
  /// <summary>
  /// getEnabled, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetEnabled(DXO2010CustUI.Hyperlink openXmlElement)
  {
    return openXmlElement?.GetEnabled?.Value;
  }
  
  private static bool CmpGetEnabled(DXO2010CustUI.Hyperlink openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetEnabled?.Value == value) return true;
    diffs?.Add(objName, "GetEnabled", openXmlElement?.GetEnabled?.Value, value);
    return false;
  }
  
  private static void SetGetEnabled(DXO2010CustUI.Hyperlink openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetEnabled = new StringValue { Value = value };
    else
      openXmlElement.GetEnabled = null;
  }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetVisible(DXO2010CustUI.Hyperlink openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static bool CmpVisible(DXO2010CustUI.Hyperlink openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Visible?.Value == value) return true;
    diffs?.Add(objName, "Visible", openXmlElement?.Visible?.Value, value);
    return false;
  }
  
  private static void SetVisible(DXO2010CustUI.Hyperlink openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetVisible(DXO2010CustUI.Hyperlink openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }
  
  private static bool CmpGetVisible(DXO2010CustUI.Hyperlink openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetVisible?.Value == value) return true;
    diffs?.Add(objName, "GetVisible", openXmlElement?.GetVisible?.Value, value);
    return false;
  }
  
  private static void SetGetVisible(DXO2010CustUI.Hyperlink openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetVisible = new StringValue { Value = value };
    else
      openXmlElement.GetVisible = null;
  }
  
  /// <summary>
  /// keytip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetKeytip(DXO2010CustUI.Hyperlink openXmlElement)
  {
    return openXmlElement?.Keytip?.Value;
  }
  
  private static bool CmpKeytip(DXO2010CustUI.Hyperlink openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Keytip?.Value == value) return true;
    diffs?.Add(objName, "Keytip", openXmlElement?.Keytip?.Value, value);
    return false;
  }
  
  private static void SetKeytip(DXO2010CustUI.Hyperlink openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Keytip = new StringValue { Value = value };
    else
      openXmlElement.Keytip = null;
  }
  
  /// <summary>
  /// getKeytip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetKeytip(DXO2010CustUI.Hyperlink openXmlElement)
  {
    return openXmlElement?.GetKeytip?.Value;
  }
  
  private static bool CmpGetKeytip(DXO2010CustUI.Hyperlink openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetKeytip?.Value == value) return true;
    diffs?.Add(objName, "GetKeytip", openXmlElement?.GetKeytip?.Value, value);
    return false;
  }
  
  private static void SetGetKeytip(DXO2010CustUI.Hyperlink openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetKeytip = new StringValue { Value = value };
    else
      openXmlElement.GetKeytip = null;
  }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetLabel(DXO2010CustUI.Hyperlink openXmlElement)
  {
    return openXmlElement?.Label?.Value;
  }
  
  private static bool CmpLabel(DXO2010CustUI.Hyperlink openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Label?.Value == value) return true;
    diffs?.Add(objName, "Label", openXmlElement?.Label?.Value, value);
    return false;
  }
  
  private static void SetLabel(DXO2010CustUI.Hyperlink openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Label = new StringValue { Value = value };
    else
      openXmlElement.Label = null;
  }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetLabel(DXO2010CustUI.Hyperlink openXmlElement)
  {
    return openXmlElement?.GetLabel?.Value;
  }
  
  private static bool CmpGetLabel(DXO2010CustUI.Hyperlink openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetLabel?.Value == value) return true;
    diffs?.Add(objName, "GetLabel", openXmlElement?.GetLabel?.Value, value);
    return false;
  }
  
  private static void SetGetLabel(DXO2010CustUI.Hyperlink openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetLabel = new StringValue { Value = value };
    else
      openXmlElement.GetLabel = null;
  }
  
  /// <summary>
  /// onAction, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetOnAction(DXO2010CustUI.Hyperlink openXmlElement)
  {
    return openXmlElement?.OnAction?.Value;
  }
  
  private static bool CmpOnAction(DXO2010CustUI.Hyperlink openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.OnAction?.Value == value) return true;
    diffs?.Add(objName, "OnAction", openXmlElement?.OnAction?.Value, value);
    return false;
  }
  
  private static void SetOnAction(DXO2010CustUI.Hyperlink openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.OnAction = new StringValue { Value = value };
    else
      openXmlElement.OnAction = null;
  }
  
  /// <summary>
  /// image, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetImage(DXO2010CustUI.Hyperlink openXmlElement)
  {
    return openXmlElement?.Image?.Value;
  }
  
  private static bool CmpImage(DXO2010CustUI.Hyperlink openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Image?.Value == value) return true;
    diffs?.Add(objName, "Image", openXmlElement?.Image?.Value, value);
    return false;
  }
  
  private static void SetImage(DXO2010CustUI.Hyperlink openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Image = new StringValue { Value = value };
    else
      openXmlElement.Image = null;
  }
  
  /// <summary>
  /// imageMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetImageMso(DXO2010CustUI.Hyperlink openXmlElement)
  {
    return openXmlElement?.ImageMso?.Value;
  }
  
  private static bool CmpImageMso(DXO2010CustUI.Hyperlink openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ImageMso?.Value == value) return true;
    diffs?.Add(objName, "ImageMso", openXmlElement?.ImageMso?.Value, value);
    return false;
  }
  
  private static void SetImageMso(DXO2010CustUI.Hyperlink openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ImageMso = new StringValue { Value = value };
    else
      openXmlElement.ImageMso = null;
  }
  
  /// <summary>
  /// getImage, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetImage(DXO2010CustUI.Hyperlink openXmlElement)
  {
    return openXmlElement?.GetImage?.Value;
  }
  
  private static bool CmpGetImage(DXO2010CustUI.Hyperlink openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetImage?.Value == value) return true;
    diffs?.Add(objName, "GetImage", openXmlElement?.GetImage?.Value, value);
    return false;
  }
  
  private static void SetGetImage(DXO2010CustUI.Hyperlink openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetImage = new StringValue { Value = value };
    else
      openXmlElement.GetImage = null;
  }
  
  /// <summary>
  /// screentip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetScreentip(DXO2010CustUI.Hyperlink openXmlElement)
  {
    return openXmlElement?.Screentip?.Value;
  }
  
  private static bool CmpScreentip(DXO2010CustUI.Hyperlink openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Screentip?.Value == value) return true;
    diffs?.Add(objName, "Screentip", openXmlElement?.Screentip?.Value, value);
    return false;
  }
  
  private static void SetScreentip(DXO2010CustUI.Hyperlink openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Screentip = new StringValue { Value = value };
    else
      openXmlElement.Screentip = null;
  }
  
  /// <summary>
  /// getScreentip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetScreentip(DXO2010CustUI.Hyperlink openXmlElement)
  {
    return openXmlElement?.GetScreentip?.Value;
  }
  
  private static bool CmpGetScreentip(DXO2010CustUI.Hyperlink openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetScreentip?.Value == value) return true;
    diffs?.Add(objName, "GetScreentip", openXmlElement?.GetScreentip?.Value, value);
    return false;
  }
  
  private static void SetGetScreentip(DXO2010CustUI.Hyperlink openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetScreentip = new StringValue { Value = value };
    else
      openXmlElement.GetScreentip = null;
  }
  
  /// <summary>
  /// supertip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetSupertip(DXO2010CustUI.Hyperlink openXmlElement)
  {
    return openXmlElement?.Supertip?.Value;
  }
  
  private static bool CmpSupertip(DXO2010CustUI.Hyperlink openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Supertip?.Value == value) return true;
    diffs?.Add(objName, "Supertip", openXmlElement?.Supertip?.Value, value);
    return false;
  }
  
  private static void SetSupertip(DXO2010CustUI.Hyperlink openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Supertip = new StringValue { Value = value };
    else
      openXmlElement.Supertip = null;
  }
  
  /// <summary>
  /// getSupertip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetSupertip(DXO2010CustUI.Hyperlink openXmlElement)
  {
    return openXmlElement?.GetSupertip?.Value;
  }
  
  private static bool CmpGetSupertip(DXO2010CustUI.Hyperlink openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetSupertip?.Value == value) return true;
    diffs?.Add(objName, "GetSupertip", openXmlElement?.GetSupertip?.Value, value);
    return false;
  }
  
  private static void SetGetSupertip(DXO2010CustUI.Hyperlink openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetSupertip = new StringValue { Value = value };
    else
      openXmlElement.GetSupertip = null;
  }
  
  /// <summary>
  /// target, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetTarget(DXO2010CustUI.Hyperlink openXmlElement)
  {
    return openXmlElement?.Target?.Value;
  }
  
  private static bool CmpTarget(DXO2010CustUI.Hyperlink openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Target?.Value == value) return true;
    diffs?.Add(objName, "Target", openXmlElement?.Target?.Value, value);
    return false;
  }
  
  private static void SetTarget(DXO2010CustUI.Hyperlink openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Target = new StringValue { Value = value };
    else
      openXmlElement.Target = null;
  }
  
  /// <summary>
  /// getTarget, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetTarget(DXO2010CustUI.Hyperlink openXmlElement)
  {
    return openXmlElement?.GetTarget?.Value;
  }
  
  private static bool CmpGetTarget(DXO2010CustUI.Hyperlink openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetTarget?.Value == value) return true;
    diffs?.Add(objName, "GetTarget", openXmlElement?.GetTarget?.Value, value);
    return false;
  }
  
  private static void SetGetTarget(DXO2010CustUI.Hyperlink openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetTarget = new StringValue { Value = value };
    else
      openXmlElement.GetTarget = null;
  }
  
  public static DM.Hyperlink? CreateModelElement(DXO2010CustUI.Hyperlink? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.Hyperlink();
      value.Id = GetId(openXmlElement);
      value.QualifiedId = GetQualifiedId(openXmlElement);
      value.Tag = GetTag(openXmlElement);
      value.AlignLabel = GetAlignLabel(openXmlElement);
      value.Expand = GetExpand(openXmlElement);
      value.Enabled = GetEnabled(openXmlElement);
      value.GetEnabled = GetGetEnabled(openXmlElement);
      value.Visible = GetVisible(openXmlElement);
      value.GetVisible = GetGetVisible(openXmlElement);
      value.Keytip = GetKeytip(openXmlElement);
      value.GetKeytip = GetGetKeytip(openXmlElement);
      value.Label = GetLabel(openXmlElement);
      value.GetLabel = GetGetLabel(openXmlElement);
      value.OnAction = GetOnAction(openXmlElement);
      value.Image = GetImage(openXmlElement);
      value.ImageMso = GetImageMso(openXmlElement);
      value.GetImage = GetGetImage(openXmlElement);
      value.Screentip = GetScreentip(openXmlElement);
      value.GetScreentip = GetGetScreentip(openXmlElement);
      value.Supertip = GetSupertip(openXmlElement);
      value.GetSupertip = GetGetSupertip(openXmlElement);
      value.Target = GetTarget(openXmlElement);
      value.GetTarget = GetGetTarget(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010CustUI.Hyperlink? openXmlElement, DM.Hyperlink? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpQualifiedId(openXmlElement, value.QualifiedId, diffs, objName))
        ok = false;
      if (!CmpTag(openXmlElement, value.Tag, diffs, objName))
        ok = false;
      if (!CmpAlignLabel(openXmlElement, value.AlignLabel, diffs, objName))
        ok = false;
      if (!CmpExpand(openXmlElement, value.Expand, diffs, objName))
        ok = false;
      if (!CmpEnabled(openXmlElement, value.Enabled, diffs, objName))
        ok = false;
      if (!CmpGetEnabled(openXmlElement, value.GetEnabled, diffs, objName))
        ok = false;
      if (!CmpVisible(openXmlElement, value.Visible, diffs, objName))
        ok = false;
      if (!CmpGetVisible(openXmlElement, value.GetVisible, diffs, objName))
        ok = false;
      if (!CmpKeytip(openXmlElement, value.Keytip, diffs, objName))
        ok = false;
      if (!CmpGetKeytip(openXmlElement, value.GetKeytip, diffs, objName))
        ok = false;
      if (!CmpLabel(openXmlElement, value.Label, diffs, objName))
        ok = false;
      if (!CmpGetLabel(openXmlElement, value.GetLabel, diffs, objName))
        ok = false;
      if (!CmpOnAction(openXmlElement, value.OnAction, diffs, objName))
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
      if (!CmpTarget(openXmlElement, value.Target, diffs, objName))
        ok = false;
      if (!CmpGetTarget(openXmlElement, value.GetTarget, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.Hyperlink? value)
    where OpenXmlElementType: DXO2010CustUI.Hyperlink, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetQualifiedId(openXmlElement, value?.QualifiedId);
      SetTag(openXmlElement, value?.Tag);
      SetAlignLabel(openXmlElement, value?.AlignLabel);
      SetExpand(openXmlElement, value?.Expand);
      SetEnabled(openXmlElement, value?.Enabled);
      SetGetEnabled(openXmlElement, value?.GetEnabled);
      SetVisible(openXmlElement, value?.Visible);
      SetGetVisible(openXmlElement, value?.GetVisible);
      SetKeytip(openXmlElement, value?.Keytip);
      SetGetKeytip(openXmlElement, value?.GetKeytip);
      SetLabel(openXmlElement, value?.Label);
      SetGetLabel(openXmlElement, value?.GetLabel);
      SetOnAction(openXmlElement, value?.OnAction);
      SetImage(openXmlElement, value?.Image);
      SetImageMso(openXmlElement, value?.ImageMso);
      SetGetImage(openXmlElement, value?.GetImage);
      SetScreentip(openXmlElement, value?.Screentip);
      SetGetScreentip(openXmlElement, value?.GetScreentip);
      SetSupertip(openXmlElement, value?.Supertip);
      SetGetSupertip(openXmlElement, value?.GetSupertip);
      SetTarget(openXmlElement, value?.Target);
      SetGetTarget(openXmlElement, value?.GetTarget);
      return openXmlElement;
    }
    return default;
  }
}
