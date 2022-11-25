namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Data Model.
/// </summary>
public interface IDataModel // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Point List.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? PointList { get ; set; }
  
  /// <summary>
  /// Connection List.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ConnectionList { get ; set; }
  
  /// <summary>
  /// Background Formatting.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? Background { get ; set; }
  
  /// <summary>
  /// Whole E2O Formatting.
  /// </summary>
  public DocumentModel.Drawing.Diagrams.IWhole? Whole { get ; set; }
  
  /// <summary>
  /// DataModelExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? DataModelExtensionList { get ; set; }
  
}
