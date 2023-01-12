namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the TextSpacingType Class.
/// </summary>
public static class TextSpacingTypeConverter
{
  /// <summary>
  /// Spacing Percent.
  /// </summary>
  public static Int32? GetSpacingPercent(DocumentFormat.OpenXml.Drawing.TextSpacingType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SpacingPercent>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetSpacingPercent(DocumentFormat.OpenXml.Drawing.TextSpacingType? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SpacingPercent>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Drawing.SpacingPercent{ Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Spacing Points.
  /// </summary>
  public static Int32? GetSpacingPoints(DocumentFormat.OpenXml.Drawing.TextSpacingType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SpacingPoints>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetSpacingPoints(DocumentFormat.OpenXml.Drawing.TextSpacingType? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SpacingPoints>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Drawing.SpacingPoints{ Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.TextSpacingType? CreateModelElement(DocumentFormat.OpenXml.Drawing.TextSpacingType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.TextSpacingType();
      value.SpacingPercent = GetSpacingPercent(openXmlElement);
      value.SpacingPoints = GetSpacingPoints(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.TextSpacingType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.TextSpacingType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSpacingPercent(openXmlElement, value?.SpacingPercent);
      SetSpacingPoints(openXmlElement, value?.SpacingPoints);
      return openXmlElement;
    }
    return default;
  }
}
