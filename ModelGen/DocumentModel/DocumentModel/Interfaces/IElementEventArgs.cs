namespace DocumentModel;

/// <summary>
/// Represents arguments for element events.
/// </summary>
public interface IElementEventArgs // : System.IEventArgs
{
  /// <summary>
  /// Gets the element that caused the event.
  /// </summary>
  public ModelElement? Element { get ; set; }
  
  /// <summary>
  /// Gets the parent element of the element that caused the event.
  /// </summary>
  public ModelElement? ParentElement { get ; set; }
  
}
