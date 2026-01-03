namespace DocumentModel.Wordprocessing;

/// <summary>
///   Automatic Captioning Settings.
/// </summary>
public interface AutoCaptions: IModelElement
{
  public AutoCaption? AutoCaption { get; set; }
}