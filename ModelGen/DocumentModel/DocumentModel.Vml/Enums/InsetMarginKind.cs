namespace DocumentModel.Vml;

/// <summary>
/// Inset Margin Type
/// </summary>
public enum InsetMarginKind
{
  /// <summary>
  /// Automatic Margins.
  /// </summary>
  [XmlEnum("auto")]
  Auto,
  
  /// <summary>
  /// Custom Margins.
  /// </summary>
  [XmlEnum("custom")]
  Custom,
  
}
