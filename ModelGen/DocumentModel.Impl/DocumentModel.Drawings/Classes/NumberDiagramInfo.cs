namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NumberDiagramInfo Class.
/// </summary>
public class NumberDiagramInfoImpl: ModelElement<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfo>, NumberDiagramInfo
{
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
