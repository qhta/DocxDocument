namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the BackstageMenuCheckBox Class.
/// </summary>
public static class BackstageMenuCheckBoxConverter
{
  /// <summary>
  /// description, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetDescription(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuCheckBox? openXmlElement)
  {
    return openXmlElement?.Description?.Value;
  }
  
  public static void SetDescription(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuCheckBox? openXmlElement, String? value)
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
  public static String? GetGetDescription(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuCheckBox? openXmlElement)
  {
    return openXmlElement?.GetDescription?.Value;
  }
  
  public static void SetGetDescription(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuCheckBox? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetDescription = new StringValue { Value = value };
      else
        openXmlElement.GetDescription = null;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuCheckBox? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuCheckBox? openXmlElement, String? value)
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
  public static String? GetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuCheckBox? openXmlElement)
  {
    return openXmlElement?.QualifiedId?.Value;
  }
  
  public static void SetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuCheckBox? openXmlElement, String? value)
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
  public static String? GetTag(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuCheckBox? openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }
  
  public static void SetTag(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuCheckBox? openXmlElement, String? value)
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
  public static String? GetOnAction(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuCheckBox? openXmlElement)
  {
    return openXmlElement?.OnAction?.Value;
  }
  
  public static void SetOnAction(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuCheckBox? openXmlElement, String? value)
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
  public static String? GetGetPressed(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuCheckBox? openXmlElement)
  {
    return openXmlElement?.GetPressed?.Value;
  }
  
  public static void SetGetPressed(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuCheckBox? openXmlElement, String? value)
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
  public static Boolean? GetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuCheckBox? openXmlElement)
  {
    return openXmlElement?.Enabled?.Value;
  }
  
  public static void SetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuCheckBox? openXmlElement, Boolean? value)
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
  public static String? GetGetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuCheckBox? openXmlElement)
  {
    return openXmlElement?.GetEnabled?.Value;
  }
  
  public static void SetGetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuCheckBox? openXmlElement, String? value)
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
  public static String? GetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuCheckBox? openXmlElement)
  {
    return openXmlElement?.Label?.Value;
  }
  
  public static void SetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuCheckBox? openXmlElement, String? value)
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
  public static String? GetGetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuCheckBox? openXmlElement)
  {
    return openXmlElement?.GetLabel?.Value;
  }
  
  public static void SetGetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuCheckBox? openXmlElement, String? value)
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
  public static Boolean? GetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuCheckBox? openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  public static void SetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuCheckBox? openXmlElement, Boolean? value)
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
  public static String? GetGetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuCheckBox? openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }
  
  public static void SetGetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuCheckBox? openXmlElement, String? value)
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
  public static String? GetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuCheckBox? openXmlElement)
  {
    return openXmlElement?.Keytip?.Value;
  }
  
  public static void SetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuCheckBox? openXmlElement, String? value)
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
  public static String? GetGetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuCheckBox? openXmlElement)
  {
    return openXmlElement?.GetKeytip?.Value;
  }
  
  public static void SetGetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuCheckBox? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetKeytip = new StringValue { Value = value };
      else
        openXmlElement.GetKeytip = null;
  }
  
  public static DocumentModel.BackstageMenuCheckBox? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuCheckBox? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.BackstageMenuCheckBox();
      value.Description = GetDescription(openXmlElement);
      value.GetDescription = GetGetDescription(openXmlElement);
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.BackstageMenuCheckBox? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuCheckBox, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDescription(openXmlElement, value?.Description);
      SetGetDescription(openXmlElement, value?.GetDescription);
      SetId(openXmlElement, value?.Id);
      SetQualifiedId(openXmlElement, value?.QualifiedId);
      SetTag(openXmlElement, value?.Tag);
      SetOnAction(openXmlElement, value?.OnAction);
      SetGetPressed(openXmlElement, value?.GetPressed);
      SetEnabled(openXmlElement, value?.Enabled);
      SetGetEnabled(openXmlElement, value?.GetEnabled);
      SetLabel(openXmlElement, value?.Label);
      SetGetLabel(openXmlElement, value?.GetLabel);
      SetVisible(openXmlElement, value?.Visible);
      SetGetVisible(openXmlElement, value?.GetVisible);
      SetKeytip(openXmlElement, value?.Keytip);
      SetGetKeytip(openXmlElement, value?.GetKeytip);
      return openXmlElement;
    }
    return default;
  }
}
