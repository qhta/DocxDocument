namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the TextData Class.
/// </summary>
public static class TextDataConverter
{
  public static DocumentModel.Drawings.ChartDrawings.OpenXmlFormulaElement? GetFormula(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TextData? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Formula>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.OpenXmlFormulaElementConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFormula(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TextData? openXmlElement, DocumentModel.Drawings.ChartDrawings.OpenXmlFormulaElement? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Formula>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.OpenXmlFormulaElementConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Formula>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static String? GetVXsdstring(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TextData? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.VXsdstring>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  public static void SetVXsdstring(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TextData? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.VXsdstring>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.VXsdstring { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.TextData? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TextData? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TextData, new()
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
