namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the text frame in a Shape object. Contains the text in the text frame as well as the properties that control the margins and orientation of the text frame.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe?view=word-pia"/>
public partial interface TextFrame : InteropObject
{
  /// <summary>
  /// The margin bottom.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.marginbottom?view=word-pia"/>
  public float MarginBottom { get; set; }

  /// <summary>
  /// The margin left.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.marginleft?view=word-pia"/>
  public float MarginLeft { get; set; }

  /// <summary>
  /// The margin right.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.marginright?view=word-pia"/>
  public float MarginRight { get; set; }

  /// <summary>
  /// The margin top.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.margintop?view=word-pia"/>
  public float MarginTop { get; set; }

  /// <summary>
  /// The orientation.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.orientation?view=word-pia"/>
  public Core.MsoTextOrientation Orientation { get; set; }

  /// <summary>
  /// The text range.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.textrange?view=word-pia"/>
  public Range TextRange { get; }

  /// <summary>
  /// The containing range.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.containingrange?view=word-pia"/>
  public Range ContainingRange { get; }

  /// <summary>
  /// The next.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.next?view=word-pia"/>
  public TextFrame Next { get; set; }

  /// <summary>
  /// The previous.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.previous?view=word-pia"/>
  public TextFrame Previous { get; set; }

  /// <summary>
  /// The overflowing.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.overflowing?view=word-pia"/>
  public bool Overflowing { get; }

  /// <summary>
  /// The has text.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.hastext?view=word-pia"/>
  public int HasText { get; }

  /// <summary>
  /// The auto size.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.autosize?view=word-pia"/>
  public int AutoSize { get; set; }

  /// <summary>
  /// The word wrap.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.wordwrap?view=word-pia"/>
  public int WordWrap { get; set; }

  /// <summary>
  /// The vertical anchor.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.verticalanchor?view=word-pia"/>
  public Core.MsoVerticalAnchor VerticalAnchor { get; set; }

  /// <summary>
  /// The horizontal anchor.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.horizontalanchor?view=word-pia"/>
  public Core.MsoHorizontalAnchor HorizontalAnchor { get; set; }

  /// <summary>
  /// The path format.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.pathformat?view=word-pia"/>
  public Core.MsoPathFormat PathFormat { get; set; }

  /// <summary>
  /// The warp format.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.warpformat?view=word-pia"/>
  public Core.MsoWarpFormat WarpFormat { get; set; }

  /// <summary>
  /// The column.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.column?view=word-pia"/>
  public Core.TextColumn2 Column { get; }

  /// <summary>
  /// The three d.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.threed?view=word-pia"/>
  public ThreeDFormat ThreeD { get; }

  /// <summary>
  /// The no text rotation.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textframe.notextrotation?view=word-pia"/>
  public Core.MsoTriState NoTextRotation { get; set; }
}
