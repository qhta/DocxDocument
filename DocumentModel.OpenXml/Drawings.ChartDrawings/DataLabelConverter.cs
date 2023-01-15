using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using DataLabelPos = DocumentModel.Drawings.ChartDrawings.DataLabelPos;
using DataLabelVisibilities = DocumentModel.Drawings.ChartDrawings.DataLabelVisibilities;
using NumberFormat = DocumentModel.Drawings.ChartDrawings.NumberFormat;
using ShapeProperties = DocumentModel.Drawings.ChartDrawings.ShapeProperties;
using TxPrTextBody = DocumentModel.Drawings.ChartDrawings.TxPrTextBody;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the DataLabel Class.
/// </summary>
public static class DataLabelConverter
{
  /// <summary>
  ///   idx, this property is only available in Office 2016 and later.
  /// </summary>
  public static UInt32? GetIdx(DataLabel? openXmlElement)
  {
    return openXmlElement?.Idx?.Value;
  }

  public static void SetIdx(DataLabel? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Idx = value;
  }

  /// <summary>
  ///   pos, this property is only available in Office 2016 and later.
  /// </summary>
  public static DataLabelPos? GetPos(DataLabel? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelPos, DataLabelPos>(openXmlElement?.Pos?.Value);
  }

  public static void SetPos(DataLabel? openXmlElement, DataLabelPos? value)
  {
    if (openXmlElement != null)
      openXmlElement.Pos = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelPos, DataLabelPos>(value);
  }

  /// <summary>
  ///   NumberFormat.
  /// </summary>
  public static NumberFormat? GetNumberFormat(DataLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberFormat>();
    if (itemElement != null)
      return NumberFormatConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNumberFormat(DataLabel? openXmlElement, NumberFormat? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberFormat>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumberFormatConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberFormat>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  public static ShapeProperties? GetShapeProperties(DataLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
    if (itemElement != null)
      return ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShapeProperties(DataLabel? openXmlElement, ShapeProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   TxPrTextBody.
  /// </summary>
  public static TxPrTextBody? GetTxPrTextBody(DataLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody>();
    if (itemElement != null)
      return TxPrTextBodyConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTxPrTextBody(DataLabel? openXmlElement, TxPrTextBody? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TxPrTextBodyConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   DataLabelVisibilities.
  /// </summary>
  public static DataLabelVisibilities? GetDataLabelVisibilities(DataLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelVisibilities>();
    if (itemElement != null)
      return DataLabelVisibilitiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDataLabelVisibilities(DataLabel? openXmlElement, DataLabelVisibilities? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelVisibilities>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataLabelVisibilitiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelVisibilities>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   SeparatorXsdstring.
  /// </summary>
  public static String? GetSeparatorXsdstring(DataLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<SeparatorXsdstring>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetSeparatorXsdstring(DataLabel? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SeparatorXsdstring>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new SeparatorXsdstring { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.ExtensionList? GetExtensionList(DataLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(DataLabel? openXmlElement, DocumentModel.Drawings.ChartDrawings.ExtensionList? value)
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

  public static DocumentModel.Drawings.ChartDrawings.DataLabel? CreateModelElement(DataLabel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.DataLabel();
      value.Idx = GetIdx(openXmlElement);
      value.Pos = GetPos(openXmlElement);
      value.NumberFormat = GetNumberFormat(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.TxPrTextBody = GetTxPrTextBody(openXmlElement);
      value.DataLabelVisibilities = GetDataLabelVisibilities(openXmlElement);
      value.SeparatorXsdstring = GetSeparatorXsdstring(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.DataLabel? value)
    where OpenXmlElementType : DataLabel, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetIdx(openXmlElement, value?.Idx);
      SetPos(openXmlElement, value?.Pos);
      SetNumberFormat(openXmlElement, value?.NumberFormat);
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetTxPrTextBody(openXmlElement, value?.TxPrTextBody);
      SetDataLabelVisibilities(openXmlElement, value?.DataLabelVisibilities);
      SetSeparatorXsdstring(openXmlElement, value?.SeparatorXsdstring);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}