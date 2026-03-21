namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an object in the text layer of a document.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape?view=word-pia"/>
public partial interface InlineShape : InteropObject
{
  /// <summary>
  /// The borders.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.borders?view=word-pia"/>
  public Borders Borders { get; set; }

  /// <summary>
  /// The range.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// The link format.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.linkformat?view=word-pia"/>
  public LinkFormat LinkFormat { get; }

  /// <summary>
  /// The field.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.field?view=word-pia"/>
  public Field Field { get; }

  /// <summary>
  /// The oleformat.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.oleformat?view=word-pia"/>
  public OLEFormat OLEFormat { get; }

  /// <summary>
  /// The type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.type?view=word-pia"/>
  public WdInlineShapeType Type { get; }

  /// <summary>
  /// The hyperlink.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.hyperlink?view=word-pia"/>
  public Hyperlink Hyperlink { get; }

  /// <summary>
  /// The height.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.height?view=word-pia"/>
  public float Height { get; set; }

  /// <summary>
  /// The width.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.width?view=word-pia"/>
  public float Width { get; set; }

  /// <summary>
  /// The scale height.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.scaleheight?view=word-pia"/>
  public float ScaleHeight { get; set; }

  /// <summary>
  /// The scale width.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.scalewidth?view=word-pia"/>
  public float ScaleWidth { get; set; }

  /// <summary>
  /// The lock aspect ratio.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.lockaspectratio?view=word-pia"/>
  public Core.MsoTriState LockAspectRatio { get; set; }

  /// <summary>
  /// The line.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.line?view=word-pia"/>
  public LineFormat Line { get; }

  /// <summary>
  /// The fill.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.fill?view=word-pia"/>
  public FillFormat Fill { get; }

  /// <summary>
  /// The picture format.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.pictureformat?view=word-pia"/>
  public PictureFormat PictureFormat { get; set; }

  /// <summary>
  /// The horizontal line format.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.horizontallineformat?view=word-pia"/>
  public HorizontalLineFormat HorizontalLineFormat { get; }

  /// <summary>
  /// The script.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.script?view=word-pia"/>
  public Core.Script Script { get; }

  /// <summary>
  /// The owsanchor.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.owsanchor?view=word-pia"/>
  public int OWSAnchor { get; }

  /// <summary>
  /// The text effect.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.texteffect?view=word-pia"/>
  public TextEffectFormat TextEffect { get; set; }

  /// <summary>
  /// The alternative text.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.alternativetext?view=word-pia"/>
  public string AlternativeText { get; set; }

  /// <summary>
  /// The is picture bullet.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.ispicturebullet?view=word-pia"/>
  public bool IsPictureBullet { get; }

  /// <summary>
  /// The group items.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.groupitems?view=word-pia"/>
  public GroupShapes GroupItems { get; }

  /// <summary>
  /// The has chart.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.haschart?view=word-pia"/>
  public Core.MsoTriState HasChart { get; }

  /// <summary>
  /// The chart.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.chart?view=word-pia"/>
  public Chart Chart { get; }

  /// <summary>
  /// The soft edge.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.softedge?view=word-pia"/>
  public SoftEdgeFormat SoftEdge { get; }

  /// <summary>
  /// The glow.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.glow?view=word-pia"/>
  public GlowFormat Glow { get; }

  /// <summary>
  /// The reflection.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.reflection?view=word-pia"/>
  public ReflectionFormat Reflection { get; }

  /// <summary>
  /// The shadow.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.shadow?view=word-pia"/>
  public ShadowFormat Shadow { get; }

  /// <summary>
  /// The has smart art.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.hassmartart?view=word-pia"/>
  public Core.MsoTriState HasSmartArt { get; }

  /// <summary>
  /// The smart art.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.smartart?view=word-pia"/>
  public Core.SmartArt SmartArt { get; }

  /// <summary>
  /// The title.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.title?view=word-pia"/>
  public string Title { get; set; }

  /// <summary>
  /// The anchor id.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.anchorid?view=word-pia"/>
  public int AnchorID { get; }

  /// <summary>
  /// The edit id.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.editid?view=word-pia"/>
  public int EditID { get; }
}
