namespace DocumentModel.Drawings;

/// <summary>
/// Dash Stop.
/// </summary>
public partial class DashStopImpl: ModelElementImpl, DashStop
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.DashStop? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.DashStop?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public DashStopImpl(): base() {}
  
  public DashStopImpl(DocumentFormat.OpenXml.Drawing.DashStop openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Dash Length
  /// </summary>
  public Int32? DashLength
  {
    get => (System.Int32?)OpenXmlElement?.DashLength?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DashLength = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Space Length
  /// </summary>
  public Int32? SpaceLength
  {
    get => (System.Int32?)OpenXmlElement?.SpaceLength?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SpaceLength = (System.Int32?)value;
    }
  }
  
}
