namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies which font properties to apply when using SetRange method.
/// </summary>
[Flags]
[OpenXmlNotMapped]
public enum FontPropertiesKind
{
  /// <summary>Font name</summary>
  Name = 1,
  /// <summary>Font size</summary>
  Size = 2,
  /// <summary>Bold</summary>
  Bold = 4,
  /// <summary>Italic</summary>
  Italic = 8,
  /// <summary>Underline</summary>
  Underline = 16,
  /// <summary>Color</summary>
  Color = 32,
  /// <summary>All properties</summary>
  All = 0xFFFF
}