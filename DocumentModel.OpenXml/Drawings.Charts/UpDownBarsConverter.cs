namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the UpDownBars Class.
/// </summary>
public static class UpDownBarsConverter
{
  /// <summary>
  /// Gap Width.
  /// </summary>
  public static UInt16? GetGapWidth(DocumentFormat.OpenXml.Drawing.Charts.UpDownBars? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.GapWidth");
  }
  
  public static void SetGapWidth(DocumentFormat.OpenXml.Drawing.Charts.UpDownBars? openXmlElement, UInt16? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.GapWidth");
  }
  
  /// <summary>
  /// Up Bars.
  /// </summary>
  public static DocumentModel.Drawings.Charts.UpBars? GetUpBars(DocumentFormat.OpenXml.Drawing.Charts.UpDownBars? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.UpBars>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.UpBarsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetUpBars(DocumentFormat.OpenXml.Drawing.Charts.UpDownBars? openXmlElement, DocumentModel.Drawings.Charts.UpBars? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.UpBars>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.UpBarsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.UpBars>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Down Bars.
  /// </summary>
  public static DocumentModel.Drawings.Charts.DownBars? GetDownBars(DocumentFormat.OpenXml.Drawing.Charts.UpDownBars? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DownBars>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.DownBarsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDownBars(DocumentFormat.OpenXml.Drawing.Charts.UpDownBars? openXmlElement, DocumentModel.Drawings.Charts.DownBars? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DownBars>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.DownBarsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DownBars>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.UpDownBars? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.UpDownBars? openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.Charts.UpDownBars? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.UpDownBars? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.UpDownBars();
      value.GapWidth = GetGapWidth(openXmlElement);
      value.UpBars = GetUpBars(openXmlElement);
      value.DownBars = GetDownBars(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.UpDownBars? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.UpDownBars, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
