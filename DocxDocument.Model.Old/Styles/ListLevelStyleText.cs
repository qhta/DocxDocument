namespace DocxDocument.Model;

public abstract class ListLevelStyleText
{
  /// <summary>
  /// Level of an outline or number list style (starting from 1).
  /// </summary>
  public int? Level { get; set; }
  /// <summary>
  /// Specifies what to display before a number.
  /// If Prefix and Suffix values do not contain any character 
  /// that has a Unicode category of Nd, Nl, No, Lu, Ll, Lt, Lm or Lo, 
  /// an format attribute can be created by concatenating the values 
  /// of the Prefix, Format, and Suffix attributes.
  /// This attribute can also specify a character before the value of a Bullet attribute.
  /// </summary>
  public string? NumPrefix { get; set; }
  /// <summary>
  /// Specifies what to display after a number.
  /// If Prefix and Suffix values do not contain any character 
  /// that has a Unicode category of Nd, Nl, No, Lu, Ll, Lt, Lm or Lo, 
  /// an format attribute can be created by concatenating the values 
  /// of the Prefix, Format, and Suffix attributes.
  /// This attribute can also specify a character after the value of a Bullet attribute.
  /// </summary>
  public string? NumSuffix { get; set; }
  /// <summary>
  /// Specifies a style by name, with the additional requirement that the style belongs to a family 
  /// that is consistent with the style's use.
  /// </summary>
  public string? StyleName { get; set; }

  public ListLevelProperties? ListLevelProperties { get; set; }

  public TextProperties? TextProperties { get; set; }
}