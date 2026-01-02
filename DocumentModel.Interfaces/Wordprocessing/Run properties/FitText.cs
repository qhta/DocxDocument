namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the FitText Class.
/// </summary>
public class FitText: ModelElement
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