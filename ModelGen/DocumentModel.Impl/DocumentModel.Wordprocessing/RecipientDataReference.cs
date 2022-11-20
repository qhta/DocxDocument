namespace DocumentModel.Wordprocessing;

/// <summary>
/// Reference to Inclusion/Exclusion Data for Data Source.
/// </summary>
public class RecipientDataReference: IRecipientDataReference
{
  /// <summary>
  /// Relationship to Part
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
}
