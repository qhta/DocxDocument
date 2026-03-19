namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the walls of a 3-D chart. This object isnĂ„â€šĂ‹ÂÄ‚â€šĂ˘â€šÂ¬Ä‚â€šĂ˘â€žËt a collection. ThereĂ„â€šĂ‹ÂÄ‚â€šĂ˘â€šÂ¬Ä‚â€šĂ˘â€žËs no object that represents a single wall; you must return all the walls as a unit.
/// </summary>
public partial interface Walls : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; }

  /// <summary>
  /// The border.
  /// </summary>
  public ChartBorder Border { get; }

  /// <summary>
  /// The interior.
  /// </summary>
  public Interior Interior { get; }

  /// <summary>
  /// The fill.
  /// </summary>
  public ChartFillFormat Fill { get; }

  /// <summary>
  /// The picture type.
  /// </summary>
  public object PictureType { get; set; }

  /// <summary>
  /// The picture unit.
  /// </summary>
  public object PictureUnit { get; set; }

  /// <summary>
  /// The thickness.
  /// </summary>
  public int Thickness { get; set; }

  /// <summary>
  /// The format.
  /// </summary>
  public ChartFormat Format { get; }
}
