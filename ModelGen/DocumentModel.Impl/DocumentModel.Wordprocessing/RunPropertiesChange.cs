namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the RunPropertiesChange Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IPreviousRunProperties))]
public class RunPropertiesChange: IRunPropertiesChange
{
  /// <summary>
  /// author
  /// </summary>
  public string? Author
  {
    get;
    set;
  }
  
  /// <summary>
  /// date
  /// </summary>
  public DateTime? Date
  {
    get;
    set;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// Previous Run Properties.
  /// </summary>
  public IPreviousRunProperties? PreviousRunProperties
  {
    get;
    set;
  }
  
}
