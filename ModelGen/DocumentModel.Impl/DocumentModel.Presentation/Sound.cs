namespace DocumentModel.Presentation;

/// <summary>
/// Sound.
/// </summary>
public class Sound: ISound
{
  /// <summary>
  /// Embedded Audio File Relationship ID
  /// </summary>
  public string? Embed
  {
    get;
    set;
  }
  
  /// <summary>
  /// Sound Name
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// Recognized Built-In Sound
  /// </summary>
  public bool? BuiltIn
  {
    get;
    set;
  }
  
}
