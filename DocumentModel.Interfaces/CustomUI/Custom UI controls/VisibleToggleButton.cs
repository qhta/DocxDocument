namespace DocumentModel;

/// <summary>
/// Represents a visible toggle button control for Office UI, supporting dynamic pressed state, customizable appearance, and advanced callback integration for flexible scenarios.
/// </summary>
/// <remarks>
/// This interface defines a toggle button that maintains an on/off state and can be placed in various Office UI contexts. It supports dynamic state, labeling, images, tooltips, and flexible positioning, with callback integration for runtime behavior and accessibility.
/// </remarks>
public interface VisibleToggleButton : CustomUIControl, BuiltInObject, TaggedObject,
    EnableControl, VisibleControl, 
    LabelledControl, ShowLabelControl,
    ImagedControl, ShowImageControl,
    DescriptionControl, KeytipControl, ScreentipControl, SupertipControl,
    PressedControl, ActionControl
{

}