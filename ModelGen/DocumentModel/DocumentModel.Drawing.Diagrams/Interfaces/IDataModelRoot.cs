namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Data Model.
/// </summary>
public interface IDataModelRoot // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Point List.
  /// </summary>
  public IPointList? PointList { get ; set; }
  
  /// <summary>
  /// Connection List.
  /// </summary>
  public IConnectionList? ConnectionList { get ; set; }
  
  /// <summary>
  /// Background Formatting.
  /// </summary>
  public IBackground? Background { get ; set; }
  
  /// <summary>
  /// Whole E2O Formatting.
  /// </summary>
  public IWhole? Whole { get ; set; }
  
  /// <summary>
  /// DataModelExtensionList.
  /// </summary>
  public IDataModelExtensionList? DataModelExtensionList { get ; set; }
  
  /// <summary>
  /// Gets the DiagramDataPart associated with this element.
  /// </summary>
  public DiagramDataPart? DiagramDataPart { get ; set; }
  
}
