namespace DocumentModel.Wordprocessing;

/// <summary>
/// Merged Document Destination.
/// </summary>
public interface IDestination // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Mail Merge Merged Document Type
  /// </summary>
  public MailMergeDestinationValues? Val { get ; set; }
  
}
