namespace DocumentModel.Drawing;

/// <summary>
/// Data Model.
/// </summary>
public interface IDataModel // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Point List.
  /// </summary>
  public DocumentModel.Drawing.IPointList? PointList { get ; set; }
  
  /// <summary>
  /// Connection List.
  /// </summary>
  public DocumentModel.Drawing.IConnectionList? ConnectionList { get ; set; }
  
  /// <summary>
  /// Background Formatting.
  /// </summary>
  public DocumentModel.Drawing.IBackground? Background { get ; set; }
  
  /// <summary>
  /// Whole E2O Formatting.
  /// </summary>
  public DocumentModel.Drawing.IWhole? Whole { get ; set; }
  
  /// <summary>
  /// DataModelExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IDataModelExtensionList? DataModelExtensionList { get ; set; }
  
}
