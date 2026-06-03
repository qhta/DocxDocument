namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Border objects that represent the borders of an object.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders?view=word-pia"/>
public partial class Borders : InteropCollection<Border>
{
  /// <summary>
  /// Gets or sets whether borders are enabled.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.enable?view=word-pia"/>
  public int Enable { get; set; }

  /// <summary>
  /// Gets or sets the distance, in points, between the top border and the top edge of the page.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.distancefromtop?view=word-pia"/>
  public int DistanceFromTop { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the borders have a shadow.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.shadow?view=word-pia"/>
  public bool Shadow { get; set; }

  /// <summary>
  /// Gets or sets the line style for inside borders.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.insidelinestyle?view=word-pia"/>
  public LineStyle InsideLineStyle { get; set; }

  /// <summary>
  /// Gets or sets the line style for outside borders.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.outsidelinestyle?view=word-pia"/>
  public LineStyle OutsideLineStyle { get; set; }

  /// <summary>
  /// Gets or sets the line width for inside borders.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.insidelinewidth?view=word-pia"/>
  public LineWidth InsideLineWidth { get; set; }

  /// <summary>
  /// Gets or sets the line width for outside borders.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.outsidelinewidth?view=word-pia"/>
  public LineWidth OutsideLineWidth { get; set; }

  /// <summary>
  /// Gets or sets the color index for inside borders.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.insidecolorindex?view=word-pia"/>
  public ColorIndex InsideColorIndex { get; set; }

  /// <summary>
  /// Gets or sets the color index for outside borders.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.outsidecolorindex?view=word-pia"/>
  public ColorIndex OutsideColorIndex { get; set; }

  /// <summary>
  /// Gets or sets the distance, in points, between the left border and the left edge of the page.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.distancefromleft?view=word-pia"/>
  public int DistanceFromLeft { get; set; }

  /// <summary>
  /// Gets or sets the distance, in points, between the bottom border and the bottom edge of the page.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.distancefrombottom?view=word-pia"/>
  public int DistanceFromBottom { get; set; }

  /// <summary>
  /// Gets or sets the distance, in points, between the right border and the right edge of the page.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.distancefromright?view=word-pia"/>
  public int DistanceFromRight { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether page borders are displayed in front of document text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.alwaysinfront?view=word-pia"/>
  public bool AlwaysInFront { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether borders surround header text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.surroundheader?view=word-pia"/>
  public bool SurroundHeader { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether borders surround footer text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.surroundfooter?view=word-pia"/>
  public bool SurroundFooter { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether adjacent paragraph borders are joined.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.joinborders?view=word-pia"/>
  public bool JoinBorders { get; set; }

  /// <summary>
  /// Gets a value indicating whether the collection includes a horizontal border.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.hashorizontal?view=word-pia"/>
  public bool HasHorizontal { get; set; }

  /// <summary>
  /// Gets a value indicating whether the collection includes a vertical border.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.hasvertical?view=word-pia"/>
  public bool HasVertical { get; set; }

  /// <summary>
  /// Gets or sets what border distances are measured from.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.distancefrom?view=word-pia"/>
  public BorderDistanceFrom DistanceFrom { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether borders are enabled on the first page of a section.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.enablefirstpageinsection?view=word-pia"/>
  public bool EnableFirstPageInSection { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether borders are enabled on pages other than the first page in a section.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.enableotherpagesinsection?view=word-pia"/>
  public bool EnableOtherPagesInSection { get; set; }

  /// <summary>
  /// Gets or sets the color of inside borders.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.insidecolor?view=word-pia"/>
  public PresetColors InsideColor { get; set; }

  /// <summary>
  /// Gets or sets the color of outside borders.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.outsidecolor?view=word-pia"/>
  public PresetColors OutsideColor { get; set; }


  #region methods

/// <summary>
  /// Returns a Border object that represents a single border.
  /// </summary>
  /// <param name="index">A <see cref="BorderType"/> value that identifies which border to return.</param>
  /// <returns>The requested <see cref="Border"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.get_item?view=word-pia"/>
  public Border Item(BorderType index) { throw new NotImplementedException(); }

  /// <summary>
  /// Applies the specified page-border formatting to all sections in a document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.borders.applypageborderstoallsections?view=word-pia"/>
  public void ApplyPageBordersToAllSections() { throw new NotImplementedException(); }

  #endregion methods
}
