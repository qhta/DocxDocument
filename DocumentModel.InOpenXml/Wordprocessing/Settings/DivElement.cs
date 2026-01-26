namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents information about a single HTML div element in a Wordprocessing document.
/// This class provides properties for div identification, blockquote and body flags, margins, borders, and child div elements, enabling advanced configuration and management of HTML div structures within the document.
/// </summary>
[OpenXmlType(typeof(DXW.Div))]
public partial class DivElement : ModelElement<DXW.Div>
{
 /// <summary>
 /// Data ID for the HTML div element.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Div.Id))]
 /// <summary>
 /// Data ID for the HTML div element.
 /// </summary>
 [OpenXmlElement(typeof(DXW.Div))]
 public Int32? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

 private Int32? _Id;
 /// <summary>
 /// Indicates whether the div represents an HTML blockquote element.
 /// </summary>
 [OpenXmlElement(typeof(DXW.Div))]
 public bool? IsBlockQuote { get => _IsBlockQuote; set => UpdateField(ref _IsBlockQuote, value, nameof(IsBlockQuote)); }

 private bool? _IsBlockQuote;
 /// <summary>
 /// Indicates whether the div represents an HTML body element.
 /// </summary>
 [OpenXmlElement(typeof(DXW.Div))]
 public bool? IsBody { get => _IsBody; set => UpdateField(ref _IsBody, value, nameof(IsBody)); }

 private bool? _IsBody;
 /// <summary>
 /// Left margin for the HTML div element.
 /// </summary>
 [OpenXmlElement(typeof(DXW.Div))]
 public Twips? LeftMargin { get => _LeftMargin; set => UpdateField(ref _LeftMargin, value, nameof(LeftMargin)); }

 private Twips? _LeftMargin;
 /// <summary>
 /// Right margin for the HTML div element.
 /// </summary>
 [OpenXmlElement(typeof(DXW.Div))]
 public Twips? RightMargin { get => _RightMargin; set => UpdateField(ref _RightMargin, value, nameof(RightMargin)); }

 private Twips? _RightMargin;
 /// <summary>
 /// Top margin for the HTML div element.
 /// </summary>
 [OpenXmlElement(typeof(DXW.Div))]
 public Twips? TopMargin { get => _TopMargin; set => UpdateField(ref _TopMargin, value, nameof(TopMargin)); }

 private Twips? _TopMargin;
 /// <summary>
 /// Bottom margin for the HTML div element.
 /// </summary>
 [OpenXmlElement(typeof(DXW.Div))]
 public Twips? BottomMargin { get => _BottomMargin; set => UpdateField(ref _BottomMargin, value, nameof(BottomMargin)); }

 private Twips? _BottomMargin;
 /// <summary>
 /// Set of borders for the HTML div element.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Div.DivBorder))]
 /// <summary>
 /// Set of borders for the HTML div element.
 /// </summary>
 [OpenXmlElement(typeof(DXW.Div))]
 public DivBorders? DivBorder { get => _DivBorder; set => UpdateField(ref _DivBorder, value, nameof(DivBorder)); }

 private DivBorders? _DivBorder;
 /// <summary>
 /// Collection of child div elements nested within this div.
 /// </summary>
 [OpenXmlElement(typeof(DXW.Div))]
 public DivCollection? Children { get => _Children; set => UpdateField(ref _Children, value, nameof(Children)); }

 private DivCollection? _Children;
}