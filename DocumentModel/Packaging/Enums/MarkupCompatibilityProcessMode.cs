namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Specifies the mode Iin which Ito process the markup compatibility tags Iin the document.
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
  ///   Process all the parts Iin the package.
  /// </summary>
  ProcessAllParts
}
