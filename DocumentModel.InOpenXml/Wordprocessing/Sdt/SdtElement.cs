namespace DocumentModel.Wordprocessing;
/// <summary>
/// Defines SdtElement, the base interface for structured document tag (SDT) elements in a Wordprocessing document.
/// This class provides properties for SDT configuration and end character formatting, enabling advanced management and customization of SDT elements.
/// </summary>
public partial class SdtElement : ModelElement<DXW.SdtElement>
{
    /// <summary>
    /// Specifies the set of properties applied to this structured document tag.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.SdtElement.SdtProperties))]
    public SdtProperties? SdtProperties { get => _SdtProperties; set => UpdateField(ref _SdtProperties, value, nameof(SdtProperties)); }

    private SdtProperties? _SdtProperties;
    /// <summary>
    /// Specifies the properties applied to the physical character that delimits the end of a structured document tag.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.SdtElement.SdtEndCharProperties))]
    public SdtEndCharProperties? SdtEndCharProperties { get => _SdtEndCharProperties; set => UpdateField(ref _SdtEndCharProperties, value, nameof(SdtEndCharProperties)); }

    private SdtEndCharProperties? _SdtEndCharProperties;
}