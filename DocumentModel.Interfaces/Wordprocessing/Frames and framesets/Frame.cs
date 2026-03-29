namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a frame in a selection, range, or document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frame?view=word-pia"/>
public partial interface Frame : InteropObject
{
  /// <summary>
  /// Returns or sets a <see cref="FrameSizeRule"/> constant that represents the rule for determining the height of the specified frame.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frame.heightrule?view=word-pia"/>
  public FrameSizeRule HeightRule { get; set; }

  /// <summary>
  /// Returns or sets a <see cref="FrameSizeRule"/> constant that represents the rule for determining the width of the specified frame.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frame.widthrule?view=word-pia"/>
  public FrameSizeRule WidthRule { get; set; }

  /// <summary>
  /// Returns or sets the horizontal distance, in points, between the frame and the surrounding text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frame.horizontaldistancefromtext?view=word-pia"/>
  public float HorizontalDistanceFromText { get; set; }

  /// <summary>
  /// Returns or sets the height, in points, of the specified frame.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frame.height?view=word-pia"/>
  public float Height { get; set; }

  /// <summary>
  /// Returns or sets the horizontal position, in points, of the specified frame.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frame.horizontalposition?view=word-pia"/>
  public float HorizontalPosition { get; set; }

  /// <summary>
  /// Determines whether the specified frame is locked to a specific paragraph.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frame.lockanchor?view=word-pia"/>
  public bool LockAnchor { get; set; }

  /// <summary>
  /// Returns or sets the relative horizontal position of the specified frame.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frame.relativehorizontalposition?view=word-pia"/>
  public RelativeHorizontalPosition RelativeHorizontalPosition { get; set; }

  /// <summary>
  /// Returns or sets the relative vertical position of the specified frame.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frame.relativeverticalposition?view=word-pia"/>
  public RelativeVerticalPosition RelativeVerticalPosition { get; set; }

  /// <summary>
  /// Returns or sets the vertical distance, in points, between the frame and the surrounding text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frame.verticaldistancefromtext?view=word-pia"/>
  public float VerticalDistanceFromText { get; set; }

  /// <summary>
  /// Returns or sets the vertical position, in points, of the specified frame.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frame.verticalposition?view=word-pia"/>
  public float VerticalPosition { get; set; }

  /// <summary>
  /// Returns or sets the width, in points, of the specified frame.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frame.width?view=word-pia"/>
  public float Width { get; set; }

  /// <summary>
  /// Determines whether text wraps around the specified frame.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frame.textwrap?view=word-pia"/>
  public bool TextWrap { get; set; }

  /// <summary>
  /// Returns a <see cref="Shading"/> object that represents the shading formatting for the specified frame.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frame.shading?view=word-pia"/>
  public Drw.Shading Shading { get; }

  /// <summary>
  /// Returns or sets a <see cref="Borders"/> collection that represents the borders of the specified frame.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frame.borders?view=word-pia"/>
  public Borders Borders { get; set; }

  /// <summary>
  /// Returns a <see cref="Range"/> object that represents the portion of a document that's contained in the specified frame.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frame.range?view=word-pia"/>
  public Range Range { get; }
}
