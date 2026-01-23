namespace DocumentModel.Vml;
/// <summary>
///   Ink.
/// </summary>
public partial class Ink : ModelElement<DXVO.Ink>
{
    /// <summary>
    ///   Ink Data
    /// </summary>
    [OpenXmlProperty(nameof(DXVO.Ink.InkData))]
    /// <summary>
    ///   Ink Data
    /// </summary>
    [OpenXmlElement(typeof(DXVO.Ink))]
    public Base64Binary? InkData { get => _InkData; set => UpdateField(ref _InkData, value, nameof(InkData)); }

    private Base64Binary? _InkData;
    /// <summary>
    ///   Annotation Flag
    /// </summary>
    [OpenXmlProperty(nameof(DXVO.Ink.AnnotationFlag))]
    /// <summary>
    ///   Annotation Flag
    /// </summary>
    [OpenXmlElement(typeof(DXVO.Ink))]
    public bool? AnnotationFlag { get => _AnnotationFlag; set => UpdateField(ref _AnnotationFlag, value, nameof(AnnotationFlag)); }

    private bool? _AnnotationFlag;
}