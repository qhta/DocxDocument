using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using NumericDimension = DocumentModel.Drawings.ChartDrawings.NumericDimension;
using StringDimension = DocumentModel.Drawings.ChartDrawings.StringDimension;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the Data Class.
/// </summary>
public static class DataConverter
{
  /// <summary>
  ///   id, this property is only available in Office 2016 and later.
  /// </summary>
  public static UInt32? GetId(Data? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(Data? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Id = value;
  }

  public static NumericDimension? GetNumericDimension(Data? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimension>();
    if (itemElement != null)
      return NumericDimensionConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNumericDimension(Data? openXmlElement, NumericDimension? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimension>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumericDimensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimension>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static StringDimension? GetStringDimension(Data? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimension>();
    if (itemElement != null)
      return StringDimensionConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetStringDimension(Data? openXmlElement, StringDimension? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimension>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StringDimensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimension>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.ExtensionList? GetExtensionList(Data? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(Data? openXmlElement, DocumentModel.Drawings.ChartDrawings.ExtensionList? value)
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

  public static DocumentModel.Drawings.ChartDrawings.Data? CreateModelElement(Data? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.Data();
      value.Id = GetId(openXmlElement);
      value.NumericDimension = GetNumericDimension(openXmlElement);
      value.StringDimension = GetStringDimension(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.Data? value)
    where OpenXmlElementType : Data, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetNumericDimension(openXmlElement, value?.NumericDimension);
      SetStringDimension(openXmlElement, value?.StringDimension);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}