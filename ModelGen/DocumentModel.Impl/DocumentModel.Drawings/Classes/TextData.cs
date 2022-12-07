namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TextData Class.
/// </summary>
public class TextDataImpl: ModelElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TextData>, TextData
{
  public OpenXmlFormulaElement? Formula
  {
    get;
    set;
  }
  
}
