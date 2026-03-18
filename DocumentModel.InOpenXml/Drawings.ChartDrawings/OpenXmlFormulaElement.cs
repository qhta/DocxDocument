namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the OpenXmlFormulaElement Class.
/// </summary>
[OpenXmlType(typeof(DXO16DCD.OpenXmlFormulaElement))]
public class OpenXmlFormulaElement: ModelElement<DXO16DCD.OpenXmlFormulaElement>
{
  /// <summary>
  /// Specifies the dir.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.OpenXmlFormulaElement.Dir))]
  public FormulaDirection? Dir { get => _Dir; set => UpdateField(ref _Dir, value, nameof(Dir)); }

  private FormulaDirection? _Dir;
}