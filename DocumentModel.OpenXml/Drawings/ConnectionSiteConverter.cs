namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Shape Connection Site.
/// </summary>
public static class ConnectionSiteConverter
{
  /// <summary>
  /// Connection Site Angle
  /// </summary>
  public static String? GetAngle(DocumentFormat.OpenXml.Drawing.ConnectionSite? openXmlElement)
  {
    return openXmlElement?.Angle?.Value;
  }
  
  public static void SetAngle(DocumentFormat.OpenXml.Drawing.ConnectionSite? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Angle = new StringValue { Value = value };
      else
        openXmlElement.Angle = null;
  }
  
  /// <summary>
  /// Position.
  /// </summary>
  public static DocumentModel.Drawings.AdjustPoint2DType? GetPosition(DocumentFormat.OpenXml.Drawing.ConnectionSite? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Position>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.AdjustPoint2DTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPosition(DocumentFormat.OpenXml.Drawing.ConnectionSite? openXmlElement, DocumentModel.Drawings.AdjustPoint2DType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Position>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.AdjustPoint2DTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Position>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ConnectionSite? CreateModelElement(DocumentFormat.OpenXml.Drawing.ConnectionSite? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ConnectionSite();
      value.Angle = GetAngle(openXmlElement);
      value.Position = GetPosition(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ConnectionSite? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.ConnectionSite, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAngle(openXmlElement, value?.Angle);
      SetPosition(openXmlElement, value?.Position);
      return openXmlElement;
    }
    return default;
  }
}
