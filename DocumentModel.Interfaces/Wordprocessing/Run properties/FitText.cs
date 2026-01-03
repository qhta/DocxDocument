namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the FitText Class.
/// </summary>
public interface FitText: IModelElement
{
  /// <summary>
  ///   Fit Text Run ID
  /// </summary>
  public Int32? Id { get; set; }
  /// <summary>
  ///   Value
  /// </summary>
  public ITwips? Value { get; set; }
}