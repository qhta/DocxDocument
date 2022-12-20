namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the NumericDimension Class.
/// </summary>
public partial interface NumericDimension
{
  /// <summary>
  /// type, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.NumericDimensionType? Type { get; set; }
  
  public DocumentModel.Drawings.ChartDrawings.OpenXmlFormulaElement? Formula { get; set; }
  
  public DocumentModel.Drawings.ChartDrawings.OpenXmlFormulaElement? NfFormula { get; set; }
  
  public Collection<DocumentModel.Drawings.ChartDrawings.NumericLevel>? NumericLevels { get; set; }
  
  public DocumentModel.Drawings.ChartDrawings.NumericLevel? NumericLevel { get; set; }
  
}
