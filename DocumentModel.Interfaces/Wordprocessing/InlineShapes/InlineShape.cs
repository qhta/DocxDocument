using DocumentModel.Drawings.Charts;
using DocumentModel.Drawings.SmartArt;
using DocumentModel.HTML;
using DocumentModel.Wordprocessing;

using Range = System.Range;

namespace DocumentModel.Drawings;

/// <summary>
/// Represents an object in the text layer of a document.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape?view=word-pia"/>
public partial interface InlineShape : IModelObject
{
  /// <summary>
  /// Returns or sets the borders for the inline shape.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.borders?view=word-pia"/>
  public IBorders Borders { get; set; }

  /// <summary>
  /// Returns a range object that represents the inline shape in the document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// Returns a link format object that contains link properties for the inline shape.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.linkformat?view=word-pia"/>
  public ILinkFormat LinkFormat { get; }

  /// <summary>
  /// Returns a field object associated with the inline shape.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.field?view=word-pia"/>
  public IField Field { get; }

  /// <summary>
  /// Returns an OLE format object that contains OLE properties for the inline shape.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.oleformat?view=word-pia"/>
  public IOLEFormat OLEFormat { get; }

  /// <summary>
  /// Returns the type of inline shape.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.type?view=word-pia"/>
  public InlineShapeType Type { get; }

  /// <summary>
  /// Returns a hyperlink object associated with the inline shape.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.hyperlink?view=word-pia"/>
  public IHyperlink Hyperlink { get; }

  /// <summary>
  /// Returns or sets the height of the inline shape, in points.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.height?view=word-pia"/>
  public float Height { get; set; }

  /// <summary>
  /// Returns or sets the width of the inline shape, in points.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.width?view=word-pia"/>
  public float Width { get; set; }

  /// <summary>
  /// Returns or sets the vertical scale of the inline shape, as a percentage.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.scaleheight?view=word-pia"/>
  public float ScaleHeight { get; set; }

  /// <summary>
  /// Returns or sets the horizontal scale of the inline shape, as a percentage.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.scalewidth?view=word-pia"/>
  public float ScaleWidth { get; set; }

  /// <summary>
  /// Returns or sets whether the inline shape retains its original proportions when resized.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.lockaspectratio?view=word-pia"/>
  public TriState LockAspectRatio { get; set; }

  /// <summary>
  /// Returns a line format object that represents line formatting for the inline shape.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.line?view=word-pia"/>
  public ILineFormat Line { get; }

  /// <summary>
  /// Returns a fill format object that represents fill formatting for the inline shape.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.fill?view=word-pia"/>
  public IFillFormat Fill { get; }

  /// <summary>
  /// Returns or sets picture formatting for the inline shape.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.pictureformat?view=word-pia"/>
  public IPictureFormat PictureFormat { get; set; }

  /// <summary>
  /// Returns a horizontal line format object for the inline shape.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.horizontallineformat?view=word-pia"/>
  public IHorizontalLineFormat HorizontalLineFormat { get; }

  /// <summary>
  /// Returns the script associated with the inline shape.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.script?view=word-pia"/>
  public IScript Script { get; }

  /// <summary>
  /// Returns the anchor identifier for the inline shape.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.owsanchor?view=word-pia"/>
  public int OWSAnchor { get; }

  /// <summary>
  /// Returns or sets text effect formatting for the inline shape.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.texteffect?view=word-pia"/>
  public ITextEffectFormat TextEffect { get; set; }

  /// <summary>
  /// Returns or sets alternative text for the inline shape.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.alternativetext?view=word-pia"/>
  public string AlternativeText { get; set; }

  /// <summary>
  /// Returns whether the inline shape is used as a picture bullet.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.ispicturebullet?view=word-pia"/>
  public bool IsPictureBullet { get; }

  /// <summary>
  /// Returns a group shapes collection for items in the inline shape group.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.groupitems?view=word-pia"/>
  public IGroupShapes GroupItems { get; }

  /// <summary>
  /// Returns whether the inline shape has an associated chart.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.haschart?view=word-pia"/>
  public TriState HasChart { get; }

  /// <summary>
  /// Returns the chart associated with the inline shape.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.chart?view=word-pia"/>
  public IChart Chart { get; }

  /// <summary>
  /// Returns soft edge formatting for the inline shape.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.softedge?view=word-pia"/>
  public ISoftEdgeFormat SoftEdge { get; }

  /// <summary>
  /// Returns glow formatting for the inline shape.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.glow?view=word-pia"/>
  public IGlowFormat Glow { get; }

  /// <summary>
  /// Returns reflection formatting for the inline shape.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.reflection?view=word-pia"/>
  public IReflectionFormat Reflection { get; }

  /// <summary>
  /// Returns shadow formatting for the inline shape.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.shadow?view=word-pia"/>
  public IShadowFormat Shadow { get; }

  /// <summary>
  /// Returns whether the inline shape has SmartArt.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.hassmartart?view=word-pia"/>
  public TriState HasSmartArt { get; }

  /// <summary>
  /// Returns SmartArt for the inline shape.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.smartart?view=word-pia"/>
  public SmartArt.ISmartArt SmartArt { get; }

  /// <summary>
  /// Returns or sets the title for the inline shape.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.title?view=word-pia"/>
  public string Title { get; set; }

  /// <summary>
  /// Returns the anchor ID of the inline shape.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.anchorid?view=word-pia"/>
  public int AnchorID { get; }

  /// <summary>
  /// Returns the edit ID of the inline shape.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.editid?view=word-pia"/>
  public int EditID { get; }
}
