using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using NumericValue = DocumentModel.Drawings.ChartDrawings.NumericValue;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the NumericLevel Class.
/// </summary>
public static class NumericLevelConverter
{
  /// <summary>
  ///   ptCount, this property is only available in Office 2016 and later.
  /// </summary>
  public static UInt32? GetPtCount(NumericLevel? openXmlElement)
  {
    return openXmlElement?.PtCount?.Value;
  }

  public static void SetPtCount(NumericLevel? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.PtCount = value;
  }

  /// <summary>
  ///   formatCode, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetFormatCode(NumericLevel? openXmlElement)
  {
    return openXmlElement?.FormatCode?.Value;
  }

  public static void SetFormatCode(NumericLevel? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.FormatCode = new StringValue { Value = value };
      else
        openXmlElement.FormatCode = null;
  }

  /// <summary>
  ///   name, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetName(NumericLevel? openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }

  public static void SetName(NumericLevel? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Name = new StringValue { Value = value };
      else
        openXmlElement.Name = null;
  }

  public static Collection<NumericValue>? GetNumericValues(NumericLevel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<NumericValue>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericValue>())
      {
        var newItem = NumericValueConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetNumericValues(NumericLevel? openXmlElement, Collection<NumericValue>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericValue>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = NumericValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericValue>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.NumericLevel? CreateModelElement(NumericLevel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.NumericLevel();
      value.PtCount = GetPtCount(openXmlElement);
      value.FormatCode = GetFormatCode(openXmlElement);
      value.Name = GetName(openXmlElement);
      value.NumericValues = GetNumericValues(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.NumericLevel? value)
    where OpenXmlElementType : NumericLevel, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPtCount(openXmlElement, value?.PtCount);
      SetFormatCode(openXmlElement, value?.FormatCode);
      SetName(openXmlElement, value?.Name);
      SetNumericValues(openXmlElement, value?.NumericValues);
      return openXmlElement;
    }
    return default;
  }
}