namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the BrowseMode Class.
/// </summary>
public interface IBrowseMode // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// showStatus, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? ShowStatus { get ; set; }
  
}
