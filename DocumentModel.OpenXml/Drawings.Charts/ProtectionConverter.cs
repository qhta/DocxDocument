namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Protection Class.
/// </summary>
public static class ProtectionConverter
{
  /// <summary>
  /// Chart Object.
  /// </summary>
  private static Boolean? GetChartObject(DocumentFormat.OpenXml.Drawing.Charts.Protection openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartObject>();
    return itemElement != null;
  }
  
  private static void SetChartObject(DocumentFormat.OpenXml.Drawing.Charts.Protection openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartObject>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Drawing.Charts.ChartObject();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Data Cannot Be Changed.
  /// </summary>
  private static Boolean? GetData(DocumentFormat.OpenXml.Drawing.Charts.Protection openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Data>();
    return itemElement != null;
  }
  
  private static void SetData(DocumentFormat.OpenXml.Drawing.Charts.Protection openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Data>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Drawing.Charts.Data();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Formatting.
  /// </summary>
  private static Boolean? GetFormatting(DocumentFormat.OpenXml.Drawing.Charts.Protection openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Formatting>();
    return itemElement != null;
  }
  
  private static void SetFormatting(DocumentFormat.OpenXml.Drawing.Charts.Protection openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Formatting>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Drawing.Charts.Formatting();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Selection.
  /// </summary>
  private static Boolean? GetSelection(DocumentFormat.OpenXml.Drawing.Charts.Protection openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Selection>();
    return itemElement != null;
  }
  
  private static void SetSelection(DocumentFormat.OpenXml.Drawing.Charts.Protection openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Selection>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Drawing.Charts.Selection();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// User Interface.
  /// </summary>
  private static Boolean? GetUserInterface(DocumentFormat.OpenXml.Drawing.Charts.Protection openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.UserInterface>();
    return itemElement != null;
  }
  
  private static void SetUserInterface(DocumentFormat.OpenXml.Drawing.Charts.Protection openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.UserInterface>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Drawing.Charts.UserInterface();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.Protection? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.Protection? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Protection();
      value.ChartObject = GetChartObject(openXmlElement);
      value.Data = GetData(openXmlElement);
      value.Formatting = GetFormatting(openXmlElement);
      value.Selection = GetSelection(openXmlElement);
      value.UserInterface = GetUserInterface(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.Protection? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.Protection, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetChartObject(openXmlElement, value?.ChartObject);
      SetData(openXmlElement, value?.Data);
      SetFormatting(openXmlElement, value?.Formatting);
      SetSelection(openXmlElement, value?.Selection);
      SetUserInterface(openXmlElement, value?.UserInterface);
      return openXmlElement;
    }
    return default;
  }
}
