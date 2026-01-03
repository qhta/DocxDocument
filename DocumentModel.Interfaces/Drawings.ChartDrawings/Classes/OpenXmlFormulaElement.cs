namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the OpenXmlFormulaElement Class.
/// </summary>
public interface OpenXmlFormulaElement: IModelElement
{
  /// <summary>
  ///   dir
  /// </summary>
  public FormulaDirection? Dir { get; set; }
}