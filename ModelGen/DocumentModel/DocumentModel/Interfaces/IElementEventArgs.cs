namespace DocumentModel;

/// <summary>
/// Represents arguments for element events.
/// </summary>
public interface IElementEventArgs // : System.EventArgs
{
  /// <summary>
  /// Gets the element that caused the event.
  /// </summary>
  public IOpenXmlElement? Element { get ; set; }
  
  /// <summary>
  /// Gets the parent element of the element that caused the event.
  /// </summary>
  public IOpenXmlElement? ParentElement { get ; set; }
  
}
