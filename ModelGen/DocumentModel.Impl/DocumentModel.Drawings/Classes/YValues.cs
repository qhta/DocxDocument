namespace DocumentModel.Drawings;

/// <summary>
/// Defines the YValues Class.
/// </summary>
public class YValuesImpl: DocumentModel.Drawings.NumberDataSourceTypeImpl, YValues
{
  public new DocumentFormat.OpenXml.Drawing.Charts.YValues? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.YValues?)_OpenXmlElement;
    set => _OpenXmlElement = value;
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
  
}
