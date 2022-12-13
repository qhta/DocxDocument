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
    get => (System.Int32?)OpenXmlElement?.NumberID?.Value;
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
    get => (System.Int32?)OpenXmlElement?.DurableId?.Value;
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
    get => (System.Int32?)OpenXmlElement?.AbstractNumId?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.AbstractNumId != null)
        {
          if (value is not null)
            OpenXmlElement.AbstractNumId.Val = (System.Int32?)value;
          else
            OpenXmlElement.AbstractNumId = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.AbstractNumId = new DocumentFormat.OpenXml.Wordprocessing.AbstractNumId{ Val = (System.Int32?)value };
        }
      }
    }
  }
  
  public DocumentModel.Wordprocessing.LevelOverride? LevelOverride
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
