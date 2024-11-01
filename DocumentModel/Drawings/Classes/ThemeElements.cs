namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ThemeElements Class.
/// </summary>
public class ThemeElements: ModelElement
{
  /// <summary>
  ///   ColorScheme.
  /// </summary>
  public ColorScheme? ColorScheme { get; set; }

  /// <summary>
  ///   Font Scheme.
  /// </summary>
  public FontScheme? FontScheme { get; set; }

  /// <summary>
  ///   Format Scheme.
  /// </summary>
  public FormatScheme? FormatScheme { get; set; }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}