namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FitText Class.
/// </summary>
public interface IFitText // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Value
  /// </summary>
  public System.UInt32? Val { get ; set; }
  
  /// <summary>
  /// Fit Text Run ID
  /// </summary>
  public System.Int32? Id { get ; set; }
  
}
