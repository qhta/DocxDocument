namespace DocumentModel.Interop;

/// <summary>
/// Represents a type of smart tag.
/// </summary>
public interface SmartTagType : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; }
  /// <summary>
  /// The smart tag actions.
  /// </summary>
  public SmartTagActions SmartTagActions { get; }
  /// <summary>
  /// The smart tag recognizers.
  /// </summary>
  public SmartTagRecognizers SmartTagRecognizers { get; }
  /// <summary>
  /// The friendly name.
  /// </summary>
  public string FriendlyName { get; }

}
