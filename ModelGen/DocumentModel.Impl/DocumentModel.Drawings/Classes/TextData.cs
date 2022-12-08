namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TextData Class.
/// </summary>
public class TextDataImpl: ModelElementImpl, TextData
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TextData? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TextData?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public OpenXmlFormulaElement? Formula
  {
    get;
    set;
  }
  
  public String? VXsdstring
  {
    get;
    set;
  }
  
}
