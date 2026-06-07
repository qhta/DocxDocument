namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format to use when opening a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdopenformat?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdOpenFormat")]
public enum OpenFormat
{
  /// <summary>
  /// The existing format.
  /// </summary>
  [InteropEnumValue("wdOpenFormatAuto")]
  Auto = 0,
  /// <summary>
  /// Microsoft Word format.
  /// </summary>
  [InteropEnumValue("wdOpenFormatDocument")]
  Document = 1,
  /// <summary>
  /// Microsoft Word 97 document format.
  /// </summary>
  [InteropEnumValue("wdOpenFormatDocument97")]
  Document97 = 1,
  /// <summary>
  /// As a Microsoft Word template.
  /// </summary>
  [InteropEnumValue("wdOpenFormatTemplate")]
  Template = 2,
  /// <summary>
  /// Word 97 template format.
  /// </summary>
  [InteropEnumValue("wdOpenFormatTemplate97")]
  Template97 = 2,
  /// <summary>
  /// Rich text format (RTF).
  /// </summary>
  [InteropEnumValue("wdOpenFormatRTF")]
  RTF = 3,
  /// <summary>
  /// Unencoded text format.
  /// </summary>
  [InteropEnumValue("wdOpenFormatText")]
  Text = 4,
  /// <summary>
  /// Unicode text format.
  /// </summary>
  [InteropEnumValue("wdOpenFormatUnicodeText")]
  UnicodeText = 5,
  /// <summary>
  /// Encoded text format.
  /// </summary>
  [InteropEnumValue("wdOpenFormatEncodedText")]
  EncodedText = 5,
  /// <summary>
  /// A Microsoft Word format that is backward compatible with earlier versions of Microsoft Word.
  /// </summary>
  [InteropEnumValue("wdOpenFormatAllWord")]
  AllWord = 6,
  /// <summary>
  /// HTML format.
  /// </summary>
  [InteropEnumValue("wdOpenFormatWebPages")]
  WebPages = 7,
  /// <summary>
  /// XML format.
  /// </summary>
  [InteropEnumValue("wdOpenFormatXML")]
  XML = 8,
  /// <summary>
  /// XML document format.
  /// </summary>
  [InteropEnumValue("wdOpenFormatXMLDocument")]
  XMLDocument = 9,
  /// <summary>
  /// XML document format with macros enabled.
  /// </summary>
  [InteropEnumValue("wdOpenFormatXMLDocumentMacroEnabled")]
  XMLDocumentMacroEnabled = 10,
  /// <summary>
  /// XML template format.
  /// </summary>
  [InteropEnumValue("wdOpenFormatXMLTemplate")]
  XMLTemplate = 11,
  /// <summary>
  /// XML template format with macros enabled.
  /// </summary>
  [InteropEnumValue("wdOpenFormatXMLTemplateMacroEnabled")]
  XMLTemplateMacroEnabled = 12,
  /// <summary>
  /// Word template format.
  /// </summary>
  [InteropEnumValue("wdOpenFormatAllWordTemplates")]
  AllWordTemplates = 13,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [InteropEnumValue("wdOpenFormatXMLDocumentSerialized")]
  XMLDocumentSerialized = 14,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [InteropEnumValue("wdOpenFormatXMLDocumentMacroEnabledSerialized")]
  XMLDocumentMacroEnabledSerialized = 15,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [InteropEnumValue("wdOpenFormatXMLTemplateSerialized")]
  XMLTemplateSerialized = 16,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [InteropEnumValue("wdOpenFormatXMLTemplateMacroEnabledSerialized")]
  XMLTemplateMacroEnabledSerialized = 17,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("wdOpenFormatOpenDocumentText")]
  OpenDocumentText = 18
}
