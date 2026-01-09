namespace DocumentModel;

/// <summary>
///   Represents a collection of tabs that define the main ribbon interface structure.
/// </summary>
/// <remarks>
///   This interface provides access to a collection
///   of <see cref="Tab"/> objects. These tabs form the primary navigation structure in the
///   ribbon UI, displaying groups of related commands and controls.
/// </remarks>
public interface Tabs : CollectionItem, ElementCollection<Tab>
{
}