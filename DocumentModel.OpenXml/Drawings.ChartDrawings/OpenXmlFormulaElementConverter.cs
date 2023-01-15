using DocumentModel.Drawings.ChartDrawings;
using OpenXmlFormulaElement = DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlFormulaElement;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the OpenXmlFormulaElement Class.
/// </summary>
public static class OpenXmlFormulaElementConverter
{
  /// <summary>
  ///   dir, this property is only available in Office 2016 and later.
  /// </summary>
  public static FormulaDirection? GetDir(OpenXmlFormulaElement? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormulaDirection, FormulaDirection>(openXmlElement?.Dir?.Value);
  }

  public static void SetDir(OpenXmlFormulaElement? openXmlElement, FormulaDirection? value)
  {
    if (openXmlElement != null)
      openXmlElement.Dir = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormulaDirection, FormulaDirection>(value);
  }

  public static DocumentModel.Drawings.ChartDrawings.OpenXmlFormulaElement? CreateModelElement(OpenXmlFormulaElement? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.OpenXmlFormulaElement();
      value.Dir = GetDir(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.OpenXmlFormulaElement? value)
    where OpenXmlElementType : OpenXmlFormulaElement, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDir(openXmlElement, value?.Dir);
      return openXmlElement;
    }
    return default;
  }
}