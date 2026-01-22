namespace DocumentModel.Drawings;
/// <summary>
/// Represents the outcome of a classification process, including the outcome type and any additional extension data.
/// </summary>
public partial class ClassificationOutcome : ModelElement<DXO21DDC.ClassificationOutcome>, IExtendableElement
{
    /// <summary>
    /// Classification outcome type.
    /// </summary>
    public ClassificationOutcomeKind? ClassificationOutcomeType { get => _ClassificationOutcomeType; set => UpdateField(ref _ClassificationOutcomeType, value, nameof(ClassificationOutcomeType)); }

    private ClassificationOutcomeKind? _ClassificationOutcomeType;
    public IExtensionList? ExtensionList { get; set; }
}