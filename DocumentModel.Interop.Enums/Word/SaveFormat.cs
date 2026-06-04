namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format to use when saving a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdsaveformat?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdSaveFormat")]
public enum SaveFormat
{
  /// <summary>
  /// Microsoft Word format.
  /// </summary>
  [InteropEnumValue("wdFormatDocument")]
  Document = 0,
  /// <summary>
  /// Microsoft Word 97 document format.
  /// </summary>
  [InteropEnumValue("wdFormatDocument97")]
  Document97 = 0,
  /// <summary>
  /// Microsoft Word template format.
  /// </summary>
  [InteropEnumValue("wdFormatTemplate")]
  Template = 1,
  /// <summary>
  /// Word 97 template format.
  /// </summary>
  [InteropEnumValue("wdFormatTemplate97")]
  Template97 = 1,
  /// <summary>
  /// Microsoft Windows text format.
  /// </summary>
  [InteropEnumValue("wdFormatText")]
  Text = 2,
  /// <summary>
  /// Microsoft Windows text format with line breaks preserved.
  /// </summary>
  [InteropEnumValue("wdFormatTextLineBreaks")]
  TextLineBreaks = 3,
  /// <summary>
  /// Microsoft DOS text format.
  /// </summary>
  [InteropEnumValue("wdFormatDOSText")]
  DOSText = 4,
  /// <summary>
  /// Microsoft DOS text with line breaks preserved.
  /// </summary>
  [InteropEnumValue("wdFormatDOSTextLineBreaks")]
  DOSTextLineBreaks = 5,
  /// <summary>
  /// Rich text format (RTF).
  /// </summary>
  [InteropEnumValue("wdFormatRTF")]
  RTF = 6,
  /// <summary>
  /// Unicode text format.
  /// </summary>
  [InteropEnumValue("wdFormatUnicodeText")]
  UnicodeText = 7,
  /// <summary>
  /// Encoded text format.
  /// </summary>
  [InteropEnumValue("wdFormatEncodedText")]
  EncodedText = 7,
  /// <summary>
  /// Standard HTML format.
  /// </summary>
  [InteropEnumValue("wdFormatHTML")]
  HTML = 8,
  /// <summary>
  /// Web archive format.
  /// </summary>
  [InteropEnumValue("wdFormatWebArchive")]
  WebArchive = 9,
  /// <summary>
  /// Filtered HTML format.
  /// </summary>
  [InteropEnumValue("wdFormatFilteredHTML")]
  FilteredHTML = 10,
  /// <summary>
  /// Extensible Markup Language (XML) format.
  /// </summary>
  [InteropEnumValue("wdFormatXML")]
  XML = 11,
  /// <summary>
  /// XML document format.
  /// </summary>
  [InteropEnumValue("wdFormatXMLDocument")]
  XMLDocument = 12,
  /// <summary>
  /// XML template format with macros enabled.
  /// </summary>
  [InteropEnumValue("wdFormatXMLDocumentMacroEnabled")]
  XMLDocumentMacroEnabled = 13,
  /// <summary>
  /// XML template format.
  /// </summary>
  [InteropEnumValue("wdFormatXMLTemplate")]
  XMLTemplate = 14,
  /// <summary>
  /// XML template format with macros enabled.
  /// </summary>
  [InteropEnumValue("wdFormatXMLTemplateMacroEnabled")]
  XMLTemplateMacroEnabled = 15,
  /// <summary>
  /// Word default document file format. For Microsoft Office Word 2007, this is the DOCX format.
  /// </summary>
  [InteropEnumValue("wdFormatDocumentDefault")]
  DocumentDefault = 16,
  /// <summary>
  /// PDF format.
  /// </summary>
  [InteropEnumValue("wdFormatPDF")]
  PDF = 17,
  /// <summary>
  /// XPS format.
  /// </summary>
  [InteropEnumValue("wdFormatXPS")]
  XPS = 18,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [InteropEnumValue("wdFormatFlatXML")]
  FlatXML = 19,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [InteropEnumValue("wdFormatFlatXMLMacroEnabled")]
  FlatXMLMacroEnabled = 20,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [InteropEnumValue("wdFormatFlatXMLTemplate")]
  FlatXMLTemplate = 21,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [InteropEnumValue("wdFormatFlatXMLTemplateMacroEnabled")]
  FlatXMLTemplateMacroEnabled = 22,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("wdFormatOpenDocumentText")]
  OpenDocumentText = 23,
  /// <summary>
  /// Strict Open XML document format.
  /// </summary>
  [InteropEnumValue("wdFormatStrictOpenXMLDocument")]
  StrictOpenXMLDocument = 24
}
