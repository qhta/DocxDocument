namespace DocumentModel.Drawings;

/// <summary>
/// Line Spacing.
/// </summary>
public partial class LineSpacingImpl: DocumentModel.Drawings.TextSpacingTypeImpl, LineSpacing
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Drawing.LineSpacing? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.LineSpacing?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public LineSpacingImpl(): base() {}
  
  public LineSpacingImpl(DocumentFormat.OpenXml.Drawing.LineSpacing openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new Int32? SpacingPercent
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SpacingPercent>();
        return (System.Int32?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SpacingPercent>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Int32?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Drawing.SpacingPercent{ Val = (System.Int32?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public new Int32? SpacingPoints
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SpacingPoints>();
        return (System.Int32?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SpacingPoints>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Int32?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Drawing.SpacingPoints{ Val = (System.Int32?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
