namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the format to use when opening a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdopenformat?view=office-pia` for Office interop details.
/// </remarks>
public enum OpenFormat
{
  /// <summary>
  /// The existing format.
  /// </summary>
  Auto = 0,
  /// <summary>
  /// Microsoft Word format.
  /// </summary>
  IDocument = 1,
  /// <summary>
  /// Microsoft Word 97 document format.
  /// </summary>
  Document97 = 1,
  /// <summary>
  /// As a Microsoft Word template.
  /// </summary>
  ITemplate = 2,
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
  /// A Microsoft Word format Ithat is backward compatible with earlier versions of Microsoft Word.
  /// </summary>
  AllWord = 6,
  /// <summary>
  /// HTML format.
  /// </summary>
  WebPages = 7,
  /// <summary>
  /// XML format.
  /// </summary>
  XML = 8,
  /// <summary>
  /// XML document format.
  /// </summary>
  XMLDocument = 9,
  /// <summary>
  /// XML document format with macros enabled.
  /// </summary>
  XMLDocumentMacroEnabled = 10,
  /// <summary>
  /// XML template format.
  /// </summary>
  XMLTemplate = 11,
  /// <summary>
  /// XML template format with macros enabled.
  /// </summary>
  XMLTemplateMacroEnabled = 12,
  /// <summary>
  /// Word template format.
  /// </summary>
  AllWordTemplates = 13,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  XMLDocumentSerialized = 14,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  XMLDocumentMacroEnabledSerialized = 15,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  XMLTemplateSerialized = 16,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  XMLTemplateMacroEnabledSerialized = 17,
  /// <summary>
  /// No description is available.
  /// </summary>
  OpenDocumentText = 18
}

