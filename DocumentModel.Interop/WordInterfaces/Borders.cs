namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Border objects that represent the borders of an object.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders?view=word-pia"/>
public partial interface Borders : InteropObject, InteropCollection<Border>
{
  /// <summary>
  /// The enable.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.enable?view=word-pia"/>
  public int Enable { get; set; }

  /// <summary>
  /// The distance from top.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.distancefromtop?view=word-pia"/>
  public int DistanceFromTop { get; set; }

  /// <summary>
  /// The shadow.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.shadow?view=word-pia"/>
  public bool Shadow { get; set; }

  /// <summary>
  /// The inside line style.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.insidelinestyle?view=word-pia"/>
  public WdLineStyle InsideLineStyle { get; set; }

  /// <summary>
  /// The outside line style.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.outsidelinestyle?view=word-pia"/>
  public WdLineStyle OutsideLineStyle { get; set; }

  /// <summary>
  /// The inside line width.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.insidelinewidth?view=word-pia"/>
  public WdLineWidth InsideLineWidth { get; set; }

  /// <summary>
  /// The outside line width.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.outsidelinewidth?view=word-pia"/>
  public WdLineWidth OutsideLineWidth { get; set; }

  /// <summary>
  /// The inside color index.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.insidecolorindex?view=word-pia"/>
  public WdColorIndex InsideColorIndex { get; set; }

  /// <summary>
  /// The outside color index.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.outsidecolorindex?view=word-pia"/>
  public WdColorIndex OutsideColorIndex { get; set; }

  /// <summary>
  /// The distance from left.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.distancefromleft?view=word-pia"/>
  public int DistanceFromLeft { get; set; }

  /// <summary>
  /// The distance from bottom.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.distancefrombottom?view=word-pia"/>
  public int DistanceFromBottom { get; set; }

  /// <summary>
  /// The distance from right.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.distancefromright?view=word-pia"/>
  public int DistanceFromRight { get; set; }

  /// <summary>
  /// The always in front.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.alwaysinfront?view=word-pia"/>
  public bool AlwaysInFront { get; set; }

  /// <summary>
  /// The surround header.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.surroundheader?view=word-pia"/>
  public bool SurroundHeader { get; set; }

  /// <summary>
  /// The surround footer.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.surroundfooter?view=word-pia"/>
  public bool SurroundFooter { get; set; }

  /// <summary>
  /// The join borders.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.joinborders?view=word-pia"/>
  public bool JoinBorders { get; set; }

  /// <summary>
  /// The has horizontal.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.hashorizontal?view=word-pia"/>
  public bool HasHorizontal { get; }

  /// <summary>
  /// The has vertical.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.hasvertical?view=word-pia"/>
  public bool HasVertical { get; }

  /// <summary>
  /// The distance from.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.distancefrom?view=word-pia"/>
  public WdBorderDistanceFrom DistanceFrom { get; set; }

  /// <summary>
  /// The enable first page in section.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.enablefirstpageinsection?view=word-pia"/>
  public bool EnableFirstPageInSection { get; set; }

  /// <summary>
  /// The enable other pages in section.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.enableotherpagesinsection?view=word-pia"/>
  public bool EnableOtherPagesInSection { get; set; }

  /// <summary>
  /// The inside color.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.insidecolor?view=word-pia"/>
  public WdColor InsideColor { get; set; }

  /// <summary>
  /// The outside color.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.outsidecolor?view=word-pia"/>
  public WdColor OutsideColor { get; set; }
}
