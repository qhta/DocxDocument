namespace DocumentModel.Wordprocessing;

/// <summary>
/// Default Run Properties.
/// </summary>
public class RunPropertiesDefaultImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.RunPropertiesDefault>, RunPropertiesDefault
{
  /// <summary>
  /// Run Properties.
  /// </summary>
  public RunPropertiesBaseStyle? RunPropertiesBaseStyle
  {
    get;
    set;
  }
  
}
