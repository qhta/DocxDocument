namespace DocumentModel.Math;
/// <summary>
///   This element specifies the properties of the Accent function. 
///   If AccentChar is omitted, the default accent character is U+0302 (COMBINING CIRCUMFLEX ACCENT). 
/// </summary>
public class AccentProperties: ModelElement
{
  /// <summary>
  ///   Specifies visible accent character.
  /// </summary>
  public string? AccentChar { get; set; }
  /// <summary>
  ///   Specifies formatting of accent character.
  /// </summary>
  public ControlProperties? ControlProperties { get; set; }
}