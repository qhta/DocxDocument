namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the NumericDimension Class.
/// </summary>
public record NumericDimension
{
  /// <summary>
  ///   type, this property is only available in Office 2016 and later.
  /// </summary>
  public NumericDimensionType? Type { get; set; }

  public OpenXmlFormulaElement? Formula { get; set; }

  public OpenXmlFormulaElement? NfFormula { get; set; }

  public Collection<NumericLevel>? NumericLevels { get; set; }

  public NumericLevel? NumericLevel { get; set; }
}