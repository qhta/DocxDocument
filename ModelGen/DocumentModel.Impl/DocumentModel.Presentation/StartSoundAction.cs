namespace DocumentModel.Presentation;

/// <summary>
/// Start Sound Action.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.ISound))]
public class StartSoundAction: IStartSoundAction
{
  /// <summary>
  /// Loop Sound
  /// </summary>
  public bool? Loop
  {
    get;
    set;
  }
  
  /// <summary>
  /// Sound.
  /// </summary>
  public ISound? Sound
  {
    get;
    set;
  }
  
}
