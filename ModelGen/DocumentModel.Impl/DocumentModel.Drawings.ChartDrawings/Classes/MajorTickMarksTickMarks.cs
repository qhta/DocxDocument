namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the MajorTickMarksTickMarks Class.
/// </summary>
public partial class MajorTickMarksTickMarksImpl: DocumentModel.Drawings.ChartDrawings.OpenXmlTickMarksElementImpl, MajorTickMarksTickMarks
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MajorTickMarksTickMarks? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MajorTickMarksTickMarks?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public MajorTickMarksTickMarksImpl(): base() {}
  
  public MajorTickMarksTickMarksImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MajorTickMarksTickMarks openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new DocumentModel.Drawings.ChartDrawings.ExtensionList? ExtensionList
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
