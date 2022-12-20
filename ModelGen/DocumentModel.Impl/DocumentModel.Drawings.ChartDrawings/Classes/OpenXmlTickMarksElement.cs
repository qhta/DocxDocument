namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the OpenXmlTickMarksElement Class.
/// </summary>
public partial class OpenXmlTickMarksElementImpl: ModelElementImpl, OpenXmlTickMarksElement
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlTickMarksElement? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlTickMarksElement?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public OpenXmlTickMarksElementImpl(): base() {}
  
  public OpenXmlTickMarksElementImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlTickMarksElement openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// type, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.TickMarksType? Type
  {
    get => (DocumentModel.Drawings.ChartDrawings.TickMarksType?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TickMarksType?)value;
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public virtual DocumentModel.Drawings.ChartDrawings.ExtensionList? ExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.ExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.ExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
