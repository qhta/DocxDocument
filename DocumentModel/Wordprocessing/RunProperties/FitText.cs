namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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