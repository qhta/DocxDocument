namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Scenarios Class.
/// </summary>
public interface IScenarios // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Current Scenario
  /// </summary>
  public UInt32? Current { get ; set; }
  
  /// <summary>
  /// Last Shown Scenario
  /// </summary>
  public UInt32? Show { get ; set; }
  
  /// <summary>
  /// Sequence of References
  /// </summary>
  public List<String>? SequenceOfReferences { get ; set; }
  
  public Collection<IScenario>? Scenarios { get ; set; }
  
}
