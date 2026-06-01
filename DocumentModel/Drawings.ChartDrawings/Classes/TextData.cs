namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the TextData Class.
/// </summary>
public class TextData: ModelElement
{
  public OpenXmlFormulaElement? Formula { get; set; }

  public string? VXsdstring { get; set; }
}
