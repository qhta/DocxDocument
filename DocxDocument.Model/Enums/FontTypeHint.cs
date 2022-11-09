namespace DocxDocument.Model;

/// <summary>
/// Defines the FontTypeHintValues enumeration.
/// </summary>
public enum FontTypeHint
{
  /// <summary>
  /// High ANSI Font.
  /// <para>When the item is serialized out as xml, its value is "default".</para>
  /// </summary>
  Default,
  /// <summary>
  /// East Asian Font.
  /// <para>When the item is serialized out as xml, its value is "eastAsia".</para>
  /// </summary>
  EastAsia,
  /// <summary>
  /// Complex Script Font.
  /// <para>When the item is serialized out as xml, its value is "cs".</para>
  /// </summary>
  ComplexScript
}