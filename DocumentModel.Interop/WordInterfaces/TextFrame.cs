namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the text frame in a Shape object. Contains the text in the text frame as well as the properties that control the margins and orientation of the text frame.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe?view=word-pia"/>
public partial interface TextFrame : InteropObject
{
  /// <summary>
  /// Returns or sets the margin bottom.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.marginbottom?view=word-pia"/>
  public float MarginBottom { get; set; }

  /// <summary>
  /// Returns or sets the margin left.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.marginleft?view=word-pia"/>
  public float MarginLeft { get; set; }

  /// <summary>
  /// Returns or sets the margin right.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.marginright?view=word-pia"/>
  public float MarginRight { get; set; }

  /// <summary>
  /// Returns or sets the margin top.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.margintop?view=word-pia"/>
  public float MarginTop { get; set; }

  /// <summary>
  /// Returns or sets the orientation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.orientation?view=word-pia"/>
  public Core.MsoTextOrientation Orientation { get; set; }

  /// <summary>
  /// Returns the text range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.textrange?view=word-pia"/>
  public Range TextRange { get; }

  /// <summary>
  /// Returns the containing range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.containingrange?view=word-pia"/>
  public Range ContainingRange { get; }

  /// <summary>
  /// Returns or sets the next.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.next?view=word-pia"/>
  public TextFrame Next { get; set; }

  /// <summary>
  /// Returns or sets the previous.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.previous?view=word-pia"/>
  public TextFrame Previous { get; set; }

  /// <summary>
  /// Returns whether overflowing.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.overflowing?view=word-pia"/>
  public bool Overflowing { get; }

  /// <summary>
  /// Returns the has text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.hastext?view=word-pia"/>
  public int HasText { get; }

  /// <summary>
  /// Returns or sets the auto size.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.autosize?view=word-pia"/>
  public int AutoSize { get; set; }

  /// <summary>
  /// Returns or sets the word wrap.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.wordwrap?view=word-pia"/>
  public int WordWrap { get; set; }

  /// <summary>
  /// Returns or sets the vertical anchor.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.verticalanchor?view=word-pia"/>
  public Core.MsoVerticalAnchor VerticalAnchor { get; set; }

  /// <summary>
  /// Returns or sets the horizontal anchor.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.horizontalanchor?view=word-pia"/>
  public Core.MsoHorizontalAnchor HorizontalAnchor { get; set; }

  /// <summary>
  /// Returns or sets the path format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.pathformat?view=word-pia"/>
  public Core.MsoPathFormat PathFormat { get; set; }

  /// <summary>
  /// Returns or sets the warp format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.warpformat?view=word-pia"/>
  public Core.MsoWarpFormat WarpFormat { get; set; }

  /// <summary>
  /// Returns the column.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.column?view=word-pia"/>
  public Core.TextColumn2 Column { get; }

  /// <summary>
  /// Returns the three d.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.threed?view=word-pia"/>
  public ThreeDFormat ThreeD { get; }

  /// <summary>
  /// Returns or sets whether no text rotation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.notextrotation?view=word-pia"/>
  public Core.MsoTriState NoTextRotation { get; set; }
}
