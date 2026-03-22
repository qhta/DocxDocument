namespace DocumentModel.Wordprocessing;
/// <summary>
/// Structured document tag around one or more inline-level structures (runs, DrawingML objects, fields, etc.) in the current paragraph.
/// This class represents a collection of structured document tag run content and provides properties for tag configuration and end character formatting, enabling advanced handling of inline-level structured document tags.
/// </summary>
[OpenXmlType(typeof(DXW.SdtRun))]
public partial class SdtRun : ModelElement<DXW.SdtRun>, IParagraphContent, ISdtRunContent, IBidirectionalContent, DMM.IMathArgumentContent
{
 /// <summary>
 /// Specifies the set of properties applied to this structured document tag.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.SdtRun.SdtProperties))]
 public SdtProperties? SdtProperties { get => _SdtProperties; set => UpdateField(ref _SdtProperties, value, nameof(SdtProperties)); }
 private SdtProperties? _SdtProperties;
 /// <summary>
 /// Specifies the properties applied to the physical character that delimits the end of a structured document tag.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.SdtRun.SdtEndCharProperties))]
 public SdtEndCharProperties? SdtEndCharProperties { get => _SdtEndCharProperties; set => UpdateField(ref _SdtEndCharProperties, value, nameof(SdtEndCharProperties)); }
 private SdtEndCharProperties? _SdtEndCharProperties;
}