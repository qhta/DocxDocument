namespace DocumentModel.Drawings.ChartsStyle;
/// <summary>
/// Represents a reference to a style entry, including an index and a list of modifiers for chart elements.
/// </summary>
[XmlRoot("StyleReference", Namespace = "DocumentModel.Drawings.ChartsStyle")]
public class StyleReference
{
 /// <summary>
 /// Index value identifying the referenced style entry.
 /// </summary>
 public UInt32? Index { get; set; }
 /// <summary>
 /// List of string modifiers that customize the referenced style.
 /// </summary>
 public ListOf<String>? Modifiers { get; set; }
}