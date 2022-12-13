namespace DocumentModel.Drawings16.Charts;

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
  
  public OpenXmlFormulaElementImpl(): base() {}
  
  public OpenXmlFormulaElementImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlFormulaElement openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// dir, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings16.Charts.FormulaDirection? Dir
  {
    get => (DocumentModel.Drawings16.Charts.FormulaDirection?)OpenXmlElement?.Dir?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Dir = (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormulaDirection?)value;
    }
  }
  
}
