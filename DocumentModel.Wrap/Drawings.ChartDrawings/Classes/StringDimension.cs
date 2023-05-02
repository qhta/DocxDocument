namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the StringDimension Class.
/// </summary>
public class StringDimension: ModelElement
{
  /// <summary>
  ///   type, this property is only available in Office 2016 and later.
  /// </summary>
  public StringDimensionType? Type { get; set; }

  public OpenXmlFormulaElement? Formula { get; set; }

  public OpenXmlFormulaElement? NfFormula { get; set; }

  public Collection<StringLevel>? StringLevels { get; set; }

  public StringLevel? StringLevel { get; set; }
}