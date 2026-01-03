namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the TextData Class.
/// </summary>
public interface TextData: IModelElement
{
  public OpenXmlFormulaElement? Formula { get; set; }
  public string? VXsdstring { get; set; }
}