namespace DocumentModel.Properties;

/// <summary>
///   Application Specific File Properties.
/// </summary>
public partial class ContentProperties: KnownDocumentProperties
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
  ///   Intended Format of Presentation.
  /// </summary>
  public String? PresentationFormat { get; set; }

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
  ///   Document Security.
  /// </summary>
  public int? DocumentSecurity { get; set; }

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

}