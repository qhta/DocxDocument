namespace DocumentModel.Drawings.Office;
/// <summary>
///   Defines the TextBody Class.
/// </summary>
public partial class TextBody : ModelElement<DXOD.TextBody>
{
    /// <summary>
    ///   Body Properties.
    /// </summary>
    [OpenXmlProperty(nameof(DXOD.TextBody.BodyProperties))]
    public BodyProperties? BodyProperties { get => _BodyProperties; set => UpdateField(ref _BodyProperties, value, nameof(BodyProperties)); }

    private BodyProperties? _BodyProperties;
    /// <summary>
    ///   Text List Styles.
    /// </summary>
    [OpenXmlProperty(nameof(DXOD.TextBody.ListStyle))]
    public ListStyle? ListStyle { get => _ListStyle; set => UpdateField(ref _ListStyle, value, nameof(ListStyle)); }

    private ListStyle? _ListStyle;
    public Paragraph? Paragraph { get => _Paragraph; set => UpdateField(ref _Paragraph, value, nameof(Paragraph)); }

    private Paragraph? _Paragraph;
}