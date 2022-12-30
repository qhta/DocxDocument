namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the StringDimension Class.
/// </summary>
public partial class StringDimension
{
  /// <summary>
  /// type, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.StringDimensionType? Type { get; set; }
  
  public DocumentModel.Drawings.ChartDrawings.OpenXmlFormulaElement? Formula { get; set; }
  
  public DocumentModel.Drawings.ChartDrawings.OpenXmlFormulaElement? NfFormula { get; set; }
  
  public Collection<DocumentModel.Drawings.ChartDrawings.StringLevel>? StringLevels { get; set; }
  
  public DocumentModel.Drawings.ChartDrawings.StringLevel? StringLevel { get; set; }
  
}
