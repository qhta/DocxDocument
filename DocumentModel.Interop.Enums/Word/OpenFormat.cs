namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format to use when opening a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdopenformat?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdOpenFormat")]
public enum OpenFormat
{
  /// <summary>
  /// The existing format.
  /// </summary>
  [WordInteropEnumValue("wdOpenFormatAuto")]
  Auto = 0,
  /// <summary>
  /// Microsoft Word format.
  /// </summary>
  [WordInteropEnumValue("wdOpenFormatDocument")]
  Document = 1,
  /// <summary>
  /// Microsoft Word 97 document format.
  /// </summary>
  [WordInteropEnumValue("wdOpenFormatDocument97")]
  Document97 = 1,
  /// <summary>
  /// As a Microsoft Word template.
  /// </summary>
  [WordInteropEnumValue("wdOpenFormatTemplate")]
  Template = 2,
  /// <summary>
  /// Word 97 template format.
  /// </summary>
  [WordInteropEnumValue("wdOpenFormatTemplate97")]
  Template97 = 2,
  /// <summary>
  /// Rich text format (RTF).
  /// </summary>
  [WordInteropEnumValue("wdOpenFormatRTF")]
  RTF = 3,
  /// <summary>
  /// Unencoded text format.
  /// </summary>
  [WordInteropEnumValue("wdOpenFormatText")]
  Text = 4,
  /// <summary>
  /// Unicode text format.
  /// </summary>
  [WordInteropEnumValue("wdOpenFormatUnicodeText")]
  UnicodeText = 5,
  /// <summary>
  /// Encoded text format.
  /// </summary>
  [WordInteropEnumValue("wdOpenFormatEncodedText")]
  EncodedText = 5,
  /// <summary>
  /// A Microsoft Word format that is backward compatible with earlier versions of Microsoft Word.
  /// </summary>
  [WordInteropEnumValue("wdOpenFormatAllWord")]
  AllWord = 6,
  /// <summary>
  /// HTML format.
  /// </summary>
  [WordInteropEnumValue("wdOpenFormatWebPages")]
  WebPages = 7,
  /// <summary>
  /// XML format.
  /// </summary>
  [WordInteropEnumValue("wdOpenFormatXML")]
  XML = 8,
  /// <summary>
  /// XML document format.
  /// </summary>
  [WordInteropEnumValue("wdOpenFormatXMLDocument")]
  XMLDocument = 9,
  /// <summary>
  /// XML document format with macros enabled.
  /// </summary>
  [WordInteropEnumValue("wdOpenFormatXMLDocumentMacroEnabled")]
  XMLDocumentMacroEnabled = 10,
  /// <summary>
  /// XML template format.
  /// </summary>
  [WordInteropEnumValue("wdOpenFormatXMLTemplate")]
  XMLTemplate = 11,
  /// <summary>
  /// XML template format with macros enabled.
  /// </summary>
  [WordInteropEnumValue("wdOpenFormatXMLTemplateMacroEnabled")]
  XMLTemplateMacroEnabled = 12,
  /// <summary>
  /// Word template format.
  /// </summary>
  [WordInteropEnumValue("wdOpenFormatAllWordTemplates")]
  AllWordTemplates = 13,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue("wdOpenFormatXMLDocumentSerialized")]
  XMLDocumentSerialized = 14,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue("wdOpenFormatXMLDocumentMacroEnabledSerialized")]
  XMLDocumentMacroEnabledSerialized = 15,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue("wdOpenFormatXMLTemplateSerialized")]
  XMLTemplateSerialized = 16,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue("wdOpenFormatXMLTemplateMacroEnabledSerialized")]
  XMLTemplateMacroEnabledSerialized = 17,
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue("wdOpenFormatOpenDocumentText")]
  OpenDocumentText = 18
}
