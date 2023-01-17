namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the SketchOptions Class.
/// </summary>
public static class SketchOptionsConverter
{
  /// <summary>
  /// InSketchMode.
  /// </summary>
  private static Boolean? GetInSketchMode(DocumentFormat.OpenXml.Office2010.Drawing.Charts.SketchOptions openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.InSketchMode>();
    return itemElement != null;
  }
  
  private static void SetInSketchMode(DocumentFormat.OpenXml.Office2010.Drawing.Charts.SketchOptions openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.InSketchMode>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Office2010.Drawing.Charts.InSketchMode();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ShowSketchButton.
  /// </summary>
  private static Boolean? GetShowSketchButton(DocumentFormat.OpenXml.Office2010.Drawing.Charts.SketchOptions openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.ShowSketchButton>();
    return itemElement != null;
  }
  
  private static void SetShowSketchButton(DocumentFormat.OpenXml.Office2010.Drawing.Charts.SketchOptions openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.ShowSketchButton>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Office2010.Drawing.Charts.ShowSketchButton();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.SketchOptions? CreateModelElement(DocumentFormat.OpenXml.Office2010.Drawing.Charts.SketchOptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.SketchOptions();
      value.InSketchMode = GetInSketchMode(openXmlElement);
      value.ShowSketchButton = GetShowSketchButton(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.SketchOptions? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Drawing.Charts.SketchOptions, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetInSketchMode(openXmlElement, value?.InSketchMode);
      SetShowSketchButton(openXmlElement, value?.ShowSketchButton);
      return openXmlElement;
    }
    return default;
  }
}
