namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents all the properties for wrapping text around a shape or shape range.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wrapformat?view=word-pia"/>
public interface WrapFormat : InteropObject
{
  /// <summary>
  /// Returns or sets the type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wrapformat.type?view=word-pia"/>
  public WdWrapType Type { get; set; }
  /// <summary>
  /// Returns or sets the side.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wrapformat.side?view=word-pia"/>
  public WdWrapSideType Side { get; set; }
  /// <summary>
  /// Returns or sets the distance top.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wrapformat.distancetop?view=word-pia"/>
  public float DistanceTop { get; set; }
  /// <summary>
  /// Returns or sets the distance bottom.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wrapformat.distancebottom?view=word-pia"/>
  public float DistanceBottom { get; set; }
  /// <summary>
  /// Returns or sets the distance left.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wrapformat.distanceleft?view=word-pia"/>
  public float DistanceLeft { get; set; }
  /// <summary>
  /// Returns or sets the distance right.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wrapformat.distanceright?view=word-pia"/>
  public float DistanceRight { get; set; }
  /// <summary>
  /// Returns or sets the allow overlap.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wrapformat.allowoverlap?view=word-pia"/>
  public int AllowOverlap { get; set; }

}
