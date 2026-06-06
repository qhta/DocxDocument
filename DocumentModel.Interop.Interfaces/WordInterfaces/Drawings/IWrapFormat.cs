namespace DocumentModel.Interop.Word;	
/// <summary>
/// Represents all the properties for wrapping text around a shape or shape range.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wrapformat?view=word-pia"/>
public interface IWrapFormat : IInteropObject
{
  /// <summary>
  /// Returns the wrap type for the specified shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wrapformat.type?view=word-pia"/>
  public WrapType Type { get; set; }
  /// <summary>
  /// Returns or sets a value that indicates whether the document text should wrap on both sides of the specified
  /// shape, on either the left or right side only, or on the side of the shape that's farthest from the page
  /// margin.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wrapformat.side?view=word-pia"/>
  public WrapSideType Side { get; set; }
  /// <summary>
  /// Returns or sets the distance (in points) between the document text and the top edge of the text-free area
  /// surrounding the specified shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wrapformat.distancetop?view=word-pia"/>
  public float DistanceTop { get; set; }
  /// <summary>
  /// Returns or sets the distance (in points) between the document text and the bottom edge of the text-free area
  /// surrounding the specified shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wrapformat.distancebottom?view=word-pia"/>
  public float DistanceBottom { get; set; }
  /// <summary>
  /// Returns or sets the distance (in points) between the document text and the left edge of the text-free area
  /// surrounding the specified shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wrapformat.distanceleft?view=word-pia"/>
  public float DistanceLeft { get; set; }
  /// <summary>
  /// Returns or sets the distance (in points) between the document text and the right edge of the text-free area
  /// surrounding the specified shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wrapformat.distanceright?view=word-pia"/>
  public float DistanceRight { get; set; }
  /// <summary>
  /// Returns or sets a value that specifies whether a given shape can overlap other shapes. Can be set to either
  /// True or False.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wrapformat.allowoverlap?view=word-pia"/>
  public int AllowOverlap { get; set; }	
}
