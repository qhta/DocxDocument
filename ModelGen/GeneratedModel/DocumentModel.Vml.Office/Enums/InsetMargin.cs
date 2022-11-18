namespace DocumentModel.Vml.Office;

/// <summary>
/// Inset Margin Type
/// </summary>
public enum InsetMargin
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
