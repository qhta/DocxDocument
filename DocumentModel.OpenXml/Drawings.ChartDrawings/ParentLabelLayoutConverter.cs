using DocumentModel.Drawings.ChartDrawings;
using ParentLabelLayout = DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ParentLabelLayout;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the ParentLabelLayout Class.
/// </summary>
public static class ParentLabelLayoutConverter
{
  /// <summary>
  ///   val, this property is only available in Office 2016 and later.
  /// </summary>
  public static ParentLabelLayoutVal? GetParentLabelLayoutVal(ParentLabelLayout? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ParentLabelLayoutVal, ParentLabelLayoutVal>(openXmlElement?.ParentLabelLayoutVal?.Value);
  }

  public static void SetParentLabelLayoutVal(ParentLabelLayout? openXmlElement, ParentLabelLayoutVal? value)
  {
    if (openXmlElement != null)
      openXmlElement.ParentLabelLayoutVal = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ParentLabelLayoutVal, ParentLabelLayoutVal>(value);
  }

  public static DocumentModel.Drawings.ChartDrawings.ParentLabelLayout? CreateModelElement(ParentLabelLayout? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.ParentLabelLayout();
      value.ParentLabelLayoutVal = GetParentLabelLayoutVal(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.ParentLabelLayout? value)
    where OpenXmlElementType : ParentLabelLayout, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetParentLabelLayoutVal(openXmlElement, value?.ParentLabelLayoutVal);
      return openXmlElement;
    }
    return default;
  }
}