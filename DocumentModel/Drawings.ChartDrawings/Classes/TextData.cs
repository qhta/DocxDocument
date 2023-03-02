namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the TextData Class.
/// </summary>
public record TextData
{
  public OpenXmlFormulaElement? Formula { get; set; }

  public String? VXsdstring { get; set; }
}