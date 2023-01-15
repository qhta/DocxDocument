using DocumentModel.Drawings.ChartDrawings;
using ChartData = DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartData;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the ChartData Class.
/// </summary>
public static class ChartDataConverter
{
  /// <summary>
  ///   ExternalData.
  /// </summary>
  public static ExternalData? GetExternalData(ChartData? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExternalData>();
    if (itemElement != null)
      return ExternalDataConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExternalData(ChartData? openXmlElement, ExternalData? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExternalData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExternalDataConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExternalData>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Data? GetData(ChartData? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Data>();
    if (itemElement != null)
      return DataConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetData(ChartData? openXmlElement, Data? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Data>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Data>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.ExtensionList? GetExtensionList(ChartData? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(ChartData? openXmlElement, DocumentModel.Drawings.ChartDrawings.ExtensionList? value)
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

  public static DocumentModel.Drawings.ChartDrawings.ChartData? CreateModelElement(ChartData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.ChartData();
      value.ExternalData = GetExternalData(openXmlElement);
      value.Data = GetData(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.ChartData? value)
    where OpenXmlElementType : ChartData, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExternalData(openXmlElement, value?.ExternalData);
      SetData(openXmlElement, value?.Data);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}