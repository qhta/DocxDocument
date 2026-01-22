namespace DocumentModel.Drawings;

/// <summary>
///   Represents an extra color scheme, including a color scheme definition and an associated color map.
/// </summary>
public class ExtraColorScheme : ModelElement<DXD.ExtraColorScheme>
{
  /// <summary>
  ///   Color scheme definition for the extra color scheme.
  /// </summary>
  public ColorScheme? ColorScheme { get; set; }

  /// <summary>
  ///   Color map associated with the extra color scheme.
  /// </summary>
  public ColorMap? ColorMap { get; set; }
}