namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Data Model.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IBackground))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IDataModelExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IWhole))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IConnectionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IPointList))]
public interface IDataModelRoot // : DocumentFormat.OpenXml.TypedOpenXmlPartRootElement
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
  public DocumentModel.Drawing.Diagrams.IBackground? Background { get ; set; }
  
  /// <summary>
  /// Whole E2O Formatting.
  /// </summary>
  public IWhole? Whole { get ; set; }
  
  /// <summary>
  /// DataModelExtensionList.
  /// </summary>
  public IDataModelExtensionList? DataModelExtensionList { get ; set; }
  
}
