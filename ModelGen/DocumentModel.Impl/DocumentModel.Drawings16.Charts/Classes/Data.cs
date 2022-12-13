namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the Data Class.
/// </summary>
public class DataImpl: ModelElementImpl, Data
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Data? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Data?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DataImpl(): base() {}
  
  public DataImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Data openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? Id
  {
    get => (System.UInt32?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.UInt32?)value;
    }
  }
  
  public DocumentModel.Drawings16.Charts.NumericDimension? NumericDimension
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings16.Charts.StringDimension? StringDimension
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings16.Charts.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
