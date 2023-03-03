namespace DocumentModel.Vml;

/// <summary>
///   Inset Margin Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
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