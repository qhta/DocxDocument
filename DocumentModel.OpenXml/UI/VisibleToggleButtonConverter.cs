namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the VisibleToggleButton Class.
/// </summary>
public static class VisibleToggleButtonConverter
{
  /// <summary>
  /// getPressed
  /// </summary>
  private static String? GetGetPressed(DXOCustUI.VisibleToggleButton openXmlElement)
  {
    return openXmlElement?.GetPressed?.Value;
  }
  
  private static void SetGetPressed(DXOCustUI.VisibleToggleButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetPressed = new StringValue { Value = value };
    else
      openXmlElement.GetPressed = null;
  }
  
  /// <summary>
  /// onAction
  /// </summary>
  private static String? GetOnAction(DXOCustUI.VisibleToggleButton openXmlElement)
  {
    return openXmlElement?.OnAction?.Value;
  }
  
  private static void SetOnAction(DXOCustUI.VisibleToggleButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.OnAction = new StringValue { Value = value };
    else
      openXmlElement.OnAction = null;
  }
  
  /// <summary>
  /// enabled
  /// </summary>
  private static Boolean? GetEnabled(DXOCustUI.VisibleToggleButton openXmlElement)
  {
    return openXmlElement?.Enabled?.Value;
  }
  
  private static void SetEnabled(DXOCustUI.VisibleToggleButton openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Enabled = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Enabled = null;
  }
  
  /// <summary>
  /// getEnabled
  /// </summary>
  private static String? GetGetEnabled(DXOCustUI.VisibleToggleButton openXmlElement)
  {
    return openXmlElement?.GetEnabled?.Value;
  }
  
  private static void SetGetEnabled(DXOCustUI.VisibleToggleButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetEnabled = new StringValue { Value = value };
    else
      openXmlElement.GetEnabled = null;
  }
  
  /// <summary>
  /// description
  /// </summary>
  private static String? GetDescription(DXOCustUI.VisibleToggleButton openXmlElement)
  {
    return openXmlElement?.Description?.Value;
  }
  
  private static void SetDescription(DXOCustUI.VisibleToggleButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Description = new StringValue { Value = value };
    else
      openXmlElement.Description = null;
  }
  
  /// <summary>
  /// getDescription
  /// </summary>
  private static String? GetGetDescription(DXOCustUI.VisibleToggleButton openXmlElement)
  {
    return openXmlElement?.GetDescription?.Value;
  }
  
  private static void SetGetDescription(DXOCustUI.VisibleToggleButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetDescription = new StringValue { Value = value };
    else
      openXmlElement.GetDescription = null;
  }
  
  /// <summary>
  /// image
  /// </summary>
  private static String? GetImage(DXOCustUI.VisibleToggleButton openXmlElement)
  {
    return openXmlElement?.Image?.Value;
  }
  
  private static void SetImage(DXOCustUI.VisibleToggleButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Image = new StringValue { Value = value };
    else
      openXmlElement.Image = null;
  }
  
  /// <summary>
  /// imageMso
  /// </summary>
  private static String? GetImageMso(DXOCustUI.VisibleToggleButton openXmlElement)
  {
    return openXmlElement?.ImageMso?.Value;
  }
  
  private static void SetImageMso(DXOCustUI.VisibleToggleButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ImageMso = new StringValue { Value = value };
    else
      openXmlElement.ImageMso = null;
  }
  
  /// <summary>
  /// getImage
  /// </summary>
  private static String? GetGetImage(DXOCustUI.VisibleToggleButton openXmlElement)
  {
    return openXmlElement?.GetImage?.Value;
  }
  
  private static void SetGetImage(DXOCustUI.VisibleToggleButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetImage = new StringValue { Value = value };
    else
      openXmlElement.GetImage = null;
  }
  
  /// <summary>
  /// id
  /// </summary>
  private static String? GetId(DXOCustUI.VisibleToggleButton openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXOCustUI.VisibleToggleButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// idQ
  /// </summary>
  private static String? GetIdQ(DXOCustUI.VisibleToggleButton openXmlElement)
  {
    return openXmlElement?.IdQ?.Value;
  }
  
  private static void SetIdQ(DXOCustUI.VisibleToggleButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.IdQ = new StringValue { Value = value };
    else
      openXmlElement.IdQ = null;
  }
  
  /// <summary>
  /// idMso
  /// </summary>
  private static String? GetIdMso(DXOCustUI.VisibleToggleButton openXmlElement)
  {
    return openXmlElement?.IdMso?.Value;
  }
  
  private static void SetIdMso(DXOCustUI.VisibleToggleButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.IdMso = new StringValue { Value = value };
    else
      openXmlElement.IdMso = null;
  }
  
  /// <summary>
  /// tag
  /// </summary>
  private static String? GetTag(DXOCustUI.VisibleToggleButton openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }
  
  private static void SetTag(DXOCustUI.VisibleToggleButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Tag = new StringValue { Value = value };
    else
      openXmlElement.Tag = null;
  }
  
  /// <summary>
  /// screentip
  /// </summary>
  private static String? GetScreentip(DXOCustUI.VisibleToggleButton openXmlElement)
  {
    return openXmlElement?.Screentip?.Value;
  }
  
  private static void SetScreentip(DXOCustUI.VisibleToggleButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Screentip = new StringValue { Value = value };
    else
      openXmlElement.Screentip = null;
  }
  
  /// <summary>
  /// getScreentip
  /// </summary>
  private static String? GetGetScreentip(DXOCustUI.VisibleToggleButton openXmlElement)
  {
    return openXmlElement?.GetScreentip?.Value;
  }
  
  private static void SetGetScreentip(DXOCustUI.VisibleToggleButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetScreentip = new StringValue { Value = value };
    else
      openXmlElement.GetScreentip = null;
  }
  
  /// <summary>
  /// supertip
  /// </summary>
  private static String? GetSupertip(DXOCustUI.VisibleToggleButton openXmlElement)
  {
    return openXmlElement?.Supertip?.Value;
  }
  
  private static void SetSupertip(DXOCustUI.VisibleToggleButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Supertip = new StringValue { Value = value };
    else
      openXmlElement.Supertip = null;
  }
  
  /// <summary>
  /// getSupertip
  /// </summary>
  private static String? GetGetSupertip(DXOCustUI.VisibleToggleButton openXmlElement)
  {
    return openXmlElement?.GetSupertip?.Value;
  }
  
  private static void SetGetSupertip(DXOCustUI.VisibleToggleButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetSupertip = new StringValue { Value = value };
    else
      openXmlElement.GetSupertip = null;
  }
  
  /// <summary>
  /// label
  /// </summary>
  private static String? GetLabel(DXOCustUI.VisibleToggleButton openXmlElement)
  {
    return openXmlElement?.Label?.Value;
  }
  
  private static void SetLabel(DXOCustUI.VisibleToggleButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Label = new StringValue { Value = value };
    else
      openXmlElement.Label = null;
  }
  
  /// <summary>
  /// getLabel
  /// </summary>
  private static String? GetGetLabel(DXOCustUI.VisibleToggleButton openXmlElement)
  {
    return openXmlElement?.GetLabel?.Value;
  }
  
  private static void SetGetLabel(DXOCustUI.VisibleToggleButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetLabel = new StringValue { Value = value };
    else
      openXmlElement.GetLabel = null;
  }
  
  /// <summary>
  /// insertAfterMso
  /// </summary>
  private static String? GetInsertAfterMso(DXOCustUI.VisibleToggleButton openXmlElement)
  {
    return openXmlElement?.InsertAfterMso?.Value;
  }
  
  private static void SetInsertAfterMso(DXOCustUI.VisibleToggleButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterMso = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterMso = null;
  }
  
  /// <summary>
  /// insertBeforeMso
  /// </summary>
  private static String? GetInsertBeforeMso(DXOCustUI.VisibleToggleButton openXmlElement)
  {
    return openXmlElement?.InsertBeforeMso?.Value;
  }
  
  private static void SetInsertBeforeMso(DXOCustUI.VisibleToggleButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeMso = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeMso = null;
  }
  
  /// <summary>
  /// insertAfterQ
  /// </summary>
  private static String? GetInsertAfterQ(DXOCustUI.VisibleToggleButton openXmlElement)
  {
    return openXmlElement?.InsertAfterQ?.Value;
  }
  
  private static void SetInsertAfterQ(DXOCustUI.VisibleToggleButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterQ = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterQ = null;
  }
  
  /// <summary>
  /// insertBeforeQ
  /// </summary>
  private static String? GetInsertBeforeQ(DXOCustUI.VisibleToggleButton openXmlElement)
  {
    return openXmlElement?.InsertBeforeQ?.Value;
  }
  
  private static void SetInsertBeforeQ(DXOCustUI.VisibleToggleButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeQ = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeQ = null;
  }
  
  /// <summary>
  /// keytip
  /// </summary>
  private static String? GetKeytip(DXOCustUI.VisibleToggleButton openXmlElement)
  {
    return openXmlElement?.Keytip?.Value;
  }
  
  private static void SetKeytip(DXOCustUI.VisibleToggleButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Keytip = new StringValue { Value = value };
    else
      openXmlElement.Keytip = null;
  }
  
  /// <summary>
  /// getKeytip
  /// </summary>
  private static String? GetGetKeytip(DXOCustUI.VisibleToggleButton openXmlElement)
  {
    return openXmlElement?.GetKeytip?.Value;
  }
  
  private static void SetGetKeytip(DXOCustUI.VisibleToggleButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetKeytip = new StringValue { Value = value };
    else
      openXmlElement.GetKeytip = null;
  }
  
  /// <summary>
  /// showLabel
  /// </summary>
  private static Boolean? GetShowLabel(DXOCustUI.VisibleToggleButton openXmlElement)
  {
    return openXmlElement?.ShowLabel?.Value;
  }
  
  private static void SetShowLabel(DXOCustUI.VisibleToggleButton openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowLabel = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowLabel = null;
  }
  
  /// <summary>
  /// getShowLabel
  /// </summary>
  private static String? GetGetShowLabel(DXOCustUI.VisibleToggleButton openXmlElement)
  {
    return openXmlElement?.GetShowLabel?.Value;
  }
  
  private static void SetGetShowLabel(DXOCustUI.VisibleToggleButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetShowLabel = new StringValue { Value = value };
    else
      openXmlElement.GetShowLabel = null;
  }
  
  /// <summary>
  /// showImage
  /// </summary>
  private static Boolean? GetShowImage(DXOCustUI.VisibleToggleButton openXmlElement)
  {
    return openXmlElement?.ShowImage?.Value;
  }
  
  private static void SetShowImage(DXOCustUI.VisibleToggleButton openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowImage = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowImage = null;
  }
  
  /// <summary>
  /// getShowImage
  /// </summary>
  private static String? GetGetShowImage(DXOCustUI.VisibleToggleButton openXmlElement)
  {
    return openXmlElement?.GetShowImage?.Value;
  }
  
  private static void SetGetShowImage(DXOCustUI.VisibleToggleButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetShowImage = new StringValue { Value = value };
    else
      openXmlElement.GetShowImage = null;
  }
  
  public static DMUI.VisibleToggleButton? CreateModelElement(DXOCustUI.VisibleToggleButton? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMUI.VisibleToggleButton();
      value.GetPressed = GetGetPressed(openXmlElement);
      value.OnAction = GetOnAction(openXmlElement);
      value.Enabled = GetEnabled(openXmlElement);
      value.GetEnabled = GetGetEnabled(openXmlElement);
      value.Description = GetDescription(openXmlElement);
      value.GetDescription = GetGetDescription(openXmlElement);
      value.Image = GetImage(openXmlElement);
      value.ImageMso = GetImageMso(openXmlElement);
      value.GetImage = GetGetImage(openXmlElement);
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMUI.VisibleToggleButton? value)
    where OpenXmlElementType: DXOCustUI.VisibleToggleButton, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGetPressed(openXmlElement, value?.GetPressed);
      SetOnAction(openXmlElement, value?.OnAction);
      SetEnabled(openXmlElement, value?.Enabled);
      SetGetEnabled(openXmlElement, value?.GetEnabled);
      SetDescription(openXmlElement, value?.Description);
      SetGetDescription(openXmlElement, value?.GetDescription);
      SetImage(openXmlElement, value?.Image);
      SetImageMso(openXmlElement, value?.ImageMso);
      SetGetImage(openXmlElement, value?.GetImage);
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
