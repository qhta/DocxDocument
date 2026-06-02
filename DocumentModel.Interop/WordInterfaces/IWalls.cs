namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the walls of a 3-D chart. This object isn’t a collection. There’s no object that represents a
/// single wall; you must return all the walls as a unit.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.walls?view=word-pia"/>
public partial interface IWalls : IInteropObject
{
  /// <summary>
  /// Returns a String value that represents the name of the object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.walls.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Returns a Border object that represents the border of the object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.walls.border?view=word-pia"/>
  public ChartBorder Border { get; }

  /// <summary>
  /// Returns an Interior object that represents the interior of the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.walls.interior?view=word-pia"/>
  public Interior Interior { get; }

  /// <summary>
  /// Returns a ChartFillFormat object for a specified chart that contains fill formatting properties for the chart.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.walls.fill?view=word-pia"/>
  public ChartFillFormat Fill { get; }

  /// <summary>
  /// Returns or sets a Object value that represents the way pictures are displayed on the walls and faces of a 3-D
  /// chart.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.walls.picturetype?view=word-pia"/>
  public object PictureType { get; set; }

  /// <summary>
  /// Returns or sets the unit for each picture on the chart if the PictureType property is set to xlStackScale (if
  /// not, this property is ignored). Read/write Integer.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.walls.pictureunit?view=word-pia"/>
  public object PictureUnit { get; set; }

  /// <summary>
  /// Returns or sets a Integer specifying the thickness of the wall. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.walls.thickness?view=word-pia"/>
  public int Thickness { get; set; }

  /// <summary>
  /// Returns the line, fill, and effect formatting for the object. Read-only ChartFormat.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.walls.format?view=word-pia"/>
  public ChartFormat Format { get; }


  #region methods

/// <summary>
  /// Selects the object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.walls.select?view=word-pia"/>
  public object Select();

  #endregion methods
}
