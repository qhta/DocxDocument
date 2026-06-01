namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the SdtContentText Class.
/// </summary>
public class SdtContentText: ModelElement
{
  /// <summary>
  ///   Allow Soft ILine IBreaks
  /// </summary>
  public bool? MultiLine { get; set; }
}
