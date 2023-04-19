namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Application Specific File Properties.
/// </summary>
public partial class ContentProperties: KnownDocumentProperties
{
  /// <summary>
  ///   Name of Document Template.
  /// </summary>
  public string? Template { get; set; }

  /// <summary>
  ///   Name of Manager.
  /// </summary>
  public string? Manager { get; set; }

  /// <summary>
  ///   Name of Company.
  /// </summary>
  public string? Company { get; set; }

  /// <summary>
  ///   Intended Format of Presentation.
  /// </summary>
  public string? PresentationFormat { get; set; }

  /// <summary>
  ///   Thumbnail Display Mode.
  /// </summary>
  public bool? ScaleCrop { get; set; }

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
  public bool? LinksUpToDate { get; set; }

  /// <summary>
  ///   Shared Document.
  /// </summary>
  public bool? SharedDocument { get; set; }

  /// <summary>
  ///   Relative Hyperlink Base.
  /// </summary>
  public string? HyperlinkBase { get; set; }

  /// <summary>
  ///   Hyperlink List.
  /// </summary>
  public StringList? HyperlinkList { get; set; }

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
  public string? Application { get; set; }

  /// <summary>
  ///   Application Version.
  /// </summary>
  public string? ApplicationVersion { get; set; }

}