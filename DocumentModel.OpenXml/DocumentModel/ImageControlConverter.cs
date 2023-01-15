namespace DocumentModel.OpenXml;

/// <summary>
///   Defines the ImageControl Class.
/// </summary>
public static class ImageControlConverter
{
  /// <summary>
  ///   id, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  /// <summary>
  ///   idQ, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl? openXmlElement)
  {
    return openXmlElement?.QualifiedId?.Value;
  }

  public static void SetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.QualifiedId = new StringValue { Value = value };
      else
        openXmlElement.QualifiedId = null;
  }

  /// <summary>
  ///   tag, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetTag(DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl? openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }

  public static void SetTag(DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Tag = new StringValue { Value = value };
      else
        openXmlElement.Tag = null;
  }

  /// <summary>
  ///   enabled, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl? openXmlElement)
  {
    return openXmlElement?.Enabled?.Value;
  }

  public static void SetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Enabled = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Enabled = null;
  }

  /// <summary>
  ///   getEnabled, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl? openXmlElement)
  {
    return openXmlElement?.GetEnabled?.Value;
  }

  public static void SetGetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetEnabled = new StringValue { Value = value };
      else
        openXmlElement.GetEnabled = null;
  }

  /// <summary>
  ///   visible, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl? openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }

  public static void SetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Visible = null;
  }

  /// <summary>
  ///   getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl? openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }

  public static void SetGetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetVisible = new StringValue { Value = value };
      else
        openXmlElement.GetVisible = null;
  }

  /// <summary>
  ///   image, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetImage(DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl? openXmlElement)
  {
    return openXmlElement?.Image?.Value;
  }

  public static void SetImage(DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Image = new StringValue { Value = value };
      else
        openXmlElement.Image = null;
  }

  /// <summary>
  ///   imageMso, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetImageMso(DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl? openXmlElement)
  {
    return openXmlElement?.ImageMso?.Value;
  }

  public static void SetImageMso(DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ImageMso = new StringValue { Value = value };
      else
        openXmlElement.ImageMso = null;
  }

  /// <summary>
  ///   getImage, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetImage(DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl? openXmlElement)
  {
    return openXmlElement?.GetImage?.Value;
  }

  public static void SetGetImage(DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetImage = new StringValue { Value = value };
      else
        openXmlElement.GetImage = null;
  }

  /// <summary>
  ///   altText, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetAltText(DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl? openXmlElement)
  {
    return openXmlElement?.AltText?.Value;
  }

  public static void SetAltText(DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AltText = new StringValue { Value = value };
      else
        openXmlElement.AltText = null;
  }

  /// <summary>
  ///   getAltText, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetAltText(DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl? openXmlElement)
  {
    return openXmlElement?.GetAltText?.Value;
  }

  public static void SetGetAltText(DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetAltText = new StringValue { Value = value };
      else
        openXmlElement.GetAltText = null;
  }

  public static ImageControl? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new ImageControl();
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(ImageControl? value)
    where OpenXmlElementType : DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl, new()
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