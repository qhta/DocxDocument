namespace DocumentModel;

/// <summary>
/// Represents a group of buttons and controls within a ribbon group or menu, supporting compact arrangement, visual clustering, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a container that groups related buttons and controls together within the Office ribbon UI. Button groups allow multiple controls to be visually clustered, providing better organization and efficient use of ribbon space by displaying controls in a compact arrangement.
/// </remarks>
public interface ButtonGroup : CustomUIControl, TaggedObject, 
  VisibleControl,
  ButtonGroupContentCollection,
  BoxContent, GroupContent
{
  /// <summary>
  /// Cloned instance of a built-in or custom control.
  /// </summary>
  public ControlCloneRegular? ControlCloneRegular { get; set; }

}