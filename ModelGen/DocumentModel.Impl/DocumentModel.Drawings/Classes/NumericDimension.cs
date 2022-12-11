namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NumericDimension Class.
/// </summary>
public class NumericDimensionImpl: ModelElementImpl, NumericDimension
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public NumericDimensionImpl(): base() {}
  
  public NumericDimensionImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimension openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// type, this property is only available in Office 2016 and later.
  /// </summary>
  public NumericDimensionType? Type
  {
    get => (NumericDimensionType?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimensionType?)value;
    }
  }
  
  public OpenXmlFormulaElement? Formula
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public OpenXmlFormulaElement? NfFormula
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<NumericLevel>? NumericLevels
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public NumericLevel? NumericLevel
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
