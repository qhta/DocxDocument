namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NumberingCache Class.
/// </summary>
public class NumberingCacheImpl: DocumentModel.Drawings.NumberDataTypeImpl, NumberingCache
{
  public new DocumentFormat.OpenXml.Drawing.Charts.NumberingCache? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.NumberingCache?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override String? FormatCode
  {
    get;
    set;
  }
  
  public override UInt32? PointCount
  {
    get;
    set;
  }
  
  public Collection<NumericPoint>? NumericPoints
  {
    get;
    set;
  }
  
  public ExtensionList4? ExtensionList
  {
    get;
    set;
  }
  
}
