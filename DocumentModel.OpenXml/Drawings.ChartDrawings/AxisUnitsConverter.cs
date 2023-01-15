using DocumentModel.Drawings.ChartDrawings;
using AxisUnits = DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnits;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the AxisUnits Class.
/// </summary>
public static class AxisUnitsConverter
{
  /// <summary>
  ///   unit, this property is only available in Office 2016 and later.
  /// </summary>
  public static AxisUnit? GetUnit(AxisUnits? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnit, AxisUnit>(openXmlElement?.Unit?.Value);
  }

  public static void SetUnit(AxisUnits? openXmlElement, AxisUnit? value)
  {
    if (openXmlElement != null)
      openXmlElement.Unit = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnit, AxisUnit>(value);
  }

  /// <summary>
  ///   AxisUnitsLabel.
  /// </summary>
  public static AxisUnitsLabel? GetAxisUnitsLabel(AxisUnits? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnitsLabel>();
    if (itemElement != null)
      return AxisUnitsLabelConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAxisUnitsLabel(AxisUnits? openXmlElement, AxisUnitsLabel? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnitsLabel>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AxisUnitsLabelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnitsLabel>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.ExtensionList? GetExtensionList(AxisUnits? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(AxisUnits? openXmlElement, DocumentModel.Drawings.ChartDrawings.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.AxisUnits? CreateModelElement(AxisUnits? openXmlElement)
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
    where OpenXmlElementType : AxisUnits, new()
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