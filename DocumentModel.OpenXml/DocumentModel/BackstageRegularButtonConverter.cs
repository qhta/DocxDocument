namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the BackstageRegularButton Class.
/// </summary>
public static class BackstageRegularButtonConverter
{
  /// <summary>
  /// screentip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetScreentip(DXO2010CustUI.BackstageRegularButton openXmlElement)
  {
    return openXmlElement?.Screentip?.Value;
  }
  
  private static void SetScreentip(DXO2010CustUI.BackstageRegularButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Screentip = new StringValue { Value = value };
    else
      openXmlElement.Screentip = null;
  }
  
  /// <summary>
  /// getScreentip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetScreentip(DXO2010CustUI.BackstageRegularButton openXmlElement)
  {
    return openXmlElement?.GetScreentip?.Value;
  }
  
  private static void SetGetScreentip(DXO2010CustUI.BackstageRegularButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetScreentip = new StringValue { Value = value };
    else
      openXmlElement.GetScreentip = null;
  }
  
  /// <summary>
  /// supertip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetSupertip(DXO2010CustUI.BackstageRegularButton openXmlElement)
  {
    return openXmlElement?.Supertip?.Value;
  }
  
  private static void SetSupertip(DXO2010CustUI.BackstageRegularButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Supertip = new StringValue { Value = value };
    else
      openXmlElement.Supertip = null;
  }
  
  /// <summary>
  /// getSupertip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetSupertip(DXO2010CustUI.BackstageRegularButton openXmlElement)
  {
    return openXmlElement?.GetSupertip?.Value;
  }
  
  private static void SetGetSupertip(DXO2010CustUI.BackstageRegularButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetSupertip = new StringValue { Value = value };
    else
      openXmlElement.GetSupertip = null;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetId(DXO2010CustUI.BackstageRegularButton openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXO2010CustUI.BackstageRegularButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetQualifiedId(DXO2010CustUI.BackstageRegularButton openXmlElement)
  {
    return openXmlElement?.QualifiedId?.Value;
  }
  
  private static void SetQualifiedId(DXO2010CustUI.BackstageRegularButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.QualifiedId = new StringValue { Value = value };
    else
      openXmlElement.QualifiedId = null;
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetTag(DXO2010CustUI.BackstageRegularButton openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }
  
  private static void SetTag(DXO2010CustUI.BackstageRegularButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Tag = new StringValue { Value = value };
    else
      openXmlElement.Tag = null;
  }
  
  /// <summary>
  /// onAction, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetOnAction(DXO2010CustUI.BackstageRegularButton openXmlElement)
  {
    return openXmlElement?.OnAction?.Value;
  }
  
  private static void SetOnAction(DXO2010CustUI.BackstageRegularButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.OnAction = new StringValue { Value = value };
    else
      openXmlElement.OnAction = null;
  }
  
  /// <summary>
  /// isDefinitive, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetIsDefinitive(DXO2010CustUI.BackstageRegularButton openXmlElement)
  {
    return openXmlElement?.IsDefinitive?.Value;
  }
  
  private static void SetIsDefinitive(DXO2010CustUI.BackstageRegularButton openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.IsDefinitive = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.IsDefinitive = null;
  }
  
  /// <summary>
  /// enabled, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetEnabled(DXO2010CustUI.BackstageRegularButton openXmlElement)
  {
    return openXmlElement?.Enabled?.Value;
  }
  
  private static void SetEnabled(DXO2010CustUI.BackstageRegularButton openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Enabled = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Enabled = null;
  }
  
  /// <summary>
  /// getEnabled, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetEnabled(DXO2010CustUI.BackstageRegularButton openXmlElement)
  {
    return openXmlElement?.GetEnabled?.Value;
  }
  
  private static void SetGetEnabled(DXO2010CustUI.BackstageRegularButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetEnabled = new StringValue { Value = value };
    else
      openXmlElement.GetEnabled = null;
  }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetLabel(DXO2010CustUI.BackstageRegularButton openXmlElement)
  {
    return openXmlElement?.Label?.Value;
  }
  
  private static void SetLabel(DXO2010CustUI.BackstageRegularButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Label = new StringValue { Value = value };
    else
      openXmlElement.Label = null;
  }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetLabel(DXO2010CustUI.BackstageRegularButton openXmlElement)
  {
    return openXmlElement?.GetLabel?.Value;
  }
  
  private static void SetGetLabel(DXO2010CustUI.BackstageRegularButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetLabel = new StringValue { Value = value };
    else
      openXmlElement.GetLabel = null;
  }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetVisible(DXO2010CustUI.BackstageRegularButton openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static void SetVisible(DXO2010CustUI.BackstageRegularButton openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetVisible(DXO2010CustUI.BackstageRegularButton openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }
  
  private static void SetGetVisible(DXO2010CustUI.BackstageRegularButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetVisible = new StringValue { Value = value };
    else
      openXmlElement.GetVisible = null;
  }
  
  /// <summary>
  /// keytip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetKeytip(DXO2010CustUI.BackstageRegularButton openXmlElement)
  {
    return openXmlElement?.Keytip?.Value;
  }
  
  private static void SetKeytip(DXO2010CustUI.BackstageRegularButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Keytip = new StringValue { Value = value };
    else
      openXmlElement.Keytip = null;
  }
  
  /// <summary>
  /// getKeytip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetKeytip(DXO2010CustUI.BackstageRegularButton openXmlElement)
  {
    return openXmlElement?.GetKeytip?.Value;
  }
  
  private static void SetGetKeytip(DXO2010CustUI.BackstageRegularButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetKeytip = new StringValue { Value = value };
    else
      openXmlElement.GetKeytip = null;
  }
  
  /// <summary>
  /// image, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetImage(DXO2010CustUI.BackstageRegularButton openXmlElement)
  {
    return openXmlElement?.Image?.Value;
  }
  
  private static void SetImage(DXO2010CustUI.BackstageRegularButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Image = new StringValue { Value = value };
    else
      openXmlElement.Image = null;
  }
  
  /// <summary>
  /// imageMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetImageMso(DXO2010CustUI.BackstageRegularButton openXmlElement)
  {
    return openXmlElement?.ImageMso?.Value;
  }
  
  private static void SetImageMso(DXO2010CustUI.BackstageRegularButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ImageMso = new StringValue { Value = value };
    else
      openXmlElement.ImageMso = null;
  }
  
  /// <summary>
  /// getImage, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetImage(DXO2010CustUI.BackstageRegularButton openXmlElement)
  {
    return openXmlElement?.GetImage?.Value;
  }
  
  private static void SetGetImage(DXO2010CustUI.BackstageRegularButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetImage = new StringValue { Value = value };
    else
      openXmlElement.GetImage = null;
  }
  
  public static DM.BackstageRegularButton? CreateModelElement(DXO2010CustUI.BackstageRegularButton? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.BackstageRegularButton();
      value.Screentip = GetScreentip(openXmlElement);
      value.GetScreentip = GetGetScreentip(openXmlElement);
      value.Supertip = GetSupertip(openXmlElement);
      value.GetSupertip = GetGetSupertip(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.QualifiedId = GetQualifiedId(openXmlElement);
      value.Tag = GetTag(openXmlElement);
      value.OnAction = GetOnAction(openXmlElement);
      value.IsDefinitive = GetIsDefinitive(openXmlElement);
      value.Enabled = GetEnabled(openXmlElement);
      value.GetEnabled = GetGetEnabled(openXmlElement);
      value.Label = GetLabel(openXmlElement);
      value.GetLabel = GetGetLabel(openXmlElement);
      value.Visible = GetVisible(openXmlElement);
      value.GetVisible = GetGetVisible(openXmlElement);
      value.Keytip = GetKeytip(openXmlElement);
      value.GetKeytip = GetGetKeytip(openXmlElement);
      value.Image = GetImage(openXmlElement);
      value.ImageMso = GetImageMso(openXmlElement);
      value.GetImage = GetGetImage(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.BackstageRegularButton? value)
    where OpenXmlElementType: DXO2010CustUI.BackstageRegularButton, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetScreentip(openXmlElement, value?.Screentip);
      SetGetScreentip(openXmlElement, value?.GetScreentip);
      SetSupertip(openXmlElement, value?.Supertip);
      SetGetSupertip(openXmlElement, value?.GetSupertip);
      SetId(openXmlElement, value?.Id);
      SetQualifiedId(openXmlElement, value?.QualifiedId);
      SetTag(openXmlElement, value?.Tag);
      SetOnAction(openXmlElement, value?.OnAction);
      SetIsDefinitive(openXmlElement, value?.IsDefinitive);
      SetEnabled(openXmlElement, value?.Enabled);
      SetGetEnabled(openXmlElement, value?.GetEnabled);
      SetLabel(openXmlElement, value?.Label);
      SetGetLabel(openXmlElement, value?.GetLabel);
      SetVisible(openXmlElement, value?.Visible);
      SetGetVisible(openXmlElement, value?.GetVisible);
      SetKeytip(openXmlElement, value?.Keytip);
      SetGetKeytip(openXmlElement, value?.GetKeytip);
      SetImage(openXmlElement, value?.Image);
      SetImageMso(openXmlElement, value?.ImageMso);
      SetGetImage(openXmlElement, value?.GetImage);
      return openXmlElement;
    }
    return default;
  }
}
