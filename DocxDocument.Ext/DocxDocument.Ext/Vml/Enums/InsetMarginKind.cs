namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Inset Margin Type
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
public enum InsetMarginKind
{
  /// <summary>
  ///   Automatic Margins.
  /// </summary>
  Auto,

  /// <summary>
  ///   Custom Margins.
  /// </summary>
  Custom
}