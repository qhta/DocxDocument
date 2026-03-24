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
  /// Microsoft
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
  /// Unicode text format.
  /// </summary>
  UnicodeText = 7,
  /// <summary>
  /// Encoded text format. [System.Runtime.InteropServices.Guid("6AEEBC10-0420-3FB1-8A04-5F2053C4DAE9")] public enum
  /// WdSaveFormat ﾉ Expand table
  /// </summary>
  EncodedText = 7,
  /// <summary>
  /// Standard HTML format.
  /// </summary>
  HTML = 8,
  /// <summary>
  /// Web archive format.
  /// </summary>
  WebArchive = 9,
  /// <summary>
  /// Filtered HTML format.
  /// </summary>
  FilteredHTML = 10,
  /// <summary>
  /// Extensible Markup Language (XML) format.
  /// </summary>
  XML = 11,
  /// <summary>
  /// XML document format. wdFormatXMLDocumentMacroEnabled13 XML template format with macros enabled.
  /// </summary>
  XMLDocument = 12,
  /// <summary>
  /// Specifies the format to use when saving a document.
  /// </summary>
  XMLDocumentMacroEnabled = 13,
  /// <summary>
  /// XML template format. wdFormatXMLTemplateMacroEnabled15 XML template format with macros enabled.
  /// </summary>
  XMLTemplate = 14,
  /// <summary>
  /// Specifies the format to use when saving a document.
  /// </summary>
  XMLTemplateMacroEnabled = 15,
  /// <summary>
  /// Word default document file format. For Microsoft Office Word 2007, this is the DOCX format.
  /// </summary>
  DocumentDefault = 16,
  /// <summary>
  /// PDF format.
  /// </summary>
  PDF = 17,
  /// <summary>
  /// XPS format.
  /// </summary>
  XPS = 18,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  FlatXML = 19,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  FlatXMLMacroEnabled = 20,
  /// <summary>
  /// Reserved for internal use. wdFormatFlatXMLTemplateMacroEnabled22 Reserved for internal use.
  /// </summary>
  FlatXMLTemplate = 21,
  /// <summary>
  /// Specifies the format to use when saving a document.
  /// </summary>
  FlatXMLTemplateMacroEnabled = 22,
  /// <summary>
  /// wdFormatStrictOpenXMLDocument24 Strict Open XML document format.
  /// </summary>
  OpenDocumentText = 23,
  /// <summary>
  /// Specifies the format to use when saving a document.
  /// </summary>
  StrictOpenXMLDocument = 24
}
