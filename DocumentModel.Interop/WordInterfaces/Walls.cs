namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the walls of a 3-D chart. This object isnÄ‚â€žĂ˘â‚¬ĹˇÄ‚â€ąĂ‚ÂĂ„â€šĂ˘â‚¬ĹˇÄ‚ËĂ˘â‚¬ĹˇĂ‚Â¬Ă„â€šĂ˘â‚¬ĹˇÄ‚ËĂ˘â‚¬ĹľĂ‹Ât a collection. ThereÄ‚â€žĂ˘â‚¬ĹˇÄ‚â€ąĂ‚ÂĂ„â€šĂ˘â‚¬ĹˇÄ‚ËĂ˘â‚¬ĹˇĂ‚Â¬Ă„â€šĂ˘â‚¬ĹˇÄ‚ËĂ˘â‚¬ĹľĂ‹Âs no object that represents a single wall; you must return all the walls as a unit.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.walls?view=word-pia"/>
public partial interface Walls : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.walls.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// The border.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.walls.border?view=word-pia"/>
  public ChartBorder Border { get; }

  /// <summary>
  /// The interior.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.walls.interior?view=word-pia"/>
  public Interior Interior { get; }

  /// <summary>
  /// The fill.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.walls.fill?view=word-pia"/>
  public ChartFillFormat Fill { get; }

  /// <summary>
  /// The picture type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.walls.picturetype?view=word-pia"/>
  public object PictureType { get; set; }

  /// <summary>
  /// The picture unit.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.walls.pictureunit?view=word-pia"/>
  public object PictureUnit { get; set; }

  /// <summary>
  /// The thickness.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.walls.thickness?view=word-pia"/>
  public int Thickness { get; set; }

  /// <summary>
  /// The format.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.walls.format?view=word-pia"/>
  public ChartFormat Format { get; }
}
