namespace DocumentModel.Drawings;

/// <summary>
///   Represents a collection of theme colors, indexed by name, for use in document themes and styles.
/// </summary>
public partial interface ThemeColors : NameIndexedElementCollection<ThemeColor>
{
}