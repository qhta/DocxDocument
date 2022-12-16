namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the TickLabels Class.
/// </summary>
public class TickLabelsImpl: ModelElementImpl, TickLabels
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TickLabels? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TickLabels?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TickLabelsImpl(): base() {}
  
  public TickLabelsImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TickLabels openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.ExtensionList? ExtensionList
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
