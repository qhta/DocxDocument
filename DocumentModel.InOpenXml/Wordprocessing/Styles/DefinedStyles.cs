using System.Diagnostics.CodeAnalysis;

namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the collection of defined styles in a Wordprocessing document.
/// This class provides access to paragraph, character, table, and numbering styles, enabling advanced formatting and style management for document content.
/// </summary>
[OpenXmlType(typeof(Style))]
public partial class DefinedStyles : ModelElementCollection<Style>
{
  /// <summary>
  /// Default constructor.
  /// </summary>
  public DefinedStyles()
  {
  }

  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name = "styles"></param>
  public DefinedStyles(Styles styles)
  {
    Styles = styles;
  }

  /// <summary>
  /// Parent styles element that contains this collection of defined styles. 
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public Styles? Styles { get => _Styles; set => UpdateField(ref _Styles, value, nameof(Styles)); }

  private Styles? _Styles;
///// <summary>
///// Collection of paragraph styles defined in the document, used for formatting paragraphs.
///// </summary>
//public IEnumerable<Style> ParagraphStyles { get; set; }
///// <summary>
///// Collection of character styles defined in the document, used for formatting text runs and characters.
///// </summary>
//public IEnumerable<Style> CharacterStyles { get; set; }
///// <summary>
///// Collection of table styles defined in the document, used for formatting tables and table elements.
///// </summary>
//public IEnumerable<Style> TableStyles { get; set; }
///// <summary>
///// Collection of numbering styles defined in the document, used for formatting numbered lists and outlines.
///// </summary>
//public IEnumerable<Style> NumberingStyles { get; set; }
}