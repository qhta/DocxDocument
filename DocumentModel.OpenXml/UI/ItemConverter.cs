namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the Item Class.
/// </summary>
public static class ItemConverter
{
  /// <summary>
  /// id
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Office.CustomUI.Item? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Office.CustomUI.Item? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  /// <summary>
  /// label
  /// </summary>
  public static String? GetLabel(DocumentFormat.OpenXml.Office.CustomUI.Item? openXmlElement)
  {
    return openXmlElement?.Label?.Value;
  }
  
  public static void SetLabel(DocumentFormat.OpenXml.Office.CustomUI.Item? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Label = new StringValue { Value = value };
      else
        openXmlElement.Label = null;
  }
  
  /// <summary>
  /// image
  /// </summary>
  public static String? GetImage(DocumentFormat.OpenXml.Office.CustomUI.Item? openXmlElement)
  {
    return openXmlElement?.Image?.Value;
  }
  
  public static void SetImage(DocumentFormat.OpenXml.Office.CustomUI.Item? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Image = new StringValue { Value = value };
      else
        openXmlElement.Image = null;
  }
  
  /// <summary>
  /// imageMso
  /// </summary>
  public static String? GetImageMso(DocumentFormat.OpenXml.Office.CustomUI.Item? openXmlElement)
  {
    return openXmlElement?.ImageMso?.Value;
  }
  
  public static void SetImageMso(DocumentFormat.OpenXml.Office.CustomUI.Item? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ImageMso = new StringValue { Value = value };
      else
        openXmlElement.ImageMso = null;
  }
  
  /// <summary>
  /// screentip
  /// </summary>
  public static String? GetScreentip(DocumentFormat.OpenXml.Office.CustomUI.Item? openXmlElement)
  {
    return openXmlElement?.Screentip?.Value;
  }
  
  public static void SetScreentip(DocumentFormat.OpenXml.Office.CustomUI.Item? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Screentip = new StringValue { Value = value };
      else
        openXmlElement.Screentip = null;
  }
  
  /// <summary>
  /// supertip
  /// </summary>
  public static String? GetSupertip(DocumentFormat.OpenXml.Office.CustomUI.Item? openXmlElement)
  {
    return openXmlElement?.Supertip?.Value;
  }
  
  public static void SetSupertip(DocumentFormat.OpenXml.Office.CustomUI.Item? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Supertip = new StringValue { Value = value };
      else
        openXmlElement.Supertip = null;
  }
  
  public static DocumentModel.UI.Item? CreateModelElement(DocumentFormat.OpenXml.Office.CustomUI.Item? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.UI.Item();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.UI.Item? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.CustomUI.Item, new()
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
