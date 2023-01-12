namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the Item Class.
/// </summary>
public static class ItemConverter
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Office2010.CustomUI.Item? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Office2010.CustomUI.Item? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.Item? openXmlElement)
  {
    return openXmlElement?.Label?.Value;
  }
  
  public static void SetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.Item? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Label = new StringValue { Value = value };
      else
        openXmlElement.Label = null;
  }
  
  /// <summary>
  /// image, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetImage(DocumentFormat.OpenXml.Office2010.CustomUI.Item? openXmlElement)
  {
    return openXmlElement?.Image?.Value;
  }
  
  public static void SetImage(DocumentFormat.OpenXml.Office2010.CustomUI.Item? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Image = new StringValue { Value = value };
      else
        openXmlElement.Image = null;
  }
  
  /// <summary>
  /// imageMso, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetImageMso(DocumentFormat.OpenXml.Office2010.CustomUI.Item? openXmlElement)
  {
    return openXmlElement?.ImageMso?.Value;
  }
  
  public static void SetImageMso(DocumentFormat.OpenXml.Office2010.CustomUI.Item? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ImageMso = new StringValue { Value = value };
      else
        openXmlElement.ImageMso = null;
  }
  
  /// <summary>
  /// screentip, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetScreentip(DocumentFormat.OpenXml.Office2010.CustomUI.Item? openXmlElement)
  {
    return openXmlElement?.Screentip?.Value;
  }
  
  public static void SetScreentip(DocumentFormat.OpenXml.Office2010.CustomUI.Item? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Screentip = new StringValue { Value = value };
      else
        openXmlElement.Screentip = null;
  }
  
  /// <summary>
  /// supertip, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetSupertip(DocumentFormat.OpenXml.Office2010.CustomUI.Item? openXmlElement)
  {
    return openXmlElement?.Supertip?.Value;
  }
  
  public static void SetSupertip(DocumentFormat.OpenXml.Office2010.CustomUI.Item? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Supertip = new StringValue { Value = value };
      else
        openXmlElement.Supertip = null;
  }
  
  public static DocumentModel.Item? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.Item? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Item();
      value.Id = GetId(openXmlElement);
      value.Label = GetLabel(openXmlElement);
      value.Image = GetImage(openXmlElement);
      value.ImageMso = GetImageMso(openXmlElement);
      value.Screentip = GetScreentip(openXmlElement);
      value.Supertip = GetSupertip(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Item? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.CustomUI.Item, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetLabel(openXmlElement, value?.Label);
      SetImage(openXmlElement, value?.Image);
      SetImageMso(openXmlElement, value?.ImageMso);
      SetScreentip(openXmlElement, value?.Screentip);
      SetSupertip(openXmlElement, value?.Supertip);
      return openXmlElement;
    }
    return default;
  }
}
