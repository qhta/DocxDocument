namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the CategoryAxisData Class.
/// </summary>
public class CategoryAxisDataImpl: DocumentModel.Drawings.Charts.AxisDataSourceTypeImpl, CategoryAxisData
{
  public new DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public CategoryAxisDataImpl(): base() {}
  
  public CategoryAxisDataImpl(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new DocumentModel.Drawings.Charts.MultiLevelStringReference? MultiLevelStringReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new DocumentModel.Drawings.Charts.NumberReference? NumberReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new DocumentModel.Drawings.Charts.NumberLiteral? NumberLiteral
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new DocumentModel.Drawings.Charts.StringReference? StringReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new DocumentModel.Drawings.Charts.StringLiteral? StringLiteral
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
