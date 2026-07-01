namespace DocumentModel;

/// <summary>
/// Interface for an item to be used as a sender of PropertyChanged event, which needs a property name.
/// </summary>
public interface INotificationSource
{
  /// <summary>
  /// Property name to be used when the object raise PropertyChanged event.
  /// </summary>
  public string? PropertyName { get; set; }

  /// <summary>
  /// Flag to determine if notification is enabled when the object raise PropertyChanged event.
  /// It should be set to true when the object is created.
  /// </summary>
  public bool IsNotificationEnabled { get; }

}
