namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the TextData Class.
/// </summary>
public interface TextData
{
  public OpenXmlFormulaElement? Formula { get; set; }
  public string? VXsdString { get; set; }
}