namespace DocumentModel.Properties;

/// <summary>
///   Application Specific File Properties.
/// </summary>
public partial class ExtendedProperties
{
  /// <summary>
  ///   Name of Document Template.
  /// </summary>
  public String? Template { get; set; }

  /// <summary>
  ///   Name of Manager.
  /// </summary>
  public String? Manager { get; set; }

  /// <summary>
  ///   Name of Company.
  /// </summary>
  public String? Company { get; set; }

  /// <summary>
  ///   Total Number of Pages.
  /// </summary>
  public int? Pages { get; set; }

  /// <summary>
  ///   Word Count.
  /// </summary>
  public int? Words { get; set; }

  /// <summary>
  ///   Total Number of Characters.
  /// </summary>
  public int? Characters { get; set; }

  /// <summary>
  ///   Intended Format of Presentation.
  /// </summary>
  public String? PresentationFormat { get; set; }

  /// <summary>
  ///   Number of Lines.
  /// </summary>
  public int? Lines { get; set; }

  /// <summary>
  ///   Total Number of Paragraphs.
  /// </summary>
  public int? Paragraphs { get; set; }

  /// <summary>
  ///   Slides Metadata Element.
  /// </summary>
  public int? Slides { get; set; }

  /// <summary>
  ///   Number of Slides Containing Notes.
  /// </summary>
  public int? Notes { get; set; }

  /// <summary>
  ///   Total Edit Time Metadata Element.
  /// </summary>
  public int? TotalTime { get; set; }

  /// <summary>
  ///   Number of Hidden Slides.
  /// </summary>
  public int? HiddenSlides { get; set; }

  /// <summary>
  ///   Total Number of Multimedia Clips.
  /// </summary>
  public int? MultimediaClips { get; set; }

  /// <summary>
  ///   Thumbnail Display Mode.
  /// </summary>
  public bool? ScaleCrop { get; set; }

  /// <summary>
  ///   Heading Pairs.
  /// </summary>
  public VectorVariant? HeadingPairs { get; set; }

  /// <summary>
  ///   Part Titles.
  /// </summary>
  public VectorVariant? TitlesOfParts { get; set; }

  /// <summary>
  ///   Links Up-to-Date.
  /// </summary>
  public bool? LinksUpToDate { get; set; }

  /// <summary>
  ///   Number of Characters (With Spaces).
  /// </summary>
  public int? CharactersWithSpaces { get; set; }

  /// <summary>
  ///   Shared Document.
  /// </summary>
  public bool? SharedDocument { get; set; }

  /// <summary>
  ///   Relative Hyperlink Base.
  /// </summary>
  public String? HyperlinkBase { get; set; }

  /// <summary>
  ///   Hyperlink List.
  /// </summary>
  public VectorVariant? HyperlinkList { get; set; }

  /// <summary>
  ///   Hyperlinks Changed.
  /// </summary>
  public bool? HyperlinksChanged { get; set; }

  /// <summary>
  ///   Digital Signature.
  /// </summary>
  public byte[]? DigitalSignature { get; set; }

  /// <summary>
  ///   Application Name.
  /// </summary>
  public String? Application { get; set; }

  /// <summary>
  ///   Application Version.
  /// </summary>
  public String? ApplicationVersion { get; set; }

  /// <summary>
  ///   Document Security.
  /// </summary>
  public int? DocumentSecurity { get; set; }
}