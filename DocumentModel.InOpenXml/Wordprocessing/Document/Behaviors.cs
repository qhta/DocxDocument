namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents entry insertion behaviors for document parts in a WordprocessingML document.
/// This interface provides a property for specifying the behavior type, enabling advanced control over how document parts are inserted and managed within the document.
/// </summary>
public partial class Behaviors : ModelElement<DXW.Behaviors>
{
    /// <summary>
    /// Entry insertion behavior type, specifying how the document part behaves during insertion.
    /// </summary>
    public DocPartBehaviorKind? Behavior { get => _Behavior; set => UpdateField(ref _Behavior, value, nameof(Behavior)); }

    private DocPartBehaviorKind? _Behavior;
}