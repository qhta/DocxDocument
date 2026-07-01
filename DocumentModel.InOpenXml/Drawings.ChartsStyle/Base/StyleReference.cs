namespace DocumentModel.Drawings.ChartsStyle;
/// <summary>
/// Represents a reference to a style entry, including an index and a list of modifiers for chart elements.
/// </summary>
[DataContract]
[XmlRoot("StyleReference", Namespace = "DocumentModel.Drawings.ChartsStyle")]
public partial class StyleReference
{
  /// <summary>
  /// Index value identifying the referenced style entry.
  /// </summary>
  public UInt32? Index { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// List of string modifiers that customize the referenced style.
  /// </summary>
  public List<String>? Modifiers { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}