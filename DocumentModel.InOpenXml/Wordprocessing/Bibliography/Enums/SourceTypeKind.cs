namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies the type of bibliographic source.
/// </summary>
public enum SourceTypeKind
{
  /// <summary>Book</summary>
  Book,
  /// <summary>Section in a book</summary>
  BookSection,
  /// <summary>Journal article</summary>
  JournalArticle,
  /// <summary>Article in a periodical</summary>
  ArticleInAPeriodical,
  /// <summary>Conference proceedings</summary>
  ConferenceProceedings,
  /// <summary>Report</summary>
  Report,
  /// <summary>Website</summary>
  InternetSite,
  /// <summary>Electronic source</summary>
  ElectronicSource,
  /// <summary>Art work</summary>
  Art,
  /// <summary>Sound recording</summary>
  SoundRecording,
  /// <summary>Performance</summary>
  Performance,
  /// <summary>Film</summary>
  Film,
  /// <summary>Interview</summary>
  Interview,
  /// <summary>Patent</summary>
  Patent,
  /// <summary>Case (legal)</summary>
  Case,
  /// <summary>Miscellaneous</summary>
  Miscellaneous
}