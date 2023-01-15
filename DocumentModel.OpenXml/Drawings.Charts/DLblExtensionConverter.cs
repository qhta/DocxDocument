using DocumentFormat.OpenXml.Office2013.Drawing.Chart;
using DocumentModel.Drawings.Charts;
using DataLabelFieldTable = DocumentModel.Drawings.Charts.DataLabelFieldTable;
using DLblExtension = DocumentFormat.OpenXml.Drawing.Charts.DLblExtension;
using Layout = DocumentFormat.OpenXml.Office2013.Drawing.Chart.Layout;
using ShapeProperties = DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShapeProperties;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the DLblExtension Class.
/// </summary>
public static class DLblExtensionConverter
{
  /// <summary>
  ///   URI
  /// </summary>
  public static String? GetUri(DLblExtension? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }

  public static void SetUri(DLblExtension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }

  public static DataLabelFieldTable? GetDataLabelFieldTable(DLblExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTable>();
    if (itemElement != null)
      return DataLabelFieldTableConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDataLabelFieldTable(DLblExtension? openXmlElement, DataLabelFieldTable? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTable>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataLabelFieldTableConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTable>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetExceptionForSave(DLblExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ExceptionForSave>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetExceptionForSave(DLblExtension? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ExceptionForSave>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new ExceptionForSave();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetShowDataLabelsRange(DLblExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ShowDataLabelsRange>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetShowDataLabelsRange(DLblExtension? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ShowDataLabelsRange>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new ShowDataLabelsRange();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ShapeProperties3? GetShapeProperties(DLblExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<ShapeProperties>();
    if (itemElement != null)
      return ShapeProperties3Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShapeProperties(DLblExtension? openXmlElement, ShapeProperties3? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapeProperties3Converter.CreateOpenXmlElement<ShapeProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Layout3? GetLayout(DLblExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Layout>();
    if (itemElement != null)
      return Layout3Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLayout(DLblExtension? openXmlElement, Layout3? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Layout>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Layout3Converter.CreateOpenXmlElement<Layout>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.DLblExtension? CreateModelElement(DLblExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.DLblExtension();
      value.Uri = GetUri(openXmlElement);
      value.DataLabelFieldTable = GetDataLabelFieldTable(openXmlElement);
      value.ExceptionForSave = GetExceptionForSave(openXmlElement);
      value.ShowDataLabelsRange = GetShowDataLabelsRange(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.Layout = GetLayout(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.DLblExtension? value)
    where OpenXmlElementType : DLblExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetDataLabelFieldTable(openXmlElement, value?.DataLabelFieldTable);
      SetExceptionForSave(openXmlElement, value?.ExceptionForSave);
      SetShowDataLabelsRange(openXmlElement, value?.ShowDataLabelsRange);
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetLayout(openXmlElement, value?.Layout);
      return openXmlElement;
    }
    return default;
  }
}