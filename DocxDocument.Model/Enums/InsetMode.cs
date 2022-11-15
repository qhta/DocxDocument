using DocumentFormat.OpenXml;

namespace DocxDocument.Model;

/// <summary>
/// Inset Margin Type
/// </summary>
public enum InsetMode
{
  /// <summary>
  /// Automatic Margins.
  /// <para>When the item is serialized out as xml, its value is "auto".</para>
  /// </summary>
  [EnumString("auto")]
  Auto,
  /// <summary>
  /// Custom Margins.
  /// <para>When the item is serialized out as xml, its value is "custom".</para>
  /// </summary>
  [EnumString("custom")]
  Custom
}