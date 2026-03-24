namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format to use when saving a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdsaveformat?view=office-pia` for Office interop details.
/// </remarks>
public enum WdSaveFormat
{
  /// <summary>
  /// Microsoft Word format.
  /// </summary>
  Document = 0,
  /// <summary>
  /// Microsoft Word 97 document format.
  /// </summary>
  Document97 = 0,
  /// <summary>
  /// Microsoft Word template format.
  /// </summary>
  Template = 1,
  /// <summary>
  /// Word 97 template format.
  /// </summary>
  Template97 = 1,
  /// <summary>
  /// Microsoft Windows text format.
  /// </summary>
  Text = 2,
  /// <summary>
  /// Microsoft Windows text format with line breaks preserved.
  /// </summary>
  TextLineBreaks = 3,
  /// <summary>
  /// Microsoft DOS text format.
  /// </summary>
  DOSText = 4,
  /// <summary>
  /// Microsoft DOS text with line breaks preserved.
  /// </summary>
  DOSTextLineBreaks = 5,
  /// <summary>
  /// Rich text format (RTF).
  /// </summary>
  RTF = 6,
  /// <summary>
  /// Specifies the format to use when saving a document.
  /// </summary>
  UnicodeText = 7,
  /// <summary>
  /// Encoded text format.
  /// </summary>
  EncodedText = 7,
  /// <summary>
  /// Specifies the format to use when saving a document.
  /// </summary>
  HTML = 8,
  /// <summary>
  /// Specifies the format to use when saving a document.
  /// </summary>
  WebArchive = 9,
  /// <summary>
  /// Specifies the format to use when saving a document.
  /// </summary>
  FilteredHTML = 10,
  /// <summary>
  /// Specifies the format to use when saving a document.
  /// </summary>
  XML = 11,
  /// <summary>
  /// Specifies the format to use when saving a document.
  /// </summary>
  XMLDocument = 12,
  /// <summary>
  /// Specifies the format to use when saving a document.
  /// </summary>
  XMLDocumentMacroEnabled = 13,
  /// <summary>
  /// Specifies the format to use when saving a document.
  /// </summary>
  XMLTemplate = 14,
  /// <summary>
  /// Specifies the format to use when saving a document.
  /// </summary>
  XMLTemplateMacroEnabled = 15,
  /// <summary>
  /// Specifies the format to use when saving a document.
  /// </summary>
  DocumentDefault = 16,
  /// <summary>
  /// Specifies the format to use when saving a document.
  /// </summary>
  PDF = 17,
  /// <summary>
  /// Specifies the format to use when saving a document.
  /// </summary>
  XPS = 18,
  /// <summary>
  /// Specifies the format to use when saving a document.
  /// </summary>
  FlatXML = 19,
  /// <summary>
  /// Specifies the format to use when saving a document.
  /// </summary>
  FlatXMLMacroEnabled = 20,
  /// <summary>
  /// Specifies the format to use when saving a document.
  /// </summary>
  FlatXMLTemplate = 21,
  /// <summary>
  /// Specifies the format to use when saving a document.
  /// </summary>
  FlatXMLTemplateMacroEnabled = 22,
  /// <summary>
  /// Specifies the format to use when saving a document.
  /// </summary>
  OpenDocumentText = 23,
  /// <summary>
  /// Specifies the format to use when saving a document.
  /// </summary>
  StrictOpenXMLDocument = 24
}
