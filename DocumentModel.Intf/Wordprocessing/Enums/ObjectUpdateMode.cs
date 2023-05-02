namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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