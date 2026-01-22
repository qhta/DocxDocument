namespace DocumentModel.Drawings.Office;
/// <summary>
///   Defines the TextBody Class.
/// </summary>
public partial class TextBody : ModelElement<DXOD.TextBody>
{
    /// <summary>
    ///   Body Properties.
    /// </summary>
    public BodyProperties? BodyProperties { get => _BodyProperties; set => UpdateField(ref _BodyProperties, value, nameof(BodyProperties)); }

    private BodyProperties? _BodyProperties;
    /// <summary>
    ///   Text List Styles.
    /// </summary>
    public ListStyle? ListStyle { get; set; }
    public Paragraph? Paragraph { get; set; }
}