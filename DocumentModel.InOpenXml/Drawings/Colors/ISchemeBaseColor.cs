namespace DocumentModel.Drawings;
/// <summary>
/// Represents a color that is defined in the color scheme of a theme, used as a base color for drawing elements.
/// The following types of colors can be defined in a color scheme:
/// <list type="bullet">
///   <item><description><see cref="T:DocumentModel.Drawings.RgbColorModelHex" /></description></item>
///   <item><description><see cref="T:DocumentModel.Drawings.RgbColorModelPercentage" /></description></item>
///   <item><description><see cref="T:DocumentModel.Drawings.PresetColor" /></description></item>
///   <item><description><see cref="T:DocumentModel.Drawings.SystemColor" /></description></item>
///   <item><description><see cref="T:DocumentModel.Drawings.HslColor" /></description></item>
/// </list>
/// </summary>
public partial interface ISchemeBaseColor
{
  /// <summary>
  /// Gets the RGB color value represented by this instance, if available.
  /// </summary>
  public UInt32? RGB { get; }
}