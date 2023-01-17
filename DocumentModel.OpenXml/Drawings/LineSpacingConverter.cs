namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Line Spacing.
/// </summary>
public static class LineSpacingConverter
{
  private static Int32? GetSpacingPercent(DocumentFormat.OpenXml.Drawing.LineSpacing openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SpacingPercent>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetSpacingPercent(DocumentFormat.OpenXml.Drawing.LineSpacing openXmlElement, Int32? value)
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
  
  private static Int32? GetSpacingPoints(DocumentFormat.OpenXml.Drawing.LineSpacing openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SpacingPoints>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetSpacingPoints(DocumentFormat.OpenXml.Drawing.LineSpacing openXmlElement, Int32? value)
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
  
  public static DocumentModel.Drawings.LineSpacing? CreateModelElement(DocumentFormat.OpenXml.Drawing.LineSpacing? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.LineSpacing();
      value.SpacingPercent = GetSpacingPercent(openXmlElement);
      value.SpacingPoints = GetSpacingPoints(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.LineSpacing? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.LineSpacing, new()
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
