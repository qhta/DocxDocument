using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using OpenXmlFormulaElement = DocumentModel.Drawings.ChartDrawings.OpenXmlFormulaElement;
using TextData = DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TextData;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the TextData Class.
/// </summary>
public static class TextDataConverter
{
  public static OpenXmlFormulaElement? GetFormula(TextData? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Formula>();
    if (itemElement != null)
      return OpenXmlFormulaElementConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFormula(TextData? openXmlElement, OpenXmlFormulaElement? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Formula>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OpenXmlFormulaElementConverter.CreateOpenXmlElement<Formula>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static String? GetVXsdstring(TextData? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<VXsdstring>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetVXsdstring(TextData? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<VXsdstring>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new VXsdstring { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.TextData? CreateModelElement(TextData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.TextData();
      value.Formula = GetFormula(openXmlElement);
      value.VXsdstring = GetVXsdstring(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.TextData? value)
    where OpenXmlElementType : TextData, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFormula(openXmlElement, value?.Formula);
      SetVXsdstring(openXmlElement, value?.VXsdstring);
      return openXmlElement;
    }
    return default;
  }
}