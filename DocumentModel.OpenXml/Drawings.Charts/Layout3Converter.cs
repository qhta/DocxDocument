namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Layout Class.
/// </summary>
public static class Layout3Converter
{
  /// <summary>
  /// Manual Layout.
  /// </summary>
  public static DocumentModel.Drawings.Charts.ManualLayout? GetManualLayout(DocumentFormat.OpenXml.Office2013.Drawing.Chart.Layout? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ManualLayout>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ManualLayoutConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetManualLayout(DocumentFormat.OpenXml.Office2013.Drawing.Chart.Layout? openXmlElement, DocumentModel.Drawings.Charts.ManualLayout? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ManualLayout>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.ManualLayoutConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ManualLayout>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Office2013.Drawing.Chart.Layout? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Office2013.Drawing.Chart.Layout? openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.Layout3? CreateModelElement(DocumentFormat.OpenXml.Office2013.Drawing.Chart.Layout? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Layout3();
      value.ManualLayout = GetManualLayout(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.Layout3? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Drawing.Chart.Layout, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
