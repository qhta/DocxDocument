namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the NumericDimension Class.
/// </summary>
public class NumericDimension: ModelElement
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