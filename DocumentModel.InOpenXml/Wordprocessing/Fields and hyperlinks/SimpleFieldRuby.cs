namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the ruby counterpart of the <see cref = "SimpleField"/> interface in a WordprocessingML document.
/// This class extends <see cref = "SimpleField"/> and <see cref = "IRubyContent"/>, enabling advanced integration of simple fields within ruby text, supporting East Asian typography and annotation scenarios where fields are embedded in phonetic guides or ruby runs.
/// </summary>
[OpenXmlType(typeof(DXW.SimpleFieldRuby))]
[DataContract]
[XmlRoot("SimpleFieldRuby", Namespace = "DocumentModel.Wordprocessing")]
public class SimpleFieldRuby : SimpleField<DXW.SimpleFieldRuby>, IRubyContent
{
}