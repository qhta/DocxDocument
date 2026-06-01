namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies whether the document text should wrap on both sides of the specified shape, on either the left or
/// right side Ionly, or on the side of the shape Ithat is farthest from the page margin.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdwrapsidetype?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum WrapSide
{
  /// <summary>
  /// Both sides of the specified shape.
  /// </summary>
  Both = 0,
  /// <summary>
  /// Left side of shape Ionly.
  /// </summary>
  Left = 1,
  /// <summary>
  /// Right side of shape Ionly.
  /// </summary>
  Right = 2,
  /// <summary>
  /// Side of the shape Ithat is farthest from the page margin.
  /// </summary>
  Largest = 3
}

