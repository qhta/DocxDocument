namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format to use when opening a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdopenformat?view=office-pia` for Office interop details.
/// </remarks>
public enum WdOpenFormat
{
  /// <summary>
  /// The existing format.
  /// </summary>
  Auto = 0,
  /// <summary>
  /// Microsoft Word format.
  /// </summary>
  Document = 1,
  /// <summary>
  /// Microsoft Word 97 document format.
  /// </summary>
  Document97 = 1,
  /// <summary>
  /// As a Microsoft Word template.
  /// </summary>
  Template = 2,
  /// <summary>
  /// Word 97 template format.
  /// </summary>
  Template97 = 2,
  /// <summary>
  /// Rich text format (RTF).
  /// </summary>
  RTF = 3,
  /// <summary>
  /// Unencoded text format.
  /// </summary>
  Text = 4,
  /// <summary>
  /// Unicode text format.
  /// </summary>
  UnicodeText = 5,
  /// <summary>
  /// Encoded text format.
  /// </summary>
  EncodedText = 5,
  /// <summary>
  /// A Microsoft Word format that is backward compatible with earlier versions of Microsoft Word.
  /// </summary>
  AllWord = 6,
  /// <summary>
  /// Specifies the format to use when opening a document.
  /// </summary>
  WebPages = 7,
  /// <summary>
  /// Specifies the format to use when opening a document.
  /// </summary>
  XML = 8,
  /// <summary>
  /// Specifies the format to use when opening a document.
  /// </summary>
  XMLDocument = 9,
  /// <summary>
  /// Specifies the format to use when opening a document.
  /// </summary>
  XMLDocumentMacroEnabled = 10,
  /// <summary>
  /// Specifies the format to use when opening a document.
  /// </summary>
  XMLTemplate = 11,
  /// <summary>
  /// Specifies the format to use when opening a document.
  /// </summary>
  XMLTemplateMacroEnabled = 12,
  /// <summary>
  /// Specifies the format to use when opening a document.
  /// </summary>
  AllWordTemplates = 13,
  /// <summary>
  /// Specifies the format to use when opening a document.
  /// </summary>
  XMLDocumentSerialized = 14,
  /// <summary>
  /// Specifies the format to use when opening a document.
  /// </summary>
  XMLDocumentMacroEnabledSerialized = 15,
  /// <summary>
  /// Specifies the format to use when opening a document.
  /// </summary>
  XMLTemplateSerialized = 16,
  /// <summary>
  /// Specifies the format to use when opening a document.
  /// </summary>
  XMLTemplateMacroEnabledSerialized = 17,
  /// <summary>
  /// Specifies the format to use when opening a document.
  /// </summary>
  OpenDocumentText = 18
}
