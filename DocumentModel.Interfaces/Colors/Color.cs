namespace DocumentModel;

/// <summary>
/// Full color interface, supporting both RGB and theme colors.
/// </summary>
public interface IColor
{
  /// <summary>
  /// Gets or sets the hexadecimal value represented by this property.
  /// </summary>
  public UInt32 Val { get; set; }

  /// <summary>
  /// Gets or sets the theme color represented by this property.
  /// </summary>
  public ThemeColors? ThemeColor { get; set; }
  
  /// <summary>
  /// Gets or sets the theme tint represented by this property.
  /// </summary>  
  public float? ThemeTint { get; set; }
  
  /// <summary>
  /// Gets or sets the theme shade represented by this property.
  /// </summary>  
  public float? ThemeShade { get; set; }

}