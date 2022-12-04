namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NonVisualPicturePropertiesExtension Class.
/// </summary>
public class NonVisualPicturePropertiesExtension
{
  public CameraTool? CameraTool
  {
    get;
    set;
  }
  
  public SignatureLine? SignatureLine
  {
    get;
    set;
  }
  
  public ObjectProperties? ObjectProperties
  {
    get;
    set;
  }
  
  public LiveFeedProperties? LiveFeedProperties
  {
    get;
    set;
  }
  
}
