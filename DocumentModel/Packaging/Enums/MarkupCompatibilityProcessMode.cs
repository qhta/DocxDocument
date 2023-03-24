namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Specifies the mode in which to process the markup compatibility tags in the document.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum MarkupCompatibilityProcessMode
{
  /// <summary>
  ///   Do not process MarkupCompatibility tags.
  /// </summary>
  NoProcess,

  /// <summary>
  ///   Process the loaded parts.
  /// </summary>
  ProcessLoadedPartsOnly,

  /// <summary>
  ///   Process all the parts in the package.
  /// </summary>
  ProcessAllParts
}