namespace DocumentModel.Drawings;

/// <summary>
/// Defines the CategoryAxisData Class.
/// </summary>
public class CategoryAxisDataImpl: DocumentModel.Drawings.AxisDataSourceType2Impl, CategoryAxisData
{
  public new DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override MultiLevelStringReference? MultiLevelStringReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public override NumberReference? NumberReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public override NumberLiteral? NumberLiteral
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public override StringReference? StringReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public override StringLiteral? StringLiteral
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
