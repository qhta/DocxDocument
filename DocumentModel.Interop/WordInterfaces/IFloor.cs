namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the floor of a 3-D chart.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.floor?view=word-pia"/>
public interface IFloor : IInteropObject
{
  /// <summary>
  /// Returns a string value that represents the name of the object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.floor.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Returns a <see cref="ChartBorder"/> object that represents the border of the object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.floor.border?view=word-pia"/>
  public ChartBorder Border { get; }

  /// <summary>
  /// Returns an <see cref="Interior"/> object that represents the interior of the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.floor.interior?view=word-pia"/>
  public Interior Interior { get; }

  /// <summary>
  /// Returns a <see cref="ChartFillFormat"/> object that contains fill formatting properties for the chart.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.floor.fill?view=word-pia"/>
  public ChartFillFormat Fill { get; }

  /// <summary>
  /// Returns or sets an object value that represents the way pictures are displayed on the walls and faces of a 3-D chart.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.floor.picturetype?view=word-pia"/>
  public object PictureType { get; set; }

  /// <summary>
  /// Returns or sets an integer specifying the thickness of the floor.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.floor.thickness?view=word-pia"/>
  public int Thickness { get; set; }

  /// <summary>
  /// Returns the line, fill, and effect formatting for the object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.floor.format?view=word-pia"/>
  public ChartFormat Format { get; }


  #region methods

/// <summary>
  /// Returns the value produced by the select operation.
  /// </summary>
  /// <returns>The resulting value.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.floor.select?view=word-pia"/>
  public object Select();

  #endregion methods
}
