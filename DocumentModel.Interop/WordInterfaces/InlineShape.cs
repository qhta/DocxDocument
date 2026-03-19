namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an object in the text layer of a document.
/// </summary>
public partial interface InlineShape : InteropObject
{
  /// <summary>
  /// The borders.
  /// </summary>
  public Borders Borders { get; set; }

  /// <summary>
  /// The range.
  /// </summary>
  public Range Range { get; }

  /// <summary>
  /// The link format.
  /// </summary>
  public LinkFormat LinkFormat { get; }

  /// <summary>
  /// The field.
  /// </summary>
  public Field Field { get; }

  /// <summary>
  /// The oleformat.
  /// </summary>
  public OLEFormat OLEFormat { get; }

  /// <summary>
  /// The type.
  /// </summary>
  public WdInlineShapeType Type { get; }

  /// <summary>
  /// The hyperlink.
  /// </summary>
  public Hyperlink Hyperlink { get; }

  /// <summary>
  /// The height.
  /// </summary>
  public float Height { get; set; }

  /// <summary>
  /// The width.
  /// </summary>
  public float Width { get; set; }

  /// <summary>
  /// The scale height.
  /// </summary>
  public float ScaleHeight { get; set; }

  /// <summary>
  /// The scale width.
  /// </summary>
  public float ScaleWidth { get; set; }

  /// <summary>
  /// The lock aspect ratio.
  /// </summary>
  public Core.MsoTriState LockAspectRatio { get; set; }

  /// <summary>
  /// The line.
  /// </summary>
  public LineFormat Line { get; }

  /// <summary>
  /// The fill.
  /// </summary>
  public FillFormat Fill { get; }

  /// <summary>
  /// The picture format.
  /// </summary>
  public PictureFormat PictureFormat { get; set; }

  /// <summary>
  /// The horizontal line format.
  /// </summary>
  public HorizontalLineFormat HorizontalLineFormat { get; }

  /// <summary>
  /// The script.
  /// </summary>
  public Core.Script Script { get; }

  /// <summary>
  /// The owsanchor.
  /// </summary>
  public int OWSAnchor { get; }

  /// <summary>
  /// The text effect.
  /// </summary>
  public TextEffectFormat TextEffect { get; set; }

  /// <summary>
  /// The alternative text.
  /// </summary>
  public string AlternativeText { get; set; }

  /// <summary>
  /// The is picture bullet.
  /// </summary>
  public bool IsPictureBullet { get; }

  /// <summary>
  /// The group items.
  /// </summary>
  public GroupShapes GroupItems { get; }

  /// <summary>
  /// The has chart.
  /// </summary>
  public Core.MsoTriState HasChart { get; }

  /// <summary>
  /// The chart.
  /// </summary>
  public Chart Chart { get; }

  /// <summary>
  /// The soft edge.
  /// </summary>
  public SoftEdgeFormat SoftEdge { get; }

  /// <summary>
  /// The glow.
  /// </summary>
  public GlowFormat Glow { get; }

  /// <summary>
  /// The reflection.
  /// </summary>
  public ReflectionFormat Reflection { get; }

  /// <summary>
  /// The shadow.
  /// </summary>
  public ShadowFormat Shadow { get; }

  /// <summary>
  /// The has smart art.
  /// </summary>
  public Core.MsoTriState HasSmartArt { get; }

  /// <summary>
  /// The smart art.
  /// </summary>
  public Core.SmartArt SmartArt { get; }

  /// <summary>
  /// The title.
  /// </summary>
  public string Title { get; set; }

  /// <summary>
  /// The anchor id.
  /// </summary>
  public int AnchorID { get; }

  /// <summary>
  /// The edit id.
  /// </summary>
  public int EditID { get; }
}
