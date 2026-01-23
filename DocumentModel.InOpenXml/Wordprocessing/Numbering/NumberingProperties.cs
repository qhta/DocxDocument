namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the numbering properties for a paragraph or list item in a WordprocessingML document.
/// This class provides properties for referencing numbering levels, numbering definition instances, previous numbering changes, and inserted numbering properties, enabling advanced list and outline numbering management and revision tracking.
/// </summary>
public partial class NumberingProperties : ModelElement<DXW.NumberingProperties>
{
    /// <summary>
    /// Reference to the numbering level applied to the paragraph or list item.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.NumberingProperties.NumberingLevelReference))]
    /// <summary>
    /// Reference to the numbering level applied to the paragraph or list item.
    /// </summary>
    [OpenXmlElement(typeof(DXW.NumberingProperties))]
    public Int32? NumberingLevelReference { get => _NumberingLevelReference; set => UpdateField(ref _NumberingLevelReference, value, nameof(NumberingLevelReference)); }

    private Int32? _NumberingLevelReference;
    /// <summary>
    /// Reference to the numbering definition instance used for the paragraph or list item.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.NumberingProperties.NumberingId))]
    /// <summary>
    /// Reference to the numbering definition instance used for the paragraph or list item.
    /// </summary>
    [OpenXmlElement(typeof(DXW.NumberingProperties))]
    public Int32? NumberingId { get => _NumberingId; set => UpdateField(ref _NumberingId, value, nameof(NumberingId)); }

    private Int32? _NumberingId;
    /// <summary>
    /// Previous paragraph numbering properties, enabling tracking and management of numbering revisions.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.NumberingProperties.NumberingChange))]
    /// <summary>
    /// Previous paragraph numbering properties, enabling tracking and management of numbering revisions.
    /// </summary>
    [OpenXmlElement(typeof(DXW.NumberingProperties))]
    public NumberingChange? NumberingChange { get => _NumberingChange; set => UpdateField(ref _NumberingChange, value, nameof(NumberingChange)); }

    private NumberingChange? _NumberingChange;
    /// <summary>
    /// Inserted numbering properties, used to track newly added numbering information as part of revisions.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.NumberingProperties.Inserted))]
    /// <summary>
    /// Inserted numbering properties, used to track newly added numbering information as part of revisions.
    /// </summary>
    [OpenXmlElement(typeof(DXW.NumberingProperties))]
    public Inserted? Inserted { get => _Inserted; set => UpdateField(ref _Inserted, value, nameof(Inserted)); }

    private Inserted? _Inserted;
}