namespace DocumentModel.Wordprocessing;

/// <summary>
/// Numbering Definition Instance.
/// </summary>
public class NumberingInstanceImpl: ModelElementImpl, NumberingInstance
{
  public DocumentFormat.OpenXml.Wordprocessing.NumberingInstance? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.NumberingInstance?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public NumberingInstanceImpl(): base() {}
  
  public NumberingInstanceImpl(DocumentFormat.OpenXml.Wordprocessing.NumberingInstance openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// numId
  /// </summary>
  public Int32? NumberID
  {
    get => (Int32?)OpenXmlElement?.NumberID?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.NumberID = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// durableId
  /// </summary>
  public Int32? DurableId
  {
    get => (Int32?)OpenXmlElement?.DurableId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DurableId = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// AbstractNumId.
  /// </summary>
  public Int32? AbstractNumId
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AbstractNumId>();
        return (Int32?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AbstractNumId>();
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
            item = new DocumentFormat.OpenXml.Wordprocessing.AbstractNumId{ Val = (System.Int32?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public LevelOverride? LevelOverride
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
