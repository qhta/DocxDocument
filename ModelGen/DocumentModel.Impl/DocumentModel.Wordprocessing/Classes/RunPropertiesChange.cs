namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the RunPropertiesChange Class.
/// </summary>
public class RunPropertiesChangeImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.RunPropertiesChange>, RunPropertiesChange
{
  /// <summary>
  /// Previous Run Properties.
  /// </summary>
  public PreviousRunProperties? PreviousRunProperties
  {
    get;
    set;
  }
  
}
