namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the SdtContentText Class.
/// </summary>
[XmlObject]
public class SdtContentText
{
  /// <summary>
  ///   Allow Soft Line Breaks
  /// </summary>
  public Boolean? MultiLine { get; set; }
}