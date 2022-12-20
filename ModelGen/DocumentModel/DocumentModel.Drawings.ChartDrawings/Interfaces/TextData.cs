namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the TextData Class.
/// </summary>
public partial interface TextData
{
  public DocumentModel.Drawings.ChartDrawings.OpenXmlFormulaElement? Formula { get; set; }
  
  public String? VXsdstring { get; set; }
  
}
