namespace DocumentModel.Drawings;

/// <summary>
/// Defines the UpDownBars Class.
/// </summary>
public class UpDownBarsImpl: ModelElementImpl, UpDownBars
{
  public DocumentFormat.OpenXml.Drawing.Charts.UpDownBars? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.UpDownBars?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public UpDownBarsImpl(): base() {}
  
  public UpDownBarsImpl(DocumentFormat.OpenXml.Drawing.Charts.UpDownBars openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gap Width.
  /// </summary>
  public UInt16? GapWidth
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.GapWidth>();
        return (UInt16?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.GapWidth>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.UInt16?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Drawing.Charts.GapWidth{ Val = (System.UInt16?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Up Bars.
  /// </summary>
  public UpBars? UpBars
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Down Bars.
  /// </summary>
  public DownBars? DownBars
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
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
