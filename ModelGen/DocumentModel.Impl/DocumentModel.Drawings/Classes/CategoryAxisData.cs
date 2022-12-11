namespace DocumentModel.Drawings;

/// <summary>
/// Defines the CategoryAxisData Class.
/// </summary>
public class CategoryAxisDataImpl: DocumentModel.Drawings.AxisDataSourceTypeImpl, CategoryAxisData
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
  
  public new MultiLevelStringReference? MultiLevelStringReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new NumberReference? NumberReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new NumberLiteral? NumberLiteral
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new StringReference? StringReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new StringLiteral? StringLiteral
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
