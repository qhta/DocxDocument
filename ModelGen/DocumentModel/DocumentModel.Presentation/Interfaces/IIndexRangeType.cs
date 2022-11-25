namespace DocumentModel.Presentation;

/// <summary>
/// Defines the IndexRangeType Class.
/// </summary>
public interface IIndexRangeType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Start
  /// </summary>
  public System.UInt32? Start { get ; set; }
  
  /// <summary>
  /// End
  /// </summary>
  public System.UInt32? End { get ; set; }
  
}
