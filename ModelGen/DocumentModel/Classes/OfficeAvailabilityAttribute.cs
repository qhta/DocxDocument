namespace DocumentModel;


/// <summary>
///   Defines an OfficeAvailabilityAttribute class to indicate whether the property is available in a specific version of an Office application.
/// </summary>
public partial class OfficeAvailabilityAttribute
{
  
  /// <summary>
  ///   Gets the Office version of the available property.
  /// </summary>
  public DocumentModel.FileFormatVersions? OfficeVersion { get; set; }
  
}
