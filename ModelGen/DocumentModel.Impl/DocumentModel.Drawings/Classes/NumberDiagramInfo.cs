namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NumberDiagramInfo Class.
/// </summary>
public class NumberDiagramInfoImpl: ModelElementImpl, NumberDiagramInfo
{
  public DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfo? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfo?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public NumberDiagramInfoImpl(): base() {}
  
  public NumberDiagramInfoImpl(DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfo openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// lvl, this property is only available in Office 2019 and later.
  /// </summary>
  public UInt32? Lvl
  {
    get => (System.UInt32?)OpenXmlElement?.Lvl?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Lvl = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// ptType, this property is only available in Office 2019 and later.
  /// </summary>
  public DocumentModel.Drawings.STorageType? PtType
  {
    get => (DocumentModel.Drawings.STorageType?)OpenXmlElement?.PtType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.PtType = (DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.STorageType?)value;
    }
  }
  
  /// <summary>
  /// DiagramAutoBullet.
  /// </summary>
  public DocumentModel.Drawings.DiagramAutoBullet? DiagramAutoBullet
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
