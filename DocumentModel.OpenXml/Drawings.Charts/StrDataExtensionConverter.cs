namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the StrDataExtension Class.
/// </summary>
public static class StrDataExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  public static String? GetUri(DocumentFormat.OpenXml.Drawing.Charts.StrDataExtension? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  public static void SetUri(DocumentFormat.OpenXml.Drawing.Charts.StrDataExtension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }
  
  public static Boolean? GetAutoGeneneratedCategories(DocumentFormat.OpenXml.Drawing.Charts.StrDataExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.AutoGeneneratedCategories>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetAutoGeneneratedCategories(DocumentFormat.OpenXml.Drawing.Charts.StrDataExtension? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.AutoGeneneratedCategories>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Office2013.Drawing.Chart.AutoGeneneratedCategories();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.StrDataExtension? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.StrDataExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.StrDataExtension();
      value.Uri = GetUri(openXmlElement);
      value.AutoGeneneratedCategories = GetAutoGeneneratedCategories(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.StrDataExtension? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.StrDataExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetAutoGeneneratedCategories(openXmlElement, value?.AutoGeneneratedCategories);
      return openXmlElement;
    }
    return default;
  }
}
