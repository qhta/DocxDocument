
namespace DocumentModel.Wordprocessing;

/// <summary>
///   Main Document interface representing a Word document.
/// </summary>
/// <remarks>
///   This interface provides access to document-level properties, settings, and content.
///   It corresponds to the Microsoft.Office.Interop.Word._Document interface.
/// </remarks>
public interface Document
{
  #region CoreProperties

  /// <summary>
  /// Title of the document.
  /// </summary>
  public string? Title { get; set; }

  /// <summary>
  /// First author of the document.
  /// </summary>
  public string? Author { get; set; }

  /// <summary>
  ///   Comma-delimited set of keywords to support searching and indexing. 
  /// </summary>
  public string? Keywords { get; set; }

  /// <summary>
  ///   Short description of the document.
  /// </summary>
  public string? Description { get; set; }

  /// <summary>
  ///   The user who performed the last modification.
  /// </summary>
  public string? LastModifiedBy { get; set; }

  /// <summary>
  ///   The revision number.
  /// </summary>
  public int? Revision { get; set; }

  /// <summary>
  ///   The date and time of the last printing.
  /// </summary>
  public DateTime? LastPrinted { get; set; }

  /// <summary>
  ///   Date of creation of the resource.
  /// </summary>
  public DateTime? Created { get; set; }

  /// <summary>
  ///   The date and time of the last modification.
  /// </summary>
  public DateTime? Modified { get; set; }

  /// <summary>
  ///   A categorization of the content of the document. 
  /// </summary>
  public string? Category { get; set; }

  /// <summary>
  ///   An unambiguous reference to the document within a given context.
  /// </summary>
  public string? Identifier { get; set; }

  /// <summary>
  ///   The type of content document.
  /// </summary>
  public string? ContentType { get; set; }

  /// <summary>
  ///   Main language of the document.
  /// </summary>
  public string? Language { get; set; }

  /// <summary>
  ///   The version number. This value is set by the user or by the application.
  /// </summary>
  public string? Version { get; set; }

  /// <summary>
  ///   The status of the content.
  /// </summary>
  public string? ContentStatus { get; set; }

  /// <summary>
  ///   Subject of the document.
  /// </summary>
  public string? Subject { get; set; }

  /// <summary>
  ///   Company name associated with the document.
  /// </summary>
  public string? Company { get; set; }

  /// <summary>
  ///   Manager name associated with the document.
  /// </summary>
  public string? Manager { get; set; }

  #endregion

  /// <summary>
  /// Compound object of document properties
  /// </summary>
  public AllDocumentProperties? Properties { get; set; }

  /// <summary>
  /// Style definitions.
  /// </summary>
  public IStyles? Styles { get; set; }

  /// <summary>
  /// Set of color and font themes.
  /// </summary>
  public DMD.Theme? Theme { get; set; }

  /// <summary>
  /// Font table
  /// </summary>
  public Fonts? Fonts { get; set; }

  /// <summary>
  /// Collection of embedded fonts data.
  /// </summary>
  public EmbedFontData? EmbeddedFonts { get; set; }

  /// <summary>
  /// Numbering definitions.
  /// </summary>
  public Numbering? Numbering { get; set; }

  /// <summary>
  /// Comment annotations.
  /// </summary>
  public DocComments? Comments { get; set; }

  /// <summary>
  /// Document background.
  /// </summary>
  public DocumentBackground? Background { get; set; }

  /// <summary>
  ///   Document conformance level.
  /// </summary>
  public DocumentConformance? Conformance { get; set; }

  /// <summary>
  ///   Document Background (duplicate - consider removing).
  /// </summary>
  [Obsolete("Use Background property instead")]
  public DocumentBackground? DocumentBackground { get; set; }

  /// <summary>
  ///   Main document body content.
  /// </summary>
  public Body? Body { get; set; }

  /// <summary>
  ///   Collection of sections in the document.
  /// </summary>
  public Sections? Sections { get; set; }

}

