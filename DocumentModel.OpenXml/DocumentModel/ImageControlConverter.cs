namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the ImageControl Class.
/// </summary>
public static class ImageControlConverter
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetId(DXO2010CustUI.ImageControl openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXO2010CustUI.ImageControl openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Id?.Value == value;
  }
  
  private static void SetId(DXO2010CustUI.ImageControl openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetQualifiedId(DXO2010CustUI.ImageControl openXmlElement)
  {
    return openXmlElement?.QualifiedId?.Value;
  }
  
  private static bool CmpQualifiedId(DXO2010CustUI.ImageControl openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.QualifiedId?.Value == value;
  }
  
  private static void SetQualifiedId(DXO2010CustUI.ImageControl openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.QualifiedId = new StringValue { Value = value };
    else
      openXmlElement.QualifiedId = null;
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetTag(DXO2010CustUI.ImageControl openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }
  
  private static bool CmpTag(DXO2010CustUI.ImageControl openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Tag?.Value == value;
  }
  
  private static void SetTag(DXO2010CustUI.ImageControl openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Tag = new StringValue { Value = value };
    else
      openXmlElement.Tag = null;
  }
  
  /// <summary>
  /// enabled, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetEnabled(DXO2010CustUI.ImageControl openXmlElement)
  {
    return openXmlElement?.Enabled?.Value;
  }
  
  private static bool CmpEnabled(DXO2010CustUI.ImageControl openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Enabled?.Value == value;
  }
  
  private static void SetEnabled(DXO2010CustUI.ImageControl openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Enabled = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Enabled = null;
  }
  
  /// <summary>
  /// getEnabled, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetEnabled(DXO2010CustUI.ImageControl openXmlElement)
  {
    return openXmlElement?.GetEnabled?.Value;
  }
  
  private static bool CmpGetEnabled(DXO2010CustUI.ImageControl openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetEnabled?.Value == value;
  }
  
  private static void SetGetEnabled(DXO2010CustUI.ImageControl openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetEnabled = new StringValue { Value = value };
    else
      openXmlElement.GetEnabled = null;
  }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetVisible(DXO2010CustUI.ImageControl openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static bool CmpVisible(DXO2010CustUI.ImageControl openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Visible?.Value == value;
  }
  
  private static void SetVisible(DXO2010CustUI.ImageControl openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetVisible(DXO2010CustUI.ImageControl openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }
  
  private static bool CmpGetVisible(DXO2010CustUI.ImageControl openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetVisible?.Value == value;
  }
  
  private static void SetGetVisible(DXO2010CustUI.ImageControl openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetVisible = new StringValue { Value = value };
    else
      openXmlElement.GetVisible = null;
  }
  
  /// <summary>
  /// image, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetImage(DXO2010CustUI.ImageControl openXmlElement)
  {
    return openXmlElement?.Image?.Value;
  }
  
  private static bool CmpImage(DXO2010CustUI.ImageControl openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Image?.Value == value;
  }
  
  private static void SetImage(DXO2010CustUI.ImageControl openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Image = new StringValue { Value = value };
    else
      openXmlElement.Image = null;
  }
  
  /// <summary>
  /// imageMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetImageMso(DXO2010CustUI.ImageControl openXmlElement)
  {
    return openXmlElement?.ImageMso?.Value;
  }
  
  private static bool CmpImageMso(DXO2010CustUI.ImageControl openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ImageMso?.Value == value;
  }
  
  private static void SetImageMso(DXO2010CustUI.ImageControl openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ImageMso = new StringValue { Value = value };
    else
      openXmlElement.ImageMso = null;
  }
  
  /// <summary>
  /// getImage, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetImage(DXO2010CustUI.ImageControl openXmlElement)
  {
    return openXmlElement?.GetImage?.Value;
  }
  
  private static bool CmpGetImage(DXO2010CustUI.ImageControl openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetImage?.Value == value;
  }
  
  private static void SetGetImage(DXO2010CustUI.ImageControl openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetImage = new StringValue { Value = value };
    else
      openXmlElement.GetImage = null;
  }
  
  /// <summary>
  /// altText, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetAltText(DXO2010CustUI.ImageControl openXmlElement)
  {
    return openXmlElement?.AltText?.Value;
  }
  
  private static bool CmpAltText(DXO2010CustUI.ImageControl openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.AltText?.Value == value;
  }
  
  private static void SetAltText(DXO2010CustUI.ImageControl openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.AltText = new StringValue { Value = value };
    else
      openXmlElement.AltText = null;
  }
  
  /// <summary>
  /// getAltText, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetAltText(DXO2010CustUI.ImageControl openXmlElement)
  {
    return openXmlElement?.GetAltText?.Value;
  }
  
  private static bool CmpGetAltText(DXO2010CustUI.ImageControl openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetAltText?.Value == value;
  }
  
  private static void SetGetAltText(DXO2010CustUI.ImageControl openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetAltText = new StringValue { Value = value };
    else
      openXmlElement.GetAltText = null;
  }
  
  public static DM.ImageControl? CreateModelElement(DXO2010CustUI.ImageControl? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.ImageControl();
      value.Id = GetId(openXmlElement);
      value.QualifiedId = GetQualifiedId(openXmlElement);
      value.Tag = GetTag(openXmlElement);
      value.Enabled = GetEnabled(openXmlElement);
      value.GetEnabled = GetGetEnabled(openXmlElement);
      value.Visible = GetVisible(openXmlElement);
      value.GetVisible = GetGetVisible(openXmlElement);
      value.Image = GetImage(openXmlElement);
      value.ImageMso = GetImageMso(openXmlElement);
      value.GetImage = GetGetImage(openXmlElement);
      value.AltText = GetAltText(openXmlElement);
      value.GetAltText = GetGetAltText(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010CustUI.ImageControl? openXmlElement, DM.ImageControl? value, DiffList? diffs, string? objName)
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
      if (!CmpEnabled(openXmlElement, value.Enabled, diffs, objName))
        ok = false;
      if (!CmpGetEnabled(openXmlElement, value.GetEnabled, diffs, objName))
        ok = false;
      if (!CmpVisible(openXmlElement, value.Visible, diffs, objName))
        ok = false;
      if (!CmpGetVisible(openXmlElement, value.GetVisible, diffs, objName))
        ok = false;
      if (!CmpImage(openXmlElement, value.Image, diffs, objName))
        ok = false;
      if (!CmpImageMso(openXmlElement, value.ImageMso, diffs, objName))
        ok = false;
      if (!CmpGetImage(openXmlElement, value.GetImage, diffs, objName))
        ok = false;
      if (!CmpAltText(openXmlElement, value.AltText, diffs, objName))
        ok = false;
      if (!CmpGetAltText(openXmlElement, value.GetAltText, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.ImageControl? value)
    where OpenXmlElementType: DXO2010CustUI.ImageControl, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetQualifiedId(openXmlElement, value?.QualifiedId);
      SetTag(openXmlElement, value?.Tag);
      SetEnabled(openXmlElement, value?.Enabled);
      SetGetEnabled(openXmlElement, value?.GetEnabled);
      SetVisible(openXmlElement, value?.Visible);
      SetGetVisible(openXmlElement, value?.GetVisible);
      SetImage(openXmlElement, value?.Image);
      SetImageMso(openXmlElement, value?.ImageMso);
      SetGetImage(openXmlElement, value?.GetImage);
      SetAltText(openXmlElement, value?.AltText);
      SetGetAltText(openXmlElement, value?.GetAltText);
      return openXmlElement;
    }
    return default;
  }
}
