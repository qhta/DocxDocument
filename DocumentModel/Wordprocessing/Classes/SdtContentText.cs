namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the SdtContentText Class.
/// </summary>
[XmlObject]
public class SdtContentText: ModelElement
{
  /// <summary>
  ///   Allow Soft Line Breaks
  /// </summary>
  public Boolean? MultiLine { get; set; }
}