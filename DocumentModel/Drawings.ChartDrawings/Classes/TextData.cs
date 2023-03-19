namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the TextData Class.
/// </summary>
public class TextData: ModelElement
{
  public OpenXmlFormulaElement? Formula { get; set; }

  public String? VXsdstring { get; set; }
}