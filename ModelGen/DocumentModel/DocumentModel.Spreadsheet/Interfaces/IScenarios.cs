namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Scenarios Class.
/// </summary>
public interface IScenarios // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Current Scenario
  /// </summary>
  public System.UInt32? Current { get ; set; }
  
  /// <summary>
  /// Last Shown Scenario
  /// </summary>
  public System.UInt32? Show { get ; set; }
  
  /// <summary>
  /// Sequence of References
  /// </summary>
  public System.Collections.Generic.List<System.String>? SequenceOfReferences { get ; set; }
  
}
