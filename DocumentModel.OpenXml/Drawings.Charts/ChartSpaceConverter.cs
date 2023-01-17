namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Chart Space.
/// </summary>
public static class ChartSpaceConverter
{
  /// <summary>
  /// Date1904.
  /// </summary>
  private static Boolean? GetDate1904(DocumentFormat.OpenXml.Drawing.Charts.ChartSpace openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Date1904>();
    return itemElement != null;
  }
  
  private static void SetDate1904(DocumentFormat.OpenXml.Drawing.Charts.ChartSpace openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Date1904>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Drawing.Charts.Date1904();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// EditingLanguage.
  /// </summary>
  private static String? GetEditingLanguage(DocumentFormat.OpenXml.Drawing.Charts.ChartSpace openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.EditingLanguage>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetEditingLanguage(DocumentFormat.OpenXml.Drawing.Charts.ChartSpace openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.EditingLanguage>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.EditingLanguage { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// RoundedCorners.
  /// </summary>
  private static Boolean? GetRoundedCorners(DocumentFormat.OpenXml.Drawing.Charts.ChartSpace openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.RoundedCorners>();
    return itemElement != null;
  }
  
  private static void SetRoundedCorners(DocumentFormat.OpenXml.Drawing.Charts.ChartSpace openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.RoundedCorners>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Drawing.Charts.RoundedCorners();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Byte? GetStyle(DocumentFormat.OpenXml.Drawing.Charts.ChartSpace openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.Style>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetStyle(DocumentFormat.OpenXml.Drawing.Charts.ChartSpace openXmlElement, Byte? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.Style>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Office2010.Drawing.Charts.Style{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Charts.ColorMapOverride? GetColorMapOverride(DocumentFormat.OpenXml.Drawing.Charts.ChartSpace openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ColorMapOverride>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ColorMapOverrideConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetColorMapOverride(DocumentFormat.OpenXml.Drawing.Charts.ChartSpace openXmlElement, DocumentModel.Drawings.Charts.ColorMapOverride? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ColorMapOverride>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.ColorMapOverrideConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ColorMapOverride>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Charts.PivotSource? GetPivotSource(DocumentFormat.OpenXml.Drawing.Charts.ChartSpace openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PivotSource>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.PivotSourceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPivotSource(DocumentFormat.OpenXml.Drawing.Charts.ChartSpace openXmlElement, DocumentModel.Drawings.Charts.PivotSource? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PivotSource>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.PivotSourceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.PivotSource>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Charts.Protection? GetProtection(DocumentFormat.OpenXml.Drawing.Charts.ChartSpace openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Protection>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ProtectionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetProtection(DocumentFormat.OpenXml.Drawing.Charts.ChartSpace openXmlElement, DocumentModel.Drawings.Charts.Protection? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Protection>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.ProtectionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Protection>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Charts.Chart? GetChart(DocumentFormat.OpenXml.Drawing.Charts.ChartSpace openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Chart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ChartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetChart(DocumentFormat.OpenXml.Drawing.Charts.ChartSpace openXmlElement, DocumentModel.Drawings.Charts.Chart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Chart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.ChartConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Chart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Charts.ShapeProperties? GetShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.ChartSpace openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.ChartSpace openXmlElement, DocumentModel.Drawings.Charts.ShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.ShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Charts.TextProperties? GetTextProperties(DocumentFormat.OpenXml.Drawing.Charts.ChartSpace openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TextProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.TextPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTextProperties(DocumentFormat.OpenXml.Drawing.Charts.ChartSpace openXmlElement, DocumentModel.Drawings.Charts.TextProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TextProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.TextPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.TextProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Charts.ExternalData? GetExternalData(DocumentFormat.OpenXml.Drawing.Charts.ChartSpace openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExternalData>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ExternalDataConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExternalData(DocumentFormat.OpenXml.Drawing.Charts.ChartSpace openXmlElement, DocumentModel.Drawings.Charts.ExternalData? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExternalData>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.ExternalDataConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ExternalData>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Charts.PrintSettings? GetPrintSettings(DocumentFormat.OpenXml.Drawing.Charts.ChartSpace openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PrintSettings>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.PrintSettingsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPrintSettings(DocumentFormat.OpenXml.Drawing.Charts.ChartSpace openXmlElement, DocumentModel.Drawings.Charts.PrintSettings? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PrintSettings>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.PrintSettingsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.PrintSettings>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Charts.RelationshipIdType? GetUserShapesReference(DocumentFormat.OpenXml.Drawing.Charts.ChartSpace openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.UserShapesReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.RelationshipIdTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetUserShapesReference(DocumentFormat.OpenXml.Drawing.Charts.ChartSpace openXmlElement, DocumentModel.Drawings.Charts.RelationshipIdType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.UserShapesReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.RelationshipIdTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.UserShapesReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Charts.ChartSpaceExtensionList? GetChartSpaceExtensionList(DocumentFormat.OpenXml.Drawing.Charts.ChartSpace openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ChartSpaceExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetChartSpaceExtensionList(DocumentFormat.OpenXml.Drawing.Charts.ChartSpace openXmlElement, DocumentModel.Drawings.Charts.ChartSpaceExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.ChartSpaceExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.ChartSpace? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.ChartSpace? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ChartSpace();
      value.Date1904 = GetDate1904(openXmlElement);
      value.EditingLanguage = GetEditingLanguage(openXmlElement);
      value.RoundedCorners = GetRoundedCorners(openXmlElement);
      value.Style = GetStyle(openXmlElement);
      value.ColorMapOverride = GetColorMapOverride(openXmlElement);
      value.PivotSource = GetPivotSource(openXmlElement);
      value.Protection = GetProtection(openXmlElement);
      value.Chart = GetChart(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.TextProperties = GetTextProperties(openXmlElement);
      value.ExternalData = GetExternalData(openXmlElement);
      value.PrintSettings = GetPrintSettings(openXmlElement);
      value.UserShapesReference = GetUserShapesReference(openXmlElement);
      value.ChartSpaceExtensionList = GetChartSpaceExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.ChartSpace? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.ChartSpace, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDate1904(openXmlElement, value?.Date1904);
      SetEditingLanguage(openXmlElement, value?.EditingLanguage);
      SetRoundedCorners(openXmlElement, value?.RoundedCorners);
      SetStyle(openXmlElement, value?.Style);
      SetColorMapOverride(openXmlElement, value?.ColorMapOverride);
      SetPivotSource(openXmlElement, value?.PivotSource);
      SetProtection(openXmlElement, value?.Protection);
      SetChart(openXmlElement, value?.Chart);
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetTextProperties(openXmlElement, value?.TextProperties);
      SetExternalData(openXmlElement, value?.ExternalData);
      SetPrintSettings(openXmlElement, value?.PrintSettings);
      SetUserShapesReference(openXmlElement, value?.UserShapesReference);
      SetChartSpaceExtensionList(openXmlElement, value?.ChartSpaceExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
