namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Starting Anchor Point.
/// </summary>
public static class FromAnchorConverter
{
  public static String? GetXPosition(DocumentFormat.OpenXml.Drawing.ChartDrawing.FromAnchor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.XPosition>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  public static void SetXPosition(DocumentFormat.OpenXml.Drawing.ChartDrawing.FromAnchor? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.XPosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Drawing.ChartDrawing.XPosition { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static String? GetYPosition(DocumentFormat.OpenXml.Drawing.ChartDrawing.FromAnchor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.YPosition>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  public static void SetYPosition(DocumentFormat.OpenXml.Drawing.ChartDrawing.FromAnchor? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.YPosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Drawing.ChartDrawing.YPosition { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawing.FromAnchor? CreateModelElement(DocumentFormat.OpenXml.Drawing.ChartDrawing.FromAnchor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.FromAnchor();
      value.XPosition = GetXPosition(openXmlElement);
      value.YPosition = GetYPosition(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawing.FromAnchor? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.ChartDrawing.FromAnchor, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
