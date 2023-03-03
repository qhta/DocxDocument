namespace DocumentModel.Wordprocessing;

/// <summary>
///   Linked Object Update Modes
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ObjectUpdateMode
{
  /// <summary>
  ///   always.
  /// </summary>
  always,

  /// <summary>
  ///   onCall.
  /// </summary>
  onCall
}