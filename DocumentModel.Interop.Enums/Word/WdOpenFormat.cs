namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format to use when opening a document.
/// </summary>
public enum WdOpenFormat
{
  /// <summary>
  /// The existing format.
  /// </summary>
  wdOpenFormatAuto = unchecked((int)0),
  /// <summary>
  /// Microsoft Word format.
  /// </summary>
  wdOpenFormatDocument = unchecked((int)1),
  /// <summary>
  /// Microsoft
  /// </summary>
  wdOpenFormatDocument97 = unchecked((int)1),
  /// <summary>
  /// As a Microsoft Word template.
  /// </summary>
  wdOpenFormatTemplate = unchecked((int)2),
  /// <summary>
  /// Word 97 template format.
  /// </summary>
  wdOpenFormatTemplate97 = unchecked((int)2),
  /// <summary>
  /// Rich text format (RTF).
  /// </summary>
  wdOpenFormatRTF = unchecked((int)3),
  /// <summary>
  /// Unencoded text format.
  /// </summary>
  wdOpenFormatText = unchecked((int)4),
  /// <summary>
  /// Unicode text format.
  /// </summary>
  wdOpenFormatUnicodeText = unchecked((int)5),
  /// <summary>
  /// Encoded text format.
  /// </summary>
  wdOpenFormatEncodedText = unchecked((int)5),
  /// <summary>
  /// A Microsoft Word format that is backward compatible with earlier versions of Microsoft Word.
  /// [System.Runtime.InteropServices.Guid("9C1B95DA-5F16-303B-8B1C-9C846D96DE8E")] public enum WdOpenFormat ﾉ
  /// Expand table
  /// </summary>
  wdOpenFormatAllWord = unchecked((int)6),
  /// <summary>
  /// HTML format.
  /// </summary>
  wdOpenFormatWebPages = unchecked((int)7),
  /// <summary>
  /// XML format.
  /// </summary>
  wdOpenFormatXML = unchecked((int)8),
  /// <summary>
  /// XML document format. wdOpenFormatXMLDocumentMacroEnabled10 XML document format with macros enabled.
  /// </summary>
  wdOpenFormatXMLDocument = unchecked((int)9),
  /// <summary>
  /// Specifies the format to use when opening a document.
  /// </summary>
  wdOpenFormatXMLDocumentMacroEnabled = unchecked((int)10),
  /// <summary>
  /// XML template format.
  /// </summary>
  wdOpenFormatXMLTemplate = unchecked((int)11),
  /// <summary>
  /// XML template format with macros enabled.
  /// </summary>
  wdOpenFormatXMLTemplateMacroEnabled = unchecked((int)12),
  /// <summary>
  /// Word template format.
  /// </summary>
  wdOpenFormatAllWordTemplates = unchecked((int)13),
  /// <summary>
  /// Reserved for internal use. wdOpenFormatXMLDocumentMacroEnabledSerialized15 Reserved for internal use.
  /// </summary>
  wdOpenFormatXMLDocumentSerialized = unchecked((int)14),
  /// <summary>
  /// Specifies the format to use when opening a document.
  /// </summary>
  wdOpenFormatXMLDocumentMacroEnabledSerialized = unchecked((int)15),
  /// <summary>
  /// Reserved for internal use. wdOpenFormatXMLTemplateMacroEnabledSerialized17 Reserved for internal use.
  /// </summary>
  wdOpenFormatXMLTemplateSerialized = unchecked((int)16),
  /// <summary>
  /// Specifies the format to use when opening a document.
  /// </summary>
  wdOpenFormatXMLTemplateMacroEnabledSerialized = unchecked((int)17),
  /// <summary>
  /// Applies to Product Versions Word primary interop assembly Latest
  /// </summary>
  wdOpenFormatOpenDocumentText = unchecked((int)18)
}
