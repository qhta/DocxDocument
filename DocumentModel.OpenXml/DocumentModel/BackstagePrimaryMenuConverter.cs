namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the BackstagePrimaryMenu Class.
/// </summary>
public static class BackstagePrimaryMenuConverter
{
  /// <summary>
  /// screentip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetScreentip(DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu openXmlElement)
  {
    return openXmlElement?.Screentip?.Value;
  }
  
  private static void SetScreentip(DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Screentip = new StringValue { Value = value };
    else
      openXmlElement.Screentip = null;
  }
  
  /// <summary>
  /// getScreentip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetScreentip(DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu openXmlElement)
  {
    return openXmlElement?.GetScreentip?.Value;
  }
  
  private static void SetGetScreentip(DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetScreentip = new StringValue { Value = value };
    else
      openXmlElement.GetScreentip = null;
  }
  
  /// <summary>
  /// supertip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetSupertip(DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu openXmlElement)
  {
    return openXmlElement?.Supertip?.Value;
  }
  
  private static void SetSupertip(DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Supertip = new StringValue { Value = value };
    else
      openXmlElement.Supertip = null;
  }
  
  /// <summary>
  /// getSupertip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetSupertip(DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu openXmlElement)
  {
    return openXmlElement?.GetSupertip?.Value;
  }
  
  private static void SetGetSupertip(DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetSupertip = new StringValue { Value = value };
    else
      openXmlElement.GetSupertip = null;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetId(DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu openXmlElement)
  {
    return openXmlElement?.QualifiedId?.Value;
  }
  
  private static void SetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.QualifiedId = new StringValue { Value = value };
    else
      openXmlElement.QualifiedId = null;
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetTag(DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }
  
  private static void SetTag(DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Tag = new StringValue { Value = value };
    else
      openXmlElement.Tag = null;
  }
  
  /// <summary>
  /// enabled, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu openXmlElement)
  {
    return openXmlElement?.Enabled?.Value;
  }
  
  private static void SetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Enabled = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Enabled = null;
  }
  
  /// <summary>
  /// getEnabled, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu openXmlElement)
  {
    return openXmlElement?.GetEnabled?.Value;
  }
  
  private static void SetGetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetEnabled = new StringValue { Value = value };
    else
      openXmlElement.GetEnabled = null;
  }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu openXmlElement)
  {
    return openXmlElement?.Label?.Value;
  }
  
  private static void SetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Label = new StringValue { Value = value };
    else
      openXmlElement.Label = null;
  }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu openXmlElement)
  {
    return openXmlElement?.GetLabel?.Value;
  }
  
  private static void SetGetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetLabel = new StringValue { Value = value };
    else
      openXmlElement.GetLabel = null;
  }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static void SetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }
  
  private static void SetGetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetVisible = new StringValue { Value = value };
    else
      openXmlElement.GetVisible = null;
  }
  
  /// <summary>
  /// image, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetImage(DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu openXmlElement)
  {
    return openXmlElement?.Image?.Value;
  }
  
  private static void SetImage(DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Image = new StringValue { Value = value };
    else
      openXmlElement.Image = null;
  }
  
  /// <summary>
  /// imageMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetImageMso(DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu openXmlElement)
  {
    return openXmlElement?.ImageMso?.Value;
  }
  
  private static void SetImageMso(DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ImageMso = new StringValue { Value = value };
    else
      openXmlElement.ImageMso = null;
  }
  
  /// <summary>
  /// getImage, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetImage(DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu openXmlElement)
  {
    return openXmlElement?.GetImage?.Value;
  }
  
  private static void SetGetImage(DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetImage = new StringValue { Value = value };
    else
      openXmlElement.GetImage = null;
  }
  
  /// <summary>
  /// keytip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu openXmlElement)
  {
    return openXmlElement?.Keytip?.Value;
  }
  
  private static void SetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Keytip = new StringValue { Value = value };
    else
      openXmlElement.Keytip = null;
  }
  
  /// <summary>
  /// getKeytip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu openXmlElement)
  {
    return openXmlElement?.GetKeytip?.Value;
  }
  
  private static void SetGetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetKeytip = new StringValue { Value = value };
    else
      openXmlElement.GetKeytip = null;
  }
  
  private static DocumentModel.BackstageMenuGroup? GetBackstageMenuGroup(DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup>();
    if (itemElement != null)
      return DocumentModel.OpenXml.BackstageMenuGroupConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBackstageMenuGroup(DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu openXmlElement, DocumentModel.BackstageMenuGroup? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.BackstageMenuGroupConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.BackstagePrimaryMenu? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.BackstagePrimaryMenu();
      value.Screentip = GetScreentip(openXmlElement);
      value.GetScreentip = GetGetScreentip(openXmlElement);
      value.Supertip = GetSupertip(openXmlElement);
      value.GetSupertip = GetGetSupertip(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.QualifiedId = GetQualifiedId(openXmlElement);
      value.Tag = GetTag(openXmlElement);
      value.Enabled = GetEnabled(openXmlElement);
      value.GetEnabled = GetGetEnabled(openXmlElement);
      value.Label = GetLabel(openXmlElement);
      value.GetLabel = GetGetLabel(openXmlElement);
      value.Visible = GetVisible(openXmlElement);
      value.GetVisible = GetGetVisible(openXmlElement);
      value.Image = GetImage(openXmlElement);
      value.ImageMso = GetImageMso(openXmlElement);
      value.GetImage = GetGetImage(openXmlElement);
      value.Keytip = GetKeytip(openXmlElement);
      value.GetKeytip = GetGetKeytip(openXmlElement);
      value.BackstageMenuGroup = GetBackstageMenuGroup(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.BackstagePrimaryMenu? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu, new()
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
      SetEnabled(openXmlElement, value?.Enabled);
      SetGetEnabled(openXmlElement, value?.GetEnabled);
      SetLabel(openXmlElement, value?.Label);
      SetGetLabel(openXmlElement, value?.GetLabel);
      SetVisible(openXmlElement, value?.Visible);
      SetGetVisible(openXmlElement, value?.GetVisible);
      SetImage(openXmlElement, value?.Image);
      SetImageMso(openXmlElement, value?.ImageMso);
      SetGetImage(openXmlElement, value?.GetImage);
      SetKeytip(openXmlElement, value?.Keytip);
      SetGetKeytip(openXmlElement, value?.GetKeytip);
      SetBackstageMenuGroup(openXmlElement, value?.BackstageMenuGroup);
      return openXmlElement;
    }
    return default;
  }
}
