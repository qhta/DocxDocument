namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the ruby counterpart of the <see cref = "Hyperlink"/> interface in a WordprocessingML document.
/// This class extends <see cref = "Hyperlink"/> and <see cref = "IRubyContent"/>, enabling advanced integration of hyperlinks within ruby text, supporting East Asian typography and annotation scenarios where hyperlinks are embedded in phonetic guides or ruby runs.
/// </summary>
[OpenXmlType(typeof(DXW.HyperlinkRuby))]
public class HyperlinkRuby : Hyperlink<DXW.HyperlinkRuby>, IRubyContent
{
}