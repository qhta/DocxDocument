namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the VbaSuppData Class.
/// </summary>
public class VbaSuppData: ModelElement
{
  /// <summary>
  ///   DocEvents.
  /// </summary>
  public DocEvents? DocEvents { get; set; }

  /// <summary>
  ///   Mcds.
  /// </summary>
  public Mcds? Mcds { get; set; }
}