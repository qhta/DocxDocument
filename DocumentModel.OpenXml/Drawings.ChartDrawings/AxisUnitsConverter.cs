namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the AxisUnits Class.
/// </summary>
public static class AxisUnitsConverter
{
  /// <summary>
  /// unit, this property is only available in Office 2016 and later.
  /// </summary>
  private static DocumentModel.Drawings.ChartDrawings.AxisUnit? GetUnit(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnits openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnit, DocumentModel.Drawings.ChartDrawings.AxisUnit>(openXmlElement?.Unit?.Value);
  }
  
  private static void SetUnit(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnits openXmlElement, DocumentModel.Drawings.ChartDrawings.AxisUnit? value)
  {
    openXmlElement.Unit = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnit, DocumentModel.Drawings.ChartDrawings.AxisUnit>(value);
  }
  
  /// <summary>
  /// AxisUnitsLabel.
  /// </summary>
  private static DocumentModel.Drawings.ChartDrawings.AxisUnitsLabel? GetAxisUnitsLabel(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnits openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnitsLabel>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.AxisUnitsLabelConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAxisUnitsLabel(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnits openXmlElement, DocumentModel.Drawings.ChartDrawings.AxisUnitsLabel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnitsLabel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.AxisUnitsLabelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnitsLabel>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DocumentModel.Drawings.ChartDrawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnits openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnits openXmlElement, DocumentModel.Drawings.ChartDrawings.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.AxisUnits? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnits? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.AxisUnits();
      value.Unit = GetUnit(openXmlElement);
      value.AxisUnitsLabel = GetAxisUnitsLabel(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.AxisUnits? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnits, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUnit(openXmlElement, value?.Unit);
      SetAxisUnitsLabel(openXmlElement, value?.AxisUnitsLabel);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
