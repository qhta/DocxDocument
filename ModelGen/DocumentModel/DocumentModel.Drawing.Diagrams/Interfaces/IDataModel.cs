namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Data Model.
/// </summary>
public interface IDataModel // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Point List.
  /// </summary>
  public DocumentModel.Drawing.Diagrams.IPointList? PointList { get ; set; }
  
  /// <summary>
  /// Connection List.
  /// </summary>
  public DocumentModel.Drawing.Diagrams.IConnectionList? ConnectionList { get ; set; }
  
  /// <summary>
  /// Background Formatting.
  /// </summary>
  public DocumentModel.Drawing.Diagrams.IBackground? Background { get ; set; }
  
  /// <summary>
  /// Whole E2O Formatting.
  /// </summary>
  public DocumentModel.Drawing.Diagrams.IWhole? Whole { get ; set; }
  
  /// <summary>
  /// DataModelExtensionList.
  /// </summary>
  public DocumentModel.Drawing.Diagrams.IDataModelExtensionList? DataModelExtensionList { get ; set; }
  
}
