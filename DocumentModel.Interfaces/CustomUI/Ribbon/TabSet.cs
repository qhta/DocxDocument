namespace DocumentModel;

/// <summary>
///   Represents a set of contextual tabs that appear together in the ribbon UI.
/// </summary>
/// <remarks>
///   This interface defines a group of related tabs
///   that are displayed as a unit in the ribbon interface. Tab sets are typically used for
///   contextual tabs that appear when specific objects or elements are selected.
/// </remarks>
public interface TabSet : BuiltInControl, CollectionItem, 
  VisibleControl,
  TabsCollection
{

}