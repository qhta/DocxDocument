namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the BackstageCheckBox Class.
/// </summary>
public static class BackstageCheckBoxConverter
{
  /// <summary>
  /// expand, this property is only available in Office 2010 and later.
  /// </summary>
  public static DocumentModel.ExpandKind? GetExpand(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DocumentModel.ExpandKind>(openXmlElement?.Expand?.Value);
  }
  
  public static void SetExpand(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox? openXmlElement, DocumentModel.ExpandKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Expand = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DocumentModel.ExpandKind>(value);
  }
  
  /// <summary>
  /// description, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetDescription(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox? openXmlElement)
  {
    return openXmlElement?.Description?.Value;
  }
  
  public static void SetDescription(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Description = new StringValue { Value = value };
      else
        openXmlElement.Description = null;
  }
  
  /// <summary>
  /// getDescription, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetDescription(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox? openXmlElement)
  {
    return openXmlElement?.GetDescription?.Value;
  }
  
  public static void SetGetDescription(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetDescription = new StringValue { Value = value };
      else
        openXmlElement.GetDescription = null;
  }
  
  /// <summary>
  /// screentip, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetScreentip(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox? openXmlElement)
  {
    return openXmlElement?.Screentip?.Value;
  }
  
  public static void SetScreentip(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Screentip = new StringValue { Value = value };
      else
        openXmlElement.Screentip = null;
  }
  
  /// <summary>
  /// getScreentip, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetScreentip(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox? openXmlElement)
  {
    return openXmlElement?.GetScreentip?.Value;
  }
  
  public static void SetGetScreentip(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetScreentip = new StringValue { Value = value };
      else
        openXmlElement.GetScreentip = null;
  }
  
  /// <summary>
  /// supertip, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetSupertip(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox? openXmlElement)
  {
    return openXmlElement?.Supertip?.Value;
  }
  
  public static void SetSupertip(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Supertip = new StringValue { Value = value };
      else
        openXmlElement.Supertip = null;
  }
  
  /// <summary>
  /// getSupertip, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetSupertip(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox? openXmlElement)
  {
    return openXmlElement?.GetSupertip?.Value;
  }
  
  public static void SetGetSupertip(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetSupertip = new StringValue { Value = value };
      else
        openXmlElement.GetSupertip = null;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox? openXmlElement)
  {
    return openXmlElement?.QualifiedId?.Value;
  }
  
  public static void SetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.QualifiedId = new StringValue { Value = value };
      else
        openXmlElement.QualifiedId = null;
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetTag(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox? openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }
  
  public static void SetTag(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Tag = new StringValue { Value = value };
      else
        openXmlElement.Tag = null;
  }
  
  /// <summary>
  /// onAction, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetOnAction(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox? openXmlElement)
  {
    return openXmlElement?.OnAction?.Value;
  }
  
  public static void SetOnAction(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.OnAction = new StringValue { Value = value };
      else
        openXmlElement.OnAction = null;
  }
  
  /// <summary>
  /// getPressed, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetPressed(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox? openXmlElement)
  {
    return openXmlElement?.GetPressed?.Value;
  }
  
  public static void SetGetPressed(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetPressed = new StringValue { Value = value };
      else
        openXmlElement.GetPressed = null;
  }
  
  /// <summary>
  /// enabled, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox? openXmlElement)
  {
    return openXmlElement?.Enabled?.Value;
  }
  
  public static void SetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Enabled = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Enabled = null;
  }
  
  /// <summary>
  /// getEnabled, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox? openXmlElement)
  {
    return openXmlElement?.GetEnabled?.Value;
  }
  
  public static void SetGetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetEnabled = new StringValue { Value = value };
      else
        openXmlElement.GetEnabled = null;
  }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox? openXmlElement)
  {
    return openXmlElement?.Label?.Value;
  }
  
  public static void SetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Label = new StringValue { Value = value };
      else
        openXmlElement.Label = null;
  }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox? openXmlElement)
  {
    return openXmlElement?.GetLabel?.Value;
  }
  
  public static void SetGetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetLabel = new StringValue { Value = value };
      else
        openXmlElement.GetLabel = null;
  }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox? openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  public static void SetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox? openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }
  
  public static void SetGetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetVisible = new StringValue { Value = value };
      else
        openXmlElement.GetVisible = null;
  }
  
  /// <summary>
  /// keytip, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox? openXmlElement)
  {
    return openXmlElement?.Keytip?.Value;
  }
  
  public static void SetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Keytip = new StringValue { Value = value };
      else
        openXmlElement.Keytip = null;
  }
  
  /// <summary>
  /// getKeytip, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox? openXmlElement)
  {
    return openXmlElement?.GetKeytip?.Value;
  }
  
  public static void SetGetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetKeytip = new StringValue { Value = value };
      else
        openXmlElement.GetKeytip = null;
  }
  
  public static DocumentModel.BackstageCheckBox? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.BackstageCheckBox();
      value.Expand = GetExpand(openXmlElement);
      value.Description = GetDescription(openXmlElement);
      value.GetDescription = GetGetDescription(openXmlElement);
      value.Screentip = GetScreentip(openXmlElement);
      value.GetScreentip = GetGetScreentip(openXmlElement);
      value.Supertip = GetSupertip(openXmlElement);
      value.GetSupertip = GetGetSupertip(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.QualifiedId = GetQualifiedId(openXmlElement);
      value.Tag = GetTag(openXmlElement);
      value.OnAction = GetOnAction(openXmlElement);
      value.GetPressed = GetGetPressed(openXmlElement);
      value.Enabled = GetEnabled(openXmlElement);
      value.GetEnabled = GetGetEnabled(openXmlElement);
      value.Label = GetLabel(openXmlElement);
      value.GetLabel = GetGetLabel(openXmlElement);
      value.Visible = GetVisible(openXmlElement);
      value.GetVisible = GetGetVisible(openXmlElement);
      value.Keytip = GetKeytip(openXmlElement);
      value.GetKeytip = GetGetKeytip(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.BackstageCheckBox? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
