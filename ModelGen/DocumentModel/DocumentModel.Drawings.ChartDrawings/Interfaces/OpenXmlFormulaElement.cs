namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the OpenXmlFormulaElement Class.
/// </summary>
public partial interface OpenXmlFormulaElement
{
  /// <summary>
  /// dir, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.FormulaDirection? Dir { get; set; }
  
}
