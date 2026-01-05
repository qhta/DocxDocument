namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the OpenXmlFormulaElement Class.
/// </summary>
public interface OpenXmlFormulaElement:
{
  /// <summary>
  ///   dir
  /// </summary>
  public FormulaDirection? Dir { get; set; }
}