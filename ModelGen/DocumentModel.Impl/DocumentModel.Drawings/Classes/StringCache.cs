namespace DocumentModel.Drawings;

/// <summary>
/// Defines the StringCache Class.
/// </summary>
public class StringCacheImpl: DocumentModel.Drawings.StringDataType1Impl, StringCache
{
  public new DocumentFormat.OpenXml.Drawing.Charts.StringCache? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.StringCache?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override UInt32? PointCount
  {
    get;
    set;
  }
  
  public Collection<StringPoint>? StringPoints
  {
    get;
    set;
  }
  
  public StrDataExtensionList? StrDataExtensionList
  {
    get;
    set;
  }
  
}
