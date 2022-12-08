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
  
  /// <summary>
  /// lvl, this property is only available in Office 2019 and later.
  /// </summary>
  public UInt32? Lvl
  {
    get;
    set;
  }
  
  /// <summary>
  /// ptType, this property is only available in Office 2019 and later.
  /// </summary>
  public STorageType? PtType
  {
    get => (STorageType?)OpenXmlElement?.PtType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.PtType = (DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.STorageType?)value;
    }
  }
  
  /// <summary>
  /// DiagramAutoBullet.
  /// </summary>
  public DiagramAutoBullet? DiagramAutoBullet
  {
    get;
    set;
  }
  
}
