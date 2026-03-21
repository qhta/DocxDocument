namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents all the properties for wrapping text around a shape or shape range.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wrapformat?view=word-pia"/>
public interface WrapFormat : InteropObject
{
  /// <summary>
  /// The type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wrapformat.type?view=word-pia"/>
  public WdWrapType Type { get; set; }
  /// <summary>
  /// The side.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wrapformat.side?view=word-pia"/>
  public WdWrapSideType Side { get; set; }
  /// <summary>
  /// The distance top.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wrapformat.distancetop?view=word-pia"/>
  public float DistanceTop { get; set; }
  /// <summary>
  /// The distance bottom.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wrapformat.distancebottom?view=word-pia"/>
  public float DistanceBottom { get; set; }
  /// <summary>
  /// The distance left.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wrapformat.distanceleft?view=word-pia"/>
  public float DistanceLeft { get; set; }
  /// <summary>
  /// The distance right.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wrapformat.distanceright?view=word-pia"/>
  public float DistanceRight { get; set; }
  /// <summary>
  /// The allow overlap.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wrapformat.allowoverlap?view=word-pia"/>
  public int AllowOverlap { get; set; }

}
