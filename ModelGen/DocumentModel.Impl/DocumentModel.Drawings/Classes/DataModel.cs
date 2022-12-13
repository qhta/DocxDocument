namespace DocumentModel.Drawings;

/// <summary>
/// Data Model.
/// </summary>
public class DataModelImpl: ModelElementImpl, DataModel
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.DataModel? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.DataModel?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DataModelImpl(): base() {}
  
  public DataModelImpl(DocumentFormat.OpenXml.Drawing.Diagrams.DataModel openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Point List.
  /// </summary>
  public DocumentModel.Drawings.PointList? PointList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Connection List.
  /// </summary>
  public DocumentModel.Drawings.ConnectionList? ConnectionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Background Formatting.
  /// </summary>
  public DocumentModel.Drawings.Background? Background
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Whole E2O Formatting.
  /// </summary>
  public DocumentModel.Drawings.Whole? Whole
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// DataModelExtensionList.
  /// </summary>
  public DocumentModel.Drawings.DataModelExtensionList? DataModelExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
