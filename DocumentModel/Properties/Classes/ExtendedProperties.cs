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
  public String? Pages { get; set; }

  /// <summary>
  ///   Word Count.
  /// </summary>
  public String? Words { get; set; }

  /// <summary>
  ///   Total Number of Characters.
  /// </summary>
  public String? Characters { get; set; }

  /// <summary>
  ///   Intended Format of Presentation.
  /// </summary>
  public String? PresentationFormat { get; set; }

  /// <summary>
  ///   Number of Lines.
  /// </summary>
  public String? Lines { get; set; }

  /// <summary>
  ///   Total Number of Paragraphs.
  /// </summary>
  public String? Paragraphs { get; set; }

  /// <summary>
  ///   Slides Metadata Element.
  /// </summary>
  public String? Slides { get; set; }

  /// <summary>
  ///   Number of Slides Containing Notes.
  /// </summary>
  public String? Notes { get; set; }

  /// <summary>
  ///   Total Edit Time Metadata Element.
  /// </summary>
  public String? TotalTime { get; set; }

  /// <summary>
  ///   Number of Hidden Slides.
  /// </summary>
  public String? HiddenSlides { get; set; }

  /// <summary>
  ///   Total Number of Multimedia Clips.
  /// </summary>
  public String? MultimediaClips { get; set; }

  /// <summary>
  ///   Thumbnail Display Mode.
  /// </summary>
  public String? ScaleCrop { get; set; }

  /// <summary>
  ///   Heading Pairs.
  /// </summary>
  public HeadingPairs? HeadingPairs { get; set; }

  /// <summary>
  ///   Part Titles.
  /// </summary>
  public StringList? TitlesOfParts { get; set; }

  /// <summary>
  ///   Links Up-to-Date.
  /// </summary>
  public String? LinksUpToDate { get; set; }

  /// <summary>
  ///   Number of Characters (With Spaces).
  /// </summary>
  public String? CharactersWithSpaces { get; set; }

  /// <summary>
  ///   Shared Document.
  /// </summary>
  public String? SharedDocument { get; set; }

  /// <summary>
  ///   Relative Hyperlink Base.
  /// </summary>
  public String? HyperlinkBase { get; set; }

  /// <summary>
  ///   Hyperlink List.
  /// </summary>
  public StringList? HyperlinkList { get; set; }

  /// <summary>
  ///   Hyperlinks Changed.
  /// </summary>
  public String? HyperlinksChanged { get; set; }

  /// <summary>
  ///   Digital Signature.
  /// </summary>
  public DigitalSignature? DigitalSignature { get; set; }

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
  public String? DocumentSecurity { get; set; }
}