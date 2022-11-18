namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Scenarios Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IScenario))]
public interface IScenarios // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Current Scenario
  /// </summary>
  public uint? Current { get ; set; }
  
  /// <summary>
  /// Last Shown Scenario
  /// </summary>
  public uint? Show { get ; set; }
  
  /// <summary>
  /// Sequence of References
  /// </summary>
  public List<string>? SequenceOfReferences { get ; set; }
  
}
