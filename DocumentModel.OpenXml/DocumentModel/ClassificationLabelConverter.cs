namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the ClassificationLabel Class.
/// </summary>
public static class ClassificationLabelConverter
{
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabel? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabel? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  /// <summary>
  /// enabled, this property is only available in Office 2021 and later.
  /// </summary>
  public static Boolean? GetEnabled(DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabel? openXmlElement)
  {
    return openXmlElement?.Enabled?.Value;
  }
  
  public static void SetEnabled(DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabel? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Enabled = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Enabled = null;
  }
  
  /// <summary>
  /// setDate, this property is only available in Office 2021 and later.
  /// </summary>
  public static String? GetSetDate(DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabel? openXmlElement)
  {
    return openXmlElement?.SetDate?.Value;
  }
  
  public static void SetSetDate(DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabel? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.SetDate = new StringValue { Value = value };
      else
        openXmlElement.SetDate = null;
  }
  
  /// <summary>
  /// method, this property is only available in Office 2021 and later.
  /// </summary>
  public static String? GetMethod(DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabel? openXmlElement)
  {
    return openXmlElement?.Method?.Value;
  }
  
  public static void SetMethod(DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabel? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Method = new StringValue { Value = value };
      else
        openXmlElement.Method = null;
  }
  
  /// <summary>
  /// name, this property is only available in Office 2021 and later.
  /// </summary>
  public static String? GetName(DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabel? openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  public static void SetName(DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabel? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Name = new StringValue { Value = value };
      else
        openXmlElement.Name = null;
  }
  
  /// <summary>
  /// siteId, this property is only available in Office 2021 and later.
  /// </summary>
  public static String? GetSiteId(DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabel? openXmlElement)
  {
    return openXmlElement?.SiteId?.Value;
  }
  
  public static void SetSiteId(DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabel? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.SiteId = new StringValue { Value = value };
      else
        openXmlElement.SiteId = null;
  }
  
  /// <summary>
  /// actionId, this property is only available in Office 2021 and later.
  /// </summary>
  public static String? GetActionId(DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabel? openXmlElement)
  {
    return openXmlElement?.ActionId?.Value;
  }
  
  public static void SetActionId(DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabel? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ActionId = new StringValue { Value = value };
      else
        openXmlElement.ActionId = null;
  }
  
  /// <summary>
  /// contentBits, this property is only available in Office 2021 and later.
  /// </summary>
  public static UInt32? GetContentBits(DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabel? openXmlElement)
  {
    return openXmlElement?.ContentBits?.Value;
  }
  
  public static void SetContentBits(DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabel? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.ContentBits = value;
  }
  
  /// <summary>
  /// removed, this property is only available in Office 2021 and later.
  /// </summary>
  public static Boolean? GetRemoved(DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabel? openXmlElement)
  {
    return openXmlElement?.Removed?.Value;
  }
  
  public static void SetRemoved(DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabel? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Removed = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Removed = null;
  }
  
  public static DocumentModel.ClassificationLabel? CreateModelElement(DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.ClassificationLabel();
      value.Id = GetId(openXmlElement);
      value.Enabled = GetEnabled(openXmlElement);
      value.SetDate = GetSetDate(openXmlElement);
      value.Method = GetMethod(openXmlElement);
      value.Name = GetName(openXmlElement);
      value.SiteId = GetSiteId(openXmlElement);
      value.ActionId = GetActionId(openXmlElement);
      value.ContentBits = GetContentBits(openXmlElement);
      value.Removed = GetRemoved(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.ClassificationLabel? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationLabel, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetEnabled(openXmlElement, value?.Enabled);
      SetSetDate(openXmlElement, value?.SetDate);
      SetMethod(openXmlElement, value?.Method);
      SetName(openXmlElement, value?.Name);
      SetSiteId(openXmlElement, value?.SiteId);
      SetActionId(openXmlElement, value?.ActionId);
      SetContentBits(openXmlElement, value?.ContentBits);
      SetRemoved(openXmlElement, value?.Removed);
      return openXmlElement;
    }
    return default;
  }
}
