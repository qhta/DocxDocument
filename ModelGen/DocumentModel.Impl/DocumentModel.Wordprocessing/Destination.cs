namespace DocumentModel.Wordprocessing;

/// <summary>
/// Merged Document Destination.
/// </summary>
public class Destination: IDestination
{
  /// <summary>
  /// Mail Merge Merged Document Type
  /// </summary>
  public MailMergeDestinationValues? Val
  {
    get;
    set;
  }
  
}
