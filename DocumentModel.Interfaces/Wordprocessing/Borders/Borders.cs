namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of Border objects that represent the borders of an object.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders?view=word-pia"/>
public partial interface IBorders : IModelCollection<IBorder>
{
  /// <summary>
  /// Gets or sets whether borders are enabled.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.enable?view=word-pia"/>
  public int Enable { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the distance, in points, between the top border and the top edge of the page.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.distancefromtop?view=word-pia"/>
  public int DistanceFromTop { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets a value indicating whether the borders have a shadow.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.shadow?view=word-pia"/>
  public bool Shadow { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the line style for inside borders.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.insidelinestyle?view=word-pia"/>
  public LineStyle InsideLineStyle { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the line style for outside borders.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.outsidelinestyle?view=word-pia"/>
  public LineStyle OutsideLineStyle { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the line width for inside borders.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.insidelinewidth?view=word-pia"/>
  public LineWidth InsideLineWidth { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the line width for outside borders.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.outsidelinewidth?view=word-pia"/>
  public LineWidth OutsideLineWidth { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the color index for inside borders.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.insidecolorindex?view=word-pia"/>
  public ColorIndex InsideColorIndex { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the color index for outside borders.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.outsidecolorindex?view=word-pia"/>
  public ColorIndex OutsideColorIndex { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the distance, in points, between the left border and the left edge of the page.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.distancefromleft?view=word-pia"/>
  public int DistanceFromLeft { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the distance, in points, between the bottom border and the bottom edge of the page.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.distancefrombottom?view=word-pia"/>
  public int DistanceFromBottom { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the distance, in points, between the right border and the right edge of the page.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.distancefromright?view=word-pia"/>
  public int DistanceFromRight { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets a value indicating whether page borders are displayed in front of document text.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.alwaysinfront?view=word-pia"/>
  public bool AlwaysInFront { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets a value indicating whether borders surround header text.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.surroundheader?view=word-pia"/>
  public bool SurroundHeader { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets a value indicating whether borders surround footer text.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.surroundfooter?view=word-pia"/>
  public bool SurroundFooter { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets a value indicating whether adjacent paragraph borders are joined.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.joinborders?view=word-pia"/>
  public bool JoinBorders { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets a value indicating whether the collection includes a horizontal border.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.hashorizontal?view=word-pia"/>
  public bool HasHorizontal { get; }

  /// <summary>
  /// Gets a value indicating whether the collection includes a vertical border.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.hasvertical?view=word-pia"/>
  public bool HasVertical { get; }

  /// <summary>
  /// Gets or sets what border distances are measured from.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.distancefrom?view=word-pia"/>
  public BorderDistanceFrom DistanceFrom { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets a value indicating whether borders are enabled on the first page of a section.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.enablefirstpageinsection?view=word-pia"/>
  public bool EnableFirstPageInSection { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets a value indicating whether borders are enabled on pages other than the first page in a section.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.enableotherpagesinsection?view=word-pia"/>
  public bool EnableOtherPagesInSection { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the color of inside borders.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.insidecolor?view=word-pia"/>
  public IColor InsideColor { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the color of outside borders.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.outsidecolor?view=word-pia"/>
  public IColor OutsideColor { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}
