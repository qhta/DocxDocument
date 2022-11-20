namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the BrowseMode Class.
/// </summary>
public interface IBrowseMode // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// showStatus, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? ShowStatus { get ; set; }
  
}
