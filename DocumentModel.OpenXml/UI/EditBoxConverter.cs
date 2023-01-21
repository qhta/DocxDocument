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
    return openXmlElement.MaxLength?.Value;
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
  
  private static void SetGetShowImage(DXOCustUI.EditBox openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetShowImage = new StringValue { Value = value };
    else
      openXmlElement.GetShowImage = null;
  }
  
  public static DMUI.EditBox? CreateModelElement(DXOCustUI.EditBox? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMUI.EditBox();
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
