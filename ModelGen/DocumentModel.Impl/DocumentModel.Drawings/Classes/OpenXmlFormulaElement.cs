namespace DocumentModel.Drawings;

/// <summary>
/// Defines the OpenXmlFormulaElement Class.
/// </summary>
public class OpenXmlFormulaElementImpl: ModelElementImpl, OpenXmlFormulaElement
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlFormulaElement? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlFormulaElement?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// dir, this property is only available in Office 2016 and later.
  /// </summary>
  public FormulaDirection? Dir
  {
    get => (FormulaDirection?)OpenXmlElement?.Dir?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Dir = (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormulaDirection?)value;
    }
  }
  
}
