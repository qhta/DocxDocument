namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies the file format for importing/exporting sources.
/// </summary>
[OpenXmlNotMapped]
public enum BibliographyFormat
{
  /// <summary>Office Open XML format</summary>
  OpenXml,
  /// <summary>BibTeX format (.bib)</summary>
  BibTeX,
  /// <summary>EndNote format (.enl)</summary>
  EndNote,
  /// <summary>RIS format (.ris)</summary>
  RIS,
  /// <summary>MODS XML format</summary>
  MODS,
  /// <summary>PubMed XML format</summary>
  PubMed,
  /// <summary>Dublin Core format</summary>
  DublinCore,
  /// <summary>Plain text format</summary>
  PlainText
}