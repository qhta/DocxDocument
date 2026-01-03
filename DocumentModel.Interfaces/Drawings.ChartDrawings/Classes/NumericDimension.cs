namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the NumericDimension Class.
/// </summary>
public interface NumericDimension: IModelElement
{
  /// <summary>
  ///   type
  /// </summary>
  public NumericDimensionType? Type { get; set; }
  public OpenXmlFormulaElement? Formula { get; set; }
  public OpenXmlFormulaElement? NfFormula { get; set; }
  public Collection<NumericLevel>? NumericLevels { get; set; }
  public NumericLevel? NumericLevel { get; set; }
}