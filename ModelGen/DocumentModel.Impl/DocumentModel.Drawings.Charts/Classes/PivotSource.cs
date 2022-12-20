namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the PivotSource Class.
/// </summary>
public partial class PivotSourceImpl: ModelElementImpl, PivotSource
{
  public DocumentFormat.OpenXml.Drawing.Charts.PivotSource? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.PivotSource?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PivotSourceImpl(): base() {}
  
  public PivotSourceImpl(DocumentFormat.OpenXml.Drawing.Charts.PivotSource openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Pivot Name.
  /// </summary>
  public String? PivotTableName
  {
    get => (System.String?)OpenXmlElement?.PivotTableName?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.PivotTableName != null)
        {
          if (value is not null)
            OpenXmlElement.PivotTableName.Text = value;
          else
            OpenXmlElement.PivotTableName = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.PivotTableName = new DocumentFormat.OpenXml.Drawing.Charts.PivotTableName{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// Format ID.
  /// </summary>
  public UInt32? FormatId
  {
    get => (System.UInt32?)OpenXmlElement?.FormatId?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.FormatId != null)
        {
          if (value is not null)
            OpenXmlElement.FormatId.Val = (System.UInt32?)value;
          else
            OpenXmlElement.FormatId = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.FormatId = new DocumentFormat.OpenXml.Drawing.Charts.FormatId{ Val = (System.UInt32?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.ExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.ExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
