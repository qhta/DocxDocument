namespace DocumentModel.Wordprocessing;
/// <summary>
/// Counterpart of <see cref = "SdtRun"/> interface in the Ruby domain.
/// This class represents a collection of ruby content elements and provides properties for structured document tag configuration and end character formatting, enabling advanced handling of ruby annotations in structured document tags.
/// </summary>
[OpenXmlType(typeof(DXW.SdtRunRuby))]
[XmlRoot("SdtRunRuby", Namespace = "DocumentModel.Wordprocessing")]
public partial class SdtRunRuby : ModelElement<DXW.SdtRunRuby>, IRubyContent
{
 /// <summary>
 /// Specifies the set of properties applied to this structured document tag.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.SdtRunRuby.SdtProperties))]
 public SdtProperties? SdtProperties { get => _SdtProperties; set => UpdateField(ref _SdtProperties, value, nameof(SdtProperties)); }

 private SdtProperties? _SdtProperties;
 /// <summary>
 /// Specifies the properties applied to the physical character that delimits the end of a structured document tag.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.SdtRunRuby.SdtEndCharProperties))]
 public SdtEndCharProperties? SdtEndCharProperties { get => _SdtEndCharProperties; set => UpdateField(ref _SdtEndCharProperties, value, nameof(SdtEndCharProperties)); }

 private SdtEndCharProperties? _SdtEndCharProperties;
}