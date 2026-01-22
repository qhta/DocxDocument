namespace DocumentModel.Vml;
/// <summary>
///   Ink.
/// </summary>
public partial class Ink : ModelElement<DXVO.Ink>
{
    /// <summary>
    ///   Ink Data
    /// </summary>
    public Base64Binary? InkData { get => _InkData; set => UpdateField(ref _InkData, value, nameof(InkData)); }

    private Base64Binary? _InkData;
    /// <summary>
    ///   Annotation Flag
    /// </summary>
    public bool? AnnotationFlag { get; set; }
}