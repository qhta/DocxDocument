namespace DocumentModel;

/// <summary>
/// Represents a command definition for Office UI customization, supporting action execution,
/// enable state, and integration with collection and built-in object patterns for advanced extensibility.
/// </summary>
public interface Command : CollectionItem, BuiltInObject, EnableControl, ActionControl
{
}