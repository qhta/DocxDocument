namespace DocumentModel.Wordprocessing;

/// <summary>
/// Default Run Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IRunPropertiesBaseStyle))]
public class RunPropertiesDefault: IRunPropertiesDefault
{
  /// <summary>
  /// Run Properties.
  /// </summary>
  public IRunPropertiesBaseStyle? RunPropertiesBaseStyle
  {
    get;
    set;
  }
  
}
