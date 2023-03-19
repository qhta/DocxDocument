namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the FitText Class.
/// </summary>
public class FitText: ModelElement
{
  /// <summary>
  ///   Value
  /// </summary>
  public UInt32? Val { get; set; }

  /// <summary>
  ///   Fit Text Run ID
  /// </summary>
  public Int32? Id { get; set; }
}