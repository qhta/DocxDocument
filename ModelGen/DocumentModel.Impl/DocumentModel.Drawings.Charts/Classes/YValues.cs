namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the YValues Class.
/// </summary>
public class YValuesImpl: DocumentModel.Drawings.Charts.NumberDataSourceTypeImpl, YValues
{
  public new DocumentFormat.OpenXml.Drawing.Charts.YValues? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.YValues?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public YValuesImpl(): base() {}
  
  public YValuesImpl(DocumentFormat.OpenXml.Drawing.Charts.YValues openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
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
  
}
