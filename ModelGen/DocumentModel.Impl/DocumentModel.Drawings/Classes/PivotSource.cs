namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PivotSource Class.
/// </summary>
public class PivotSourceImpl: ModelElementImpl, PivotSource
{
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.PivotSource? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.PivotSource?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PivotSourceImpl(): base() {}
  
  public PivotSourceImpl(DocumentFormat.OpenXml.Office2013.Drawing.Chart.PivotSource openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Pivot Name.
  /// </summary>
  public String? PivotTableName
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PivotTableName>();
        return openXmlElement?.Text;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PivotTableName>();
        if (item != null)
        {
          if (value is not null)
            item.Text = value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Drawing.Charts.PivotTableName{ Text = value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Format ID.
  /// </summary>
  public UInt32? FormatId
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.FormatId>();
        return (UInt32?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.FormatId>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.UInt32?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Drawing.Charts.FormatId{ Val = (System.UInt32?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
