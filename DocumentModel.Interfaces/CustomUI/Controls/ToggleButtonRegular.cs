namespace DocumentModel.CustomUI;

/// <summary>
/// Represents a regular toggle button control that maintains an on/off pressed state, suitable for use within menus and button groups, supporting streamlined appearance, dynamic state, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a streamlined toggle button control optimized for use within constrained ribbon contexts such as menus, button groups, and other containers. Unlike the standard <see cref="ToggleButton"/> control which has additional sizing options, ToggleButtonRegular provides a simplified toggle button implementation that maintains consistent dimensions appropriate for its context. Like all toggle buttons, it maintains a pressed (on) or unpressed (off) state to indicate whether a feature or option is currently active. The control is commonly used for formatting options or to show/hide UI elements in compact contexts, and supports customizable appearance with images, labels, tooltips, and can have its state and behavior controlled through static properties or dynamic callbacks.
/// </remarks>
public interface ToggleButtonRegular : CustomUIControl, BuiltInObject, TaggedObject, 
    EnableControl, VisibleControl, DescriptionControl,
    LabelledControl, ShowLabelControl, 
    ImagedControl, ShowImageControl,
    KeytipControl, ScreentipControl, SupertipControl,
    PressedControl, ActionControl,
    ContextMenuContent, MenuContent, MenuRegularContent, ButtonGroupContent
{
}