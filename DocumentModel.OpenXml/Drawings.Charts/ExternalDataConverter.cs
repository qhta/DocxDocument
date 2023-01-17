namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ExternalData Class.
/// </summary>
public static class ExternalDataConverter
{
  /// <summary>
  /// Relationship Reference
  /// </summary>
  private static String? GetId(DocumentFormat.OpenXml.Drawing.Charts.ExternalData openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Drawing.Charts.ExternalData openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Update Automatically.
  /// </summary>
  private static Boolean? GetAutoUpdate(DocumentFormat.OpenXml.Drawing.Charts.ExternalData openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.AutoUpdate>();
    return itemElement != null;
  }
  
  private static void SetAutoUpdate(DocumentFormat.OpenXml.Drawing.Charts.ExternalData openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.AutoUpdate>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Drawing.Charts.AutoUpdate();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.ExternalData? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.ExternalData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ExternalData();
      value.Id = GetId(openXmlElement);
      value.AutoUpdate = GetAutoUpdate(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.ExternalData? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.ExternalData, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetAutoUpdate(openXmlElement, value?.AutoUpdate);
      return openXmlElement;
    }
    return default;
  }
}
