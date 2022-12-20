namespace DocumentModel.Drawings.Diagram1;

/// <summary>
/// Defines the NumberDiagramInfo Class.
/// </summary>
public partial class NumberDiagramInfoImpl: ModelElementImpl, NumberDiagramInfo
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfo? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfo?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
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
  public DocumentModel.Drawings.Diagram1.STorageType? PtType
  {
    get => (DocumentModel.Drawings.Diagram1.STorageType?)OpenXmlElement?.PtType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.PtType = (DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.STorageType?)value;
    }
  }
  
  /// <summary>
  /// DiagramAutoBullet.
  /// </summary>
  public DocumentModel.Drawings.Diagram1.DiagramAutoBullet? DiagramAutoBullet
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.DiagramAutoBullet>();
        if (item != null)
          return new DocumentModel.Drawings.Diagram1.DiagramAutoBulletImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.DiagramAutoBullet>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Diagram1.DiagramAutoBulletImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
