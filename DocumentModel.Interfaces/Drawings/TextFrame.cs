using DocumentModel.Wordprocessing;

using Range = System.Range;

namespace DocumentModel.Drawings;

using DocumentModel.Drawings;

/// <summary>
/// Represents the text frame in a Shape object. Contains the text in the text frame as well as the properties
/// that control the margins and orientation of the text frame.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe?view=word-pia"/>
public partial interface TextFrame : InteropObject
{
  /// <summary>
  /// Returns or sets the distance (in points) between the bottom of the text frame and the bottom of the inscribed
  /// rectangle of the shape that contains the text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.marginbottom?view=word-pia"/>
  public float MarginBottom { get; set; }

  /// <summary>
  /// Returns or sets the distance (in points) between the left edge of the text frame and the left edge of the
  /// inscribed rectangle of the shape that contains the text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.marginleft?view=word-pia"/>
  public float MarginLeft { get; set; }

  /// <summary>
  /// Returns or sets the distance (in points) between the right edge of the text frame and the right edge of the
  /// inscribed rectangle of the shape that contains the text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.marginright?view=word-pia"/>
  public float MarginRight { get; set; }

  /// <summary>
  /// Returns or sets the distance (in points) between the top of the text frame and the top of the inscribed
  /// rectangle of the shape that contains the text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.margintop?view=word-pia"/>
  public float MarginTop { get; set; }

  /// <summary>
  /// Returns or sets the orientation of the text inside the frame.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.orientation?view=word-pia"/>
  public TextOrientation Orientation { get; set; }

  /// <summary>
  /// Returns a Range object that represents the text in the specified text frame.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.textrange?view=word-pia"/>
  public Range TextRange { get; }

  /// <summary>
  /// Returns a Range object that represents the entire story in a series of shapes with linked text frames that the
  /// specified text frame belongs to.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.containingrange?view=word-pia"/>
  public Range ContainingRange { get; }

  /// <summary>
  /// Returns the next object in the collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.next?view=word-pia"/>
  public TextFrame Next { get; set; }

  /// <summary>
  /// Returns the previous object in the collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.previous?view=word-pia"/>
  public TextFrame Previous { get; set; }

  /// <summary>
  /// True if the text inside the specified text frame doesn't all fit within the frame.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.overflowing?view=word-pia"/>
  public bool Overflowing { get; }

  /// <summary>
  /// True if the specified shape has text associated with it.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.hastext?view=word-pia"/>
  public int HasText { get; }

  /// <summary>
  /// Returns or sets an Integer that represents whether a text frame is sized automatically.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.autosize?view=word-pia"/>
  public int AutoSize { get; set; }

  /// <summary>
  /// True if Microsoft Word wraps Latin text in the middle of a word in the specified paragraphs or text frames.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.wordwrap?view=word-pia"/>
  public int WordWrap { get; set; }

  /// <summary>
  /// Returns or sets an VerticalAnchor constant that represents the vertical alignment of the text within a
  /// shape. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.verticalanchor?view=word-pia"/>
  public VerticalAnchor VerticalAnchor { get; set; }

  /// <summary>
  /// Gets or sets the horizontal alignment of text in a text frame.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.horizontalanchor?view=word-pia"/>
  public HorizontalAnchor HorizontalAnchor { get; set; }

  /// <summary>
  /// Gets or sets the path type for the specified text frame.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.pathformat?view=word-pia"/>
  public PathFormat PathFormat { get; set; }

  /// <summary>
  /// Gets or sets the warp format (how the text is warped) for the specified text frame.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.warpformat?view=word-pia"/>
  public WarpFormat WarpFormat { get; set; }

  /// <summary>
  /// Gets the TextColumn2 object that represents the columns of the specified text frame.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.column?view=word-pia"/>
  public TextColumn Column { get; }

  /// <summary>
  /// Gets a ThreeDFormat object that contains 3-D effect formatting properties for the specified text frame.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.threed?view=word-pia"/>
  public ThreeDFormat ThreeD { get; }

  /// <summary>
  /// Gets or sets whether the text in the text frame should not rotate when the shape is rotated.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.notextrotation?view=word-pia"/>
  public TriState NoTextRotation { get; set; }
}
